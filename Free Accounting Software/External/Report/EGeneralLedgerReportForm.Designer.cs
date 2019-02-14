namespace Free_Accounting_Software.External.Report
{
    partial class EGeneralLedgerReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.VDetailDataTable)).BeginInit();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Size = new System.Drawing.Size(789, 437);
            this.reportViewer.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer_Drillthrough);
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 472);
            // 
            // splitContainer
            // 
            this.splitContainer.Size = new System.Drawing.Size(789, 506);
            // 
            // EGeneralLedgerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "EGeneralLedgerReportForm";
            this.Size = new System.Drawing.Size(789, 506);
            this.AfterRun += new Free_Accounting_Software.Internal.Forms.IParentForm.AfterRunHandler(this.EGeneralLedgerReportForm_AfterRun);
            ((System.ComponentModel.ISupportInitialize)(this.VDetailDataTable)).EndInit();
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
