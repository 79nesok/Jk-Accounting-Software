using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.EJournalPrintoutDSTableAdapters;
using Jk_Accounting_Software.External.Datasources.ECompanyDSTableAdapters;
using Jk_Accounting_Software.Internal.Classes;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EJournalPrintoutForm : IReportForm
    {
        public EJournalPrintoutForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);
            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            ReportParameter[] reportParam = new ReportParameter[1];

            EJournalPrintoutDS journalDataSource = new EJournalPrintoutDS();
            GetJournalPrintoutTableAdapter journalAdapter = new GetJournalPrintoutTableAdapter();
            GetJournalDetailPrintoutTableAdapter journalDetailsAdapter = new GetJournalDetailPrintoutTableAdapter();
            ECompanyDS companyDataSource = new ECompanyDS();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            journalAdapter.Fill(journalDataSource.GetJournalPrintout, Id, this.PrintoutHeader);
            journalDetailsAdapter.Fill(journalDataSource.GetJournalDetailPrintout, Id, this.PrintoutHeader);
            companyAdapter.Fill(companyDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Journal Printout.rdlc";

            reportParam[0] = new ReportParameter("Header", SwitchHeader(this.PrintoutHeader), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("GetJournalPrintout", journalDataSource.Tables["GetJournalPrintout"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("GetJournalDetailPrintout", journalDataSource.Tables["GetJournalDetailPrintout"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", companyDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }

        private String SwitchHeader(String Header)
        {
            String result = Header;

            switch (Header)
            { 
                case "Bill":
                    result = "Purchase Journal";
                    break;

                case "Bills Payment":
                    result = "Cash Disbursement Journal";
                    break;

                case "Sales Invoice":
                    result = "Sales Journal";
                    break;

                case "Cash Receipt":
                    result = "Cash Receipt Journal";
                    break;
            }

            return result;
        }
    }
}
