namespace Jk_Accounting_Software.External.Maintenance
{
    partial class ESubsidiaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESubsidiaryForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new JkComponents.JkTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTIN = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.MaskedTextBox();
            this.lblZIPCode = new System.Windows.Forms.Label();
            this.txtZIPCode = new JkComponents.JkTextBox();
            this.lblATC = new System.Windows.Forms.Label();
            this.cmbATC = new JkComponents.JkLookUpComboBox();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 502);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer.Size = new System.Drawing.Size(836, 536);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(803, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCode);
            this.flowLayoutPanel1.Controls.Add(this.txtCode);
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.lblAddress);
            this.flowLayoutPanel1.Controls.Add(this.txtAddress);
            this.flowLayoutPanel1.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel1.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel1.Controls.Add(this.lblActive);
            this.flowLayoutPanel1.Controls.Add(this.chkActive);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 477);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblCode.Size = new System.Drawing.Size(80, 27);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCode.Location = new System.Drawing.Point(86, 5);
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
            this.lblName.Size = new System.Drawing.Size(80, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Required = false;
            this.txtName.Size = new System.Drawing.Size(230, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(0, 66);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblAddress.Size = new System.Drawing.Size(80, 27);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 71);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Required = false;
            this.txtAddress.Size = new System.Drawing.Size(230, 80);
            this.txtAddress.TabIndex = 3;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 156);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(80, 27);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(86, 161);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(230, 80);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblActive
            // 
            this.lblActive.Location = new System.Drawing.Point(0, 246);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblActive.Size = new System.Drawing.Size(80, 27);
            this.lblActive.TabIndex = 8;
            this.lblActive.Text = "Active:";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(86, 251);
            this.chkActive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 27);
            this.chkActive.TabIndex = 5;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Information";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblTIN);
            this.flowLayoutPanel2.Controls.Add(this.txtTIN);
            this.flowLayoutPanel2.Controls.Add(this.lblZIPCode);
            this.flowLayoutPanel2.Controls.Add(this.txtZIPCode);
            this.flowLayoutPanel2.Controls.Add(this.lblATC);
            this.flowLayoutPanel2.Controls.Add(this.cmbATC);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(309, 104);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // lblTIN
            // 
            this.lblTIN.Location = new System.Drawing.Point(0, 0);
            this.lblTIN.Margin = new System.Windows.Forms.Padding(0);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTIN.Size = new System.Drawing.Size(80, 25);
            this.lblTIN.TabIndex = 18;
            this.lblTIN.Text = "TIN:";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(86, 5);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTIN.Mask = "000-000-000-000";
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(217, 23);
            this.txtTIN.TabIndex = 20;
            this.txtTIN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblZIPCode
            // 
            this.lblZIPCode.Location = new System.Drawing.Point(0, 33);
            this.lblZIPCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblZIPCode.Name = "lblZIPCode";
            this.lblZIPCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblZIPCode.Size = new System.Drawing.Size(80, 25);
            this.lblZIPCode.TabIndex = 19;
            this.lblZIPCode.Text = "ZIP Code:";
            // 
            // txtZIPCode
            // 
            this.txtZIPCode.Location = new System.Drawing.Point(86, 38);
            this.txtZIPCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtZIPCode.Name = "txtZIPCode";
            this.txtZIPCode.Required = false;
            this.txtZIPCode.Size = new System.Drawing.Size(217, 23);
            this.txtZIPCode.TabIndex = 21;
            // 
            // lblATC
            // 
            this.lblATC.Location = new System.Drawing.Point(0, 66);
            this.lblATC.Margin = new System.Windows.Forms.Padding(0);
            this.lblATC.Name = "lblATC";
            this.lblATC.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblATC.Size = new System.Drawing.Size(80, 25);
            this.lblATC.TabIndex = 22;
            this.lblATC.Text = "ATC:";
            // 
            // cmbATC
            // 
            this.cmbATC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbATC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbATC.DataSet = "dstATC";
            this.cmbATC.DisplayText = "CodeRate";
            this.cmbATC.ForeColor = System.Drawing.Color.Black;
            this.cmbATC.FormattingEnabled = true;
            this.cmbATC.IntegralHeight = false;
            this.cmbATC.Key = "Id";
            this.cmbATC.Location = new System.Drawing.Point(86, 71);
            this.cmbATC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbATC.Name = "cmbATC";
            this.cmbATC.Required = false;
            this.cmbATC.Size = new System.Drawing.Size(217, 23);
            this.cmbATC.TabIndex = 23;
            // 
            // ESubsidiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Subsidiary";
            this.CommandText = "SELECT Id, CompanyId, SubsidiaryTypeId, Code,\r\n\tName, [Address], TIN, ZIPCode, AT" +
    "CId, Remarks,\r\n\tActive, CreatedById, DateCreated,\r\n\tModifiedById, DateModified\r\n" +
    "FROM tblSubsidiaries\r\nWHERE Id = @Id";
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
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns11"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns12"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns13"))));
            this.Name = "ESubsidiaryForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters1"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.SetupData += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupDataHandler(this.ESubsidiaryForm_SetupData);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCode;
        private JkComponents.JkTextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private JkComponents.JkTextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private JkComponents.JkTextBox txtAddress;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblTIN;
        private System.Windows.Forms.MaskedTextBox txtTIN;
        private System.Windows.Forms.Label lblZIPCode;
        private JkComponents.JkTextBox txtZIPCode;
        private System.Windows.Forms.Label lblATC;
        private JkComponents.JkLookUpComboBox cmbATC;
    }
}
