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
    public partial class EVoucherForm : IMasterDetailForm
    {
        public EVoucherForm()
        {
            InitializeComponent();
        }

        private void EVoucherForm_SetupData()
        {
            Caption = VLookupProvider.DataSetLookup(VLookupProvider.dstJournalTypes, "Id", Parameters.Find(p => p.Name == "JournalTypeId").Value, "Name").ToString();
            MasterColumns.Find(mc => mc.Name == "JournalTypeId").DefaultValue = Parameters.Find(p => p.Name == "JournalTypeId").Value;
            jkSeriesProvider.Code = VLookupProvider.DataSetLookup(VLookupProvider.dstJournalTypes, "Id", Parameters.Find(p => p.Name == "JournalTypeId").Value, "Code").ToString();
        }

        private void EVoucherForm_ValidateSave()
        {
            double Debit = 0, Credit = 0;

            foreach (DataRow row in dstDetail.DataTable.Rows)
            {
                Debit += Convert.ToDouble(row["Debit"]);
                Credit += Convert.ToDouble(row["Credit"]);
            }

            if (Debit != Credit)
            {
                IMessageHandler.ShowError(ISystemMessages.DebitCreditNotEqual);
                ValidationFails = true;
                return;
            }
        }

        private void Post(bool IsPost)
        {
            SqlCommand Command = new SqlCommand();

            try
            {
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "uspUpdateGeneralLedger";
                Command.Parameters.AddWithValue("@Id", Parameters[0].Value);
                Command.Parameters.AddWithValue("@IsPost", IsPost);
                Command.Connection = VTransactionHandler.VConnection;
                Command.Transaction = VTransactionHandler.VTransaction;
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                IMessageHandler.Inform(ISystemMessages.ErrorOnPosting(ex.Message, IsPost));
            }
        }

        protected override void UnPost()
        {
            base.UnPost();
            Post(false);
        }

        protected override void Post()
        {
            base.Post();
            Post(true);
        }
    }
}
