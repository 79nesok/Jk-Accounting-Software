namespace Free_Accounting_Software.External.Maintenance
{
    partial class EItemsListForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EItemsListForm));
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // EItemsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Items";
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns1"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns2"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns3"))));
            this.Columns.Add(((JkComponents.JkColumn)(resources.GetObject("$this.Columns4"))));
            this.CommandText = "SELECT Id, Code, Name, Remarks, Active\r\nFROM tblItems\r\nWHERE CompanyId = @Company" +
    "Id";
            this.Name = "EItemsListForm";
            this.NewFormName = "EItemForm";
            this.OpenFormName = "EItemForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(808, 481);
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
