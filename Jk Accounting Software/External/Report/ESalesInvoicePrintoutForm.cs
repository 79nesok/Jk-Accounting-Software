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

            ESalesInvoiceReportDS siDataSource = new ESalesInvoiceReportDS();
            tblSalesVoucherTableAdapter SVAdapter = new tblSalesVoucherTableAdapter();
            tblSalesVoucherDetailTableAdapter SVDetailsAdapter = new tblSalesVoucherDetailTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            SVAdapter.Fill(siDataSource.tblSalesVoucher, Id);
            SVDetailsAdapter.Fill(siDataSource.tblSalesVoucherDetail, Id);
            CompanyAdapter.Fill(siDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Sales Invoice.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesVoucher", siDataSource.Tables["tblSalesVoucher"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("SalesVoucherDetail", siDataSource.Tables["tblSalesVoucherDetail"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", siDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
