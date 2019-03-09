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
using Jk_Accounting_Software.External.Datasources.EBillPrintoutDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EBillPrintoutForm : IReportForm
    {
        public EBillPrintoutForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);
            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);

            EBillPrintoutDS billDataSource = new EBillPrintoutDS();
            tblBillsTableAdapter bAdapter = new tblBillsTableAdapter();
            tblBillDetailsTableAdapter bDetailsAdapter = new tblBillDetailsTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            bAdapter.Fill(billDataSource.tblBills, Id);
            bDetailsAdapter.Fill(billDataSource.tblBillDetails, Id);
            CompanyAdapter.Fill(billDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Bill.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Bills", billDataSource.Tables["tblBills"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BillDetails", billDataSource.Tables["tblBillDetails"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", billDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
