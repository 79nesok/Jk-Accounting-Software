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
            tblJournalVouchersTableAdapter JVAdapter = new tblJournalVouchersTableAdapter();
            tblJournalVoucherDetailsTableAdapter JVDetailsAdapter = new tblJournalVoucherDetailsTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            JVAdapter.Fill(jvDataSource.tblJournalVouchers, int.Parse(Parameters[0].Value));
            JVDetailsAdapter.Fill(jvDataSource.tblJournalVoucherDetails, int.Parse(Parameters[0].Value));
            CompanyAdapter.Fill(jvDataSource.tblCompanies, ISecurityHandler.CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Journal Voucher.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("JournalVoucher", jvDataSource.Tables["tblJournalVouchers"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("JournalVoucherDetails", jvDataSource.Tables["tblJournalVoucherDetails"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", jvDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
