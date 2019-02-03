using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Free_Accounting_Software.Internal.Forms;
using Free_Accounting_Software.Internal.Classes;
using Free_Accounting_Software.Internal.Datasources;
using Free_Accounting_Software.Internal.Datasources.GeneralLedgerDSTableAdapters;
using Microsoft.Reporting.WinForms;

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

            GeneralLedgerDS gl = new GeneralLedgerDS();
            tblGeneralLedgerTableAdapter adap1 = new tblGeneralLedgerTableAdapter();
            tblCompaniesTableAdapter adap2 = new tblCompaniesTableAdapter();

            adap1.Fill(gl.tblGeneralLedger, ISecurityHandler.CompanyId + 1);
            adap2.Fill(gl.tblCompanies);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = @"E:\Projects\C#\Free Accounting Software\Free Accounting Software\External\Report\General Ledger.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("GeneralLedger", gl.Tables[0]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", gl.Tables[1]));
            reportViewer.RefreshReport();
        }
    }
}
