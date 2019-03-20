using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.Internal.Classes;
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.EGeneralLedgerReportDSTableAdapters;
using Microsoft.Reporting.WinForms;
using Jk_Accounting_Software.External.Datasources.EGeneralLedgerDetailsReportDSTableAdapters;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EGeneralLedgerReportForm : IReportForm
    {
        public EGeneralLedgerReportForm()
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

            EGeneralLedgerReportDS glDataSource = new EGeneralLedgerReportDS();
            tblGeneralLedgerTableAdapter GeneralLedgerAdapter = new tblGeneralLedgerTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            GeneralLedgerAdapter.Fill(glDataSource.tblGeneralLedger, CompanyId, FromDate, ToDate);
            CompanyAdapter.Fill(glDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "General Ledger.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("GeneralLedger", glDataSource.Tables["tblGeneralLedger"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", glDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }

        private void reportViewer_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            toolStripReportParam.Visible = false;

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            int AccountId = 0;
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);

            ReportParameter[] reportParam = new ReportParameter[2];

            EGeneralLedgerDetailsReportDS jDataSource = new EGeneralLedgerDetailsReportDS();
            GeneralLedgerDetailsTableAdapter JournalAdapter = new GeneralLedgerDetailsTableAdapter();
            tblCompaniesJournalTableAdapter CompanyAdapter = new tblCompaniesJournalTableAdapter();

            if ((e.Report as LocalReport).GetParameters()["ReportType"].Values[0] == "Per Date")
            {
                FromDate = IDateHandler.Parse((e.Report as LocalReport).GetParameters()["FromDate"].Values[0]);
                ToDate = IDateHandler.Parse((e.Report as LocalReport).GetParameters()["ToDate"].Values[0]);
            }

            AccountId = int.Parse((e.Report as LocalReport).GetParameters()["AccountId"].Values[0]);
            JournalAdapter.Fill(jDataSource.GeneralLedgerDetails, CompanyId, FromDate, ToDate, AccountId);
            CompanyAdapter.Fill(jDataSource.tblCompaniesJournal, CompanyId);

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            (e.Report as LocalReport).SetParameters(reportParam);

            (e.Report as LocalReport).DataSources.Add(new ReportDataSource("GeneralLedgerDetails", jDataSource.Tables["GeneralLedgerDetails"]));
            (e.Report as LocalReport).DataSources.Add(new ReportDataSource("Company", jDataSource.Tables["tblCompaniesJournal"]));
        }

        private void reportViewer_Back(object sender, BackEventArgs e)
        {
            toolStripReportParam.Visible = true;
        }
    }
}
