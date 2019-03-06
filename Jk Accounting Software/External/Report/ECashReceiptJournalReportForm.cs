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
using Jk_Accounting_Software.External.Datasources.EJournalsReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ECashReceiptJournalReportForm : IReportForm
    {
        public ECashReceiptJournalReportForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int CompanyId = int.Parse(Parameters.Find(p => p.Name == "CompanyId").Value);
            DateTime FromDate = DateTime.Parse(Parameters.Find(p => p.Name == "FromDate").Value);
            DateTime ToDate = DateTime.Parse(Parameters.Find(p => p.Name == "ToDate").Value);
            int JournalTypeId = int.Parse(Parameters.Find(p => p.Name == "JournalTypeId").Value);
            ReportParameter[] reportParam = new ReportParameter[2];

            EJournalsReportDS journalDataSource = new EJournalsReportDS();
            JournalsReportTableAdapter journalAdapter = new JournalsReportTableAdapter();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();
            tblJournalTypesTableAdapter journaltypeAdapter = new tblJournalTypesTableAdapter();

            journalAdapter.Fill(journalDataSource.JournalsReport, CompanyId, FromDate, ToDate, JournalTypeId);
            companyAdapter.Fill(journalDataSource.tblCompanies, CompanyId);
            journaltypeAdapter.Fill(journalDataSource.tblJournalTypes, JournalTypeId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Journals.rdlc";
            reportViewer.LocalReport.DisplayName = journalDataSource.tblJournalTypes.Rows[0][0].ToString();

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Journals", journalDataSource.Tables["JournalsReport"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", journalDataSource.Tables["tblCompanies"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("JournalType", journalDataSource.Tables["tblJournalTypes"]));
            reportViewer.RefreshReport();
        }
    }
}
