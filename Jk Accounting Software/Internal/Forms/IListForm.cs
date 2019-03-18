using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;
using System.Drawing.Printing;

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

                txtFind.KeyDown += txtFind_KeyDown;
                btnReset.Click += btnReset_Click;
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
                txtFind.Clear();
                (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Empty;
                txtFind.Focus();
            }

            private void txtFind_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter && !String.IsNullOrWhiteSpace(txtFind.Text))
                {
                    String filtering = null;

                    foreach (JkColumn column in Columns)
                    {
                        if (column.Visible
                            && (column.DataType == SqlDbType.NVarChar || column.DataType == SqlDbType.VarChar))
                        {
                            filtering += String.Format(" {0} LIKE '%{1}%' ", column.Name, txtFind.Text);
                            filtering += "OR";
                        }
                    }
                    filtering = filtering.Substring(0, filtering.Count() - 3);

                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = filtering;
                }
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

                //for further update
                btnPreview.Visible = false;
                toolStripSeparatorPreview.Visible = false;
                //btnPreview.Enabled = dataGridView.Rows.Count > 0;
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

            private void IListForm_AfterRun()
            {
                SetAutoCompleteForSearchField();
            }

            protected override void Preview()
            {
                base.Preview();

                PrintPreviewControl printPreviewControl = new PrintPreviewControl();

                printDocument.DocumentName = "List of " + this.Caption;
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Letter", 850, 1100);


                printPreviewDialog.Document = printDocument;
                pageSetupDialog.Document = printDocument;
                printDialog.Document = printDocument;
                printPreviewControl.Document = printDocument;

                //printPreviewDialog.Parent = IAppHandler.ParentPanel;
                printPreviewDialog.Show();

                //printPreviewDialog.ShowDialog();

                //pageSetupDialog.ShowDialog();

                //printDialog.ShowDialog();

                //printPreviewControl.Parent = IAppHandler.ParentPanel;
                //printPreviewControl.Dock = DockStyle.Fill;
                //printPreviewControl.Show();
                this.Hide();
            }

            private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                //String value = null;
                //int x = 0, y = 0;
                //Pen blackPen = new Pen(Brushes.Black, 1);

                //int PaperWidth = e.PageSettings.PaperSize.Width;
                //Font font = null;
                //int StringWidth = 0;

                ////Report Name
                //font = new Font(this.Font.Name, this.Font.Size + 8, FontStyle.Bold);
                //StringWidth = Convert.ToInt32(e.Graphics.MeasureString(printDocument.DocumentName, font).Width);
                //e.Graphics.DrawString(printDocument.DocumentName, font, Brushes.Black, (PaperWidth - StringWidth) / 2, 5);

                //foreach (DataGridViewColumn column in dataGridView.Columns)
                //{
                //    //grid header
                //    if (dataGridView.Columns[column.Index].Visible)
                //    {
                //        e.Graphics.DrawRectangle(blackPen, x * 100 - 5, y * 25 + 45, 100, 25);
                //        font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
                //        e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, (x * 100), (y * 25 + 50));
                //    }

                //    foreach (DataGridViewRow row in dataGridView.Rows)
                //    {
                //        if (dataGridView.Columns[column.Index].Visible)
                //        {
                //            y++;
                //            value = dataGridView.Rows[row.Index].Cells[column.Index].FormattedValue.ToString();

                //            //grid
                //            e.Graphics.DrawRectangle(blackPen, x * 100 - 5, y * 25 + 45, 100, 25);

                //            //item
                //            e.Graphics.DrawString(value, this.Font, Brushes.Black, (x * 100), (y * 25 + 50));
                //        }
                //    }
                //    y = 0;
                //    x++;
                //}

                try
                {
                    //Set the left margin
                    int iLeftMargin = e.MarginBounds.Left;
                    //Set the top margin
                    int iTopMargin = e.MarginBounds.Top;
                    //Whether more pages have to print or not
                    bool bMorePagesToPrint = false;
                    int iTmpWidth = 0;

                    bool bFirstPage = true;
                    int iTotalWidth = 0;
                    int iHeaderHeight = 0;
                    int iRow = 0;
                    int iCellHeight = 0;
                    bool bNewPage = false;
                    List<int> arrColumnLefts = new List<int>();
                    List<int> arrColumnWidths = new List<int>();
                    StringFormat strFormat = new StringFormat();
                    int iCount;

                    strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Near;
                    strFormat.LineAlignment = StringAlignment.Center;
                    strFormat.Trimming = StringTrimming.EllipsisCharacter;

                    arrColumnLefts.Clear();
                    arrColumnWidths.Clear();
                    iCellHeight = 0;
                    iCount = 0;
                    bFirstPage = true;
                    bNewPage = true;

                    // Calculating Total Widths
                    iTotalWidth = 0;
                    foreach (DataGridViewColumn dgvGridCol in dataGridView.Columns)
                    {
                        if (dgvGridCol.Visible)
                            iTotalWidth += dgvGridCol.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
                    }


                    //For the first page to print set the cell width and header height
                    if (bFirstPage)
                    {
                        foreach (DataGridViewColumn GridCol in dataGridView.Columns)
                        {
                            if (GridCol.Visible)
                            {
                                iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                    (double)iTotalWidth * (double)iTotalWidth *
                                    ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                                iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                                // Save width and height of headers
                                arrColumnLefts.Add(iLeftMargin);
                                arrColumnWidths.Add(iTmpWidth);
                                iLeftMargin += iTmpWidth;
                            }
                        }
                    }
                    //Loop till all the grid rows not get printed
                    while (iRow <= dataGridView.Rows.Count - 1)
                    {
                        DataGridViewRow GridRow = dataGridView.Rows[iRow];
                        //Set the cell height
                        iCellHeight = GridRow.Height + 5;
                        //Check whether the current page settings allows more rows to print
                        if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                        {
                            bNewPage = true;
                            bFirstPage = false;
                            bMorePagesToPrint = true;
                            break;
                        }
                        else
                        {
                            if (bNewPage)
                            {
                                //Draw Header
                                e.Graphics.DrawString(printDocument.DocumentName,
                                    new Font(dataGridView.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left,
                                    e.MarginBounds.Top - e.Graphics.MeasureString(printDocument.DocumentName,
                                    new Font(dataGridView.Font, FontStyle.Bold),
                                    e.MarginBounds.Width).Height - 13);

                                String strDate = DateTime.Now.ToLongDateString() + " " +
                                    DateTime.Now.ToShortTimeString();
                                //Draw Date
                                e.Graphics.DrawString(strDate,
                                    new Font(dataGridView.Font, FontStyle.Bold), Brushes.Black,
                                    e.MarginBounds.Left +
                                    (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                    new Font(dataGridView.Font, FontStyle.Bold),
                                    e.MarginBounds.Width).Width),
                                    e.MarginBounds.Top - e.Graphics.MeasureString(printDocument.DocumentName,
                                    new Font(new Font(dataGridView.Font, FontStyle.Bold),
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                //Draw Columns                 
                                iTopMargin = e.MarginBounds.Top;
                                foreach (DataGridViewColumn GridCol in dataGridView.Columns)
                                {
                                    if (GridCol.Visible)
                                    {
                                        e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight));

                                        e.Graphics.DrawRectangle(Pens.Black,
                                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight));

                                        e.Graphics.DrawString(GridCol.HeaderText,
                                            GridCol.InheritedStyle.Font,
                                            new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                            (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                        iCount++;
                                    }
                                }
                                bNewPage = false;
                                iTopMargin += iHeaderHeight;
                            }
                            iCount = 0;
                            //Draw Columns Contents                
                            foreach (DataGridViewCell Cel in GridRow.Cells)
                            {
                                if (Cel.Visible)
                                {
                                    if (Cel.Value != null)
                                    {
                                        e.Graphics.DrawString(Cel.FormattedValue.ToString(),
                                            Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount],
                                            (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight),
                                            strFormat);
                                    }
                                    //Drawing Cells Borders 
                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iCellHeight));
                                    iCount++;
                                }
                            }
                        }
                        iRow++;
                        iTopMargin += iCellHeight;
                    }
                    //If more lines exist, print another page.
                    if (bMorePagesToPrint)
                        e.HasMorePages = true;
                    else
                        e.HasMorePages = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
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

            private void SetAutoCompleteForSearchField()
            {
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();

                foreach (JkColumn column in Columns)
                {
                    if (column.Visible
                        && (column.DataType == SqlDbType.VarChar || column.DataType == SqlDbType.NVarChar))
                    {
                        foreach (String data in VMasterDataTable
                               .AsEnumerable()
                               .Select<System.Data.DataRow, String>(x => x.Field<String>(column.Name))
                               .ToArray())
                        {
                            if (!source.Contains(data) && !String.IsNullOrWhiteSpace(data))
                                source.Add(data);
                        }
                    }
                }

                txtFind.AutoCompleteCustomSource = source;
                txtFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFind.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        #endregion    
    }
}
