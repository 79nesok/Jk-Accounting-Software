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
using System.Data.SqlClient;

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class ECashReceiptVoucherForm : IMasterDetailForm
    {
        public ECashReceiptVoucherForm()
        {
            InitializeComponent();

            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            dataGridViewPaymentDetails.CellEndEdit += dataGridViewPaymentDetails_CellEndEdit;
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySummary();
        }

        private void dataGridViewPaymentDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySummary();
        }

        private void ECashReceiptVoucherForm_AfterRun()
        {
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
            txtAmountPaid.Text = ComputeAmountPaid().ToString("#,##0.00;(#,##0.00)");
            txtAmountApplied.Text = ComputeAmountApplied().ToString("#,##0.00;(#,##0.00)");
            txtBalance.Text = (ComputeAmountPaid() - ComputeAmountApplied()).ToString("#,##0.00;(#,##0.00)");
        }

        private Double ComputeAmountPaid()
        {
            double value = 0;
            int AmountIndex = dataGridViewPaymentDetails.GetCellIndex("Amount");

            //get total amount of payment
            foreach (DataGridViewRow row in dataGridViewPaymentDetails.Rows)
            {
                if (row.Index != dataGridViewPaymentDetails.NewRowIndex)
                    value += double.Parse(row.Cells[AmountIndex].Value.ToString());
            }

            return value;
        }

        private Double ComputeAmountApplied()
        {
            double value = 0;
            int CreditIndex = dataGridView.GetCellIndex("Credit");

            //deduct total applied
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index != dataGridView.NewRowIndex)
                    value += double.Parse(row.Cells[CreditIndex].Value.ToString());
            }

            return value;
        }

        private void Post(bool IsPost)
        {
            SqlCommand Command = new SqlCommand();

            //do not add try and catch statement, so that if error occurs
            //the exception will be raised on btnSave.Click event,
            //which will trigger transaction rollback
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "uspUpdateJournals";
            Command.Parameters.AddWithValue("@JournalTypeId", 4);
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
