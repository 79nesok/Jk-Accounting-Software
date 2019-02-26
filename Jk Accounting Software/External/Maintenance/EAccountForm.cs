using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

namespace Jk_Accounting_Software.External.Maintenance
{
    public partial class EAccountForm : IMasterForm
    {
        public EAccountForm()
        {
            InitializeComponent();
        }

        private void EAccountForm_BeforeRun()
        {
            PluralizationService ps = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us"));
            String cap = VLookupProvider.DataSetLookup(VLookupProvider.dstAccountTypes, "Id", Parameters.Find(p => p.Name == "AccountTypeId").Value, "Name").ToString();
            Caption = ps.Singularize(cap);

            MasterColumns.Find(mc => mc.Name == "AccountTypeId").DefaultValue = Parameters.Find(p => p.Name == "AccountTypeId").Value;
        }
    }
}
