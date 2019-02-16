using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Free_Accounting_Software.Internal.Forms;
using Free_Accounting_Software.External.Datasources;
using Free_Accounting_Software.External.Datasources.EJournalVoucherPrintoutDSTableAdapters;
using Free_Accounting_Software.Internal.Classes;
using Microsoft.Reporting.WinForms;

namespace Free_Accounting_Software.External.Report
{
    public partial class EJournalVoucherPrintoutForm : IReportForm
    {
        public EJournalVoucherPrintoutForm()
        {
            InitializeComponent();
        }

        private void EJournalVoucherPrintoutForm_AfterRun()
        {
            EJournalVoucherPrintoutDS jvDataSource = new EJournalVoucherPrintoutDS();
            tblJournalsTableAdapter JournalAdapter = new tblJournalsTableAdapter();
            tblJournalDetailsTableAdapter JournalDetailsAdapter = new tblJournalDetailsTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            JournalAdapter.Fill(jvDataSource.tblJournals, int.Parse(Parameters[0].Value));
            JournalDetailsAdapter.Fill(jvDataSource.tblJournalDetails, int.Parse(Parameters[0].Value));
            CompanyAdapter.Fill(jvDataSource.tblCompanies, ISecurityHandler.CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Journal Voucher.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Journals", jvDataSource.Tables["tblJournals"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("JournalDetails", jvDataSource.Tables["tblJournalDetails"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", jvDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
