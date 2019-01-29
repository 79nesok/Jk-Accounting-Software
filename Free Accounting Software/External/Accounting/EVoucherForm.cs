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

namespace Free_Accounting_Software.External.Accounting
{
    public partial class EVoucherForm : IMasterForm
    {
        public EVoucherForm()
        {
            InitializeComponent();
        }

        private void EVoucherForm_BeforeRun()
        {
            Caption = VLookupProvider.DataSetLookup(VLookupProvider.dstJournalTypes, "Id", Parameters.Find(p => p.Name == "JournalTypeId").Value, "Name").ToString();
            MasterColumns.Find(mc => mc.Name == "JournalTypeId").DefaultValue = Parameters.Find(p => p.Name == "JournalTypeId").Value;
        }
    }
}
