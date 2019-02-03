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
                txtRecordCount.Text = (value + 1).ToString();
            }
        }
        #endregion

        #region Variable Declarations
        public List<String> KeyList;
        #endregion

        public IMasterForm()
        {
            KeyList = new List<String>();
            InitializeComponent();
            AssignEventOnButtons();
        }

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
                    column.DataType = ConvertTypeToSqlType(dc.DataType);
                    column.Required = !dc.AllowDBNull;
                    column.DefaultValue = IAppHandler.SetColumnsDefaultValue(dc.ColumnName);

                    if (MasterColumns.Find(col => col.Name == column.Name) == null)
                        _MasterColumns.Add(column);
                }
            }
        }

        public void AssignValuesToControls()
        {
            if (VDataTable.Rows.Count > 0)
                foreach (JkMasterColumn column in MasterColumns)
                {
                    column.Value = VDataTable.Rows[0][column.Name];
                    if (!String.IsNullOrWhiteSpace(column.ControlName))
                    {
                        IAppHandler.SetControlsValue(Controls.Find(column.ControlName, true).First(), column.Value);
                    }
                }
        }

        public void AssignControlsDefaultValue()
        {
            foreach (JkMasterColumn column in MasterColumns)
            {
                if (!String.IsNullOrWhiteSpace(column.ControlName))
                {
                    IAppHandler.SetControlsValue(Controls.Find(column.ControlName, true).First(), IAppHandler.ConvertMaskValue(column.DefaultValue));
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
                    try
                    {
                        IAppHandler.StartBusy("Executing Save");
                        this.splitContainer.Panel2.Focus();
                        OnValidateSave();
                        OnBeforeSave();
                        VTransactionHandler.SaveData(ref VDataTable, MasterColumns, Parameters, FormState);
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

            txtRecordCount.KeyDown += (obj, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        int input = Convert.ToInt32(txtRecordCount.Text);

                        if (input <= 0 || input > KeyList.Count)
                        {
                            IMessageHandler.ShowError(ISystemMessages.RecordCountInputError(KeyList.Count.ToString()));
                            txtRecordCount.SelectAll();
                        }
                        else
                        {
                            KeyId = input - 1;
                            Parameters[0].Value = Convert.ToString(KeyList[KeyId]);
                            Run();
                        }
                    }
                    catch
                    {
                        IMessageHandler.ShowError(ISystemMessages.InvalidInputError);
                        txtRecordCount.SelectAll();
                    }
                }
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
                VDataTable.Clear();
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
                lblCreatedBy.Text = String.Format("Created By: {0} on {1}", VLookupProvider.DataSetLookup(VLookupProvider.dstSecurityUsers, "Id", MasterColumns.Find(col => col.Name == "CreatedById").Value, "FormalName"), Convert.ToDateTime(MasterColumns.Find(col => col.Name == "DateCreated").Value).ToString("MM'/'dd'/'yyyy 'at' hh:mm:ss tt"));
            }

            if (lblModifiedBy.Visible)
            {
                lblModifiedBy.Text = String.Format("Modified By: {0} on {1}", VLookupProvider.DataSetLookup(VLookupProvider.dstSecurityUsers, "Id", MasterColumns.Find(col => col.Name == "ModifiedById").Value, "FormalName"), Convert.ToDateTime(MasterColumns.Find(col => col.Name == "DateModified").Value).ToString("MM'/'dd'/'yyyy 'at' hh:mm:ss tt"));

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

        public void SetColumnsValue()
        {
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
            }
            return;
        }
        #endregion

        #region Built-in Events
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

            if (FormState == FormStates.fsNew)
                txtRecordCount.Clear();
            else
                KeyId = _KeyId;
        }

        private void IMasterForm_AfterRun()
        {
            SetFormFooter();
        }

        private void IMasterForm_BeforeSave()
        {
            SetColumnsValue();
        }
        #endregion    
    }
}
