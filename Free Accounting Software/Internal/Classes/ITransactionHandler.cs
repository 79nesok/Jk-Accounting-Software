using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using JkComponents;
using Free_Accounting_Software.Internal.Forms;

namespace Free_Accounting_Software.Internal.Classes
{
    public class ITransactionHandler
    {
        private string VConnectionString { get { return Properties.Settings.Default.FreeAccountingSoftwareConnectionString; } }

        private SqlConnection VConnection;
        private SqlDataAdapter VDataAdapter;
        private SqlTransaction VTransaction;
        private DataSet VDataset = new DataSet();
        private String VTableName = null;

        private void Connect()
        {
            VConnection = new SqlConnection(VConnectionString);
            VConnection.Open();
        }

        private void Disconnect()
        {
            if (VConnection.State == ConnectionState.Open)
                VConnection.Close();
        }

        private void BeginTran()
        {
            VTransaction = VConnection.BeginTransaction();
        }

        private void CommitTran()
        {
            VTransaction.Commit();
        }

        private void Rollback()
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

                VTableName = result;
            }

            return result;
        }

        public void LoadData(String PCommandText, ref DataTable PDataTable, List<JkFormParameter> PParamList, String CustomConnectionString = null)
        {
            try
            {
                try
                {
                    VDataAdapter = new SqlDataAdapter(PCommandText, CustomConnectionString ?? VConnectionString);
                    if(PParamList != null)
                    {
                        for (int i = 0; i <= PParamList.Count - 1; i++)
                        {
                            if (String.IsNullOrWhiteSpace(PParamList[i].Value))
                                VDataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, 0);
                            else
                            {
                                VDataAdapter.SelectCommand.Parameters.AddWithValue("@" + PParamList[i].Name, IAppHandler.ConvertMaskValue(PParamList[i].Value));
                            }
                        }
                    }
                    VDataAdapter.FillSchema(VDataset, SchemaType.Source, ExtractTableName(PCommandText));
                    VDataAdapter.Fill(VDataset, VTableName);
                    PDataTable = VDataset.Tables[VTableName];
                }
                catch(Exception err)
                {
                    IMessageHandler.ShowError(ISystemMessages.LoadDataError + err.Message);
                }
            }
            finally
            {
                VDataAdapter.SelectCommand.Connection.Close();
            }
        }

        public void SaveData(ref DataTable PDataTable, List<JkMasterColumn> PMasterColumn, List<JkFormParameter> PParams, IParentForm.FormStates PFormState)
        {
            if (PFormState == IParentForm.FormStates.fsNew)
                Save(ref PDataTable, PMasterColumn, PParams);
            else
                Edit(ref PDataTable, PMasterColumn, PParams);
            PDataTable.Clear();
        }

        private void Save(ref DataTable PDataTable, List<JkMasterColumn> PMasterColumn, List<JkFormParameter> PParams)
        {
            int i = 0;
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();
            SqlParameter InsertedId = new SqlParameter("@Id", DbType.Int64);

            try
            {
                try
                {
                    CommandBuilder.DataAdapter = VDataAdapter;
                    VDataAdapter.InsertCommand = CommandBuilder.GetInsertCommand();
                    VDataAdapter.InsertCommand.CommandText = VDataAdapter.InsertCommand.CommandText
                        + ";\r SET @Id = SCOPE_IDENTITY();";
                    InsertedId.Direction = ParameterDirection.Output;
                    VDataAdapter.InsertCommand.Parameters.Add(InsertedId);
                    foreach (JkMasterColumn column in PMasterColumn)
                    {
                        VDataAdapter.InsertCommand.Parameters[i].Value = column.Value ?? DBNull.Value;
                        i += 1;
                    }
                    VDataAdapter.InsertCommand.Connection = new SqlConnection(VConnectionString);
                    VDataAdapter.InsertCommand.Connection.Open();
                    VTransaction = VDataAdapter.InsertCommand.Connection.BeginTransaction();
                    VDataAdapter.InsertCommand.Transaction = VTransaction;
                    VDataAdapter.InsertCommand.ExecuteNonQuery();
                    VTransaction.Commit();
                    PParams[0].Value = VDataAdapter.InsertCommand.Parameters[VDataAdapter.InsertCommand.Parameters.Count - 1].Value.ToString();
                }
                catch (Exception err)
                {
                    VTransaction.Rollback();
                    IMessageHandler.ShowError(ISystemMessages.SaveDataError + err.Message);
                }
            }
            finally
            {
                VDataAdapter.InsertCommand.Connection.Close();
                CommandBuilder.Dispose();
            }
        }

        private void Edit(ref DataTable PDataTable, List<JkMasterColumn> PMasterColumn, List<JkFormParameter> PParams)
        {
            DataRow row = PDataTable.Rows.Find(IAppHandler.ConvertMaskValue(PParams[0].Value));
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder();
            try
            {
                try
                {
                    row.BeginEdit();
                    foreach (JkMasterColumn column in PMasterColumn)
                    {
                        row[column.Name] = column.Value ?? DBNull.Value;
                    }
                    row.EndEdit();
                    CommandBuilder.DataAdapter = VDataAdapter;
                    VDataAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();
                    Connect();
                    BeginTran();
                    VDataAdapter.Update(VDataset, VTableName);
                    CommitTran();
                }
                catch (Exception err)
                {
                    Rollback();
                    IMessageHandler.ShowError(ISystemMessages.EditDataError + err.Message);
                }
            }
            finally
            {
                Disconnect();
                CommandBuilder.Dispose();
            }
        }
    }
}
