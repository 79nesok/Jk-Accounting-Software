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
        #region Built-in Events
            public IMasterDetailForm()
            {
                InitializeComponent();
                dataGridView.AutoGenerateColumns = false;
            }

            private void IMasterDetailForm_BeforeRun()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    DataSet.Parameters.Find(dp => dp.Name == "Id").Value = Parameters.Find(p => p.Name == "Id").Value;
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText))
                    {
                        DataSet.DataTable.Clear();
                        DataSet.DataTable = VTransactionHandler.LoadData(DataSet.CommandText, DataSet.Parameters);

                        dataGridView.AutoGenerateColumns = false;
                        dataGridView.DataSource = DataSet.DataTable;
                        dataGridView.ComputeFooterValues();
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
                LoadLookUpOnGrid();
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
                    dataGridView.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                dataGridView.AllowUserToAddRows = FormState != FormStates.fsView;
                dataGridView.AllowUserToDeleteRows = FormState != FormStates.fsView;
            }

            protected override void SaveDetail()
            {
                base.SaveDetail();
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    VTransactionHandler.SaveDetail(DataSet.CommandText, DataSet.DataTable, Parameters, DataSet.Parameters);
            }

            protected override void EditDetail()
            {
                base.EditDetail();
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    VTransactionHandler.EditMaster(DataSet.CommandText, DataSet.Parameters);
            }

            private void dataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
            {
                foreach (JkDetailColumn column in dstDetail.Columns)
                {
                    if (!String.IsNullOrWhiteSpace(column.DefaultValue))
                    {
                        e.Row.Cells["dataGridViewColumn" + column.Name.Trim()].Value = IAppHandler.ConvertMaskValue(column.DefaultValue);
                    }
                }
            }

            private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                if (FormState != FormStates.fsView && e.Control != null && e.Control is ComboBox)
                {
                    (e.Control as ComboBox).IntegralHeight = false;
                    (e.Control as ComboBox).MaxDropDownItems = 10;
                }
            }

            private void dataGridView_MouseClick(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right
                    && dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.Cell
                    && dataGridView.HitTest(e.X, e.Y).RowIndex != dataGridView.NewRowIndex)
                {
                    int RowIndex = dataGridView.HitTest(e.X, e.Y).RowIndex,
                        ColumnIndex = dataGridView.HitTest(e.X, e.Y).ColumnIndex;
                    ContextMenu menu = new ContextMenu();

                    MenuItem ClearMenu = new MenuItem();
                    MenuItem CopyMenu = new MenuItem();
                    MenuItem DeleteMenu = new MenuItem();
                    MenuItem PasteMenu = new MenuItem();

                    //set text
                    ClearMenu.Text = "Clear Cell";
                    CopyMenu.Text = "Copy";
                    DeleteMenu.Text = "Delete Row";
                    PasteMenu.Text = "Paste";

                    //set event
                    ClearMenu.Click += delegate(object s, EventArgs ea)
                    {
                        if (dstDetail.DataTable.Columns[dataGridView.Columns[ColumnIndex].DataPropertyName].AllowDBNull)
                            dstDetail.DataTable.Rows[RowIndex][dataGridView.Columns[ColumnIndex].DataPropertyName] = DBNull.Value;
                        else
                            dstDetail.DataTable.Rows[RowIndex][dataGridView.Columns[ColumnIndex].DataPropertyName] = 0;
                        splitContainerMasterDetail.Panel1.Focus();
                        dataGridView.Focus();
                    };
                    CopyMenu.Click += delegate(object s, EventArgs ea)
                    {
                        Clipboard.SetText(dataGridView.Rows[RowIndex].Cells[ColumnIndex].Value.ToString(), TextDataFormat.Text);
                    };
                    DeleteMenu.Click += delegate(object s, EventArgs ea)
                    {
                        if (dataGridView.SelectedRows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dataGridView.SelectedRows)
                            {
                                if (!row.IsNewRow)
                                    dataGridView.Rows.RemoveAt(row.Index);
                            }
                        }
                        else
                            dataGridView.Rows.RemoveAt(RowIndex);

                        splitContainerMasterDetail.Panel1.Focus();
                        dataGridView.Focus();
                    };
                    PasteMenu.Click += delegate(object s, EventArgs ea)
                    {
                        dstDetail.DataTable.Rows[RowIndex][dataGridView.Columns[ColumnIndex].DataPropertyName] = Clipboard.GetText();
                        splitContainerMasterDetail.Panel1.Focus();
                        dataGridView.Focus();
                    };

                    //set if enabled
                    ClearMenu.Enabled = dataGridView.Rows[RowIndex].Cells[ColumnIndex].Value != null
                        && dataGridView.AllowUserToDeleteRows;
                    CopyMenu.Enabled = !String.IsNullOrEmpty(dataGridView.Rows[RowIndex].Cells[ColumnIndex].Value.ToString());
                    DeleteMenu.Enabled = dataGridView.AllowUserToDeleteRows;
                    PasteMenu.Enabled = Clipboard.ContainsText()
                        && dataGridView.AllowUserToAddRows;

                    //add on ContextMenu
                    menu.MenuItems.Add(ClearMenu);
                    menu.MenuItems.Add(CopyMenu);
                    menu.MenuItems.Add(DeleteMenu);
                    menu.MenuItems.Add(PasteMenu);

                    menu.Show(dataGridView, new Point(e.X, e.Y));
                }
            }

            private void IMasterDetailForm_Resize(object sender, EventArgs e)
            {
                splitContainerMasterDetail.Size = new Size(splitContainer.Width, splitContainer.Panel2.Height - FormFooter.Height);
            }
        #endregion

        #region Custom Procedures and Functions
            private void LoadLookUpOnGrid(int RowIndex, int ColumnIndex)
            {
                if (dataGridView.Rows[RowIndex].Cells[ColumnIndex].GetType().Name == "DataGridViewComboBoxCell")
                {
                    foreach (JkDetailColumn column in dstDetail.Columns)
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
                        JkLookUpComboBox lookUp = (Controls.Find(dstDetail.Columns.Find(dc => dc.Name == column.DataPropertyName).ControlName, true).First() as JkLookUpComboBox);

                        if (lookUp.Items.Count == 0)
                            lookUp.LoadData();

                        comboBox.DataSource = lookUp.Items;
                        comboBox.DisplayMember = "DisplayText";
                        comboBox.ValueMember = "Key";
                    }
                }
            }
        #endregion
    }
}
