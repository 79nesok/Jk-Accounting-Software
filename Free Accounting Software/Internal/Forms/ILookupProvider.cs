using System;
using System.Data;
using System.Windows.Forms;
using JkComponents;

namespace Free_Accounting_Software.Internal.Forms
{
    public partial class ILookupProvider : UserControl
    {
        public ILookupProvider()
        {
            InitializeComponent();
            cnConnection.ConnectionString = Properties.Settings.Default.FreeAccountingSoftwareConnectionString;
        }

        public Object DataSetLookup(JkDataSet DataSet, String KeyField, Object KeyValue, String ResultField)
        { 
            return DataSet.Lookup(KeyField, KeyValue, ResultField);
        }
    }
}
