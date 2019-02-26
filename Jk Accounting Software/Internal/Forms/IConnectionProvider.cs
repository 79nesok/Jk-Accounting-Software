using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Jk_Accounting_Software.Internal.Classes;
using System.Configuration;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class IConnectionProvider : Form
    {
        SqlConnectionStringBuilder ConnectionBuilder = new SqlConnectionStringBuilder();
        ITransactionHandler TransactionHandler = new ITransactionHandler();
        DataTable Table = new DataTable();
        String Database;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        int index;

        public IConnectionProvider(String ConnectionStringName)
        {
            InitializeComponent();
            for (int i = 0; i <= config.ConnectionStrings.ConnectionStrings.Count - 1; i++)
            {
                if (config.ConnectionStrings.ConnectionStrings[i].Name == ConnectionStringName)
                    index = i;
            }
        }

        private void IConnectionProvider_Load(object sender, EventArgs e)
        {
            ConnectionBuilder.ConnectionString = config.ConnectionStrings.ConnectionStrings[index].ConnectionString;

            radiobtnOne.Checked = true;
            if (!String.IsNullOrWhiteSpace(ConnectionBuilder.ConnectionString))
            {
                txtServerName.Text = ConnectionBuilder.DataSource;
                radiobtnOne.Checked = ConnectionBuilder.IntegratedSecurity;
                radiobtnTwo.Checked = !ConnectionBuilder.IntegratedSecurity;
                txtUsername.Text = ConnectionBuilder.UserID;

                if (ConnectionBuilder.IntegratedSecurity)
                {
                    txtUsername.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                }
                else
                {
                    txtUsername.Text = ConnectionBuilder.UserID;
                    txtPassword.Text = ConnectionBuilder.Password;
                }

                Database = ConnectionBuilder.InitialCatalog;
                cmbDatabase_DropDown(null, null);
                cmbDatabase.SelectedIndex = cmbDatabase.FindStringExact(Database);
            }
        }

        private void radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            lblUsername.Enabled = radiobtnTwo.Checked;
            lblPassword.Enabled = radiobtnTwo.Checked;
            txtUsername.Enabled = radiobtnTwo.Checked;
            txtPassword.Enabled = radiobtnTwo.Checked;
        }

        private void cmbDatabase_DropDown(object sender, EventArgs e)
        {
            String CommandText = "SELECT name FROM sys.sysdatabases ORDER BY name";

            if (cmbDatabase.Items.Count > 0)
                cmbDatabase.Items.Clear();

            BuildConnStr();
            ConnectionBuilder.InitialCatalog = "master";
            try
            {
                Table.Clear();
                TransactionHandler.LoadData(CommandText, ref Table, null, ConnectionBuilder.ConnectionString);
            }
            catch(Exception ex)
            {
                IMessageHandler.ShowError(ex.Message);
            }

            foreach (DataRow row in Table.Rows)
            {
                cmbDatabase.Items.Add(row["name"]);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            String CommandText = "SELECT 1 AS Test";

            BuildConnStr();
            ConnectionBuilder.InitialCatalog = cmbDatabase.SelectedItem.ToString();
            try
            {
                Table.Clear();
                TransactionHandler.LoadData(CommandText, ref Table, null, ConnectionBuilder.ConnectionString);

                if (Table.Rows.Count > 0)
                    IMessageHandler.Inform(ISystemMessages.TestConnectionSuccess);
            }
            catch (Exception ex)
            {
                IMessageHandler.ShowError(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BuildConnStr();
            ConnectionBuilder.InitialCatalog = cmbDatabase.SelectedItem.ToString();
            config.ConnectionStrings.ConnectionStrings[index].ConnectionString = ConnectionBuilder.ConnectionString;
            config.ConnectionStrings.ConnectionStrings[index].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuildConnStr()
        {
            ConnectionBuilder.DataSource = txtServerName.Text;
            ConnectionBuilder.IntegratedSecurity = radiobtnOne.Checked;
            ConnectionBuilder.UserID = txtUsername.Text;

            if (ConnectionBuilder.IntegratedSecurity)
            {
                ConnectionBuilder.UserID = String.Empty;
                ConnectionBuilder.Password = String.Empty;
            }
            else
            {
                ConnectionBuilder.UserID = txtUsername.Text;
                ConnectionBuilder.Password = txtPassword.Text;
            }
        }

        private void IConnectionProvider_FormClosed(object sender, FormClosedEventArgs e)
        {
            Table.Dispose();
        }
    }
}
