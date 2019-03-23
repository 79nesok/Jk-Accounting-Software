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
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.ESystemLogsReportDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.ECompanyDSTableAdapters;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using JkComponents;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ESystemLogsReportForm : IReportForm
    {
        public ESystemLogsReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);
            String SubCategory = this.SubCategory;
            ReportParameter[] reportParam = new ReportParameter[4];

            ESystemLogsReportDS logDataSource = new ESystemLogsReportDS();
            GetSystemLogReportTableAdapter logAdapter = new GetSystemLogReportTableAdapter();
            ECompanyDS companyDataSource = new ECompanyDS();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            logAdapter.Fill(logDataSource.GetSystemLogReport, CompanyId, FromDate, ToDate, SubCategory);
            companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "System Logs.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[2] = new ReportParameter("SubCategory", SubCategory + " - System Logs", false);
            reportParam[3] = new ReportParameter("IdentifierHeader", GetIdentifierHeader(), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SystemLogs", logDataSource.Tables["GetSystemLogReport"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }

        private String GetIdentifierHeader()
        {
            DataTable table = new DataTable();
            String CommandText, result;
            List<JkFormParameter> param = new List<JkFormParameter>();

            CommandText = "SELECT IdentifierColumnName FROM tblSystemLogTableConfig WHERE Caption = @Caption";
            param.Add(new JkFormParameter() { Value = this.SubCategory, Name = "Caption" });
            table = VTransactionHandler.LoadData(CommandText, param);
            result = table.Rows[table.Rows.Count - 1][0].ToString();

            if (result == "TransactionNo")
                result = "Transaction No";

            table.Dispose();

            return result;
        }
    }
}
