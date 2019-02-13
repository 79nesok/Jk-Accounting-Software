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
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.External.Accounting
{
    public partial class EVoucherForm : IMasterDetailForm
    {
        public EVoucherForm()
        {
            InitializeComponent();
        }

        private void EVoucherForm_BeforeRun()
        {
            Caption = VLookupProvider.DataSetLookup(VLookupProvider.dstJournalTypes, "Id", Parameters.Find(p => p.Name == "JournalTypeId").Value, "Name").ToString();
            MasterColumns.Find(mc => mc.Name == "JournalTypeId").DefaultValue = Parameters.Find(p => p.Name == "JournalTypeId").Value;
            jkSeriesProvider.Code = VLookupProvider.DataSetLookup(VLookupProvider.dstJournalTypes, "Id", Parameters.Find(p => p.Name == "JournalTypeId").Value, "Code").ToString();
        }

        private void EVoucherForm_ValidateSave()
        {
            double Debit = 0, Credit = 0;

            foreach(DataRow row in VDetailDataTable.Rows)
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
    }
}
