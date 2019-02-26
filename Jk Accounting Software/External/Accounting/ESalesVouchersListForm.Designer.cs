namespace Jk_Accounting_Software.External.Accounting
{
    partial class ESalesVouchersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESalesVouchersListForm));
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Size = new System.Drawing.Size(789, 481);
            // 
            // ESalesVouchersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Caption = "Sales Vouchers";
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns1"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns2"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns3"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns4"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns5"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns6"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns7"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns8"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns9"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns10"))));
            this.CommandText = resources.GetString("$this.CommandText");
            this.GridAutoSize = false;
            this.Name = "ESalesVouchersListForm";
            this.NewFormName = "ESalesVoucherForm";
            this.OpenFormName = "ESalesVoucherForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(789, 481);
            this.ZLoadColumns = true;
            this.ZLoadGrid = true;
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
