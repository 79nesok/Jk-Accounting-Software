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
using JkComponents;
using System.Data.SqlClient;
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.External.Accounting
{
    public partial class ECashReceiptVoucherForm : IMasterDetailForm
    {
        public ECashReceiptVoucherForm()
        {
            InitializeComponent();
        }

        private void cmbSubsidiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormState == FormStates.fsView)
                return;

            String CommandText = "EXEC uspGetUnpaidInvoice @Id, @SubsidiaryId";
            SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, Properties.Settings.Default.FreeAccountingSoftwareConnectionString);
            DataTable table = new DataTable();
            int Id = 0;

            try
            {
                if (FormState != FormStates.fsNew)
                    Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);

                Adapter.SelectCommand.Parameters.AddWithValue("@Id", Id);
                Adapter.SelectCommand.Parameters.AddWithValue("@SubsidiaryId", cmbSubsidiary.SelectedKey);
                Adapter.Fill(table);
                table.PrimaryKey = new DataColumn[] { table.Columns["SourceId"] };

                if (table.Rows.Count == 0)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                        dataGridView.Rows.Remove(row); //clear the grid rather than the datatable

                    IMessageHandler.Inform(ISystemMessages.NoPendingInvoice);
                    return;
                }

                if (FormState == FormStates.fsNew ||
                    (FormState == FormStates.fsEdit && IMessageHandler.Confirm(ISystemMessages.RemovePaidInvoice) == DialogResult.Yes))
                    foreach (DataGridViewRow row in dataGridView.Rows)
                        dataGridView.Rows.Remove(row);

                foreach (DataRow row in table.Rows)
                {
                    DataRow newRow = dstDetail.DataTable.NewRow();

                    foreach (DataColumn column in table.Columns)
                    {
                        newRow[column.ColumnName] = row[column.ColumnName];
                    }
                    dstDetail.DataTable.Rows.Add(newRow);
                }
            }
            finally
            {
                Adapter.Dispose();
                table.Dispose();
            }
        }

        private void ECashReceiptVoucherForm_BeforeRun()
        {
            return;
            dstDetail.DataTable.RowChanged += DataTable_RowChanged;

            String CommandText = "EXEC uspGetUnpaidInvoice @Id, @SubsidiaryId";
            SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, Properties.Settings.Default.FreeAccountingSoftwareConnectionString);
            DataTable table = new DataTable();
            int Id = 0;

            try
            {
                if (FormState != FormStates.fsNew)
                    Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);

                Adapter.SelectCommand.Parameters.AddWithValue("@Id", Id);
                Adapter.SelectCommand.Parameters.AddWithValue("@SubsidiaryId", cmbSubsidiary.SelectedKey);
                Adapter.Fill(table);
                table.PrimaryKey = new DataColumn[] { table.Columns["SourceId"] };

                foreach (DataRow row in table.Rows)
                {
                    DataRow dtRow = dstDetail.DataTable.Rows.Find(row["SourceId"]);

                    if (dtRow != null)
                    {
                        dtRow.BeginEdit();
                        foreach (DataColumn column in table.Columns)
                        {
                            dtRow[column.ColumnName] = row[column.ColumnName];
                        }
                        dtRow.EndEdit();
                    }
                }
            }
            finally
            {
                Adapter.Dispose();
                table.Dispose();
            }
        }

        private void DataTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (FormState != FormStates.fsView)
                MessageBox.Show("");
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            dataGridView.AllowUserToAddRows = false;
        }
    }
}
