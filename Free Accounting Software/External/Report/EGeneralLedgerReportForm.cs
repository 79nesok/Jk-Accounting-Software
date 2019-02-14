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

        private void EGeneralLedgerReportForm_AfterRun()
        {
            //GeneralLedgerDS gl = new GeneralLedgerDS();

            //DataSet gl = Activator.CreateInstance(Type.GetType("Free_Accounting_Software.Internal.Datasources.GeneralLedgerDS")) as DataSet;

            //SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT * FROM tblGeneralLedger WHERE CompanyId = @CompanyId";
            //cmd.Parameters.AddWithValue("CompanyId", IAppHandler.ConvertDefaultValue("@CompanyId"));
            //cmd.Connection = connection;
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(gl, gl.Tables[0].TableName);

            //ReportDataSource rds = new ReportDataSource("GeneralLedger", gl.Tables[0]);
            //reportViewer.LocalReport.ReportPath = @"E:\Projects\C#\Free Accounting Software\Free Accounting Software\External\Report\General Ledger.rdlc";

            //reportViewer.LocalReport.DataSources.Clear();
            //reportViewer.LocalReport.DataSources.Add(rds);
            //reportViewer.LocalReport.Refresh();
            //reportViewer.RefreshReport();

            //ReportParameter[] param = new ReportParameter[] {
            //    new ReportParameter("CompanyId", ISecurityHandler.CompanyId.ToString())  
            //};

            EGeneralLedgerReportDS glDataSource = new EGeneralLedgerReportDS();
            tblGeneralLedgerTableAdapter GeneralLedgerAdapter = new tblGeneralLedgerTableAdapter();
            tblCompaniesTableAdapter CompanyAdapter = new tblCompaniesTableAdapter();

            GeneralLedgerAdapter.Fill(glDataSource.tblGeneralLedger, ISecurityHandler.CompanyId, 0, DateTime.Parse("31/12/2050"));
            CompanyAdapter.Fill(glDataSource.tblCompanies, ISecurityHandler.CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = "../../External/Printouts/General Ledger.rdlc";

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
