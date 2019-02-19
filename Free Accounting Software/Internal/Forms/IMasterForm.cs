using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JkComponents;
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.Internal.Forms
{
    [Serializable]
    public partial class IMasterForm : IParentForm
    {

        #region Added Properties
            private List<JkMasterColumn> _MasterColumns = new List<JkMasterColumn>();
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            [Category("(Custom)")]
            public List<JkMasterColumn> MasterColumns { get { return _MasterColumns; } set { _MasterColumns = value; } }

            private bool _ZLoadMasterColumns;
            [Category("(Custom)")]
            public bool ZLoadMasterColumns
            {
                get { return _ZLoadMasterColumns; }
                set
                {
                    if (value)
                    {
                        try
                        {
                            CreateMasterColumns();
                        }
                        catch (Exception ex)
                        {
                            IMessageHandler.ShowError(ISystemMessages.LoadColumnsError + ex.Message);
                        }
                    }
                    else
                    {
                        if (_MasterColumns.Count > 0)
                        {
                            if (IMessageHandler.Confirm(ISystemMessages.ColumnReloadQuestion) == DialogResult.Yes)
                                _MasterColumns.Clear();
                            else
                                return;
                        }
                    }
                    _ZLoadMasterColumns = value;
                }
            }

            private int _KeyId;
            [Browsable(false)]
            public int KeyId
            {
                get
                {
                    return _KeyId;
                }
                set
                {
                    _KeyId = value;
                }
            }
        #endregion

        #region Variable Declarations
            public List<String> KeyList;
            public bool ValidationFails;
        #endregion

        #region Built-in Events
            public IMasterForm()
            {
                KeyList = new List<String>();
                InitializeComponent();
                AssignEventOnButtons();
            }

            private void IMasterForm_BeforeRun()
            {
                if (FormState == FormStates.fsNew)
                    AssignControlsDefaultValue();
                else
                    AssignValuesToControls();
            }

            protected override void UpdateControls()
            {
                base.UpdateControls();

                btnFirstRecord.Enabled = btnFirstRecord.Enabled && KeyId != 0;
                btnPreviousRecord.Enabled = btnPreviousRecord.Enabled && KeyId != 0;
                btnNextRecord.Enabled = btnLastRecord.Enabled && KeyId != KeyList.Count - 1;
                btnLastRecord.Enabled = btnLastRecord.Enabled && KeyId != KeyList.Count - 1;
                lblCreatedBy.Visible = (MasterColumns.Find(col => col.Name == "CreatedById") != null) && (FormState != FormStates.fsNew);
                lblModifiedBy.Visible = (MasterColumns.Find(col => col.Name == "ModifiedById") != null) && (FormState != FormStates.fsNew);

                if (FormState != FormStates.fsNew)
                    KeyId = _KeyId;
            }

            private void IMasterForm_AfterRun()
            {
                InitSeriesProviders();
                SetRequiredControls();
                SetFormFooter();
            }

            private void IMasterForm_BeforeSave()
            {
                //re-update series number before saving
                InitSeriesProviders();
                SetColumnsValue();
            }

            private void IMasterForm_ValidateSave()
            {
                ValidationFails = false;
                Object value = null;

                foreach (JkMasterColumn column in MasterColumns)
                {
                    if (!String.IsNullOrWhiteSpace(column.ControlName) && column.Required)
                    {
                        value = IAppHandler.GetControlsValue(Controls.Find(column.ControlName, true).First());

                        if (String.IsNullOrWhiteSpace(Convert.ToString(value)))
                        {
                            IMessageHandler.Inform(ISystemMessages.FillRequiredFieldMessage);
                            ValidationFails = true;
                        }
                    }
                }
            }

            private void IMasterForm_AfterSave()
            {
                if (FormState == FormStates.fsNew)
                    foreach (JkSeriesProvider series in IAppHandler.FindControlByType("JkSeriesProvider", this))
                    {
                        series.UpdateSeries();
                    }
            }
        #endregion

        #region Custom Procedures
            public void CreateMasterColumns()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                DataTable table = new DataTable();

                VTransactionHandler.LoadData(CommandText, ref table, this.Parameters);
                foreach (DataColumn dc in table.Columns)
                {
                    if (!dc.AutoIncrement)
                    {
                        JkMasterColumn column = new JkMasterColumn();
                        column.Name = dc.ColumnName;
                        column.DataType = IAppHandler.ConvertTypeToSqlType(dc.DataType);
                        column.Required = !dc.AllowDBNull;
                        column.DefaultValue = IAppHandler.SetColumnsDefaultValue(dc.ColumnName);

                        if (MasterColumns.Find(col => col.Name == column.Name) == null)
                            _MasterColumns.Add(column);
                    }
                }
            }

            //Gets the value from MasterColumn then assign it to controls such as textbox
            public void AssignValuesToControls()
            {
                if (VMasterDataTable.Rows.Count > 0)
                    foreach (JkMasterColumn column in MasterColumns)
                    {
                        column.Value = VMasterDataTable.Rows[0][column.Name];
                        if (!String.IsNullOrWhiteSpace(column.ControlName))
                        {
                            IAppHandler.SetControlsValue(Controls.Find(column.ControlName, true).First(), column.Value);
                        }
                    }
            }

            //Gets the default value set from MasterColumn then assign it to controls upon creating new transaction
            public void AssignControlsDefaultValue()
            {
                Control control;

                foreach (JkMasterColumn column in MasterColumns)
                {
                    column.Value = null;
                    if (!String.IsNullOrWhiteSpace(column.ControlName))
                    {
                        control = Controls.Find(column.ControlName, true).First();

                        if (String.IsNullOrWhiteSpace(column.DefaultValue))
                            IAppHandler.ClearControlsValue(control);
                        else
                            IAppHandler.SetControlsValue(control, IAppHandler.ConvertMaskValue(column.DefaultValue));
                    }
                }
            }

            //Sets the watermark for required columns
            public void SetRequiredControls()
            {
                Control control;

                foreach (JkMasterColumn column in MasterColumns)
                {
                    if (!String.IsNullOrWhiteSpace(column.ControlName))
                    {
                        control = Controls.Find(column.ControlName, true).First();

                        if (control.GetType().Name == "JkTextBox")
                        {
                            if (FormState == FormStates.fsView)
                                (control as JkTextBox).Required = false;
                            else
                                (control as JkTextBox).Required = column.Required;
                        }
                    }
                }
            }

            public void AssignEventOnButtons()
            {
                btnNew.Click += (obj, e) =>
                {
                    try
                    {
                        IAppHandler.StartBusy("Executing New");
                        FormState = FormStates.fsNew;
                        Run();

                        VMasterDataTable.Clear();
                        foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                            DataSet.DataTable.Clear();
                    }
                    finally
                    {
                        IAppHandler.EndBusy("Executing New");   
                    }
                };

                btnEdit.Click += (obj, e) =>
                {
                    try
                    {
                        IAppHandler.StartBusy("Executing Edit");
                        FormState = FormStates.fsEdit;
                        Run();
                    }
                    finally
                    {
                        IAppHandler.EndBusy("Executing Edit");
                    }
                };

                btnSave.Click += (obj, e) =>
                {
                    if (IMessageHandler.Confirm(ISystemMessages.SavingQuestion) == DialogResult.Yes)
                    {
                    
                        this.splitContainer.Panel2.Focus();
                        OnValidateSave();
                        if (ValidationFails)
                            return;
                        try
                        {
                            IAppHandler.StartBusy("Executing Save");
                            OnBeforeSave();
                            try
                            {
                                try
                                {
                                    //all of the events which interacts with the database
                                    //should be just put in one connection, so if in case
                                    //error occurs all the processes will be rolled back
                                    VTransactionHandler.Connect();
                                    VTransactionHandler.BeginTran();

                                    if (FormState == FormStates.fsEdit)
                                        UnPost();

                                    if (FormState == FormStates.fsNew)
                                    {
                                        VTransactionHandler.SaveMaster(CommandText, ref VMasterDataTable, Parameters);
                                        SaveDetail();
                                    }
                                    else if (FormState == FormStates.fsEdit)
                                    {
                                        VTransactionHandler.EditMaster(CommandText, Parameters);
                                        EditDetail();
                                    }

                                    Post();

                                    VTransactionHandler.CommitTran();
                                }
                                catch (Exception ex)
                                {
                                    VTransactionHandler.Rollback();
                                    if (FormState == FormStates.fsNew)
                                        IMessageHandler.ShowError(ISystemMessages.SaveDataError + ex.Message);
                                    else
                                        IMessageHandler.ShowError(ISystemMessages.EditDataError + ex.Message);

                                    return;
                                }
                            }
                            finally
                            {
                                VTransactionHandler.Disconnect();
                            }
                            
                            
                            if (FormState == FormStates.fsNew)
                            {
                                KeyList.Add(Parameters[0].Value);
                                KeyId = KeyList.Count() - 1;
                            }
                            OnAfterSave();
                            FormState = FormStates.fsView;
                            Run();
                        }
                        finally
                        {
                            IAppHandler.EndBusy("Executing Save");
                        }
                    }
                };

                btnCancel.Click += (obj, e) =>
                {
                    if (IMessageHandler.Confirm(ISystemMessages.ClosingOrCancellingQuestion) == DialogResult.Yes)
                    {
                        try
                        {
                            IAppHandler.StartBusy("Executing Cancel");
                            if (FormState == FormStates.fsNew)
                            {
                                if (ParametersHasValues())
                                {
                                    FormState = FormStates.fsView;
                                    Run();
                                }
                                else
                                    CloseForm();
                            }
                            else
                            {
                                FormState = FormStates.fsView;
                                Run();
                            }
                        }
                        finally
                        {
                            IAppHandler.EndBusy("Executing Cancel");
                        }
                    }
                };

                btnFirstRecord.Click += (obj, e) =>
                {
                    ReQuery(obj, e);
                };

                btnPreviousRecord.Click += (obj, e) =>
                {
                    ReQuery(obj, e);
                };

                btnNextRecord.Click += (obj, e) =>
                {
                    ReQuery(obj, e);
                };

                btnLastRecord.Click += (obj, e) =>
                {
                    ReQuery(obj, e);
                };
            }

            private void ReQuery(object sender, EventArgs e)
            {
                try
                {
                    IAppHandler.StartBusy("Fetching record");
                    switch (Convert.ToInt16((sender as ToolStripButton).Tag))
                    {
                        case 1:
                            KeyId = 0;
                            break;
                        case 2:
                            KeyId -= 1;
                            break;
                        case 3:
                            KeyId += 1;
                            break;
                        case 4:
                            KeyId = KeyList.Count - 1;
                            break;
                    }

                    Parameters[0].Value = Convert.ToString(KeyList[KeyId]);
                    Run();
                }
                finally
                {
                    IAppHandler.EndBusy("Fetching record");
                }
            }

            public void SetFormFooter()
            {
                lblMode.Text = "Mode: " + FormState.ToString().Substring(2);

                if (lblCreatedBy.Visible)
                {
                    lblCreatedBy.Text = String.Format("Created By:     {0} on {1}", VLookupProvider.DataSetLookup(VLookupProvider.dstSecurityUsers, "Id", MasterColumns.Find(col => col.Name == "CreatedById").Value, "FormalName"), Convert.ToDateTime(MasterColumns.Find(col => col.Name == "DateCreated").Value).ToString("MM'/'dd'/'yyyy 'at' hh:mm:ss tt"));
                }

                if (lblModifiedBy.Visible)
                {
                    lblModifiedBy.Text = String.Format("Modified By:   {0} on {1}", VLookupProvider.DataSetLookup(VLookupProvider.dstSecurityUsers, "Id", MasterColumns.Find(col => col.Name == "ModifiedById").Value, "FormalName"), Convert.ToDateTime(MasterColumns.Find(col => col.Name == "DateModified").Value).ToString("MM'/'dd'/'yyyy 'at' hh:mm:ss tt"));

                    if (MasterColumns.Find(col => col.Name == "DateCreated").Value.ToString() == MasterColumns.Find(col => col.Name == "DateModified").Value.ToString())
                    {
                        lblModifiedBy.Visible = false;
                        lblCreatedBy.Padding = new Padding(5, 5, 5, 5);
                    }
                    else
                    {
                        lblModifiedBy.Visible = true;
                        lblCreatedBy.Padding = new Padding(5, 0, 0, 0);
                        lblModifiedBy.Padding = new Padding(5, 0, 0, 0);
                    }
                }
            }

            //This will update the value on MasterColumns and DataTables before performing Save or Edit
            public void SetColumnsValue()
            {
                DataRow row = null;

                if (FormState == FormStates.fsNew)
                    row = VMasterDataTable.NewRow();
                else
                {
                    row = VMasterDataTable.Rows.Find(IAppHandler.ConvertMaskValue(Parameters[0].Value));
                    row.BeginEdit();
                }

                foreach (JkMasterColumn col in MasterColumns)
                {
                    if (String.IsNullOrWhiteSpace(col.ControlName))
                    {
                        if (!String.IsNullOrWhiteSpace(col.DefaultValue))
                        {
                            if ((col.Name == "CreatedById" || col.Name == "DateCreated") && FormState == FormStates.fsEdit)
                                col.Value = col.Value;
                            else
                                col.Value = IAppHandler.ConvertMaskValue(col.DefaultValue);
                        }
                    }
                    else
                    {
                        col.Value = IAppHandler.GetControlsValue(Controls.Find(col.ControlName, true).First());
                    }

                    row[col.Name] = col.Value ?? DBNull.Value;
                }

                if (FormState == FormStates.fsNew)
                    VMasterDataTable.Rows.Add(row);
                else
                    row.EndEdit();
            }

            private void InitSeriesProviders()
            {
                if (FormState == FormStates.fsNew)
                {
                    foreach (Control control in IAppHandler.FindControlByType("JkSeriesProvider", this))
                    {
                        JkSeriesProvider series = (control as JkSeriesProvider);

                        series.ConnectionString = Properties.Settings.Default.FreeAccountingSoftwareConnectionString;
                        series.CompanyId = ISecurityHandler.CompanyId.ToString();
                        series.GetSeries();

                        foreach(JkMasterColumn column in MasterColumns)
                        {
                            if (column.Name == series.TransactionColumn && !String.IsNullOrWhiteSpace(column.ControlName))
                            {
                                IAppHandler.SetControlsValue(Controls.Find(column.ControlName, true).First(), series.Value);
                            }
                        }
                    }
                }
            }

            protected virtual void SaveDetail()
            {
                //to be override in MasterDetailForm and to put Saving of detail 
            }

            protected virtual void EditDetail()
            { 
                //to be override in MasterDetailForm and to put Edit of detail
            }

            protected virtual void UnPost()
            { 
                //to be override in Forms and to put unposting event
            }

            protected virtual void Post()
            { 
                //to be override in Forms and to put posting event
            }
        #endregion
    }
}
