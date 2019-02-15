using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Free_Accounting_Software.Internal.Forms;
using Free_Accounting_Software.Internal.Classes;
using Free_Accounting_Software.External.Datasources;
using Free_Accounting_Software.External.Datasources.EGeneralLedgerReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

using Free_Accounting_Software.External.Datasources.EJournalReportDSTableAdapters;

namespace Free_Accounting_Software.External.Report
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
            reportViewer.LocalReport.ReportPath = "../../External/Printouts/General Ledger.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("GeneralLedger", glDataSource.Tables["tblGeneralLedger"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", glDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }

        private void reportViewer_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            EJournalReportDS jDataSource = new EJournalReportDS();
            tblJournalsTableAdapter JournalAdapter = new tblJournalsTableAdapter();
            tblCompaniesJournalTableAdapter CompanyAdapter = new tblCompaniesJournalTableAdapter();

            JournalAdapter.Fill(jDataSource.tblJournals, ISecurityHandler.CompanyId, DateTime.Now);
            CompanyAdapter.Fill(jDataSource.tblCompaniesJournal);

            (e.Report as LocalReport).DataSources.Add(new ReportDataSource("Journal", jDataSource.Tables[0]));
            (e.Report as LocalReport).DataSources.Add(new ReportDataSource("Company", jDataSource.Tables[1]));
        }
    }
}
