using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.Internal.Classes;
using System.Data.SqlClient;

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class ECashDisbursementVoucherForm : IMasterDetailForm
    {
        public ECashDisbursementVoucherForm()
        {
            InitializeComponent();
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.MouseClick += dataGridView_MouseClick;

            dataGridViewPaymentDetails.CellEndEdit += dataGridViewPaymentDetails_CellEndEdit;
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right
                && dataGridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.Cell
                && dataGridView.HitTest(e.X, e.Y).RowIndex != dataGridView.NewRowIndex)
            {

                MenuItem Apply = new MenuItem();

                Apply.Text = "Apply";

                Apply.Click += delegate(object s, EventArgs ea)
                {
                    int BalanceIndex = dataGridView.GetCellIndex("Balance");
                    int AmountAppliedIndex = dataGridView.GetCellIndex("AppliedAmount");
                    int AmountToApplyIndex = dataGridView.GetCellIndex("AmountToApply");

                    double AmountToApply = double.Parse(dataGridView.CurrentRow.Cells[AmountToApplyIndex].Value.ToString());
                    double Balance = double.Parse(dataGridView.CurrentRow.Cells[BalanceIndex].Value.ToString());

                    if (AmountToApply > Balance)
                        IMessageHandler.ShowError(ISystemMessages.AmountToApplyExceedsBalance);
                    else
                    {
                        dataGridView.CurrentRow.Cells[AmountAppliedIndex].Value = AmountToApply;
                        dataGridView.CurrentRow.Cells[AmountToApplyIndex].Value = 0;
                        DisplaySummary();
                    }
                };

                if (dataGridView.HitTest(e.X, e.Y).ColumnIndex == dataGridView.GetCellIndex("AmountToApply"))
                    dataGridView.AddMenuItem(Apply);
            }
        }

        private void cmbSubsidiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormState == FormStates.fsView)
                return;

            String CommandText = "EXEC uspGetUnpaidBills @Id, @SubsidiaryId";
            SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, Properties.Settings.Default.FreeAccountingSoftwareConnectionString);
            DataTable table = new DataTable();
            int Id = 0;

            try
            {
                Adapter.SelectCommand.Parameters.AddWithValue("@Id", Id);
                Adapter.SelectCommand.Parameters.AddWithValue("@SubsidiaryId", cmbSubsidiary.SelectedKey);
                Adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Index != dataGridView.NewRowIndex)
                            dataGridView.Rows.Remove(row); //clear the grid rather than the datatable
                    }

                    IMessageHandler.Inform(ISystemMessages.NoPendingBills);
                    return;
                }

                if (FormState == FormStates.fsNew ||
                    (FormState == FormStates.fsEdit && IMessageHandler.Confirm(ISystemMessages.RemovePaidBills) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Index != dataGridView.NewRowIndex)
                        {
                            dataGridView.Rows.Remove(row);
                        }
                    }
                }

                foreach (DataRow row in table.Rows)
                {
                    DataRow newRow = dstDetail.DataTable.NewRow();

                    foreach (DataColumn column in table.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName];
                    }
                    dstDetail.DataTable.Rows.Add(newRow);
                }
            }
            finally
            {
                Adapter.Dispose();
                table.Dispose();
            }
        }

        private void ECashDisbursementVoucherForm_BeforeRun()
        {
            if (FormState == FormStates.fsNew)
                return;

            String CommandText = "EXEC uspGetUnpaidBills @Id, @SubsidiaryId";
            SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, Properties.Settings.Default.FreeAccountingSoftwareConnectionString);
            DataTable table = new DataTable();
            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);

            try
            {
                Adapter.SelectCommand.Parameters.AddWithValue("@Id", Id);
                Adapter.SelectCommand.Parameters.AddWithValue("@SubsidiaryId", cmbSubsidiary.SelectedKey);
                Adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    foreach (DataRow dtRow in dstDetail.DataTable.Rows)
                    {
                        if (dtRow["SourceId"].ToString() == row["SourceId"].ToString())
                        {
                            dtRow.BeginEdit();
                            foreach (DataColumn column in table.Columns)
                            {
                                if (dstDetail.Columns.Find(c => c.Name == column.ColumnName).Temporary)
                                {
                                    dtRow[column.ColumnName] = row[column.ColumnName];
                                }
                            }
                            dtRow.EndEdit();
                        }
                    }
                }
            }
            finally
            {
                Adapter.Dispose();
                table.Dispose();
            }
        }

        private void dataGridViewPaymentDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySummary();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int AmountToApplyIndex = dataGridView.GetCellIndex("AmountToApply");
            int BalanceIndex = dataGridView.GetCellIndex("Balance");
            int AppliedAmountIndex = dataGridView.GetCellIndex("AppliedAmount");

            if (dataGridView.CurrentRow.Index != dataGridView.NewRowIndex
                && FormState != FormStates.fsView
                && e.ColumnIndex == AmountToApplyIndex
                && dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[AmountToApplyIndex].ReadOnly)
            {
                if (IMessageHandler.Confirm(ISystemMessages.RemoveAppliedAmount) == DialogResult.Yes)
                {
                    double appliedAmount = double.Parse(dataGridView.CurrentRow.Cells[AppliedAmountIndex].Value.ToString());

                    dataGridView.CurrentRow.Cells[BalanceIndex].Value = dstDetail.DataTable.Rows[e.RowIndex]["OldBalance"];
                    dataGridView.CurrentRow.Cells[AppliedAmountIndex].Value = 0;
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].DataPropertyName == "AmountToApply"
                && e.RowIndex != dataGridView.NewRowIndex)
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ComputeAmountToApply();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].DataPropertyName == "AmountToApply"
                && e.RowIndex != dataGridView.NewRowIndex)
            {
                int AppliedAmountIndex = dataGridView.GetCellIndex("AppliedAmount");

                //set readonly if Amount Applied has value
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = double.Parse(dataGridView.Rows[e.RowIndex].Cells[AppliedAmountIndex].Value.ToString()) > 0;
            }
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            dataGridView.AllowUserToAddRows = false;
        }

        private void ShowAmountToApply()
        {
            DataGridViewColumn column = null;

            foreach (DataGridViewColumn c in dataGridView.Columns)
            {
                if (c.DataPropertyName == "AmountToApply")
                    column = c;
            }

            column.Visible = (FormState != FormStates.fsView);
        }

        private void ECashDisbursementVoucherForm_AfterRun()
        {
            ShowAmountToApply();
            DisplaySummary();

            //load journal entry
            if (FormState == FormStates.fsView)
            {
                if (!dstJournalEntry.ZLoadGrid)
                    dstJournalEntry.ZLoadGrid = true;

                dstJournalEntry.Parameters[0].Value = this.MasterColumns.Find(mc => mc.Name == "JournalId").Value.ToString();
                dstJournalEntry.DataTable = VTransactionHandler.LoadData(dstJournalEntry.CommandText, dstJournalEntry.Parameters);
                dataGridViewJournalEntry.DataSource = dstJournalEntry.DataTable;
                dataGridViewJournalEntry.AutoGenerateColumns = false;

                tabPageJournalEntry.Text = String.Format("Journal Entry ({0})", dstJournalEntry.DataTable.Rows[0]["TransactionNo"].ToString());

                if (!tabControlDetails.TabPages.Contains(tabPageJournalEntry))
                    tabControlDetails.TabPages.Insert(1, tabPageJournalEntry);
            }
            else
            {
                tabPageJournalEntry.Text = "Journal Entry";
                tabControlDetails.TabPages.Remove(tabPageJournalEntry);
            }
        }

        private void DisplaySummary()
        {
            txtAmountPaid.Text = ComputeAmountPaid().ToString("N2");
            txtAmountApplied.Text = ComputeAmountApplied().ToString("N2");
            txtBalance.Text = (ComputeAmountPaid() - ComputeAmountApplied()).ToString("N2");
        }

        private Double ComputeAmountPaid()
        {
            double value = 0;

            //get total amount of payment
            foreach (DataRow row in dstPaymentDetails.DataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    value += double.Parse(row["Amount"].ToString());
            }

            return value;
        }

        private Double ComputeAmountApplied()
        {
            double value = 0;

            //deduct total applied
            foreach (DataRow row in dstDetail.DataTable.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                    value += double.Parse(row["AppliedAmount"].ToString());
            }

            return value;
        }

        private Double ComputeRemainingBalance()
        {
            return ComputeAmountPaid() - ComputeAmountApplied();
        }

        private Double ComputeAmountToApply()
        {
            int BalanceIndex = dataGridView.GetCellIndex("Balance");
            double balance = double.Parse(dataGridView.CurrentRow.Cells[BalanceIndex].Value.ToString());

            if (balance > ComputeRemainingBalance())
                return ComputeRemainingBalance();
            else
                return balance;
        }

        private void ECashDisbursementVoucherForm_ValidateSave()
        {
            if (ComputeAmountPaid() < ComputeAmountApplied())
            {
                IMessageHandler.ShowError(ISystemMessages.AmountPaidInsufficient);
                ValidationFails = true;
            }
        }

        private void Post(bool IsPost)
        {
            SqlCommand Command = new SqlCommand();

            //do not add try and catch statement, so that if error occurs
            //the exception will be raised on btnSave.Click event,
            //which will trigger transaction rollback
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "uspUpdateJournals";
            Command.Parameters.AddWithValue("@JournalTypeId", 5);
            Command.Parameters.AddWithValue("@Id", Parameters[0].Value);
            Command.Parameters.AddWithValue("@IsPost", IsPost);
            Command.Connection = VTransactionHandler.VConnection;
            Command.Transaction = VTransactionHandler.VTransaction;
            Command.ExecuteNonQuery();
        }

        protected override void Post()
        {
            base.Post();
            Post(true);
        }

        protected override void UnPost()
        {
            base.UnPost();
            Post(false);
        }
    }
}
