using System;
using System.Data;
using System.Windows.Forms;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class ILookupProvider : JkLookUpProvider
    {
        public ILookupProvider()
        {
            InitializeComponent();
            cnConnection.ConnectionString = Properties.Settings.Default.FreeAccountingSoftwareConnectionString;
            AssignMaskedParameters();
        }

        public Object DataSetLookup(JkDataSet DataSet, String KeyField, Object KeyValue, String ResultField)
        { 
            return DataSet.Lookup(KeyField, KeyValue, ResultField);
        }

        private void AssignMaskedParameters()
        {
            JkDataSet dataset = null;

            foreach (Control control in Controls)
            {
                if (control.GetType().Name == "JkDataSet")
                {
                    dataset = (control as JkDataSet);
                    foreach (JkDataSetParameter param in dataset.Parameters)
                        param.Value = IAppHandler.ConvertMaskValue(param.Value).ToString();
                }
            }
        }
    }
}
