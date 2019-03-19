using System;
using System.Data;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.Internal.Classes;
using System.Data.SqlClient;

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class EJournalVoucherForm : IMasterDetailForm
    {
        public EJournalVoucherForm()
        {
            InitializeComponent();
        }

        private void EJournalVoucherForm_ValidateSave()
        {
            double Debit = 0, Credit = 0;

            foreach (DataRow row in dstDetail.DataTable.Rows)
            {
                Debit += Double.Parse(row["Debit"].ToString());
                Credit += Double.Parse(row["Credit"].ToString());
            }

            if (Debit != Credit)
            {
                ValidationFails = true;
                IMessageHandler.ShowError(ISystemMessages.DebitCreditNotEqual);
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
            Command.Parameters.AddWithValue("@JournalTypeId", 1);
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

        private void EJournalVoucherForm_SetupControl()
        {
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
    }
}
