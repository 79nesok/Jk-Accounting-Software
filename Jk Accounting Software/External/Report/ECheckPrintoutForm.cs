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
using Jk_Accounting_Software.External.Datasources.ECheckPrintoutDSTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.External.Report
{
    public partial class ECheckPrintoutForm : IReportForm
    {
        public ECheckPrintoutForm()
        {
            InitializeComponent();
        }

        protected override void RefreshReport()
        {
            base.RefreshReport();

            int Id = int.Parse(Parameters.Find(p => p.Name == "Id").Value);
            bool? HasCheck;

            ECheckPrintoutDS checkDataSource = new ECheckPrintoutDS();
            GetCheckDetailsTableAdapter checkAdapter = new GetCheckDetailsTableAdapter();

            checkAdapter.Fill(checkDataSource.GetCheckDetails, Id, out HasCheck);

            reportViewer.Reset();
            reportViewer.LocalReport.ReportPath = Properties.Settings.Default.ReportPath + "Check.rdlc";

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CheckDetails", checkDataSource.Tables["GetCheckDetails"]));
            reportViewer.RefreshReport();
        }
    }
}
