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
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class ESalesInvoiceForm : IMasterDetailForm
    {
        bool Modifying = false;

        public ESalesInvoiceForm()
        {
            InitializeComponent();
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridViewJournalEntry.AutoGenerateColumns = false;
        }

        private void ESalesVoucherForm_SetupControl()
        {
            txtGrossAmount.Text = double.Parse(txtGrossAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtVATAmount.Text = double.Parse(txtVATAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtDiscountAmount.Text = double.Parse(txtDiscountAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtNetAmount.Text = double.Parse(txtNetAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtPaidAmount.Text = double.Parse(txtPaidAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtBalance.Text = (double.Parse(txtNetAmount.Text) - double.Parse(txtPaidAmount.Text)).ToString("#,##0.00;(#,##0.00)");

            //load journal entry
            if (FormState == FormStates.fsView)
            {
                if (!dstJournalEntry.ZLoadGrid)
                    dstJournalEntry.ZLoadGrid = true;

                dstJournalEntry.Parameters[0].Value = this.MasterColumns.Find(mc => mc.Name == "JournalId").Value.ToString();
                dstJournalEntry.DataTable = VTransactionHandler.LoadData(dstJournalEntry.CommandText, dstJournalEntry.Parameters);
                if (dataGridViewJournalEntry.DataSource == null)
                {
                    dataGridViewJournalEntry.DataSource = dstJournalEntry.DataTable;
                    dataGridViewJournalEntry.AutoGenerateColumns = false;
                }

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

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex || FormState == FormStates.fsView)
                return;

            String VATTypeId = dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("VATTypeId")].Value.ToString();

            if (VATTypeId != null)
                dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("VATRate")].Value = VLookupProvider.DataSetLookup(VLookupProvider.dstVATTypes, "Id", VATTypeId, "Rate");

            ComputeDetailAmount();
            ComputeMasterAmount();
        }

        private double ComputeVATAmount(int VATTypeId, double Amount)
        {
            double VATAmount = 0, VATRate;

            VATRate = Double.Parse(VLookupProvider.DataSetLookup(VLookupProvider.dstVATTypes, "Id", VATTypeId, "Rate").ToString());

            if (VATTypeId == 1) //Inclusive
                VATAmount = Amount - (Amount / (1 + (VATRate / 100)));
            else if (VATTypeId == 2) //Exclusive
                VATAmount = Amount * (VATRate / 100);

            return Math.Round(VATAmount, 2);
        }

        private void ComputeDetailAmount()
        {
            int VATTypeId = int.Parse(dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("VATTypeId")].Value.ToString());
            double Amount = double.Parse(dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("Amount")].Value.ToString());
            double VATAmount = 0;

            if (Amount == 0 || Modifying)
                return;

            try
            {
                Modifying = true;
                dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("VATAmount")].Value = ComputeVATAmount(VATTypeId, Amount).ToString();
                VATAmount = double.Parse(dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("VATAmount")].Value.ToString());

                if (VATTypeId == 1) //Inclusive
                    dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("GrossAmount")].Value = (Amount - VATAmount).ToString();
                else
                    dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("GrossAmount")].Value = (Amount).ToString();

                if (VATTypeId == 1) //Inclusive
                    dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("Total")].Value = Amount.ToString();
                else
                    dataGridView.CurrentRow.Cells[dataGridView.GetCellIndex("Total")].Value = (Amount + VATAmount).ToString();
            }
            finally
            {
                Modifying = false;
            }
        }

        private void ComputeMasterAmount()
        {
            double GrossAmount = 0;
            double VATAmount = 0;
            double DiscountAmount = 0;
            double NetAmount = 0;

            for (int i = 0; i <= dataGridView.Rows.Count - 1; i++)
            {
                if (dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("GrossAmount")].Value != null)
                    GrossAmount += double.Parse(dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("GrossAmount")].Value.ToString());

                if (dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("VATAmount")].Value != null)
                    VATAmount += double.Parse(dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("VATAmount")].Value.ToString());

                if (dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("DiscountAmount")].Value != null)
                    DiscountAmount += double.Parse(dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("DiscountAmount")].Value.ToString());

                if (dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("Total")].Value != null)
                    NetAmount += double.Parse(dataGridView.Rows[i].Cells[dataGridView.GetCellIndex("Total")].Value.ToString());
            }

            txtGrossAmount.Text = GrossAmount.ToString("#,##0.00;(#,##0.00)");
            txtVATAmount.Text = VATAmount.ToString("#,##0.00;(#,##0.00)");
            txtDiscountAmount.Text = DiscountAmount.ToString("#,##0.00;(#,##0.00)");
            txtNetAmount.Text = NetAmount.ToString("#,##0.00;(#,##0.00)");
            txtPaidAmount.Text = double.Parse(txtPaidAmount.Text).ToString("#,##0.00;(#,##0.00)");
        }

        private void EPurchaseVoucherForm_SetupControl()
        {
            txtGrossAmount.Text = double.Parse(txtGrossAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtVATAmount.Text = double.Parse(txtVATAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtDiscountAmount.Text = double.Parse(txtDiscountAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtNetAmount.Text = double.Parse(txtNetAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtPaidAmount.Text = double.Parse(txtPaidAmount.Text).ToString("#,##0.00;(#,##0.00)");
            txtBalance.Text = (double.Parse(txtNetAmount.Text) - double.Parse(txtPaidAmount.Text)).ToString("#,##0.00;(#,##0.00)");
        }

        private void Post(bool IsPost)
        {
            SqlCommand Command = new SqlCommand();

            //do not add try and catch statement, so that if error occurs
            //the exception will be raised on btnSave.Click event,
            //which will trigger transaction rollback
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "uspUpdateJournals";
            Command.Parameters.AddWithValue("@JournalTypeId", 3);
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

        //to ensure no incorrect amounts will come up
        private void ESalesVoucherForm_BeforeSave()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = true;
                ComputeDetailAmount();
            }
            ComputeMasterAmount();
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            IAppHandler.SetLabelColorOnEnter(lblBalance);
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            IAppHandler.SetLabelColorOnLeave(lblBalance);
        }
    }
}
