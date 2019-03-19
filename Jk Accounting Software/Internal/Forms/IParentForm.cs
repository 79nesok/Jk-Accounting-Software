using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.Internal.Forms
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
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            [Category("(Custom)")]
            public List<JkFormParameter> Parameters { get { return _Parameters; } set { _Parameters = value; } }

            public enum FormStates { fsView, fsNew, fsEdit }
            [Category("(Custom)")]
            public FormStates FormState { get; set; }

            [Browsable(false)]
            public String SubCategory { get; set; }
        #endregion

        #region Added Events
            public delegate void SetupDataHandler();
            [Category("(Custom)")]
            public event SetupDataHandler SetupData;
            protected virtual void OnSetupData()
            {
                //load all lookups
                foreach (JkLookUpComboBox comboBox in IAppHandler.FindControlByType("JkLookUpComboBox", this))
                {
                    comboBox.LoadData();
                }

                //clear all datatables
                VMasterDataTable.Clear();
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    DataSet.DataTable.Clear();

                if (CommandText != null && CommandText != "")
                    VTransactionHandler.LoadData(CommandText, ref VMasterDataTable, this.Parameters);

                if (SetupData != null)
                    SetupData();
            }

            public delegate void SetupControlHandler();
            [Category("(Custom)")]
            public event SetupControlHandler SetupControl;
            protected virtual void OnSetupControl()
            {
                UpdateControls();

                if (SetupControl != null)
                    SetupControl();
            }

            public delegate void ValidateSaveHandler();
            [Category("(Custom)")]
            public event ValidateSaveHandler ValidateSave;
            protected virtual void OnValidateSave()
            {
                if (ValidateSave != null)
                    ValidateSave();
            }

            public delegate void BeforeSaveHandler();
            [Category("(Custom)")]
            public event BeforeSaveHandler BeforeSave;
            protected virtual void OnBeforeSave()
            {
                if (BeforeSave != null)
                    BeforeSave();
            }

            public delegate void AfterSaveHandler();
            [Category("(Custom)")]
            public event AfterSaveHandler AfterSave;
            protected virtual void OnAfterSave()
            {
                if (AfterSave != null)
                    AfterSave();
            }
        #endregion

        #region Variable Declarations
            public ITransactionHandler VTransactionHandler = new ITransactionHandler();
            public ILookupProvider VLookupProvider; 
            public DataTable VMasterDataTable = new DataTable();
            public bool EditingReady;
        #endregion

        #region Built-in Events
            public IParentForm()
            {
                InitializeComponent();
                this.Hide();
                this.Dock = DockStyle.Fill;

                if (JkLookUpProviderList.List.Count > 0)
                    VLookupProvider = (JkLookUpProviderList.List[0] as ILookupProvider);
            }

            private void IParentForm_Resize(object sender, EventArgs e)
            {
                panelTop.Width = this.Width;
                panelButton.Width = this.Width;
                lblCaption.Width = this.Width - btnClose.Width;
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                if (!btnClose.Visible || !btnClose.Enabled)
                    return;

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

            private void btnPreview_Click(object sender, EventArgs e)
            {
                if (!btnPreview.Visible || !btnPreview.Enabled)
                    return;

                Preview();
            }
        #endregion

        #region Custom Functions and Procedures
            public void Run()
            {
                try
                {
                    IAppHandler.StartBusy("Preparing controls");

                    if (!this.Visible)
                        this.Show();

                    IAppHandler.SuspendDrawing(this);
                    EditingReady = false;

                    //setup data first before controls, since there are
                    //controls which are dependent on data
                    OnSetupData();
                    OnSetupControl();
                }
                finally
                {
                    IAppHandler.ResumeDrawing(this);
                    EditingReady = true;

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
                btnEdit.Visible = (FormState == FormStates.fsView) && !IsListForm();
                btnSave.Visible = (FormState != FormStates.fsView);
                btnCancel.Visible = (FormState != FormStates.fsView);

                btnFilter.Visible = false;
                btnRemoveFilter.Visible = false;

                lblFind.Visible = IsListForm();
                txtFind.Visible = IsListForm();
                btnReset.Visible = IsListForm();

                NavigatorSeparatorFirst.Visible = !IsListForm();
                NavigatorSeparatorSecond.Visible = !IsListForm();

                btnFirstRecord.Visible = !IsListForm();
                btnPreviousRecord.Visible = !IsListForm();
                btnNextRecord.Visible = !IsListForm();
                btnLastRecord.Visible = !IsListForm();

                btnFirstRecord.Enabled = (FormState == FormStates.fsView);
                btnPreviousRecord.Enabled = (FormState == FormStates.fsView);
                btnNextRecord.Enabled = (FormState == FormStates.fsView);
                btnLastRecord.Enabled = (FormState == FormStates.fsView);

                ProcessDataControls(splitContainer.Panel2);
                LoadPrintoutSelection();
            }

            private void ProcessDataControls(Control control)
            {
                foreach (Control childControl in control.Controls)
                {
                    if (((childControl is TextBox && !(childControl as TextBox).ReadOnly)
                        || childControl is CheckBox
                        || childControl is ComboBox                        
                        || childControl is DateTimePicker
                        || childControl is PictureBox
                        || childControl is LinkLabel
                        || childControl is JkLookUpComboBox
                        || (childControl is JkTextBox && !(childControl as JkTextBox).ReadOnly)
                        || childControl is MaskedTextBox)
                        
                        && childControl.Visible)
                    {
                        childControl.Enabled = (FormState != FormStates.fsView);

                        //set the tabindex to zero, to correct the controls tab arrangement
                        childControl.TabIndex = 0;
                    }

                    //readonly controls should not be able to focus upon keypress of tab
                    if ((childControl is TextBox && (childControl as TextBox).ReadOnly)
                        || (childControl is JkTextBox && (childControl as JkTextBox).ReadOnly))
                        childControl.TabStop = false;

                    ProcessDataControls(childControl);
                }
            }

            //loads selection for printout
            private void LoadPrintoutSelection()
            {
                if (FormState == FormStates.fsView
                    && !IsListForm())
                {
                    foreach(DataRow row in VLookupProvider.dstSystemPrintouts.DataTable.Select(String.Format("FormCaption = '{0}'", this.Caption)))
                    {
                        ToolStripMenuItem item = new ToolStripMenuItem();

                        item.Name = "toolStripMenuItemPrint" + row["Report"].ToString().Replace(" ", "");
                        item.Text = row["Report"].ToString();
                        item.Tag = row["PrintoutFormName"].ToString();
                        item.Click += (obj, ea) =>
                        {
                            IParentForm reportForm = IAppHandler.FindForm(item.Tag.ToString(), "Printout", true);

                            if (reportForm == null)
                                IMessageHandler.ShowError(ISystemMessages.PrintoutNotSet);
                            else
                            {
                                IAppHandler.AddUsedForm(this);
                                this.Hide();

                                if (reportForm.Parameters.Find(p => p.Name == "Id") != null)
                                    reportForm.Parameters.Find(p => p.Name == "Id").Value = this.Parameters.Find(pa => pa.Name == "Id").Value;

                                (reportForm as IReportForm).PrintoutHeader = this.Caption;
                                reportForm.Run();
                            }
                        
                        };

                        if (btnPreview.DropDownItems.Find(item.Name, true).Length == 0)
                            btnPreview.DropDownItems.Add(item);
                    }
                }
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

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    DataSet.DataTable.Clear();

                if (IAppHandler.OpenPreviousForm(this) != null)
                    IAppHandler.OpenPreviousForm(this).Run();
                this.Dispose();
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

            protected virtual void Preview()
            {
            }
        #endregion
    }
}
