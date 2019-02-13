using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Free_Accounting_Software.Internal.Forms;
using System.Drawing.Design;
using JkComponents;
using Free_Accounting_Software.Internal.Classes;
using System.Globalization;

namespace Free_Accounting_Software.Internal.Forms
{
    public partial class IMasterDetailForm : IMasterForm
    {
        #region Added Properties
            [Editor(typeof(ITextPropertyTypeEditor), typeof(UITypeEditor))]
            [Category("(Custom Detail)")]
            public String DetailCommandText { get; set; }

            private List<JkFormParameter> _DetailParameters = new List<JkFormParameter>();
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            [Category("(Custom Detail)")]
            public List<JkFormParameter> DetailParameters { get { return _DetailParameters; } set { _DetailParameters = value; } }

            private List<JkDetailColumn> _DetailColumns = new List<JkDetailColumn>();
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            [Category("(Custom Detail)")]
            public List<JkDetailColumn> DetailColumns { get { return _DetailColumns; } set { _DetailColumns = value; } }

            private bool _ZDetailLoadColumns;
            [Category("(Custom Detail)")]
            public bool ZLoadColumns
            {
                get { return _ZDetailLoadColumns; }
                set
                {
                    if (value)
                    {
                        try
                        {
                            CreateDetailColumns();
                        }
                        catch (Exception ex)
                        {
                            IMessageHandler.ShowError(ISystemMessages.LoadColumnsError + ex.Message);
                        }
                    }
                    else
                    {
                        if (_DetailColumns.Count > 0)
                        {
                            if (IMessageHandler.Confirm(ISystemMessages.ColumnReloadQuestion) == DialogResult.Yes)
                                _DetailColumns.Clear();
                            else
                                return;
                        }
                    }
                    _ZDetailLoadColumns = value;
                }
            }

            private bool _DetailGridAutoSize = true;
            [Category("(Custom Detail)")]
            public bool GridAutoSize
            {
                get { return _DetailGridAutoSize; }
                set
                {
                    UpdateDetailGridSize(value, true);
                    _DetailGridAutoSize = value;
                }
            }

            private List<DataGridViewColumn> _DetailGridColumn = new List<DataGridViewColumn>();
            [Category("(Custom Detail)")]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public List<DataGridViewColumn> DetailGridColumn { get { return _DetailGridColumn; } set { _DetailGridColumn = value; } }

            private bool _ZLoadDetailGrid;
            [Category("(Custom Detail)")]
            public bool ZLoadDetailGrid
            {
                get { return _ZLoadDetailGrid; }
                set
                {
                    if (value)
                    {
                        CreateDetailGrid();
                        CreateFooter();
                    }
                    else
                    {
                        dataGridView.Columns.Clear();
                    }
                    _ZLoadDetailGrid = value;
                }
            }

            private int VisibleColumnCount
            {
                get
                {
                    int count = 0;

                    for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
                    {
                        if (dataGridView.Columns[i].Visible)
                            count += 1;
                    }

                    return count;
                }
            }
        #endregion

        #region Built-in Events
            public IMasterDetailForm()
            {
                InitializeComponent();

                dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = VGridAlternateRowColor;
            }

            private void IMasterDetailForm_BeforeRun()
            {
                DetailParameters.Find(dp => dp.Name == "Id").Value = Parameters.Find(p => p.Name == "Id").Value;
                if (!String.IsNullOrWhiteSpace(DetailCommandText))
                {
                    VDetailDataTable.Clear();
                    VTransactionHandler.LoadData(DetailCommandText, ref VDetailDataTable, DetailParameters);
                }

                //For further update on this code, I'm still not sure if this will fit on all scenarios
                foreach (DataColumn column in VDetailDataTable.Columns)
                {
                    if (!column.AllowDBNull && column.DataType.ToString() == "System.Int32" && !column.AutoIncrement)
                    {
                        if (FormState == FormStates.fsNew)
                            column.DefaultValue = -1;
                        else
                            column.DefaultValue = Parameters.Find(p => p.Name == "Id").Value;
                    }
                }

                dataGridView.AutoGenerateColumns = false;
                if (dataGridView.DataSource == null)
                    dataGridView.DataSource = VDetailDataTable;

                LoadLookUpOnGrid();
                ComputeFooterValues();
            }

            private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {
                //retain this event, to overcome data error on comboboxcell
            }

            protected override void UpdateControls()
            {
                base.UpdateControls();

                if (FormState == FormStates.fsView)
                    dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                else
                    dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

                dataGridView.AllowUserToAddRows = FormState != FormStates.fsView;
                dataGridView.AllowUserToDeleteRows = FormState != FormStates.fsView;
            }

            protected override void SaveDetail()
            {
                base.SaveDetail();
                VTransactionHandler.SaveDetail(DetailCommandText, ref VDetailDataTable, Parameters, DetailParameters);
            }

            protected override void EditDetail()
            {
                base.EditDetail();
                VTransactionHandler.EditMaster(DetailCommandText, DetailParameters);
            }

            private void dataGridView_MouseClick(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right && dataGridView.SelectedRows.Count > 0 && dataGridView.AllowUserToDeleteRows)
                {
                    if (IMessageHandler.Confirm("Delete?") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                                dataGridView.Rows.RemoveAt(row.Index);

                            dataGridView.RefreshEdit();
                        }
                    }
                }
            }

            private void dataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
            {
                foreach (JkDetailColumn column in DetailColumns)
                {
                    if (!String.IsNullOrWhiteSpace(column.DefaultValue))
                    {
                        e.Row.Cells["dataGridViewColumn" + column.Name.Trim()].Value = IAppHandler.ConvertMaskValue(column.DefaultValue);
                    }
                }
            }

            private void IMasterDetailForm_Resize(object sender, EventArgs e)
            {
                panelGrid.Size = new Size(splitContainerMasterDetail.Panel2.Width, splitContainerMasterDetail.Panel2.Height - FormFooter.Height);
                dataGridView.Size = new Size(panelGrid.Width, panelGrid.Height - GridFooter.Height);
            }

            private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                ComputeFooterValues();
            }
        #endregion

        #region Custom Procedures and Functions
            private void LoadLookUpOnGrid(int RowIndex, int ColumnIndex)
            {
                if (dataGridView.Rows[RowIndex].Cells[ColumnIndex].GetType().Name == "DataGridViewComboBoxCell")
                {
                    foreach (JkDetailColumn column in DetailColumns)
                    {
                        if (!String.IsNullOrWhiteSpace(column.ControlName) && dataGridView.Columns[ColumnIndex].DataPropertyName == column.Name)
                        {
                            DataGridViewComboBoxCell cell = (dataGridView.Rows[RowIndex].Cells[ColumnIndex] as DataGridViewComboBoxCell);
                            JkLookUpComboBox holder = (Controls.Find(column.ControlName, true).First() as JkLookUpComboBox);

                            if (cell.DataSource == null)
                            {
                                if (holder.Items.Count == 0)
                                    holder.LoadData();

                                cell.DataSource = holder.Items;
                                cell.ValueMember = "Key";
                                cell.DisplayMember = "DisplayText";
                            }
                        }
                    }
                }
            }

            private void LoadLookUpOnGrid()
            {
                foreach(DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.GetType().ToString().Contains("DataGridViewComboBoxColumn"))
                    {
                        DataGridViewComboBoxColumn comboBox = column as DataGridViewComboBoxColumn;
                        JkLookUpComboBox lookUp = (Controls.Find(DetailColumns.Find(dc => dc.Name == column.DataPropertyName).ControlName, true).First() as JkLookUpComboBox);

                        if (lookUp.Items.Count == 0)
                            lookUp.LoadData();

                        comboBox.DataSource = lookUp.Items;
                        comboBox.DisplayMember = "DisplayText";
                        comboBox.ValueMember = "Key";
                    }
                }
            }
            
            private void CreateDetailColumns()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                DataTable dt = new DataTable();

                VTransactionHandler.LoadData(DetailCommandText, ref dt, this.DetailParameters);

                foreach (DataColumn dc in dt.Columns)
                {
                    JkDetailColumn column = new JkDetailColumn();

                    column.Caption = dc.ColumnName;
                    column.DataType = ConvertTypeToSqlType(dc.DataType);
                    column.DefaultValue = IAppHandler.SetColumnsDefaultValue(dc.ColumnName);
                    column.Name = dc.ColumnName;
                    column.Required = !dc.AllowDBNull;
                    if (column.Name.Contains("Id"))
                        column.Visible = false;
                    column.Width = 100;

                    if (DetailColumns.Find(col => col.Name == column.Name) == null)
                        _DetailColumns.Add(column);
                }
            }

            private void CreateDetailGrid()
            {
                JkDetailColumn col;

                for (int i = 0; i <= DetailColumns.Count - 1; i++)
                {
                    col = DetailColumns[i];

                    if (col.Name != "Id")
                    {


                        DataGridViewTextBoxColumn GridColText = new DataGridViewTextBoxColumn();
                        DataGridViewCheckBoxColumn GridColCheck = new DataGridViewCheckBoxColumn();
                        DataGridViewComboBoxColumn GridColCombo = new DataGridViewComboBoxColumn();
                        DataGridViewTextBoxColumn GridColDate = new DataGridViewTextBoxColumn();

                        if (col.DataType == SqlDbType.Bit)
                        {
                            GridColCheck.Name = "dataGridViewColumn" + col.Name.Trim();
                            GridColCheck.HeaderText = col.Caption;
                            GridColCheck.Width = col.Width;
                            GridColCheck.Visible = col.Visible;
                            GridColCheck.DataPropertyName = col.Name;

                            dataGridView.Columns.AddRange(new DataGridViewColumn[] { GridColCheck });
                            if (_DetailGridColumn.Find(gridCol => gridCol.Name == GridColCheck.Name) == null)
                                _DetailGridColumn.Add(GridColCheck);
                        }
                        else if (col.DataType == SqlDbType.DateTime)
                        {
                            GridColDate.Name = "dataGridViewColumn" + col.Name.Trim();
                            GridColDate.HeaderText = col.Caption;
                            GridColDate.Width = col.Width;
                            GridColDate.Visible = col.Visible;
                            GridColDate.DataPropertyName = col.Name;
                            GridColDate.DefaultCellStyle.Format = "MM'/'dd'/'yyyy";

                            dataGridView.Columns.AddRange(new DataGridViewColumn[] { GridColDate });
                            if (_DetailGridColumn.Find(gridCol => gridCol.Name == GridColDate.Name) == null)
                                _DetailGridColumn.Add(GridColDate);
                        }
                        else if (!String.IsNullOrWhiteSpace(col.ControlName))
                        {
                            GridColCombo.Name = "dataGridViewColumn" + col.Name.Trim();
                            GridColCombo.HeaderText = col.Caption;
                            GridColCombo.Width = col.Width;
                            GridColCombo.Visible = col.Visible;
                            GridColCombo.DataPropertyName = col.Name;
                            GridColCombo.MaxDropDownItems = 10;

                            dataGridView.Columns.AddRange(new DataGridViewColumn[] { GridColCombo });
                            if (_DetailGridColumn.Find(gridCol => gridCol.Name == GridColCombo.Name) == null)
                                _DetailGridColumn.Add(GridColCombo);
                        }
                        else
                        {
                            GridColText.Name = "dataGridViewColumn" + col.Name.Trim();
                            GridColText.HeaderText = col.Caption;
                            GridColText.Width = col.Width;
                            GridColText.Visible = col.Visible;
                            GridColText.DataPropertyName = col.Name;

                            if (col.DataType == SqlDbType.Money || col.DataType == SqlDbType.Float || col.DataType == SqlDbType.Decimal)
                            {
                                GridColText.DefaultCellStyle.Format = "N2";
                                GridColText.ValueType = Type.GetType("System.Decimal");
                                GridColText.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            }

                            dataGridView.Columns.AddRange(new DataGridViewColumn[] { GridColText });
                            if (_DetailGridColumn.Find(gridCol => gridCol.Name == GridColText.Name) == null)
                                _DetailGridColumn.Add(GridColText);
                        }
                    }
                }
                UpdateDetailGridSize(GridAutoSize);
            }

            private void UpdateDetailGridSize(bool AutoSize, bool ResizeColumns = false)
            {
                if (AutoSize)
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    if (ResizeColumns)
                        foreach (DataGridViewColumn dg in dataGridView.Columns)
                        {
                            dg.Width = (DetailColumns.First(col => col.Name == dg.DataPropertyName) as JkDetailColumn).Width;
                        }
                }
                dataGridView.Update();
            }

            private void CreateFooter()
            {
                JkDetailColumn ic;
                int EstimatedWidth = 0, offset = 35;

                if (VisibleColumnCount != 0)
                    EstimatedWidth = Convert.ToInt32((dataGridView.Width) / VisibleColumnCount) - 18;

                GridFooter.Padding = new Padding(offset, 3, 3, 3);

                if (DetailColumns.Count > 0)
                {
                    for (int i = 0; i <= DetailColumns.Count - 1; i++)
                    {
                        ic = DetailColumns[i];
                        if (ic.Visible)
                        {
                            Label lblFooter = new Label();
                            lblFooter.Name = "lblFooter" + ic.Caption.Trim();
                            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
                            lblFooter.Text = AssignFooterValue(ic.FooterType, "0");
                            lblFooter.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);

                            if (GridAutoSize)
                                lblFooter.Width = EstimatedWidth;
                            else
                                lblFooter.Width = ic.Width;

                            if (i == 0)
                                lblFooter.Width -= offset;

                            if (ic.FooterType != JkDetailColumn.ColumnFooterTypes.ftNone)
                                lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                            GridFooter.Controls.Add(lblFooter);
                        }
                    }
                }
            }

            private String AssignFooterValue(JkDetailColumn.ColumnFooterTypes FooterType, String value)
            {
                String text = "";

                if (FooterType == JkDetailColumn.ColumnFooterTypes.ftNone)
                    text = "";
                else if (FooterType == JkDetailColumn.ColumnFooterTypes.ftAvg)
                    text = "Avg:   " + value;
                else if (FooterType == JkDetailColumn.ColumnFooterTypes.ftCount)
                    text = "Count:   " + value;
                else if (FooterType == JkDetailColumn.ColumnFooterTypes.ftMax)
                    text = "Max:   " + value;
                else if (FooterType == JkDetailColumn.ColumnFooterTypes.ftMin)
                    text = "Min:   " + value;
                else if (FooterType == JkDetailColumn.ColumnFooterTypes.ftSum)
                    text = "Sum:   " + value;

                return text;
            }

            private void ComputeFooterValues()
            {
                String value = "";

                foreach (JkDetailColumn ic in DetailColumns)
                {
                    if (ic.Visible && ic.FooterType != JkDetailColumn.ColumnFooterTypes.ftNone)
                    {
                        if (ic.FooterType == JkDetailColumn.ColumnFooterTypes.ftCount)
                            value = VDetailDataTable.Rows.Count.ToString();
                        //todo: other footer types

                        if (ic.FooterType == JkDetailColumn.ColumnFooterTypes.ftSum)
                        {
                            double total = 0;

                            foreach (DataRow row in VDetailDataTable.Rows)
                            {
                                total += Convert.ToDouble(row[ic.Name]);
                            }

                            value = total.ToString("N2");
                        }

                        foreach (Control c in GridFooter.Controls)
                        {
                            if (c.Name == "lblFooter" + ic.Caption.Trim())
                            {
                                c.Text = AssignFooterValue(ic.FooterType, value);
                            }
                        }
                    }
                }
            }
        #endregion
    }
}
