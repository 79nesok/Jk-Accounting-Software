namespace Jk_Accounting_Software.External.Accounting
{
    partial class ECustomerOverpaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECustomerOverpaymentForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.txtTransactionNo = new JkComponents.JkTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblReferenceNo = new System.Windows.Forms.Label();
            this.txtReferenceNo = new JkComponents.JkTextBox();
            this.lblReferenceNo2 = new System.Windows.Forms.Label();
            this.txtReferenceNo2 = new JkComponents.JkTextBox();
            this.lblSubsidiary = new System.Windows.Forms.Label();
            this.cmbSubsidiary = new JkComponents.JkLookUpComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new JkComponents.JkTextBox();
            this.lblAmountApplied = new System.Windows.Forms.Label();
            this.txtAmountApplied = new JkComponents.JkTextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new JkComponents.JkTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
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
            this.flowLayoutPanel2.Controls.Add(this.lblTransactionNo);
            this.flowLayoutPanel2.Controls.Add(this.txtTransactionNo);
            this.flowLayoutPanel2.Controls.Add(this.lblDate);
            this.flowLayoutPanel2.Controls.Add(this.datePicker);
            this.flowLayoutPanel2.Controls.Add(this.lblReferenceNo);
            this.flowLayoutPanel2.Controls.Add(this.txtReferenceNo);
            this.flowLayoutPanel2.Controls.Add(this.lblReferenceNo2);
            this.flowLayoutPanel2.Controls.Add(this.txtReferenceNo2);
            this.flowLayoutPanel2.Controls.Add(this.lblSubsidiary);
            this.flowLayoutPanel2.Controls.Add(this.cmbSubsidiary);
            this.flowLayoutPanel2.Controls.Add(this.lblAmount);
            this.flowLayoutPanel2.Controls.Add(this.txtAmount);
            this.flowLayoutPanel2.Controls.Add(this.lblAmountApplied);
            this.flowLayoutPanel2.Controls.Add(this.txtAmountApplied);
            this.flowLayoutPanel2.Controls.Add(this.lblBalance);
            this.flowLayoutPanel2.Controls.Add(this.txtBalance);
            this.flowLayoutPanel2.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 422);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.Location = new System.Drawing.Point(0, 0);
            this.lblTransactionNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTransactionNo.Size = new System.Drawing.Size(110, 27);
            this.lblTransactionNo.TabIndex = 0;
            this.lblTransactionNo.Text = "Transaction No:";
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.Color.White;
            this.txtTransactionNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransactionNo.Location = new System.Drawing.Point(116, 5);
            this.txtTransactionNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.ReadOnly = true;
            this.txtTransactionNo.Required = false;
            this.txtTransactionNo.Size = new System.Drawing.Size(205, 16);
            this.txtTransactionNo.TabIndex = 1;
            this.txtTransactionNo.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(0, 27);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblDate.Size = new System.Drawing.Size(110, 27);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MM/dd/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(116, 32);
            this.datePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(205, 23);
            this.datePicker.TabIndex = 8;
            // 
            // lblReferenceNo
            // 
            this.lblReferenceNo.Location = new System.Drawing.Point(0, 60);
            this.lblReferenceNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblReferenceNo.Name = "lblReferenceNo";
            this.lblReferenceNo.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblReferenceNo.Size = new System.Drawing.Size(110, 27);
            this.lblReferenceNo.TabIndex = 2;
            this.lblReferenceNo.Text = "Reference No:";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(116, 65);
            this.txtReferenceNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Required = false;
            this.txtReferenceNo.Size = new System.Drawing.Size(205, 23);
            this.txtReferenceNo.TabIndex = 2;
            // 
            // lblReferenceNo2
            // 
            this.lblReferenceNo2.Location = new System.Drawing.Point(0, 93);
            this.lblReferenceNo2.Margin = new System.Windows.Forms.Padding(0);
            this.lblReferenceNo2.Name = "lblReferenceNo2";
            this.lblReferenceNo2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblReferenceNo2.Size = new System.Drawing.Size(110, 27);
            this.lblReferenceNo2.TabIndex = 13;
            this.lblReferenceNo2.Text = "Reference No 2:";
            // 
            // txtReferenceNo2
            // 
            this.txtReferenceNo2.Location = new System.Drawing.Point(116, 98);
            this.txtReferenceNo2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtReferenceNo2.Name = "txtReferenceNo2";
            this.txtReferenceNo2.Required = false;
            this.txtReferenceNo2.Size = new System.Drawing.Size(205, 23);
            this.txtReferenceNo2.TabIndex = 14;
            // 
            // lblSubsidiary
            // 
            this.lblSubsidiary.Location = new System.Drawing.Point(0, 126);
            this.lblSubsidiary.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubsidiary.Name = "lblSubsidiary";
            this.lblSubsidiary.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblSubsidiary.Size = new System.Drawing.Size(110, 27);
            this.lblSubsidiary.TabIndex = 18;
            this.lblSubsidiary.Text = "Subsidiary:";
            // 
            // cmbSubsidiary
            // 
            this.cmbSubsidiary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubsidiary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubsidiary.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSubsidiary.DataSet = "dstSubsidiaries";
            this.cmbSubsidiary.DisplayText = "Name";
            this.cmbSubsidiary.DropDownHeight = 150;
            this.cmbSubsidiary.DropDownWidth = 220;
            this.cmbSubsidiary.ForeColor = System.Drawing.Color.Black;
            this.cmbSubsidiary.FormattingEnabled = true;
            this.cmbSubsidiary.IntegralHeight = false;
            this.cmbSubsidiary.Key = "Id";
            this.cmbSubsidiary.Location = new System.Drawing.Point(116, 131);
            this.cmbSubsidiary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSubsidiary.Name = "cmbSubsidiary";
            this.cmbSubsidiary.Required = false;
            this.cmbSubsidiary.Size = new System.Drawing.Size(205, 23);
            this.cmbSubsidiary.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(0, 159);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblAmount.Size = new System.Drawing.Size(110, 27);
            this.lblAmount.TabIndex = 19;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(116, 164);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Required = false;
            this.txtAmount.Size = new System.Drawing.Size(205, 23);
            this.txtAmount.TabIndex = 20;
            // 
            // lblAmountApplied
            // 
            this.lblAmountApplied.Location = new System.Drawing.Point(0, 192);
            this.lblAmountApplied.Margin = new System.Windows.Forms.Padding(0);
            this.lblAmountApplied.Name = "lblAmountApplied";
            this.lblAmountApplied.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblAmountApplied.Size = new System.Drawing.Size(110, 27);
            this.lblAmountApplied.TabIndex = 21;
            this.lblAmountApplied.Text = "Amount Applied:";
            // 
            // txtAmountApplied
            // 
            this.txtAmountApplied.Location = new System.Drawing.Point(116, 197);
            this.txtAmountApplied.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAmountApplied.Name = "txtAmountApplied";
            this.txtAmountApplied.Required = false;
            this.txtAmountApplied.Size = new System.Drawing.Size(205, 23);
            this.txtAmountApplied.TabIndex = 22;
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(0, 225);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblBalance.Size = new System.Drawing.Size(110, 27);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(116, 230);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Required = false;
            this.txtBalance.Size = new System.Drawing.Size(205, 23);
            this.txtBalance.TabIndex = 24;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 258);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(110, 27);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(116, 263);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(205, 76);
            this.txtRemarks.TabIndex = 12;
            // 
            // ECustomerOverpaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Customer Overpayment";
            this.CommandText = resources.GetString("$this.CommandText");
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
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns14"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns15"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns16"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns17"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns18"))));
            this.Name = "ECustomerOverpaymentForm";
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
        private System.Windows.Forms.Label lblTransactionNo;
        private JkComponents.JkTextBox txtTransactionNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblReferenceNo;
        private JkComponents.JkTextBox txtReferenceNo;
        private System.Windows.Forms.Label lblReferenceNo2;
        private JkComponents.JkTextBox txtReferenceNo2;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Label lblSubsidiary;
        private JkComponents.JkLookUpComboBox cmbSubsidiary;
        private System.Windows.Forms.Label lblAmount;
        private JkComponents.JkTextBox txtAmount;
        private System.Windows.Forms.Label lblAmountApplied;
        private JkComponents.JkTextBox txtAmountApplied;
        private System.Windows.Forms.Label lblBalance;
        private JkComponents.JkTextBox txtBalance;
    }
}
