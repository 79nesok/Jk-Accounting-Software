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
using Jk_Accounting_Software.External.Datasources.EAgingOfPayablesReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EAgingOfPayablesReportForm : IReportForm
    {
        public EAgingOfPayablesReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            ReportParameter[] reportParam = new ReportParameter[1];

            EAgingOfPayablesReportDS agingDataSource = new EAgingOfPayablesReportDS();
            AgingOfPayablesTableAdapter agingAdapter = new AgingOfPayablesTableAdapter();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            agingAdapter.Fill(agingDataSource.AgingOfPayables, CompanyId);
            companyAdapter.Fill(agingDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Aging of Payables.rdlc";

            reportParam[0] = new ReportParameter("Date", DateTime.Now.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("AgingOfPayables", agingDataSource.Tables["AgingOfPayables"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", agingDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
