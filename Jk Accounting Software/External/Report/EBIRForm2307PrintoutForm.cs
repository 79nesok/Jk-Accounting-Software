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
using Jk_Accounting_Software.External.Datasources.EBIRForm2307ReportDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class EBIRForm2307PrintoutForm : IReportForm
    {
        public EBIRForm2307PrintoutForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);

            EBIRForm2307ReportDS birDataSource = new EBIRForm2307ReportDS();
            BIRForm2307TableAdapter birAdapter = new BIRForm2307TableAdapter();
            BIRForm2307DetailsTableAdapter birDetailAdapter = new BIRForm2307DetailsTableAdapter();

            birAdapter.Fill(birDataSource.BIRForm2307, Id);
            birDetailAdapter.Fill(birDataSource.BIRForm2307Details, Id);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "BIR Form 2307.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BIRForm2307", birDataSource.Tables["BIRForm2307"]));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("BIRForm2307Details", birDataSource.Tables["BIRForm2307Details"]));
            reportViewer.RefreshReport();
        }
    }
}
