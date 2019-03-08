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
using JkComponents;
using System.Data.SqlClient;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class EPurchaseVoucherForm : IMasterDetailForm
    {
        bool Modifying = false;

        public EPurchaseVoucherForm()
        {
            InitializeComponent();
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.RowsRemoved += dataGridView_RowsRemoved;
            dataGridView.RowsAdded += dataGridView_RowsAdded;
            dataGridViewJournalEntry.AutoGenerateColumns = false;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (FormState != FormStates.fsView)
                chkWTAX.Enabled = EnableComputeAndDeductWTAX();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (FormState != FormStates.fsView)
                chkWTAX.Enabled = EnableComputeAndDeductWTAX();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex)
                return;

            String VATTypeId = dataGridView.CurrentRow.Cells["dataGridViewColumnVATTypeId"].Value.ToString();

            if (VATTypeId != null)
                dataGridView.CurrentRow.Cells["dataGridViewColumnVATRate"].Value = VLookupProvider.DataSetLookup(VLookupProvider.dstVATTypes, "Id", VATTypeId, "Rate");

            ComputeDetailAmount();
            ComputeMasterAmount();

            if (FormState != FormStates.fsView)
                chkWTAX.Enabled = EnableComputeAndDeductWTAX();
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
            int VATTypeId = int.Parse(dataGridView.CurrentRow.Cells["dataGridViewColumnVATTypeId"].Value.ToString());
            double Amount = double.Parse(dataGridView.CurrentRow.Cells["dataGridViewColumnAmount"].Value.ToString());
            double VATAmount = 0;

            if (Amount == 0 || Modifying)
                return;

            try
            {
                Modifying = true;
                dataGridView.CurrentRow.Cells["dataGridViewColumnVATAmount"].Value = ComputeVATAmount(VATTypeId, Amount).ToString();
                VATAmount = double.Parse(dataGridView.CurrentRow.Cells["dataGridViewColumnVATAmount"].Value.ToString());

                if (VATTypeId == 1) //Inclusive
                    dataGridView.CurrentRow.Cells["dataGridViewColumnGrossAmount"].Value = (Amount - VATAmount).ToString();
                else
                    dataGridView.CurrentRow.Cells["dataGridViewColumnGrossAmount"].Value = (Amount).ToString();

                if (VATTypeId == 1) //Inclusive
                    dataGridView.CurrentRow.Cells["dataGridViewColumnTotal"].Value = Amount.ToString();
                else
                    dataGridView.CurrentRow.Cells["dataGridViewColumnTotal"].Value = (Amount + VATAmount).ToString();
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
                if (dataGridView.Rows[i].Cells["dataGridViewColumnGrossAmount"].Value != null)
                    GrossAmount += double.Parse(dataGridView.Rows[i].Cells["dataGridViewColumnGrossAmount"].Value.ToString());

                if (dataGridView.Rows[i].Cells["dataGridViewColumnVATAmount"].Value != null)
                    VATAmount += double.Parse(dataGridView.Rows[i].Cells["dataGridViewColumnVATAmount"].Value.ToString());

                if (dataGridView.Rows[i].Cells["dataGridViewColumnDiscountAmount"].Value != null)
                    DiscountAmount += double.Parse(dataGridView.Rows[i].Cells["dataGridViewColumnDiscountAmount"].Value.ToString());

                if (dataGridView.Rows[i].Cells["dataGridViewColumnTotal"].Value != null)
                    NetAmount += double.Parse(dataGridView.Rows[i].Cells["dataGridViewColumnTotal"].Value.ToString());
            }

            txtGrossAmount.Text = GrossAmount.ToString("N2");
            txtVATAmount.Text = VATAmount.ToString("N2");
            txtDiscountAmount.Text = DiscountAmount.ToString("N2");
            txtNetAmount.Text = NetAmount.ToString("N2");
            txtPaidAmount.Text = double.Parse(txtPaidAmount.Text).ToString("N2");
        }

        private void EPurchaseVoucherForm_AfterRun()
        {
            txtGrossAmount.Text = double.Parse(txtGrossAmount.Text).ToString("N2");
            txtWTAX.Text = double.Parse(txtWTAX.Text).ToString("N2");
            txtVATAmount.Text = double.Parse(txtVATAmount.Text).ToString("N2");
            txtDiscountAmount.Text = double.Parse(txtDiscountAmount.Text).ToString("N2");
            txtNetAmount.Text = double.Parse(txtNetAmount.Text).ToString("N2");
            txtPaidAmount.Text = double.Parse(txtPaidAmount.Text).ToString("N2");
            txtBalance.Text = (double.Parse(txtNetAmount.Text) - double.Parse(txtPaidAmount.Text)).ToString("N2");

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

            btnPrint.Visible = (FormState == FormStates.fsView) && double.Parse(MasterColumns.Find(mc => mc.Name == "WithholdingTax").Value.ToString()) > 0;
        }

        private void Post(bool IsPost)
        {
            SqlCommand Command = new SqlCommand();

            //do not add try and catch statement, so that if error occurs
            //the exception will be raised on btnSave.Click event,
            //which will trigger transaction rollback
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "uspUpdateJournals";
            Command.Parameters.AddWithValue("@JournalTypeId", 2);
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

        protected override void UpdateControls()
        {
            base.UpdateControls();

            chkWTAX.Enabled = (FormState != FormStates.fsView) && EnableComputeAndDeductWTAX();
        }

        private bool EnableComputeAndDeductWTAX()
        {
            bool value = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index != dataGridView.NewRowIndex
                    && row.Cells[dataGridView.GetCellIndex("ItemId")].Value != DBNull.Value)
                {
                    //check if details has service type of item
                    if (VLookupProvider.DataSetLookup(VLookupProvider.dstItems, "Id", row.Cells[dataGridView.GetCellIndex("ItemId")].Value, "TypeId").ToString() == "2")
                        value = true;
                }
            }

            return value;
        }

        private double ComputeWTAX()
        {
            double GrossAmount = 0, Rate = 0;
            int ATCId = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index != dataGridView.NewRowIndex
                    && row.Cells[dataGridView.GetCellIndex("ItemId")].Value != DBNull.Value
                    && VLookupProvider.DataSetLookup(VLookupProvider.dstItems, "Id", row.Cells[dataGridView.GetCellIndex("ItemId")].Value, "TypeId").ToString() == "2")
                {
                    GrossAmount += double.Parse(row.Cells[dataGridView.GetCellIndex("GrossAmount")].Value.ToString());
                }
            }

            ATCId = int.Parse(VLookupProvider.DataSetLookup(VLookupProvider.dstSubsidiaries, "Id", cmbSubsidiary.SelectedKey, "ATCId").ToString());
            if (ATCId == 0)
            {
                IMessageHandler.ShowError(ISystemMessages.NoATCAssigned);
                return 0;
            }
            Rate = double.Parse(VLookupProvider.DataSetLookup(VLookupProvider.dstATC, "Id", ATCId, "Rate").ToString());
            return GrossAmount * (Rate / 100);
        }

        private void chkWTAX_CheckedChanged(object sender, EventArgs e)
        {
            if (FormState == FormStates.fsView)
                return;

            double WTAX = 0;

            if (chkWTAX.Checked)
            {
                WTAX = ComputeWTAX();
                txtGrossAmount.Text = (double.Parse(txtGrossAmount.Text) - WTAX).ToString("N2");
            }
            else
                ComputeMasterAmount();

            txtWTAX.Text = WTAX.ToString("N2");
        }

        //to ensure that no wrong computation will come up before saving
        private void EPurchaseVoucherForm_BeforeSave()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = true;
                ComputeDetailAmount();
            }
            ComputeMasterAmount();

            if (chkWTAX.Checked)
                chkWTAX.Checked = EnableComputeAndDeductWTAX();
        }
    }
}
