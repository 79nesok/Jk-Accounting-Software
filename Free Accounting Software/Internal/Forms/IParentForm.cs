using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Data.SqlClient;
using JkComponents;
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.Internal.Forms
{
    [Serializable]
    [ToolboxItem(false)]
    public partial class IParentForm : UserControl
    {
        #region Added Properties
            [Browsable(false)]
            public bool IsNew { get { return btnNew.Visible; } }

            [Browsable(false)]
            public bool IsEdit { get { return btnEdit.Visible; } }

            [Browsable(false)]
            public bool IsSave { get { return btnSave.Visible; } }

            [Editor(typeof(ITextPropertyTypeEditor), typeof(UITypeEditor))]
            [Category("(Custom)")]
            public string CommandText { get; set; }

            [Category("(Custom)")]
            public string Caption { get { return lblCaption.Text; } set { lblCaption.Text = value; } }

            private List<JkFormParameter> _Parameters = new List<JkFormParameter>();
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)][Category("(Custom)")]
            public List<JkFormParameter> Parameters { get { return _Parameters; } set { _Parameters = value; } }

            public enum FormStates { fsView, fsNew, fsEdit }
            [Category("(Custom)")]
            public FormStates FormState { get; set; }

            [Browsable(false)]
            public String ListForm { get; set; }
        #endregion

        #region Added Events
            public delegate void BeforeRunHandler();
            public event BeforeRunHandler BeforeRun;
            protected virtual void OnBeforeRun()
            {
                if (CommandText != null && CommandText != "")
                    VTransactionHandler.LoadData(CommandText, ref VMasterDataTable, this.Parameters);

                if (BeforeRun != null)
                    BeforeRun();

                UpdateControls();
            }

            public delegate void ValidateSaveHandler();
            public event ValidateSaveHandler ValidateSave;
            protected virtual void OnValidateSave()
            {
                if (ValidateSave != null)
                    ValidateSave();
            }

            public delegate void BeforeSaveHandler();
            public event BeforeSaveHandler BeforeSave;
            protected virtual void OnBeforeSave()
            {
                if (BeforeSave != null)
                    BeforeSave();
            }

            public delegate void AfterSaveHandler();
            public event AfterSaveHandler AfterSave;
            protected virtual void OnAfterSave()
            {
                if (AfterSave != null)
                    AfterSave();
            }

            public delegate void AfterRunHandler();
            public event AfterRunHandler AfterRun;
            protected virtual void OnAfterRun()
            {
                if (AfterRun != null)
                    AfterRun();
            }
        #endregion

        #region Variable Declarations
            public ITransactionHandler VTransactionHandler = new ITransactionHandler();
            public ILookupProvider VLookupProvider; 
            public DataTable VMasterDataTable = new DataTable();
            public Color VGridAlternateRowColor = Color.FromArgb(180, 255, 200);
        #endregion

        #region Built-in Events
            public IParentForm()
            {
                VLookupProvider = new ILookupProvider();
                InitializeComponent();
                this.Hide();
                this.Dock = DockStyle.Fill;
            }

            private void IParentForm_Resize(object sender, EventArgs e)
            {
                panelTop.Width = this.Width;
                panelButton.Width = this.Width;
                lblCaption.Width = this.Width - btnClose.Width;
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                splitContainer.Panel2.Focus();
                if (FormState == FormStates.fsNew || FormState == FormStates.fsEdit)
                    if (IMessageHandler.Confirm(ISystemMessages.ClosingOrCancellingQuestion) == DialogResult.No)
                        return;

                CloseForm();
            }

            private void btnClose_MouseHover(object sender, EventArgs e)
            {
                btnClose.ForeColor = Color.Red;
            }

            private void btnClose_MouseLeave(object sender, EventArgs e)
            {
                btnClose.ForeColor = Color.RoyalBlue;
            }

            private void btnPrint_Click(object sender, EventArgs e)
            {
                String reportFormName = VLookupProvider.DataSetLookup(VLookupProvider.dstSystemPrintouts, "FormCaption", this.Caption, "PrintoutFormName").ToString();
                IParentForm reportForm = IAppHandler.FindForm(reportFormName, true);

                if (reportForm == null)
                    IMessageHandler.ShowError(ISystemMessages.PrintoutNotSet);
                else
                {
                    IAppHandler.AddUsedForm(this);
                    this.Hide();

                    if (reportForm.Parameters.Find(p => p.Name == "Id") != null)
                        reportForm.Parameters.Find(p => p.Name == "Id").Value = this.Parameters.Find(pa => pa.Name == "Id").Value;

                    reportForm.Run();
                }
            }
        #endregion

        #region Custom Functions and Procedures
            public void Run()
            {
                try
                {
                    IAppHandler.StartBusy("Preparing controls");
                    OnBeforeRun();

                    if(!this.Visible)
                        this.Show();
                }
                finally
                {
                    OnAfterRun();
                    IAppHandler.EndBusy("Preparing controls");
                }
            }

            public String GetSelectedValueOnGrid(DataGridView grid, int row, string columnName)
            {
                if (grid.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = grid.SelectedCells[row].RowIndex;
                    DataGridViewRow selectedRow = grid.Rows[selectedRowIndex];

                    return selectedRow.Cells[columnName].Value.ToString();
                }

                return null;
            }

            protected virtual void UpdateControls()
            {
                btnNew.Visible = (FormState == FormStates.fsView);
                btnEdit.Visible = (FormState == FormStates.fsView) && (!IsListForm()); ;
                btnSave.Visible = (FormState != FormStates.fsView);
                btnCancel.Visible = (FormState != FormStates.fsView);
                btnNavigator.Visible = !IsListForm();
                btnFirstRecord.Enabled = (FormState == FormStates.fsView);
                btnPreviousRecord.Enabled = (FormState == FormStates.fsView);
                btnNextRecord.Enabled = (FormState == FormStates.fsView);
                btnLastRecord.Enabled = (FormState == FormStates.fsView);
                btnPrint.Visible = (FormState == FormStates.fsView) && !IsListForm() && (VLookupProvider.DataSetLookup(VLookupProvider.dstSystemPrintouts, "FormCaption", this.Caption, "FormCaption") != null);

                ProcessControls(splitContainer.Panel2);
            }

            public void ProcessControls(Control control)
            {
                foreach (Control c in control.Controls)
                {
                    if (c.GetType().Name == "TextBox" ||
                        c.GetType().Name == "CheckBox" ||
                        c.GetType().Name == "ComboBox" ||
                        c.GetType().Name == "DateTimePicker" ||
                        c.GetType().Name == "PictureBox" ||
                        c.GetType().Name == "LinkLabel" ||
                        c.GetType().Name == "JkLookUpComboBox" ||
                        c.GetType().Name == "JkTextBox")
                    {
                        c.Enabled = (FormState != FormStates.fsView);
                    }

                    if (c.GetType().Name == "JkLookUpComboBox")
                    {
                        (c as JkLookUpComboBox).LoadData();
                    }
                    ProcessControls(c);
                }
            }

            public SqlDbType ConvertTypeToSqlType(Type type)
            {
                SqlParameter param;
                TypeConverter converter;

                param = new SqlParameter();
                converter = TypeDescriptor.GetConverter(param.DbType);

                if (converter.CanConvertFrom(type))
                    param.DbType = (DbType)converter.ConvertFrom(type.Name);
                else
                {
                    try
                    {
                        param.DbType = (DbType)converter.ConvertFrom(type.Name); 
                    }
                    catch { }
                }

                return param.SqlDbType;
            }

            public bool IsListForm()
            {
                return (this.GetType().BaseType.ToString().Contains("IListForm"));
            }

            public bool ParametersHasValues()
            {
                foreach (JkFormParameter param in Parameters)
                {
                    if (!String.IsNullOrEmpty(param.Value) && param.Name == "Id")
                    {
                        return true;
                    }
                }

                return false;
            }

            public void CloseForm()
            {
                VMasterDataTable.Clear();
                IAppHandler.AddUsedForm(this);
                this.Hide();

                if (IAppHandler.OpenPreviousForm(this.Tag) != null)
                    IAppHandler.OpenPreviousForm(this.Tag).Run();
            }

            public void CreateToolStripItem(String PCaption, Action<Object, EventArgs> POnItemClick, Image img, String PToolTipText = "")
            {
                ToolStripButton btn = new ToolStripButton();

                btn.Name = "btn" + Caption.Trim();
                btn.Text = PCaption;
                btn.ToolTipText = PToolTipText;
                btn.Click += (obj, e) => {
                    POnItemClick(obj, e); 
                };
                btn.Image = img;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;

                if (btnHolder.Items[btnHolder.Items.Count - 1] == btnCancel)
                {
                    ToolStripSeparator separator = new ToolStripSeparator();

                    btnHolder.Items.Add(separator);
                }

                if(!btnHolder.Items.Contains(btn))
                    btnHolder.Items.Add(btn);
            }
        #endregion
    }
}
