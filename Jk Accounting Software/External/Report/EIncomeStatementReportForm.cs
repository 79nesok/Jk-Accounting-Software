using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.External.Datasources;
using Jk_Accounting_Software.External.Datasources.EIncomeStatementReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EIncomeStatementReportForm : IReportForm
    {
        public EIncomeStatementReportForm()
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

            EIncomeStatementReportDS isDataSource = new EIncomeStatementReportDS();
            IncomeTableAdapter incomeAdapter = new IncomeTableAdapter();
            ExpenseTableAdapter expenseAdapter = new ExpenseTableAdapter();
            tblCompaniesTableAdapter companyAdapter = new tblCompaniesTableAdapter();

            incomeAdapter.Fill(isDataSource.Income, CompanyId, FromDate, ToDate, 4);
            expenseAdapter.Fill(isDataSource.Expense, CompanyId, FromDate, ToDate, 5);
            companyAdapter.Fill(isDataSource.tblCompanies, CompanyId);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Income Statement.rdlc";

            reportParam[0] = new ReportParameter("FromDate", FromDate.ToString("MM'/'dd'/'yyyy"), false);
            reportParam[1] = new ReportParameter("ToDate", ToDate.ToString("MM'/'dd'/'yyyy"), false);

            reportViewer.LocalReport.SetParameters(reportParam);

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Income", isDataSource.Tables["Income"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Expense", isDataSource.Tables["Expense"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Company", isDataSource.Tables["tblCompanies"]));
            reportViewer.RefreshReport();
        }
    }
}
