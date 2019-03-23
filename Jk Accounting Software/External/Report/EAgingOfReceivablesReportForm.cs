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
using Jk_Accounting_Software.External.Datasources.EAgingOfReceivablesReportDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.ECompanyDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EAgingOfReceivablesReportForm : IReportForm
    {
        public EAgingOfReceivablesReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            ReportParameter[] reportParam = new ReportParameter[1];

            EAgingOfReceivablesReportDS agingDataSource = new EAgingOfReceivablesReportDS();
            AgingOfReceivablesTableAdapter agingAdapter = new AgingOfReceivablesTableAdapter();
            ECompanyDS companyDataSource = new ECompanyDS();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            agingAdapter.Fill(agingDataSource.AgingOfReceivables, CompanyId);
            companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Aging of Receivables.rdlc";

            reportParam[0] = new ReportParameter("Date", DateTime.Now.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("AgingOfReceivables", agingDataSource.Tables["AgingOfReceivables"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
