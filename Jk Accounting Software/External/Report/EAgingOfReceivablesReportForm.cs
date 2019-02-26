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

            EAgingOfReceivablesReportDS agingDataSource = new EAgingOfReceivablesReportDS();
            AgingOfReceivablesTableAdapter agingAdapter = new AgingOfReceivablesTableAdapter();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            agingAdapter.Fill(agingDataSource.AgingOfReceivables, CompanyId);
            companyAdapter.Fill(agingDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Aging of Receivables.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("AgingOfReceivables", agingDataSource.Tables["AgingOfReceivables"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", agingDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
