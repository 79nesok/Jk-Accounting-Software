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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new JkComponents.JkTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtZIPCode = new JkComponents.JkTextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(700, 0);
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 502);
            this.FormFooter.Size = new System.Drawing.Size(808, 34);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer.Size = new System.Drawing.Size(808, 536);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtCode);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtAddress);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.chkActive);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 467);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCode.Location = new System.Drawing.Point(90, 5);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Required = false;
            this.txtCode.Size = new System.Drawing.Size(233, 23);
            this.txtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Required = false;
            this.txtName.Size = new System.Drawing.Size(233, 23);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 71);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Required = false;
            this.txtAddress.Size = new System.Drawing.Size(233, 80);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(90, 161);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(233, 80);
            this.txtRemarks.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Active:";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(90, 251);
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
            this.groupBox1.Size = new System.Drawing.Size(320, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Information";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtTIN);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtZIPCode);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.cmbATC);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 104);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "TIN:";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(90, 5);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTIN.Mask = "000-000-000-000";
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(213, 23);
            this.txtTIN.TabIndex = 20;
            this.txtTIN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "ZIP Code:";
            // 
            // txtZIPCode
            // 
            this.txtZIPCode.Location = new System.Drawing.Point(90, 38);
            this.txtZIPCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtZIPCode.Name = "txtZIPCode";
            this.txtZIPCode.Required = false;
            this.txtZIPCode.Size = new System.Drawing.Size(213, 23);
            this.txtZIPCode.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "ATC:";
            // 
            // cmbATC
            // 
            this.cmbATC.DataSet = "dstATC";
            this.cmbATC.DisplayText = "CodeRate";
            this.cmbATC.ForeColor = System.Drawing.Color.Black;
            this.cmbATC.FormattingEnabled = true;
            this.cmbATC.IntegralHeight = false;
            this.cmbATC.Key = "Id";
            this.cmbATC.Location = new System.Drawing.Point(90, 71);
            this.cmbATC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbATC.Name = "cmbATC";
            this.cmbATC.Required = false;
            this.cmbATC.Size = new System.Drawing.Size(213, 23);
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
            this.Size = new System.Drawing.Size(808, 536);
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
        private System.Windows.Forms.Label label1;
        private JkComponents.JkTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private JkComponents.JkTextBox txtName;
        private System.Windows.Forms.Label label4;
        private JkComponents.JkTextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTIN;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtZIPCode;
        private System.Windows.Forms.Label label8;
        private JkComponents.JkLookUpComboBox cmbATC;
    }
}
