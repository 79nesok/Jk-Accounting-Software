using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Free_Accounting_Software.Internal.Forms;
using Free_Accounting_Software.External.Datasources;
using Free_Accounting_Software.External.Datasources.ESalesInvoiceReportDSTableAdapters;
using Microsoft.Reporting.WinForms;
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.External.Report
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

            ESalesInvoiceReportDS siDataSource = new ESalesInvoiceReportDS();
            tblSalesVoucherTableAdapter SVAdapter = new tblSalesVoucherTableAdapter();
            tblSalesVoucherDetailTableAdapter SVDetailsAdapter = new tblSalesVoucherDetailTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            SVAdapter.Fill(siDataSource.tblSalesVoucher, int.Parse(Parameters[0].Value));
            SVDetailsAdapter.Fill(siDataSource.tblSalesVoucherDetail, int.Parse(Parameters[0].Value));
            CompanyAdapter.Fill(siDataSource.tblCompanies, ISecurityHandler.CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Sales Invoice.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesVoucher", siDataSource.Tables["tblSalesVoucher"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesVoucherDetail", siDataSource.Tables["tblSalesVoucherDetail"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", siDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
