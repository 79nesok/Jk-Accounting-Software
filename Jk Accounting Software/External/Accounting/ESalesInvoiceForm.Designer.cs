namespace Jk_Accounting_Software.External.Accounting
{
    partial class ESalesInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESalesInvoiceForm));
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
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGrossAmount = new System.Windows.Forms.Label();
            this.txtGrossAmount = new JkComponents.JkTextBox();
            this.lblVATAmount = new System.Windows.Forms.Label();
            this.txtVATAmount = new JkComponents.JkTextBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new JkComponents.JkTextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new JkComponents.JkTextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new JkComponents.JkTextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new JkComponents.JkTextBox();
            this.cmbVATTypes = new JkComponents.JkLookUpComboBox();
            this.cmbAccounts = new JkComponents.JkLookUpComboBox();
            this.cmbSubsidiaryDetail = new JkComponents.JkLookUpComboBox();
            this.jkSeriesProvider1 = new JkComponents.JkSeriesProvider();
            this.tabPageJournalEntry = new System.Windows.Forms.TabPage();
            this.dataGridViewJournalEntry = new JkComponents.JkDataGridView();
            this.dstJournalEntry = new JkComponents.JkDetailDataSet();
            this.cmbItems = new JkComponents.JkLookUpComboBox();
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
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageJournalEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMasterDetail
            // 
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbItems);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstJournalEntry);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbVATTypes);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbAccounts);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbSubsidiaryDetail);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.jkSeriesProvider1);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(836, 443);
            this.splitContainerMasterDetail.SplitterDistance = 255;
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
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns7"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns8"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns9"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns10"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns11"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns12"))));
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns13"))));
            this.dstDetail.CommandText = resources.GetString("dstDetail.CommandText");
            this.dstDetail.Location = new System.Drawing.Point(734, 222);
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageJournalEntry);
            this.tabControlDetails.Size = new System.Drawing.Size(836, 184);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageJournalEntry, 0);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageDetails, 0);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Size = new System.Drawing.Size(828, 156);
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
            this.flowLayoutPanel2.Controls.Add(this.lblRemarks);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 255);
            this.flowLayoutPanel2.TabIndex = 17;
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
            this.lblSubsidiary.TabIndex = 16;
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
            this.cmbSubsidiary.TabIndex = 15;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Location = new System.Drawing.Point(0, 159);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblRemarks.Size = new System.Drawing.Size(110, 27);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(116, 164);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(205, 76);
            this.txtRemarks.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblGrossAmount);
            this.flowLayoutPanel1.Controls.Add(this.txtGrossAmount);
            this.flowLayoutPanel1.Controls.Add(this.lblVATAmount);
            this.flowLayoutPanel1.Controls.Add(this.txtVATAmount);
            this.flowLayoutPanel1.Controls.Add(this.lblDiscountAmount);
            this.flowLayoutPanel1.Controls.Add(this.txtDiscountAmount);
            this.flowLayoutPanel1.Controls.Add(this.lblNetAmount);
            this.flowLayoutPanel1.Controls.Add(this.txtNetAmount);
            this.flowLayoutPanel1.Controls.Add(this.lblPaidAmount);
            this.flowLayoutPanel1.Controls.Add(this.txtPaidAmount);
            this.flowLayoutPanel1.Controls.Add(this.lblBalance);
            this.flowLayoutPanel1.Controls.Add(this.txtBalance);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(342, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 255);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // lblGrossAmount
            // 
            this.lblGrossAmount.Location = new System.Drawing.Point(0, 0);
            this.lblGrossAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblGrossAmount.Name = "lblGrossAmount";
            this.lblGrossAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblGrossAmount.Size = new System.Drawing.Size(116, 27);
            this.lblGrossAmount.TabIndex = 1;
            this.lblGrossAmount.Text = "Gross Amount:";
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.BackColor = System.Drawing.Color.White;
            this.txtGrossAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrossAmount.Location = new System.Drawing.Point(122, 5);
            this.txtGrossAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.ReadOnly = true;
            this.txtGrossAmount.Required = false;
            this.txtGrossAmount.Size = new System.Drawing.Size(90, 16);
            this.txtGrossAmount.TabIndex = 2;
            this.txtGrossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVATAmount
            // 
            this.lblVATAmount.Location = new System.Drawing.Point(0, 27);
            this.lblVATAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblVATAmount.Name = "lblVATAmount";
            this.lblVATAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblVATAmount.Size = new System.Drawing.Size(116, 27);
            this.lblVATAmount.TabIndex = 3;
            this.lblVATAmount.Text = "VAT Amount:";
            // 
            // txtVATAmount
            // 
            this.txtVATAmount.BackColor = System.Drawing.Color.White;
            this.txtVATAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVATAmount.Location = new System.Drawing.Point(122, 32);
            this.txtVATAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtVATAmount.Name = "txtVATAmount";
            this.txtVATAmount.ReadOnly = true;
            this.txtVATAmount.Required = false;
            this.txtVATAmount.Size = new System.Drawing.Size(90, 16);
            this.txtVATAmount.TabIndex = 4;
            this.txtVATAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Location = new System.Drawing.Point(0, 54);
            this.lblDiscountAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblDiscountAmount.Size = new System.Drawing.Size(116, 27);
            this.lblDiscountAmount.TabIndex = 5;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BackColor = System.Drawing.Color.White;
            this.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountAmount.Location = new System.Drawing.Point(122, 59);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Required = false;
            this.txtDiscountAmount.Size = new System.Drawing.Size(90, 16);
            this.txtDiscountAmount.TabIndex = 6;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.Location = new System.Drawing.Point(0, 81);
            this.lblNetAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblNetAmount.Size = new System.Drawing.Size(116, 27);
            this.lblNetAmount.TabIndex = 7;
            this.lblNetAmount.Text = "Net Amount:";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.Color.White;
            this.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNetAmount.Location = new System.Drawing.Point(122, 86);
            this.txtNetAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Required = false;
            this.txtNetAmount.Size = new System.Drawing.Size(90, 16);
            this.txtNetAmount.TabIndex = 8;
            this.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Location = new System.Drawing.Point(0, 108);
            this.lblPaidAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblPaidAmount.Size = new System.Drawing.Size(116, 27);
            this.lblPaidAmount.TabIndex = 9;
            this.lblPaidAmount.Text = "Paid Amount:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.Color.White;
            this.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmount.Location = new System.Drawing.Point(122, 113);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Required = false;
            this.txtPaidAmount.Size = new System.Drawing.Size(90, 16);
            this.txtPaidAmount.TabIndex = 10;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(0, 135);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblBalance.Size = new System.Drawing.Size(116, 27);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Location = new System.Drawing.Point(122, 140);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Required = false;
            this.txtBalance.Size = new System.Drawing.Size(90, 16);
            this.txtBalance.TabIndex = 12;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.Enter += new System.EventHandler(this.txtBalance_Enter);
            this.txtBalance.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // cmbVATTypes
            // 
            this.cmbVATTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVATTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVATTypes.DataSet = "dstVATTypes";
            this.cmbVATTypes.DisplayText = "Name";
            this.cmbVATTypes.ForeColor = System.Drawing.Color.Black;
            this.cmbVATTypes.FormattingEnabled = true;
            this.cmbVATTypes.Key = "Id";
            this.cmbVATTypes.Location = new System.Drawing.Point(716, 108);
            this.cmbVATTypes.Name = "cmbVATTypes";
            this.cmbVATTypes.Required = false;
            this.cmbVATTypes.Size = new System.Drawing.Size(66, 23);
            this.cmbVATTypes.TabIndex = 25;
            this.cmbVATTypes.Visible = false;
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
            this.cmbAccounts.Location = new System.Drawing.Point(716, 138);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Required = false;
            this.cmbAccounts.Size = new System.Drawing.Size(66, 23);
            this.cmbAccounts.TabIndex = 24;
            this.cmbAccounts.Visible = false;
            // 
            // cmbSubsidiaryDetail
            // 
            this.cmbSubsidiaryDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubsidiaryDetail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubsidiaryDetail.DataSet = "dstSubsidiaries";
            this.cmbSubsidiaryDetail.DisplayText = "Name";
            this.cmbSubsidiaryDetail.DropDownHeight = 200;
            this.cmbSubsidiaryDetail.DropDownWidth = 300;
            this.cmbSubsidiaryDetail.ForeColor = System.Drawing.Color.Black;
            this.cmbSubsidiaryDetail.FormattingEnabled = true;
            this.cmbSubsidiaryDetail.IntegralHeight = false;
            this.cmbSubsidiaryDetail.Key = "Id";
            this.cmbSubsidiaryDetail.Location = new System.Drawing.Point(716, 169);
            this.cmbSubsidiaryDetail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSubsidiaryDetail.Name = "cmbSubsidiaryDetail";
            this.cmbSubsidiaryDetail.Required = false;
            this.cmbSubsidiaryDetail.Size = new System.Drawing.Size(66, 23);
            this.cmbSubsidiaryDetail.TabIndex = 23;
            this.cmbSubsidiaryDetail.Visible = false;
            // 
            // jkSeriesProvider1
            // 
            this.jkSeriesProvider1.BackColor = System.Drawing.Color.Tan;
            this.jkSeriesProvider1.Code = "SI";
            this.jkSeriesProvider1.CompanyId = null;
            this.jkSeriesProvider1.ConnectionString = null;
            this.jkSeriesProvider1.Location = new System.Drawing.Point(693, 196);
            this.jkSeriesProvider1.Name = "jkSeriesProvider1";
            this.jkSeriesProvider1.Size = new System.Drawing.Size(89, 20);
            this.jkSeriesProvider1.TabIndex = 22;
            this.jkSeriesProvider1.Text = "jkSeriesProvider1";
            this.jkSeriesProvider1.TransactionColumn = "TransactionNo";
            this.jkSeriesProvider1.Value = null;
            this.jkSeriesProvider1.Visible = false;
            // 
            // tabPageJournalEntry
            // 
            this.tabPageJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageJournalEntry.Controls.Add(this.dataGridViewJournalEntry);
            this.tabPageJournalEntry.Location = new System.Drawing.Point(4, 24);
            this.tabPageJournalEntry.Name = "tabPageJournalEntry";
            this.tabPageJournalEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJournalEntry.Size = new System.Drawing.Size(824, 156);
            this.tabPageJournalEntry.TabIndex = 1;
            this.tabPageJournalEntry.Text = "Journal Entry";
            this.tabPageJournalEntry.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJournalEntry
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridViewJournalEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewJournalEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewJournalEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournalEntry.DataSet = this.dstJournalEntry;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJournalEntry.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewJournalEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJournalEntry.GridColor = System.Drawing.Color.Peru;
            this.dataGridViewJournalEntry.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewJournalEntry.Name = "dataGridViewJournalEntry";
            this.dataGridViewJournalEntry.Size = new System.Drawing.Size(814, 146);
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
            this.dstJournalEntry.Location = new System.Drawing.Point(626, 166);
            this.dstJournalEntry.Name = "dstJournalEntry";
            this.dstJournalEntry.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstJournalEntry.Parameters"))));
            this.dstJournalEntry.Size = new System.Drawing.Size(81, 20);
            this.dstJournalEntry.TabIndex = 26;
            this.dstJournalEntry.Visible = false;
            this.dstJournalEntry.ZLoadColumns = true;
            this.dstJournalEntry.ZLoadGrid = false;
            // 
            // cmbItems
            // 
            this.cmbItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItems.DataSet = "dstItems";
            this.cmbItems.DisplayText = "Name";
            this.cmbItems.ForeColor = System.Drawing.Color.Black;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Key = "Id";
            this.cmbItems.Location = new System.Drawing.Point(716, 81);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Required = false;
            this.cmbItems.Size = new System.Drawing.Size(66, 23);
            this.cmbItems.TabIndex = 24;
            this.cmbItems.Visible = false;
            // 
            // ESalesInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Sales Invoice";
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
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns19"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns20"))));
            this.Name = "ESalesInvoiceForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.ESalesVoucherForm_SetupControl);
            this.BeforeSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.BeforeSaveHandler(this.ESalesVoucherForm_BeforeSave);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPageJournalEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).EndInit();
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
        private System.Windows.Forms.Label lblSubsidiary;
        private JkComponents.JkLookUpComboBox cmbSubsidiary;
        private System.Windows.Forms.Label lblRemarks;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblGrossAmount;
        private JkComponents.JkTextBox txtGrossAmount;
        private System.Windows.Forms.Label lblVATAmount;
        private JkComponents.JkTextBox txtVATAmount;
        private System.Windows.Forms.Label lblDiscountAmount;
        private JkComponents.JkTextBox txtDiscountAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private JkComponents.JkTextBox txtNetAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private JkComponents.JkTextBox txtPaidAmount;
        private System.Windows.Forms.Label lblBalance;
        private JkComponents.JkTextBox txtBalance;
        private JkComponents.JkLookUpComboBox cmbVATTypes;
        private JkComponents.JkLookUpComboBox cmbAccounts;
        private JkComponents.JkLookUpComboBox cmbSubsidiaryDetail;
        private JkComponents.JkSeriesProvider jkSeriesProvider1;
        private System.Windows.Forms.TabPage tabPageJournalEntry;
        private JkComponents.JkDataGridView dataGridViewJournalEntry;
        private JkComponents.JkDetailDataSet dstJournalEntry;
        private JkComponents.JkLookUpComboBox cmbItems;
    }
}
