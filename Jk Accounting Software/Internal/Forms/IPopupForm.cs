using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Classes;
using System.Drawing.Design;
using JkComponents;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class IPopupForm : Form
    {
        #region Added Properties
            [Category("(Custom)")]
            public String Caption { get { return lblCaption.Text; } set { lblCaption.Text = value; } }
        #endregion

        #region Variable Declarations
            public DataTable VDataTable = new DataTable();
        #endregion

        #region Built-in Events
            public IPopupForm()
            {
                InitializeComponent();

                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
            }

            private void btnDone_Click(object sender, EventArgs e)
            {
                dataGridView.EndEdit();

                if (dstMaster.DataTable.Select("Selected = 1").Length == 0)
                {
                    IMessageHandler.Inform(ISystemMessages.SelectAtLeastOne);
                    return;
                }

                try
                {
                    IAppHandler.StartBusy("Filtering report");

                    DialogResult = DialogResult.OK;
                    PerformOperation();
                    this.Close();
                }
                finally
                {
                    IAppHandler.EndBusy("Filtering report");
                }
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }

            private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                if (e.ColumnIndex == 0 && e.RowIndex == -1)
                {
                    if (dataGridView.Columns[0].Tag == null
                        || dataGridView.Columns[0].Tag.ToString() == "0")
                        dataGridView.Columns[0].Tag = 1;
                    else
                        dataGridView.Columns[0].Tag = 0;

                    foreach (DataRow row in dstMaster.DataTable.Rows)
                    {
                        row[0] = dataGridView.Columns[0].Tag;
                    }
                }
            }

            private void cmbFilter_TextChanged(object sender, EventArgs e)
            {
                if (cmbFilter.Text == "(All)")
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Empty;
                else
                    (dataGridView.DataSource as DataTable).DefaultView.RowFilter = String.Format("{0}='{1}'", lblFilter.Text, cmbFilter.Text);
            }
        #endregion

        #region Custom Functions and Procedures
            public static DialogResult ShowSelection(String FormName, String FilterName = null, List<String> Filters = null)
            {
                IPopupForm selection = null;
                selection = Activator.CreateInstance(Type.GetType("Jk_Accounting_Software.External.Popup." + FormName)) as IPopupForm;

                if (selection == null)
                {
                    IMessageHandler.Inform(ISystemMessages.NoFormFound(FormName));
                    return DialogResult.Cancel;
                }

                try
                {
                    IAppHandler.StartBusy("Opening filter selection");

                    selection.StartPosition = FormStartPosition.CenterScreen;
                    selection.Text = IAppHandler.ApplicationText;
                    selection.LoadData();
                    selection.LoadFilter(FilterName, Filters);
                }
                finally
                {
                    IAppHandler.EndBusy("Opening filter selection");
                }
                return selection.ShowDialog(IAppHandler.FindActiveForm());
            }

            protected virtual void PerformOperation()
            {
            }

            public void LoadData()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();

                dstMaster.DataTable.Clear();
                if (!String.IsNullOrWhiteSpace(dstMaster.CommandText))
                    dstMaster.DataTable = VTransactionHandler.LoadData(dstMaster.CommandText, dstMaster.Parameters);

                dataGridView.DataSource = dstMaster.DataTable;
                dataGridView.AutoGenerateColumns = false;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.ReadOnly = column.Index != 0;
                }
            }

            public void LoadFilter(String FilterName, List<String> Filters)
            {
                if (Filters == null)
                {
                    lblFilter.Visible = false;
                    cmbFilter.Visible = false;
                    return;
                }

                lblFilter.Text = FilterName;
                foreach (String filter in Filters)
                    cmbFilter.Items.Add(filter);
                cmbFilter.SelectedIndex = 0;
            }
        #endregion
    }
}
