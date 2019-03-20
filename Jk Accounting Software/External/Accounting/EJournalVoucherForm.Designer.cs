namespace Jk_Accounting_Software.External.Accounting
{
    partial class EJournalVoucherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EJournalVoucherForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransactionNo = new JkComponents.JkTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferenceNo = new JkComponents.JkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferenceNo2 = new JkComponents.JkTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.jkSeriesProvider = new JkComponents.JkSeriesProvider();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAccounts = new JkComponents.JkLookUpComboBox();
            this.cmbSubsidiary = new JkComponents.JkLookUpComboBox();
            this.tabPageJournalEntry = new System.Windows.Forms.TabPage();
            this.dataGridViewJournalEntry = new JkComponents.JkDataGridView();
            this.dstJournalEntry = new JkComponents.JkDetailDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).BeginInit();
            this.splitContainerMasterDetail.Panel1.SuspendLayout();
            this.splitContainerMasterDetail.Panel2.SuspendLayout();
            this.splitContainerMasterDetail.SuspendLayout();
            this.tabControlDetails.SuspendLayout();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPageJournalEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMasterDetail
            // 
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstJournalEntry);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbAccounts);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbSubsidiary);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.jkSeriesProvider);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(836, 443);
            this.splitContainerMasterDetail.SplitterDistance = 220;
            // 
            // dstDetail
            // 
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns1"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns2"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns3"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns4"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns5"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns6"))));
            this.dstDetail.CommandText = "SELECT Id, JournalVoucherId, AccountId,\r\n\tSubsidiaryId, Debit, Credit, Remarks\r\nF" +
    "ROM tblJournalVoucherDetails\r\nWHERE JournalVoucherId = @Id";
            this.dstDetail.GridAutoSize = true;
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageJournalEntry);
            this.tabControlDetails.Size = new System.Drawing.Size(836, 219);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageJournalEntry, 0);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageDetails, 0);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Size = new System.Drawing.Size(828, 191);
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 502);
            // 
            // splitContainer
            // 
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
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtTransactionNo);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.datePicker);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtReferenceNo);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtReferenceNo2);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 220);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Transaction No:";
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
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label8.Size = new System.Drawing.Size(110, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date:";
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reference No:";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reference No 2:";
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
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label9.Size = new System.Drawing.Size(110, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(116, 131);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(205, 76);
            this.txtRemarks.TabIndex = 12;
            // 
            // jkSeriesProvider
            // 
            this.jkSeriesProvider.BackColor = System.Drawing.Color.Tan;
            this.jkSeriesProvider.Code = "JV";
            this.jkSeriesProvider.CompanyId = "";
            this.jkSeriesProvider.ConnectionString = "";
            this.jkSeriesProvider.Location = new System.Drawing.Point(359, 18);
            this.jkSeriesProvider.Name = "jkSeriesProvider";
            this.jkSeriesProvider.Size = new System.Drawing.Size(83, 20);
            this.jkSeriesProvider.TabIndex = 16;
            this.jkSeriesProvider.Text = "jkSeriesProvider1";
            this.jkSeriesProvider.TransactionColumn = "TransactionNo";
            this.jkSeriesProvider.Value = null;
            this.jkSeriesProvider.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccounts.DataSet = "dstAccounts";
            this.cmbAccounts.DisplayText = "Name";
            this.cmbAccounts.ForeColor = System.Drawing.Color.Black;
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Key = "Id";
            this.cmbAccounts.Location = new System.Drawing.Point(713, 63);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Required = false;
            this.cmbAccounts.Size = new System.Drawing.Size(66, 23);
            this.cmbAccounts.TabIndex = 18;
            this.cmbAccounts.Visible = false;
            // 
            // cmbSubsidiary
            // 
            this.cmbSubsidiary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubsidiary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubsidiary.DataSet = "dstSubsidiaries";
            this.cmbSubsidiary.DisplayText = "Name";
            this.cmbSubsidiary.DropDownHeight = 200;
            this.cmbSubsidiary.DropDownWidth = 300;
            this.cmbSubsidiary.ForeColor = System.Drawing.Color.Black;
            this.cmbSubsidiary.FormattingEnabled = true;
            this.cmbSubsidiary.IntegralHeight = false;
            this.cmbSubsidiary.Key = "Id";
            this.cmbSubsidiary.Location = new System.Drawing.Point(713, 99);
            this.cmbSubsidiary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSubsidiary.Name = "cmbSubsidiary";
            this.cmbSubsidiary.Required = false;
            this.cmbSubsidiary.Size = new System.Drawing.Size(66, 23);
            this.cmbSubsidiary.TabIndex = 17;
            this.cmbSubsidiary.Visible = false;
            // 
            // tabPageJournalEntry
            // 
            this.tabPageJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageJournalEntry.Controls.Add(this.dataGridViewJournalEntry);
            this.tabPageJournalEntry.Location = new System.Drawing.Point(4, 24);
            this.tabPageJournalEntry.Name = "tabPageJournalEntry";
            this.tabPageJournalEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJournalEntry.Size = new System.Drawing.Size(824, 181);
            this.tabPageJournalEntry.TabIndex = 1;
            this.tabPageJournalEntry.Text = "Journal Entry";
            this.tabPageJournalEntry.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJournalEntry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridViewJournalEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewJournalEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournalEntry.DataSet = this.dstJournalEntry;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJournalEntry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJournalEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJournalEntry.GridColor = System.Drawing.Color.Peru;
            this.dataGridViewJournalEntry.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewJournalEntry.Name = "dataGridViewJournalEntry";
            this.dataGridViewJournalEntry.Size = new System.Drawing.Size(814, 171);
            this.dataGridViewJournalEntry.TabIndex = 0;
            // 
            // dstJournalEntry
            // 
            this.dstJournalEntry.BackColor = System.Drawing.Color.Tan;
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns"))));
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns1"))));
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns2"))));
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns3"))));
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns4"))));
            this.dstJournalEntry.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstJournalEntry.Columns5"))));
            this.dstJournalEntry.CommandText = resources.GetString("dstJournalEntry.CommandText");
            this.dstJournalEntry.ConnectionString = "Data Source=.\\sqlexpress2014;Initial Catalog=FreeAccountingSoftware;Persist Secur" +
    "ity Info=True;User ID=sa;Password=masterkey";
            this.dstJournalEntry.GridAutoSize = true;
            this.dstJournalEntry.GridView = this.dataGridViewJournalEntry;
            this.dstJournalEntry.LinkToMaster = false;
            this.dstJournalEntry.Location = new System.Drawing.Point(626, 142);
            this.dstJournalEntry.Name = "dstJournalEntry";
            this.dstJournalEntry.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstJournalEntry.Parameters"))));
            this.dstJournalEntry.Size = new System.Drawing.Size(81, 20);
            this.dstJournalEntry.TabIndex = 23;
            this.dstJournalEntry.Visible = false;
            this.dstJournalEntry.ZLoadColumns = true;
            this.dstJournalEntry.ZLoadGrid = false;
            // 
            // EJournalVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Journal Voucher";
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
            this.Name = "EJournalVoucherForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.EJournalVoucherForm_SetupControl);
            this.ValidateSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.ValidateSaveHandler(this.EJournalVoucherForm_ValidateSave);
            this.splitContainerMasterDetail.Panel1.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).EndInit();
            this.splitContainerMasterDetail.ResumeLayout(false);
            this.tabControlDetails.ResumeLayout(false);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPageJournalEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtTransactionNo;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtReferenceNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label9;
        private JkComponents.JkTextBox txtRemarks;
        private JkComponents.JkSeriesProvider jkSeriesProvider;
        private System.Windows.Forms.Label label1;
        private JkComponents.JkTextBox txtReferenceNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private JkComponents.JkLookUpComboBox cmbAccounts;
        private JkComponents.JkLookUpComboBox cmbSubsidiary;
        private System.Windows.Forms.TabPage tabPageJournalEntry;
        private JkComponents.JkDataGridView dataGridViewJournalEntry;
        private JkComponents.JkDetailDataSet dstJournalEntry;
    }
}
