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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new JkComponents.JkTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(667, 0);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelLogo);
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer.Size = new System.Drawing.Size(775, 481);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtCode);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtName);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtAddress);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(330, 412);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(90, 5);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(233, 23);
            this.txtCode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 23);
            this.txtName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(90, 71);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 90);
            this.txtAddress.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(90, 171);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(233, 90);
            this.txtRemarks.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLink);
            this.panelLogo.Controls.Add(this.logoBox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(330, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogo.Size = new System.Drawing.Size(445, 185);
            this.panelLogo.TabIndex = 14;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLink.Location = new System.Drawing.Point(175, 5);
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
            this.logoBox.Location = new System.Drawing.Point(265, 5);
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
            this.CommandText = "SELECT Id, Code, Name, [Address], Logo,\r\n\tRemarks, Active, CreatedById,\r\n\tDateCre" +
    "ated, ModifiedById, DateModified\r\nFROM tblCompanies\r\nWHERE Id = @CompanyId";
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
            this.Name = "ECompanyForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(775, 481);
            this.ZLoadMasterColumns = true;
            this.AfterRun += new Jk_Accounting_Software.Internal.Forms.IParentForm.AfterRunHandler(this.ECompanyForm_AfterRun);
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtCode;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtName;
        private System.Windows.Forms.Label label8;
        private JkComponents.JkTextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}
