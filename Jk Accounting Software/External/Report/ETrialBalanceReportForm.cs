using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.ETrialBalanceReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ETrialBalanceReportForm : IReportForm
    {
        public ETrialBalanceReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);
            bool ShowZeroBalance = Boolean.Parse(Parameters.Find(p => p.Name == "ShowZeroBalance").Value);
            ReportParameter[] reportParam = new ReportParameter[2];

            ETrialBalanceReportDS tbDataSource = new ETrialBalanceReportDS();
            TrialBalanceTableAdapter tbAdapter = new TrialBalanceTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            tbAdapter.Fill(tbDataSource.TrialBalance, CompanyId, FromDate, ToDate, ShowZeroBalance);
            CompanyAdapter.Fill(tbDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Trial Balance.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("TrialBalance", tbDataSource.Tables["TrialBalance"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", tbDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
