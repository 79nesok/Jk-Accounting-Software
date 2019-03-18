using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Popup
{
    public partial class EReportFilterSelectionForm : IPopupForm
    {
        public EReportFilterSelectionForm()
        {
            InitializeComponent();
        }

        protected override void PerformOperation()
        {
            base.PerformOperation();

            JkDetailDataSet dataset = new JkDetailDataSet();
            JkFormParameter param = new JkFormParameter();
            ITransactionHandler VTransactionHandler = new ITransactionHandler();
            int SelectionIdIndex = dataGridView.GetCellIndex("SelectionId");
            int ReportFilterTypeIdIndex = dataGridView.GetCellIndex("ReportFilterTypeId");
            int SelectedIndex = dataGridView.GetCellIndex("Selected");

            dataset.CommandText =
                "SELECT Id, SystemUserId, ReportFilterTypeId, SelectionId " +
                "FROM tblReportFilter " +
                "WHERE SystemUserId = @SystemUserId";
            param.Name = "SystemUserId";
            param.Value = ISecurityHandler.SecurityUserId.ToString();
            dataset.Parameters.Add(param);
            dataset.DataTable = VTransactionHandler.LoadData(dataset.CommandText, dataset.Parameters);
            foreach (DataRow row in dataset.DataTable.Rows)
                row.Delete();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (bool.Parse(row.Cells[SelectedIndex].Value.ToString()))
                {
                    DataRow newRow = dataset.DataTable.NewRow();

                    newRow["SystemUserId"] = ISecurityHandler.SecurityUserId;
                    newRow["ReportFilterTypeId"] = row.Cells[ReportFilterTypeIdIndex].Value;
                    newRow["SelectionId"] = row.Cells[SelectionIdIndex].Value;
                    dataset.DataTable.Rows.Add(newRow);
                }
            }
            VTransactionHandler.Connect();
            VTransactionHandler.EditMaster(dataset.CommandText, dataset.Parameters);
            VTransactionHandler.Disconnect();
        }
    }
}
