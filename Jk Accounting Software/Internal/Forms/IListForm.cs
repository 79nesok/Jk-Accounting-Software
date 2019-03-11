using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.Internal.Forms
{
    [Serializable]
    public partial class IListForm : IParentForm
    {
        #region Added Properties
            [Category("(Custom)")]
            public String OpenFormName { get; set; }

            [Category("(Custom)")]
            public String NewFormName { get; set; }

            private List<JkColumn> _Columns = new List<JkColumn>();
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            [Category("(Custom)")]
            public List<JkColumn> Columns { get { return _Columns; } set { _Columns = value; } }

            private bool _ZLoadColumns;
            [Category("(Custom)")]
            public bool ZLoadColumns
            {
                get { return _ZLoadColumns; }
                set
                {
                    if (value)
                    {
                        try
                        {
                            CreateColumns();
                        }
                        catch(Exception ex)
                        {
                            IMessageHandler.ShowError(ISystemMessages.LoadColumnsError + ex.Message);
                        }
                    }
                    else
                    {
                        if (_Columns.Count > 0)
                        {
                            if (IMessageHandler.Confirm(ISystemMessages.ColumnReloadQuestion) == DialogResult.Yes)
                                _Columns.Clear();
                            else
                                return;
                        }
                    }
                    _ZLoadColumns = value;
                }
            }

            private List<DataGridViewColumn> _GridColumn = new List<DataGridViewColumn>();
            [Browsable(true)]
            [Category("(Custom)")]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public List<DataGridViewColumn> GridColumn { get { return _GridColumn; } set { _GridColumn = value; } }

            private bool _ZLoadGrid;
            [Category("(Custom)")]
            public bool ZLoadGrid
            {
                get { return _ZLoadGrid; }
                set
                {
                    if (value)
                    {
                        CreateGrid();
                        CreateFooter();
                    }
                    else
                    {
                        dataGridView.Columns.Clear();
                    }
                    _ZLoadGrid = value;
                }
            }

            private bool _GridAutoSize = true;
            [Category("(Custom)")]
            public bool GridAutoSize { get { return _GridAutoSize; }
                set
                {
                    UpdateGridSize(value, true);
                    _GridAutoSize = value;
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

        #region Added Events
            public delegate void OpenFormHandler();
            public event OpenFormHandler OpenForm;
            protected virtual void OnOpenForm(IParentForm Form, object sender)
            {
                String senderName = null;

                if (sender.GetType().Name == "ToolStripButton" && (sender as ToolStripButton).Name == "btnNew")
                {
                    senderName = "btnNew";
                    Form = IAppHandler.FindForm(this.NewFormName);
                }
                else
                    Form = IAppHandler.FindForm(this.OpenFormName);

                try
                {
                    IAppHandler.StartBusy("Opening master form");

                    if (Form == null)
                    {
                        if (senderName == "btnNew")
                            IMessageHandler.Inform(ISystemMessages.NoFormFound(this.NewFormName));
                        else
                            IMessageHandler.Inform(ISystemMessages.NoFormFound(this.OpenFormName));

                        return;
                    }

                    if (senderName == "btnNew")
                        Form.FormState = FormStates.fsNew;
                    else
                        Form.FormState = FormStates.fsView;

                    for (int i = 0; i <= this.Parameters.Count - 1; i++)
                    {
                        for (int j = 0; j <= Form.Parameters.Count - 1; j++)
                        {
                            if (this.Parameters[i].Name == Form.Parameters[j].Name)
                            {
                                Form.Parameters[j].Value = this.Parameters[i].Value;
                            }

                            if (Form.Parameters[j].Name == "Id")
                            {
                                if (Form.FormState == FormStates.fsNew)
                                    Form.Parameters[j].Value = String.Empty;
                                else
                                    Form.Parameters[j].Value = GetSelectedValueOnGrid(dataGridView, 0, "dataGridViewColumnId");
                            }
                        }
                    }
                    Form.ListForm = this.Name;

                    if (OpenForm != null)
                        OpenForm();

                    (Form as IMasterForm).KeyList.Clear();
                    for (int i = 0; i <= dataGridView.Rows.Count - 1; i++)
                    {
                        (Form as IMasterForm).KeyList.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                        if (Form.Parameters[0].Value == dataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            (Form as IMasterForm).KeyId = i;
                        }
                    }

                    IAppHandler.AddUsedForm(this);
                    this.Hide();
                    Form.Run();
                }
                finally
                {
                    IAppHandler.EndBusy("Opening master form");
                }
            }
        #endregion

        #region Built-in events
            public IListForm()
            {
                InitializeComponent();

                JkDataGridView.ApplyStyleOnGrid(dataGridView);
                dataGridView.AllowUserToAddRows = false;
                dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView.AllowUserToOrderColumns = true;

                btnNew.Click += (obj, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(this.NewFormName))
                        OnOpenForm(null, btnNew);
                };
            }

            private void IListForm_BeforeRun()
            {
                SetColumnVisibility();
                ComputeFooterValues();
                
                if(dataGridView.DataSource == null)
                    dataGridView.DataSource = VMasterDataTable;
            }

            private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && !String.IsNullOrWhiteSpace(this.OpenFormName))
                    OnOpenForm(null, dataGridView);
            }

            private void dataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
            {
                foreach (Control c in GridFooter.Controls)
                {
                    if (c.Name == "lblFooter" + e.Column.HeaderText.Trim())
                    {
                        c.Width = e.Column.Width;
                    }
                }
            }

            protected override void UpdateControls()
            {
                base.UpdateControls();
                btnNew.Enabled = !String.IsNullOrWhiteSpace(NewFormName);
            }

            private void dataGridView_Scroll(object sender, ScrollEventArgs e)
            {
                HScrollBar hScrollBar = dataGridView.Controls.OfType<HScrollBar>().First();

                if (hScrollBar.Visible && e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
                {
                    GridFooter.HorizontalScroll.Maximum = hScrollBar.Maximum;
                    GridFooter.HorizontalScroll.Minimum = hScrollBar.Minimum;
                    GridFooter.HorizontalScroll.LargeChange = hScrollBar.LargeChange;
                    GridFooter.HorizontalScroll.SmallChange = hScrollBar.SmallChange;
                    GridFooter.HorizontalScroll.Value = e.NewValue;
                    GridFooter.Update();
                    dataGridView.Update();
                }
            }
        #endregion

        #region Custom procedures and functions
            public void CreateColumns()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                DataTable dt = new DataTable();

                try
                {
                    VTransactionHandler.LoadData(CommandText, ref dt, this.Parameters);

                    foreach (DataColumn dc in dt.Columns)
                    {
                        JkColumn column = new JkColumn();
                        column.Name = dc.ColumnName;
                        column.Caption = dc.ColumnName;
                        column.DataType = IAppHandler.ConvertTypeToSqlType(dc.DataType);
                        column.Width = 100;
                        column.FooterType = JkColumn.ColumnFooterTypes.ftNone;
                        if (dc.ColumnName.Contains("Id"))
                            column.Visible = false;

                        if (Columns.Find(col => col.Name == column.Name) == null)
                            _Columns.Add(column);
                    }
                }
                finally
                {
                    dt.Dispose();
                }
            }

            public void CreateGrid()
            {
                JkColumn col;

                for (int i = 0; i <= Columns.Count - 1; i++)
                {
                    col = Columns[i];

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
                        if (_GridColumn.Find(gridCol => gridCol.Name == GridColCheck.Name) == null)
                            _GridColumn.Add(GridColCheck);
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
                        if (_GridColumn.Find(gridCol => gridCol.Name == GridColDate.Name) == null)
                            _GridColumn.Add(GridColDate);
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
                            GridColText.DefaultCellStyle.Format = "#,##0.00;(#,##0.00)";
                            GridColText.ValueType = Type.GetType("System.Decimal");
                            GridColText.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }

                        dataGridView.Columns.AddRange(new DataGridViewColumn[] { GridColText });
                        if (_GridColumn.Find(gridCol => gridCol.Name == GridColText.Name) == null)
                            _GridColumn.Add(GridColText);
                    }
                    UpdateGridSize(GridAutoSize);
                }
            }

            public void UpdateGridSize(bool AutoSize, bool ResizeColumns = false)
            {
                if (AutoSize)
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                    if (ResizeColumns)
                        foreach (DataGridViewColumn dg in dataGridView.Columns)
                        {
                            dg.Width = (Columns.First(col => col.Name == dg.DataPropertyName) as JkColumn).Width;
                        }
                }
                dataGridView.Update();
            }

            public void CreateFooter()
            {
                JkColumn ic;
                int EstimatedWidth = 0, offset = 35, gridWidth = 0;

                if(VisibleColumnCount != 0)
                    EstimatedWidth = Convert.ToInt32((dataGridView.Width) / VisibleColumnCount);

                GridFooter.Padding = new Padding(3, 3, 3, 3);
                GridFooter.AutoScroll = false;

                if (Columns.Count > 0)
                {
                    Label lblOffset = new Label();

                    lblOffset.Name = "lblFooterOffset";
                    lblOffset.Width = offset;
                    lblOffset.Margin = new Padding(0, 0, 0, 0);

                    if (GridFooter.Controls.Find(lblOffset.Name, false).Length == 0)
                        GridFooter.Controls.Add(lblOffset);

                    for (int i = 0; i <= Columns.Count - 1; i++)
                    {
                        ic = Columns[i];

                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            if (column.DataPropertyName == ic.Name)
                                gridWidth = column.Width;
                        }

                        if (ic.Visible)
                        {
                            Label lblFooter = new Label();
                            lblFooter.Name = "lblFooter" + ic.Caption.Trim();
                            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
                            lblFooter.Text = AssignFooterValue(ic.FooterType, "0");
                            lblFooter.Font = new Font(this.Font.Name, this.Font.Size - 1, FontStyle.Bold);

                            if (GridAutoSize)
                                lblFooter.Width = EstimatedWidth;
                            else
                                lblFooter.Width = gridWidth;

                            if (ic.FooterType != JkColumn.ColumnFooterTypes.ftNone)
                            {
                                lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                                lblFooter.Margin = new Padding(0, 0, 2, 0);
                            }
                            else
                            {
                                lblFooter.Margin = new Padding(0, 0, 0, 0);
                            }

                            GridFooter.Controls.Add(lblFooter);
                        }
                    }
                }
            }

            public String AssignFooterValue(JkColumn.ColumnFooterTypes FooterType, String value)
            {
                String text = "";

                if (FooterType == JkColumn.ColumnFooterTypes.ftNone)
                    text = "";
                else if (FooterType == JkColumn.ColumnFooterTypes.ftAvg)
                    text = "Avg:   " + value;
                else if (FooterType == JkColumn.ColumnFooterTypes.ftCount)
                    text = "Count:   " + value;
                else if (FooterType == JkColumn.ColumnFooterTypes.ftMax)
                    text = "Max:   " + value;
                else if (FooterType == JkColumn.ColumnFooterTypes.ftMin)
                    text = "Min:   " + value;
                else if (FooterType == JkColumn.ColumnFooterTypes.ftSum)
                    text = "Sum:   " + value;

                return text;
            }

            public void ComputeFooterValues()
            {
                String value = "";

                foreach (JkColumn ic in Columns)
                {
                    if (ic.Visible && ic.FooterType != JkColumn.ColumnFooterTypes.ftNone)
                    {
                        if (ic.FooterType == JkColumn.ColumnFooterTypes.ftAvg)
                        {
                            double total = 0;

                            foreach (DataRow row in VMasterDataTable.Rows)
                                total += Convert.ToDouble(row[ic.Name]);

                            total = total / VMasterDataTable.Rows.Count;
                            value = total.ToString("#,##0.00;(#,##0.00)");
                        }
                        else if (ic.FooterType == JkColumn.ColumnFooterTypes.ftCount)
                            value = VMasterDataTable.Rows.Count.ToString();
                        else if (ic.FooterType == JkColumn.ColumnFooterTypes.ftMax)
                        {
                            double max = 0;

                            foreach (DataRow row in VMasterDataTable.Rows)
                                if (Double.Parse(row[ic.Name].ToString()) > max)
                                    max = Double.Parse(row[ic.Name].ToString());

                            if (ic.DataType == SqlDbType.BigInt || ic.DataType == SqlDbType.Int)
                                value = max.ToString();
                            else
                                value = max.ToString("#,##0.00;(#,##0.00)");
                        }
                        else if (ic.FooterType == JkColumn.ColumnFooterTypes.ftMin)
                        {
                            double min = 2147483647;

                            foreach (DataRow row in VMasterDataTable.Rows)
                                if (Double.Parse(row[ic.Name].ToString()) < min)
                                    min = Double.Parse(row[ic.Name].ToString());

                            if (ic.DataType == SqlDbType.BigInt || ic.DataType == SqlDbType.Int)
                                value = min.ToString();
                            else
                                value = min.ToString("#,##0.00;(#,##0.00)");
                        }
                        else if (ic.FooterType == JkColumn.ColumnFooterTypes.ftSum)
                        {
                            double total = 0;

                            foreach (DataRow row in VMasterDataTable.Rows)
                                total += Convert.ToDouble(row[ic.Name]);

                            value = total.ToString("#,##0.00;(#,##0.00)");
                        }

                        foreach (Control c in GridFooter.Controls)
                        {
                            if (c.Name == "lblFooter" + ic.Caption.Trim())
                                c.Text = AssignFooterValue(ic.FooterType, value);
                        }
                    }
                }
            }

            public void SetColumnVisibility()
            {
                foreach (DataGridViewColumn dg in dataGridView.Columns)
                {
                    dg.Visible = (Columns.First(col => col.Name == dg.DataPropertyName) as JkColumn).Visible;
                }
            }
        #endregion
    }
}
