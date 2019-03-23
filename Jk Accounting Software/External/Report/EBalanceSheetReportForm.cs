using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.EBalanceSheetReportDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.ECompanyDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EBalanceSheetReportForm : IReportForm
    {
        public EBalanceSheetReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime Date = DateTime.Parse(Parameters.Find(p => p.Name == "Date").Value);
            ReportParameter[] reportParam = new ReportParameter[1];

            EBalanceSheetReportDS bsDataSource = new EBalanceSheetReportDS();
            AssetTableAdapter assetAdapter = new AssetTableAdapter();
            LiabilityTableAdapter liabilityAdapter = new LiabilityTableAdapter();
            EquityTableAdapter equityAdapter = new EquityTableAdapter();
            ECompanyDS companyDataSource = new ECompanyDS();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            assetAdapter.Fill(bsDataSource.Asset, CompanyId, Date, 1);
            liabilityAdapter.Fill(bsDataSource.Liability, CompanyId, Date, 2);
            equityAdapter.Fill(bsDataSource.Equity, CompanyId, Date, 3);
            companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Balance Sheet.rdlc";

            reportParam[0] = new ReportParameter("Date", Date.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Asset", bsDataSource.Tables["Asset"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Liability", bsDataSource.Tables["Liability"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Equity", bsDataSource.Tables["Equity"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
