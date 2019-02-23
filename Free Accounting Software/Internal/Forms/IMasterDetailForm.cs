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
            }

            private void IMasterDetailForm_BeforeRun()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText))
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
                        DataSet.GridView.EditMode = DataGridViewEditMode.EditOnEnter;

                    DataSet.GridView.AllowUserToAddRows = FormState != FormStates.fsView;
                    DataSet.GridView.AllowUserToDeleteRows = FormState != FormStates.fsView;
                }
            }

            protected override void SaveDetail()
            {
                base.SaveDetail();

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText))
                        VTransactionHandler.SaveDetail(DataSet.CommandText, DataSet.DataTable, Parameters, DataSet.Parameters);
            }

            protected override void EditDetail()
            {
                base.EditDetail();

                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                    if (!String.IsNullOrWhiteSpace(DataSet.CommandText))
                        VTransactionHandler.EditMaster(DataSet.CommandText, DataSet.Parameters);
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
                        && dataGridView.AllowUserToDeleteRows
                        && !dataGridView.Rows[RowIndex].Cells[ColumnIndex].ReadOnly;
                    CopyMenu.Enabled = !String.IsNullOrEmpty(dataGridView.Rows[RowIndex].Cells[ColumnIndex].Value.ToString());
                    DeleteMenu.Enabled = dataGridView.AllowUserToDeleteRows;
                    PasteMenu.Enabled = Clipboard.ContainsText()
                        && dataGridView.AllowUserToAddRows
                        && !dataGridView.Rows[RowIndex].Cells[ColumnIndex].ReadOnly;

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

            private void IMasterDetailForm_AfterRun()
            {
                foreach (JkDetailDataSet DataSet in IAppHandler.FindControlByType("JkDetailDataSet", this))
                {
                    //workaround to hide columns that are generated automatically by .Net
                    foreach (DataGridViewColumn column in DataSet.GridView.Columns)
                    {
                        column.Visible = DataSet.Columns.Find(c => c.Name == column.DataPropertyName).Visible;
                    }
                }
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
        #endregion
    }
}
