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
using Jk_Accounting_Software.External.Datasources.ESalesInvoiceReportDSTableAdapters;
using Microsoft.Reporting.WinForms;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ESalesInvoicePrintoutForm : IReportForm
    {
        public ESalesInvoicePrintoutForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);
            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);

            ESalesInvoicePrintoutDS siDataSource = new ESalesInvoicePrintoutDS();
            tblSalesInvoicesTableAdapter SIAdapter = new tblSalesInvoicesTableAdapter();
            tblSalesInvoiceDetailsTableAdapter SIDetailsAdapter = new tblSalesInvoiceDetailsTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            SIAdapter.Fill(siDataSource.tblSalesInvoices, Id);
            SIDetailsAdapter.Fill(siDataSource.tblSalesInvoiceDetails, Id);
            CompanyAdapter.Fill(siDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Sales Invoice.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesInvoice", siDataSource.Tables["tblSalesInvoices"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesInvoiceDetails", siDataSource.Tables["tblSalesInvoiceDetails"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", siDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
