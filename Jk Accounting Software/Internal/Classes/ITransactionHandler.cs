using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using JkComponents;
using Jk_Accounting_Software.Internal.Forms;
using System.Data.SqlTypes;

namespace Jk_Accounting_Software.Internal.Classes
{
    public class ITransactionHandler
    {
        private string VConnectionString { get { return Properties.Settings.Default.FreeAccountingSoftwareConnectionString; } }

        public SqlConnection VConnection;
        public SqlTransaction VTransaction;
        private DataSet VDataset = new DataSet();

        public void Connect()
        {
            VConnection = new SqlConnection(VConnectionString);
            VConnection.Open();
        }

        public void Disconnect()
        {
            if (VConnection.State == ConnectionState.Open)
                VConnection.Close();
        }

        public void BeginTran()
        {
            VTransaction = VConnection.BeginTransaction();
        }

        public void CommitTran()
        {
            VTransaction.Commit();
        }

        public void Rollback()
        {
            VTransaction.Rollback();
        }

        public String ExtractTableName(String PCommandText)
        {
            String result = "";

            if (!String.IsNullOrEmpty(PCommandText))
            {
                if (PCommandText.IndexOf("WHERE", 0) > 0)
                    result = PCommandText.Substring(PCommandText.IndexOf("FROM", 0) + 4, PCommandText.IndexOf("WHERE", 0) - PCommandText.IndexOf("FROM", 0) - 5).Trim();
                else
                    result = PCommandText.Substring(PCommandText.IndexOf("FROM", 0) + 4, PCommandText.Length - PCommandText.IndexOf("FROM", 0) - 4).Trim();
            }

            return result;
        }

        private SqlCommand GetInsertCommand(String PCommandText, List<JkFormParameter> PParams)
        {
            SqlCommand Command = new SqlCommand();
            SqlDataAdapter Adapter = new SqlDataAdapter(PCommandText, VConnectionString);
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();

            if (PParams != null)
            {
                for (int i = 0; i <= PParams.Count - 1; i++)
                {
                    if (String.IsNullOrWhiteSpace(PParams[i].Value))
                        Adapter.SelectCommand.Parameters.AddWithValue("@" + PParams[i].Name, 0);
                    else
                    {
                        Adapter.SelectCommand.Parameters.AddWithValue("@" + PParams[i].Name, IAppHandler.ConvertMaskValue(PParams[i].Value));
                    }
                }
            }

            CommandBuilder.DataAdapter = Adapter;
            Command = CommandBuilder.GetInsertCommand();

            return Command;
        }

        public void LoadData(String PCommandText, ref DataTable PDataTable, List<JkFormParameter> PParamList, String CustomConnectionString = null)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(PCommandText, CustomConnectionString ?? VConnectionString);
            String TableName = ExtractTableName(PCommandText);

            try
            {
                try
                {
                    if(PParamList != null)
                    {
                        for (int i = 0; i <= PParamList.Count - 1; i++)
                        {
                            if (String.IsNullOrWhiteSpace(PParamList[i].Value))
                                DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, 0);
                            else
                            {
                                DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, IAppHandler.ConvertMaskValue(PParamList[i].Value));
                            }
                        }
                    }
                    DataAdapter.FillSchema(VDataset, SchemaType.Source, TableName);
                    DataAdapter.Fill(VDataset, TableName);
                    PDataTable = VDataset.Tables[TableName];
                }
                catch(Exception err)
                {
                    IMessageHandler.ShowError(ISystemMessages.LoadDataError + err.Message);
                }
            }
            finally
            {
                DataAdapter.SelectCommand.Connection.Close();
                DataAdapter.Dispose();
            }
        }

        public DataTable LoadData(String PCommandText, List<JkFormParameter> PParamList, String CustomConnectionString = null)
        {
            DataTable PDataTable = new DataTable();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(PCommandText, CustomConnectionString ?? VConnectionString);
            String TableName = ExtractTableName(PCommandText);

            try
            {
                try
                {
                    if (PParamList != null)
                    {
                        for (int i = 0; i <= PParamList.Count - 1; i++)
                        {
                            if (String.IsNullOrWhiteSpace(PParamList[i].Value))
                                DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, 0);
                            else
                            {
                                DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, IAppHandler.ConvertMaskValue(PParamList[i].Value));
                            }
                        }
                    }
                    DataAdapter.FillSchema(VDataset, SchemaType.Source, TableName);
                    DataAdapter.Fill(VDataset, TableName);
                    PDataTable = VDataset.Tables[TableName];
                }
                catch (Exception err)
                {
                    IMessageHandler.ShowError(ISystemMessages.LoadDataError + err.Message);
                }
            }
            finally
            {
                DataAdapter.SelectCommand.Connection.Close();
                DataAdapter.Dispose();
            }

            return PDataTable;
        }

        public void SaveMaster(String PCommandText, ref DataTable PDataTable, List<JkFormParameter> PParams)
        {
            SqlCommand Command = new SqlCommand();
            SqlParameter InsertedId = new SqlParameter("@Id", DbType.Int64);
            int i = 0;

            try
            {
                Command = GetInsertCommand(PCommandText, PParams);
                Command.CommandText = Command.CommandText + ";\r SET @Id = SCOPE_IDENTITY();";
                foreach (DataColumn column in PDataTable.Columns)
                {
                    if (!column.AutoIncrement)
                    {
                        Command.Parameters[i].Value = PDataTable.Rows[0][column.ColumnName];
                        i += 1;
                    }
                }
                InsertedId.Direction = ParameterDirection.Output;
                Command.Parameters.Add(InsertedId);
                Command.Connection = VConnection;
                Command.Transaction = VTransaction;
                Command.ExecuteNonQuery();
                PParams.Find(p => p.Name == "Id").Value = Command.Parameters[Command.Parameters.Count - 1].Value.ToString();
            }
            finally
            {
                Command.Dispose();
            }
        }

        public void SaveDetail(String PCommandText, DataTable PDataTable, List<JkFormParameter> PMasterParams, List<JkFormParameter> PDetailParams)
        {
            SqlCommand Command = new SqlCommand();
            int i = 0;

            try
            {
                Command = GetInsertCommand(PCommandText, PMasterParams);

                foreach (DataRow row in PDataTable.Rows)
                {
                    i = 0;
                    foreach (DataColumn column in PDataTable.Columns)
                    {
                        if (!column.AutoIncrement)
                        {
                            if (!Convert.IsDBNull(row[column.ColumnName]) && Convert.ToInt32(row[column.ColumnName]) == -1)
                            {
                                row[column.ColumnName] = PMasterParams.Find(pm => pm.Name == "Id").Value;
                            }
                            Command.Parameters[i].Value = row[column.ColumnName] ?? DBNull.Value;

                            i += 1;
                        }
                    }
                    Command.Connection = VConnection;
                    Command.Transaction = VTransaction;
                    Command.ExecuteNonQuery();
                }
            }
            finally
            {
                Command.Dispose();
            }
        }

        public void EditMaster(String PCommandText, List<JkFormParameter> PParams)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(PCommandText, VConnection);
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();

            try
            {
                if (PParams != null)
                {
                    for (int i = 0; i <= PParams.Count - 1; i++)
                    {
                        if (String.IsNullOrWhiteSpace(PParams[i].Value))
                            DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParams[i].Name, 0);
                        else
                        {
                            DataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParams[i].Name, PParams[i].Value);
                        }
                    }
                }
                DataAdapter.SelectCommand.Transaction = VTransaction;
                CommandBuilder.DataAdapter = DataAdapter;

                DataAdapter.InsertCommand = CommandBuilder.GetInsertCommand();
                DataAdapter.InsertCommand.Transaction = VTransaction;

                DataAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();
                DataAdapter.UpdateCommand.Transaction = VTransaction;

                DataAdapter.DeleteCommand = CommandBuilder.GetDeleteCommand();
                DataAdapter.DeleteCommand.Transaction = VTransaction;

                DataAdapter.Update(VDataset, ExtractTableName(PCommandText));
            }
            finally
            {
                CommandBuilder.Dispose();
                DataAdapter.Dispose();
            }
        }

        public void ExecuteStoredProc(SqlCommand Command)
        {
            try
            {
                Connect();
                try
                {
                    BeginTran();
                    Command.Connection = VConnection;
                    Command.Transaction = VTransaction;
                    Command.ExecuteNonQuery();
                    CommitTran();
                }
                catch(Exception ex)
                {
                    Rollback();
                    IMessageHandler.ShowError(ISystemMessages.ErrorExecutingCommand(ex.Message));
                }
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
