namespace Jk_Accounting_Software.External.Administration
{
    partial class ECompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECompanyForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new JkComponents.JkTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTIN = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.MaskedTextBox();
            this.lblZIPCode = new System.Windows.Forms.Label();
            this.txtZIPCode = new JkComponents.JkTextBox();
            this.lblATC = new System.Windows.Forms.Label();
            this.cmbATC = new JkComponents.JkLookUpComboBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
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
            this.splitContainer.Panel2.Controls.Add(this.panelLogo);
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel2);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblCode);
            this.flowLayoutPanel2.Controls.Add(this.txtCode);
            this.flowLayoutPanel2.Controls.Add(this.lblName);
            this.flowLayoutPanel2.Controls.Add(this.txtName);
            this.flowLayoutPanel2.Controls.Add(this.lblAddress);
            this.flowLayoutPanel2.Controls.Add(this.txtAddress);
            this.flowLayoutPanel2.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(330, 477);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblCode.Size = new System.Drawing.Size(80, 25);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
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
            this.lblName.Size = new System.Drawing.Size(80, 25);
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
            this.lblAddress.Size = new System.Drawing.Size(80, 25);
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
            this.txtAddress.Size = new System.Drawing.Size(230, 90);
            this.txtAddress.TabIndex = 3;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 166);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(80, 25);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(86, 171);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(230, 90);
            this.txtRemarks.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 131);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Information";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTIN);
            this.flowLayoutPanel1.Controls.Add(this.txtTIN);
            this.flowLayoutPanel1.Controls.Add(this.lblZIPCode);
            this.flowLayoutPanel1.Controls.Add(this.txtZIPCode);
            this.flowLayoutPanel1.Controls.Add(this.lblATC);
            this.flowLayoutPanel1.Controls.Add(this.cmbATC);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 109);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTIN
            // 
            this.lblTIN.Location = new System.Drawing.Point(0, 0);
            this.lblTIN.Margin = new System.Windows.Forms.Padding(0);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTIN.Size = new System.Drawing.Size(80, 25);
            this.lblTIN.TabIndex = 26;
            this.lblTIN.Text = "TIN:";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(86, 5);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTIN.Mask = "000-000-000-000";
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(217, 23);
            this.txtTIN.TabIndex = 28;
            this.txtTIN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblZIPCode
            // 
            this.lblZIPCode.Location = new System.Drawing.Point(0, 33);
            this.lblZIPCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblZIPCode.Name = "lblZIPCode";
            this.lblZIPCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblZIPCode.Size = new System.Drawing.Size(80, 25);
            this.lblZIPCode.TabIndex = 27;
            this.lblZIPCode.Text = "ZIP Code:";
            // 
            // txtZIPCode
            // 
            this.txtZIPCode.Location = new System.Drawing.Point(86, 38);
            this.txtZIPCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtZIPCode.Name = "txtZIPCode";
            this.txtZIPCode.Required = false;
            this.txtZIPCode.Size = new System.Drawing.Size(217, 23);
            this.txtZIPCode.TabIndex = 29;
            // 
            // lblATC
            // 
            this.lblATC.Location = new System.Drawing.Point(0, 66);
            this.lblATC.Margin = new System.Windows.Forms.Padding(0);
            this.lblATC.Name = "lblATC";
            this.lblATC.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblATC.Size = new System.Drawing.Size(80, 25);
            this.lblATC.TabIndex = 30;
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
            this.cmbATC.TabIndex = 31;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLink);
            this.panelLogo.Controls.Add(this.logoBox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(330, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogo.Size = new System.Drawing.Size(506, 185);
            this.panelLogo.TabIndex = 14;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLink.Location = new System.Drawing.Point(236, 5);
            this.lblLink.Margin = new System.Windows.Forms.Padding(0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblLink.Size = new System.Drawing.Size(90, 25);
            this.lblLink.TabIndex = 1;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Change Logo";
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.White;
            this.logoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoBox.Location = new System.Drawing.Point(326, 5);
            this.logoBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.logoBox.Size = new System.Drawing.Size(175, 175);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // ECompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Caption = "Company";
            this.CommandText = "SELECT Id, Code, Name, [Address], Logo, TIN,\r\n\tZIPCode, ATCId, Remarks, Active, C" +
    "reatedById,\r\n\tDateCreated, ModifiedById, DateModified\r\nFROM tblCompanies\r\nWHERE " +
    "Id = @CompanyId";
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
            this.Name = "ECompanyForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.ECompanyForm_SetupControl);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblCode;
        private JkComponents.JkTextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private JkComponents.JkTextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private JkComponents.JkTextBox txtAddress;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTIN;
        private System.Windows.Forms.MaskedTextBox txtTIN;
        private System.Windows.Forms.Label lblZIPCode;
        private JkComponents.JkTextBox txtZIPCode;
        private System.Windows.Forms.Label lblATC;
        private JkComponents.JkLookUpComboBox cmbATC;
    }
}
