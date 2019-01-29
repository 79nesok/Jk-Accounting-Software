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

namespace Free_Accounting_Software.External.Maintenance
{
    public partial class ESubsidiaryForm : IMasterForm
    {
        public ESubsidiaryForm()
        {
            InitializeComponent();
        }

        private void ESubsidiaryForm_BeforeRun()
        {
            String cap = VLookupProvider.DataSetLookup(VLookupProvider.dstSubsidiaryTypes, "Id", Parameters.Find(p => p.Name == "SubsidiaryTypeId").Value, "Name").ToString();

            cap = cap.Remove(cap.Length - 1);
            Caption = cap;

            MasterColumns.Find(mc => mc.Name == "SubsidiaryTypeId").DefaultValue = Parameters.Find(p => p.Name == "SubsidiaryTypeId").Value;
        }
    }
}
