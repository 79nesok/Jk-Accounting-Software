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
using Microsoft.Reporting.WinForms;

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
            ReportParameter[] reportParam = new ReportParameter[3];

            ESystemLogsReportDS logDataSource = new ESystemLogsReportDS();
            GetSystemLogReportTableAdapter logAdapter = new GetSystemLogReportTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            logAdapter.Fill(logDataSource.GetSystemLogReport, CompanyId, FromDate, ToDate, SubCategory);
            CompanyAdapter.Fill(logDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "System Logs.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[2] = new ReportParameter("SubCategory", SubCategory + " - System Logs", false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SystemLogs", logDataSource.Tables["GetSystemLogReport"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", logDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
