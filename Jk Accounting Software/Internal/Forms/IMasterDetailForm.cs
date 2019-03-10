using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using System.Drawing.Design;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;
using System.Globalization;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class IMasterDetailForm : IMasterForm
    {
        #region Built-in Events
            public IMasterDetailForm()
            {
                InitializeComponent();
            }

            private void IMasterDetailForm_BeforeRun()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText) && DataSet.LinkToMaster)
                    {
                        DataSet.Parameters.Find(dp => dp.Name == "Id").Value = Parameters.Find(p => p.Name == "Id").Value;
                        if (!String.IsNullOrWhiteSpace(DataSet.CommandText))
                        {
                            DataSet.DataTable = VTransactionHandler.LoadData(DataSet.CommandText, DataSet.Parameters);
                            DataSet.AddTemporaryColumns();        
                            DataSet.GridView.DataSource = DataSet.DataTable;
                        }

                        //For further update on this code, I'm still not sure if this will fit on all scenarios
                        foreach (DataColumn column in DataSet.DataTable.Columns)
                        {
                            if (!column.AllowDBNull && column.DataType.ToString() == "System.Int32" && !column.AutoIncrement)
                            {
                                if (FormState == FormStates.fsNew)
                                    column.DefaultValue = -1;
                                else
                                    column.DefaultValue = Parameters.Find(p => p.Name == "Id").Value;
                            }
                        }
                    }

                    //load data from lookup to grid
                    foreach (DataGridViewColumn column in DataSet.GridView.Columns)
                    {
                        if (column.GetType().ToString().Contains("DataGridViewComboBoxColumn"))
                        {
                            DataGridViewComboBoxColumn comboBox = column as DataGridViewComboBoxColumn;
                            JkLookUpComboBox lookUp = (Controls.Find(DataSet.Columns.Find(dc => dc.Name == column.DataPropertyName).ControlName, true).First() as JkLookUpComboBox);

                            if (lookUp.Items.Count == 0)
                                lookUp.LoadData();

                            comboBox.DataSource = lookUp.Items;
                            comboBox.DisplayMember = "DisplayText";
                            comboBox.ValueMember = "Key";
                        }
                    }
                }
            }

            protected override void UpdateControls()
            {
                base.UpdateControls();

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    if (FormState == FormStates.fsView)
                        DataSet.GridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                    else
                        DataSet.GridView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                    DataSet.GridView.AllowUserToAddRows = FormState != FormStates.fsView;
                    DataSet.GridView.AllowUserToDeleteRows = FormState != FormStates.fsView;
                }
            }

            protected override void SaveDetail()
            {
                base.SaveDetail();

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText) && DataSet.LinkToMaster)
                        VTransactionHandler.SaveDetail(DataSet.CommandText, DataSet.DataTable, Parameters, DataSet.Parameters);
            }

            protected override void EditDetail()
            {
                base.EditDetail();

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText) && DataSet.LinkToMaster)
                        VTransactionHandler.EditMaster(DataSet.CommandText, DataSet.Parameters);
            }

            private void IMasterDetailForm_Resize(object sender, EventArgs e)
            {
                splitContainerMasterDetail.Size = new Size(splitContainer.Width, splitContainer.Panel2.Height - FormFooter.Height);
            }

            private void IMasterDetailForm_AfterRun()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    //workaround to hide columns that are generated automatically by .Net
                    foreach (DataGridViewColumn column in DataSet.GridView.Columns)
                    {
                        if (!String.IsNullOrWhiteSpace(column.DataPropertyName))
                            column.Visible = DataSet.Columns.Find(c => c.Name == column.DataPropertyName).Visible;
                    }

                    //workaround to fix temporary columns that are not recomputing
                    //after cancelling a transaction
                    DataSet.GridView.ComputeFooterValues();
                }
                splitContainerMasterDetail.Panel1.Focus();
            }

            private void IMasterDetailForm_BeforeSave()
            {
                //remove temporary columns so that it will not cause
                //malfuction on DataAdapter.Update function
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    DataSet.RemoveTemporaryColumns();
                }
            }

            //check if all required columns are filled up
            private void IMasterDetailForm_ValidateSave()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    foreach (JkDetailColumn column in DataSet.Columns)
                    {
                        if (column.Required)
                        {
                            foreach (DataRow row in DataSet.DataTable.Rows)
                            {
                                if (((row[column.Name] == null || row[column.Name] == DBNull.Value) && String.IsNullOrWhiteSpace(column.ControlName))
                                    || (!String.IsNullOrWhiteSpace(column.ControlName) && int.Parse(row[column.Name].ToString()) == 0))
                                {
                                    IMessageHandler.Inform(ISystemMessages.FillRequiredFieldOnGridMessage(column.Caption));
                                    ValidationFails = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        #endregion
    }
}
