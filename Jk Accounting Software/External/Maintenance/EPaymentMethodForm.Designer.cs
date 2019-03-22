namespace Jk_Accounting_Software.External.Maintenance
{
    partial class EPaymentMethodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPaymentMethodForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new JkComponents.JkTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new JkComponents.JkTextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbAccount = new JkComponents.JkLookUpComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.lblForClearing = new System.Windows.Forms.Label();
            this.chkForClearing = new System.Windows.Forms.CheckBox();
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
            this.flowLayoutPanel2.Controls.Add(this.lblAccount);
            this.flowLayoutPanel2.Controls.Add(this.cmbAccount);
            this.flowLayoutPanel2.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Controls.Add(this.lblForClearing);
            this.flowLayoutPanel2.Controls.Add(this.chkForClearing);
            this.flowLayoutPanel2.Controls.Add(this.lblActive);
            this.flowLayoutPanel2.Controls.Add(this.chkActive);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 422);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(0, 0);
            this.lblCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblCode.Size = new System.Drawing.Size(95, 25);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(101, 5);
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
            this.lblName.Size = new System.Drawing.Size(95, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Required = false;
            this.txtName.Size = new System.Drawing.Size(230, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.Location = new System.Drawing.Point(0, 66);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblAccount.Size = new System.Drawing.Size(95, 33);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "Account:";
            // 
            // cmbAccount
            // 
            this.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccount.DataSet = "dstAccounts";
            this.cmbAccount.DisplayText = "Name";
            this.cmbAccount.ForeColor = System.Drawing.Color.Black;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Key = "Id";
            this.cmbAccount.Location = new System.Drawing.Point(101, 71);
            this.cmbAccount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Required = false;
            this.cmbAccount.Size = new System.Drawing.Size(230, 23);
            this.cmbAccount.TabIndex = 10;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 99);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(95, 25);
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 104);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(230, 90);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblForClearing
            // 
            this.lblForClearing.Location = new System.Drawing.Point(0, 199);
            this.lblForClearing.Margin = new System.Windows.Forms.Padding(0);
            this.lblForClearing.Name = "lblForClearing";
            this.lblForClearing.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblForClearing.Size = new System.Drawing.Size(95, 25);
            this.lblForClearing.TabIndex = 11;
            this.lblForClearing.Text = "For Clearing:";
            // 
            // chkForClearing
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkForClearing, true);
            this.chkForClearing.Location = new System.Drawing.Point(101, 204);
            this.chkForClearing.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkForClearing.Name = "chkForClearing";
            this.chkForClearing.Size = new System.Drawing.Size(15, 25);
            this.chkForClearing.TabIndex = 12;
            this.chkForClearing.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.Location = new System.Drawing.Point(0, 234);
            this.lblActive.Margin = new System.Windows.Forms.Padding(0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblActive.Size = new System.Drawing.Size(95, 25);
            this.lblActive.TabIndex = 8;
            this.lblActive.Text = "Active:";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(101, 239);
            this.chkActive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 25);
            this.chkActive.TabIndex = 5;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // EPaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Payment Method";
            this.CommandText = "SELECT Id, CompanyId, Code, Name,\r\n\tAccountId, Remarks, ForClearing, Active,\r\n\tCr" +
    "eatedById, DateCreated,\r\n\tModifiedById, DateModified\r\nFROM tblPaymentMethods\r\nWH" +
    "ERE Id = @Id";
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
            this.Name = "EPaymentMethodForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 481);
            this.ZLoadMasterColumns = true;
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
        private System.Windows.Forms.Label lblAccount;
        private JkComponents.JkLookUpComboBox cmbAccount;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblForClearing;
        private System.Windows.Forms.CheckBox chkForClearing;
    }
}
