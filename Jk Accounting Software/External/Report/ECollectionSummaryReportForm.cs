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
using Jk_Accounting_Software.External.Datasources.ECollectionSummaryReportDSTableAdapters;
using Microsoft.Reporting.WinForms;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ECollectionSummaryReportForm : IReportForm
    {
        public ECollectionSummaryReportForm()
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

            ECollectionSummaryReportDS collectionDataSource = new ECollectionSummaryReportDS();
            CollectionSummaryTableAdapter collectionAdapter = new CollectionSummaryTableAdapter();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            collectionAdapter.Fill(collectionDataSource.CollectionSummary, CompanyId, FromDate, ToDate);
            companyAdapter.Fill(collectionDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.LoadReportDefinition(IDynamicReportHandler.LoadDynamicReport(Properties.Settings.Default.ReportPath + "Collection Summary.rdlc", collectionDataSource.CollectionSummary));

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);
            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CollectionSummary", collectionDataSource.Tables["CollectionSummary"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", collectionDataSource.Tables["tblCompanies"]));

            reportViewer.RefreshReport();
        }
    }
}
