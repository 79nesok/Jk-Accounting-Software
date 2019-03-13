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

namespace Jk_Accounting_Software.External.Administration
{
    public partial class ELogConfigurationForm : IMasterDetailForm
    {
        public ELogConfigurationForm()
        {
            InitializeComponent();
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            btnNew.Visible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
        }

        private void ELogConfigurationForm_AfterSave()
        {
            SqlCommand Command = new SqlCommand();

            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "uspCreateTrigger";
            Command.Parameters.AddWithValue("@Id", Parameters.Find(p => p.Name == "Id").Value);
            VTransactionHandler.ExecuteStoredProc(Command);
        }
    }
}
