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
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

namespace Jk_Accounting_Software.External.Maintenance
{
    public partial class ESubsidiaryForm : IMasterForm
    {
        public ESubsidiaryForm()
        {
            InitializeComponent();
        }

        private void ESubsidiaryForm_SetupData()
        {
            PluralizationService ps = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us"));
            String cap = VLookupProvider.DataSetLookup(VLookupProvider.dstSubsidiaryTypes, "Id", Parameters.Find(p => p.Name == "SubsidiaryTypeId").Value, "Name").ToString();
            Caption = ps.Singularize(cap);

            MasterColumns.Find(mc => mc.Name == "SubsidiaryTypeId").DefaultValue = Parameters.Find(p => p.Name == "SubsidiaryTypeId").Value;
        }
    }
}
