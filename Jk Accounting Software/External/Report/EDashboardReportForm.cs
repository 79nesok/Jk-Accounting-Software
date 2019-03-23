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
using Jk_Accounting_Software.External.Datasources.ECompanyDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.EIncomeStatementChartReportDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.EBalanceSheetChartReportTableAdapters;
using Jk_Accounting_Software.External.Datasources.ESalesAndCollectionChartReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EDashboardReportForm : IReportForm
    {
        public EDashboardReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);
            ReportParameter[] reportParam = new ReportParameter[2];

            ECompanyDS companyDataSource = new ECompanyDS();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Dashboard.rdlc";
            reportViewer.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            reportViewer.Drillthrough += reportViewer_Drillthrough;

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }

        private void reportViewer_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);

            if (e.ReportPath == "Income Statement Detail Chart")
            {
                ReportParameter[] reportParam = new ReportParameter[2];

                EIncomeStatementChartReportDS isDataSource = new EIncomeStatementChartReportDS();
                IncomeStatementDetailChartReportTableAdapter isDetailAdapter = new IncomeStatementDetailChartReportTableAdapter();
                ECompanyDS companyDataSource = new ECompanyDS();
                tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

                isDetailAdapter.Fill(isDataSource.IncomeStatementDetailChartReport, CompanyId, FromDate, ToDate);
                companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

                reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
                reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

                (e.Report as LocalReport).SetParameters(reportParam);

                (e.Report as LocalReport).DataSources.Add(new ReportDataSource("IncomeStatementDetailChartReport", isDataSource.Tables["IncomeStatementDetailChartReport"]));
                (e.Report as LocalReport).DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            }
            else if (e.ReportPath == "Balance Sheet Detail Chart")
            {
                ReportParameter[] reportParam = new ReportParameter[1];

                EBalanceSheetChartReport bsDataSource = new EBalanceSheetChartReport();
                BalanceSheetDetailChartReportTableAdapter bsDetailAdapter = new BalanceSheetDetailChartReportTableAdapter();
                ECompanyDS companyDataSource = new ECompanyDS();
                tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

                bsDetailAdapter.Fill(bsDataSource.BalanceSheetDetailChartReport, CompanyId, ToDate);
                companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

                reportParam[0] = new ReportParameter("AsOfDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

                (e.Report as LocalReport).SetParameters(reportParam);

                (e.Report as LocalReport).DataSources.Add(new ReportDataSource("BalanceSheetDetailChartReport", bsDataSource.Tables["BalanceSheetDetailChartReport"]));
                (e.Report as LocalReport).DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            }
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //Income Statement
            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);

            EIncomeStatementChartReportDS isDataSource = new EIncomeStatementChartReportDS();
            IncomeStatementChartReportTableAdapter isAdapter = new IncomeStatementChartReportTableAdapter();

            isAdapter.Fill(isDataSource.IncomeStatementChartReport, CompanyId, FromDate, ToDate);

            e.DataSources.Add(new ReportDataSource("IncomeStatementChartReport", isDataSource.Tables["IncomeStatementChartReport"]));

            //Balance Sheet
            EBalanceSheetChartReport bsDataSource = new EBalanceSheetChartReport();
            BalanceSheetChartReportTableAdapter bsAdapter = new BalanceSheetChartReportTableAdapter();

            bsAdapter.Fill(bsDataSource.BalanceSheetChartReport, CompanyId, ToDate);

            e.DataSources.Add(new ReportDataSource("BalanceSheetChartReport", bsDataSource.Tables["BalanceSheetChartReport"]));

            //Sales and Collection
            ESalesAndCollectionChartReportDS scDataSource = new ESalesAndCollectionChartReportDS();
            SalesAndCollectionChartReportTableAdapter scAdapter = new SalesAndCollectionChartReportTableAdapter();

            scAdapter.Fill(scDataSource.SalesAndCollectionChartReport, CompanyId, FromDate, ToDate);

            e.DataSources.Add(new ReportDataSource("SalesAndCollectionChartReport", scDataSource.Tables["SalesAndCollectionChartReport"]));
        }

        private void EDashboardReportForm_SetupControl()
        {
            btnFilter.Visible = false;
            btnRemoveFilter.Visible = false;
        }
    }
}
