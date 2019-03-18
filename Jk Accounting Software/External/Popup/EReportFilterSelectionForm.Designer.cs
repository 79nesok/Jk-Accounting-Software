namespace Jk_Accounting_Software.External.Popup
{
    partial class EReportFilterSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EReportFilterSelectionForm));
            ((System.ComponentModel.ISupportInitialize)(this.VDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dstMaster
            // 
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns1"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns2"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns3"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns4"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns5"))));
            this.dstMaster.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstMaster.Columns6"))));
            this.dstMaster.CommandText = "EXEC uspGetReportFilterSelection @CompanyId, @SystemUserId, @Subsidiary, @TypeId";
            this.dstMaster.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstMaster.Parameters"))));
            this.dstMaster.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstMaster.Parameters1"))));
            this.dstMaster.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstMaster.Parameters2"))));
            this.dstMaster.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstMaster.Parameters3"))));
            this.dstMaster.ZLoadColumns = true;
            this.dstMaster.ZLoadGrid = true;
            // 
            // EReportFilterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Report Filter";
            this.ClientSize = new System.Drawing.Size(489, 452);
            this.Name = "EReportFilterSelectionForm";
            this.Text = "EReportFilterSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.VDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}