namespace Jk_Accounting_Software.External.Maintenance
{
    partial class EAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EAccountForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.lblSystemAccountCode = new System.Windows.Forms.Label();
            this.cmbSystemAccountCode = new JkComponents.JkLookUpComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 447);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer.Size = new System.Drawing.Size(836, 481);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(803, 0);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblCode);
            this.flowLayoutPanel2.Controls.Add(this.txtCode);
            this.flowLayoutPanel2.Controls.Add(this.lblName);
            this.flowLayoutPanel2.Controls.Add(this.txtName);
            this.flowLayoutPanel2.Controls.Add(this.lblSystemAccountCode);
            this.flowLayoutPanel2.Controls.Add(this.cmbSystemAccountCode);
            this.flowLayoutPanel2.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Controls.Add(this.lblActive);
            this.flowLayoutPanel2.Controls.Add(this.chkActive);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 422);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblCode.Size = new System.Drawing.Size(145, 25);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(151, 5);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Required = false;
            this.txtCode.Size = new System.Drawing.Size(230, 23);
            this.txtCode.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblName.Size = new System.Drawing.Size(145, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Required = false;
            this.txtName.Size = new System.Drawing.Size(230, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblSystemAccountCode
            // 
            this.lblSystemAccountCode.Location = new System.Drawing.Point(0, 66);
            this.lblSystemAccountCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSystemAccountCode.Name = "lblSystemAccountCode";
            this.lblSystemAccountCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblSystemAccountCode.Size = new System.Drawing.Size(145, 33);
            this.lblSystemAccountCode.TabIndex = 9;
            this.lblSystemAccountCode.Text = "System Account Code:";
            // 
            // cmbSystemAccountCode
            // 
            this.cmbSystemAccountCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSystemAccountCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSystemAccountCode.DataSet = "dstSystemAccountCodes";
            this.cmbSystemAccountCode.DisplayText = "Name";
            this.cmbSystemAccountCode.ForeColor = System.Drawing.Color.Black;
            this.cmbSystemAccountCode.FormattingEnabled = true;
            this.cmbSystemAccountCode.Key = "Id";
            this.cmbSystemAccountCode.Location = new System.Drawing.Point(151, 71);
            this.cmbSystemAccountCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSystemAccountCode.Name = "cmbSystemAccountCode";
            this.cmbSystemAccountCode.Required = false;
            this.cmbSystemAccountCode.Size = new System.Drawing.Size(230, 23);
            this.cmbSystemAccountCode.TabIndex = 10;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 99);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(145, 25);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(151, 104);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(230, 90);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblActive
            // 
            this.lblActive.Location = new System.Drawing.Point(0, 199);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblActive.Size = new System.Drawing.Size(145, 25);
            this.lblActive.TabIndex = 8;
            this.lblActive.Text = "Active:";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(151, 204);
            this.chkActive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 25);
            this.chkActive.TabIndex = 5;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // EAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Caption = "Account";
            this.CommandText = "SELECT Id, CompanyId, AccountTypeId,\r\n\tSystemAccountCodeId, Code, Name,\r\n\tRemarks" +
    ", Active, CreatedById,\r\n\tDateCreated, ModifiedById, DateModified\r\nFROM tblAccoun" +
    "ts\r\nWHERE Id = @Id";
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns1"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns2"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns3"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns4"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns5"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns6"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns7"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns8"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns9"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns10"))));
            this.Name = "EAccountForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters1"))));
            this.Size = new System.Drawing.Size(836, 481);
            this.ZLoadMasterColumns = true;
            this.SetupData += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupDataHandler(this.EAccountForm_SetupData);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblCode;
        private JkComponents.JkTextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private JkComponents.JkTextBox txtName;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblSystemAccountCode;
        private JkComponents.JkLookUpComboBox cmbSystemAccountCode;
    }
}
