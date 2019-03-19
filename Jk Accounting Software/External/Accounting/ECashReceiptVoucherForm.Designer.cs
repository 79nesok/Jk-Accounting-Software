namespace Jk_Accounting_Software.External.Accounting
{
    partial class ECashReceiptVoucherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECashReceiptVoucherForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransactionNo = new JkComponents.JkTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferenceNo = new JkComponents.JkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferenceNo2 = new JkComponents.JkTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubsidiary = new JkComponents.JkLookUpComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.tabControlPaymentDetails = new System.Windows.Forms.TabControl();
            this.tabPagePaymentDetails = new System.Windows.Forms.TabPage();
            this.splitContainerPaymentDetails = new System.Windows.Forms.SplitContainer();
            this.dataGridViewPaymentDetails = new JkComponents.JkDataGridView();
            this.dstPaymentDetails = new JkComponents.JkDetailDataSet();
            this.flowLayoutPanelPaymentDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new JkComponents.JkTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountApplied = new JkComponents.JkTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new JkComponents.JkTextBox();
            this.dstJournalEntry = new JkComponents.JkDetailDataSet();
            this.dataGridViewJournalEntry = new JkComponents.JkDataGridView();
            this.jkSeriesProvider1 = new JkComponents.JkSeriesProvider();
            this.cmbPaymentMethods = new JkComponents.JkLookUpComboBox();
            this.cmbAccounts = new JkComponents.JkLookUpComboBox();
            this.cmbSubsidiaryDetail = new JkComponents.JkLookUpComboBox();
            this.tabPageJournalEntry = new System.Windows.Forms.TabPage();
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
            this.tabControlPaymentDetails.SuspendLayout();
            this.tabPagePaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPaymentDetails)).BeginInit();
            this.splitContainerPaymentDetails.Panel1.SuspendLayout();
            this.splitContainerPaymentDetails.Panel2.SuspendLayout();
            this.splitContainerPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentDetails)).BeginInit();
            this.flowLayoutPanelPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).BeginInit();
            this.tabPageJournalEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMasterDetail
            // 
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbAccounts);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbSubsidiaryDetail);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstJournalEntry);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.jkSeriesProvider1);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstPaymentDetails);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbPaymentMethods);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.tabControlPaymentDetails);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(836, 403);
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
            this.dstDetail.CommandText = "SELECT Id, CashReceiptId, AccountId, SubsidiaryId,\r\n\tDebit, Credit, Remarks\r\nFROM" +
    " tblCashReceiptAccountDetails\r\nWHERE CashReceiptId = @Id";
            this.dstDetail.GridAutoSize = true;
            this.dstDetail.Location = new System.Drawing.Point(779, 204);
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageJournalEntry);
            this.tabControlDetails.Size = new System.Drawing.Size(836, 144);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageJournalEntry, 0);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageDetails, 0);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Size = new System.Drawing.Size(828, 116);
            // 
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(728, 0);
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 472);
            this.FormFooter.Size = new System.Drawing.Size(836, 34);
            // 
            // splitContainer
            // 
            this.splitContainer.Size = new System.Drawing.Size(836, 506);
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
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.cmbSubsidiary);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 255);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Transaction No.:";
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
            this.txtTransactionNo.Size = new System.Drawing.Size(194, 16);
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
            this.datePicker.Size = new System.Drawing.Size(194, 23);
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
            this.label7.Text = "Reference No.:";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(116, 65);
            this.txtReferenceNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Required = false;
            this.txtReferenceNo.Size = new System.Drawing.Size(194, 23);
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
            this.label1.Text = "Reference No 2.:";
            // 
            // txtReferenceNo2
            // 
            this.txtReferenceNo2.Location = new System.Drawing.Point(116, 98);
            this.txtReferenceNo2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtReferenceNo2.Name = "txtReferenceNo2";
            this.txtReferenceNo2.Required = false;
            this.txtReferenceNo2.Size = new System.Drawing.Size(194, 23);
            this.txtReferenceNo2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Subsidiary:";
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
            this.cmbSubsidiary.Size = new System.Drawing.Size(194, 23);
            this.cmbSubsidiary.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label9.Size = new System.Drawing.Size(110, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(116, 164);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(194, 76);
            this.txtRemarks.TabIndex = 12;
            // 
            // tabControlPaymentDetails
            // 
            this.tabControlPaymentDetails.Controls.Add(this.tabPagePaymentDetails);
            this.tabControlPaymentDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlPaymentDetails.Location = new System.Drawing.Point(325, 0);
            this.tabControlPaymentDetails.Name = "tabControlPaymentDetails";
            this.tabControlPaymentDetails.SelectedIndex = 0;
            this.tabControlPaymentDetails.Size = new System.Drawing.Size(420, 255);
            this.tabControlPaymentDetails.TabIndex = 31;
            // 
            // tabPagePaymentDetails
            // 
            this.tabPagePaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePaymentDetails.Controls.Add(this.splitContainerPaymentDetails);
            this.tabPagePaymentDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPagePaymentDetails.Name = "tabPagePaymentDetails";
            this.tabPagePaymentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaymentDetails.Size = new System.Drawing.Size(412, 227);
            this.tabPagePaymentDetails.TabIndex = 0;
            this.tabPagePaymentDetails.Text = "Payment Details";
            this.tabPagePaymentDetails.UseVisualStyleBackColor = true;
            // 
            // splitContainerPaymentDetails
            // 
            this.splitContainerPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPaymentDetails.IsSplitterFixed = true;
            this.splitContainerPaymentDetails.Location = new System.Drawing.Point(3, 3);
            this.splitContainerPaymentDetails.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerPaymentDetails.Name = "splitContainerPaymentDetails";
            this.splitContainerPaymentDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPaymentDetails.Panel1
            // 
            this.splitContainerPaymentDetails.Panel1.Controls.Add(this.dataGridViewPaymentDetails);
            // 
            // splitContainerPaymentDetails.Panel2
            // 
            this.splitContainerPaymentDetails.Panel2.Controls.Add(this.flowLayoutPanelPaymentDetails);
            this.splitContainerPaymentDetails.Size = new System.Drawing.Size(402, 217);
            this.splitContainerPaymentDetails.SplitterDistance = 160;
            this.splitContainerPaymentDetails.SplitterWidth = 1;
            this.splitContainerPaymentDetails.TabIndex = 0;
            // 
            // dataGridViewPaymentDetails
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridViewPaymentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaymentDetails.AutoGenerateColumns = false;
            this.dataGridViewPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentDetails.DataSet = this.dstPaymentDetails;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaymentDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaymentDetails.GridColor = System.Drawing.Color.Peru;
            this.dataGridViewPaymentDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPaymentDetails.Name = "dataGridViewPaymentDetails";
            this.dataGridViewPaymentDetails.Size = new System.Drawing.Size(402, 160);
            this.dataGridViewPaymentDetails.TabIndex = 34;
            // 
            // dstPaymentDetails
            // 
            this.dstPaymentDetails.BackColor = System.Drawing.Color.Tan;
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns1"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns2"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns3"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns4"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns5"))));
            this.dstPaymentDetails.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstPaymentDetails.Columns6"))));
            this.dstPaymentDetails.CommandText = "SELECT Id, CashReceiptId, PaymentMethodId,\r\n\tAmount, CheckNo, CheckDate, Remarks\r" +
    "\nFROM tblCashReceiptDetails\r\nWHERE CashReceiptId = @Id";
            this.dstPaymentDetails.ConnectionString = "Data Source=.\\sqlexpress2014;Initial Catalog=FreeAccountingSoftware;Persist Secur" +
    "ity Info=True;User ID=sa;Password=masterkey";
            this.dstPaymentDetails.GridAutoSize = false;
            this.dstPaymentDetails.GridView = this.dataGridViewPaymentDetails;
            this.dstPaymentDetails.LinkToMaster = true;
            this.dstPaymentDetails.Location = new System.Drawing.Point(732, 127);
            this.dstPaymentDetails.Name = "dstPaymentDetails";
            this.dstPaymentDetails.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstPaymentDetails.Parameters"))));
            this.dstPaymentDetails.Size = new System.Drawing.Size(95, 20);
            this.dstPaymentDetails.TabIndex = 34;
            this.dstPaymentDetails.Visible = false;
            this.dstPaymentDetails.ZLoadColumns = true;
            this.dstPaymentDetails.ZLoadGrid = true;
            // 
            // flowLayoutPanelPaymentDetails
            // 
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.label5);
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.txtAmountPaid);
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.label3);
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.txtAmountApplied);
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.label4);
            this.flowLayoutPanelPaymentDetails.Controls.Add(this.txtBalance);
            this.flowLayoutPanelPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPaymentDetails.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPaymentDetails.Name = "flowLayoutPanelPaymentDetails";
            this.flowLayoutPanelPaymentDetails.Size = new System.Drawing.Size(402, 56);
            this.flowLayoutPanelPaymentDetails.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount Paid:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BackColor = System.Drawing.Color.White;
            this.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowLayoutPanelPaymentDetails.SetFlowBreak(this.txtAmountPaid, true);
            this.txtAmountPaid.Location = new System.Drawing.Point(116, 0);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Required = false;
            this.txtAmountPaid.Size = new System.Drawing.Size(114, 16);
            this.txtAmountPaid.TabIndex = 7;
            this.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Applied:";
            // 
            // txtAmountApplied
            // 
            this.txtAmountApplied.BackColor = System.Drawing.Color.White;
            this.txtAmountApplied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowLayoutPanelPaymentDetails.SetFlowBreak(this.txtAmountApplied, true);
            this.txtAmountApplied.Location = new System.Drawing.Point(116, 17);
            this.txtAmountApplied.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtAmountApplied.Name = "txtAmountApplied";
            this.txtAmountApplied.ReadOnly = true;
            this.txtAmountApplied.Required = false;
            this.txtAmountApplied.Size = new System.Drawing.Size(114, 16);
            this.txtAmountApplied.TabIndex = 3;
            this.txtAmountApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Location = new System.Drawing.Point(116, 34);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Required = false;
            this.txtBalance.Size = new System.Drawing.Size(114, 16);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dstJournalEntry.Location = new System.Drawing.Point(747, 153);
            this.dstJournalEntry.Name = "dstJournalEntry";
            this.dstJournalEntry.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstJournalEntry.Parameters"))));
            this.dstJournalEntry.Size = new System.Drawing.Size(81, 20);
            this.dstJournalEntry.TabIndex = 24;
            this.dstJournalEntry.Visible = false;
            this.dstJournalEntry.ZLoadColumns = true;
            this.dstJournalEntry.ZLoadGrid = false;
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
            this.dataGridViewJournalEntry.Size = new System.Drawing.Size(815, 106);
            this.dataGridViewJournalEntry.TabIndex = 1;
            // 
            // jkSeriesProvider1
            // 
            this.jkSeriesProvider1.BackColor = System.Drawing.Color.Tan;
            this.jkSeriesProvider1.Code = "CRV";
            this.jkSeriesProvider1.CompanyId = null;
            this.jkSeriesProvider1.ConnectionString = null;
            this.jkSeriesProvider1.Location = new System.Drawing.Point(739, 179);
            this.jkSeriesProvider1.Name = "jkSeriesProvider1";
            this.jkSeriesProvider1.Size = new System.Drawing.Size(89, 20);
            this.jkSeriesProvider1.TabIndex = 32;
            this.jkSeriesProvider1.Text = "jkSeriesProvider1";
            this.jkSeriesProvider1.TransactionColumn = "TransactionNo";
            this.jkSeriesProvider1.Value = null;
            this.jkSeriesProvider1.Visible = false;
            // 
            // cmbPaymentMethods
            // 
            this.cmbPaymentMethods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPaymentMethods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentMethods.DataSet = "dstPaymentMethods";
            this.cmbPaymentMethods.DisplayText = "Name";
            this.cmbPaymentMethods.ForeColor = System.Drawing.Color.Black;
            this.cmbPaymentMethods.FormattingEnabled = true;
            this.cmbPaymentMethods.Key = "Id";
            this.cmbPaymentMethods.Location = new System.Drawing.Point(742, 98);
            this.cmbPaymentMethods.Name = "cmbPaymentMethods";
            this.cmbPaymentMethods.Required = false;
            this.cmbPaymentMethods.Size = new System.Drawing.Size(83, 23);
            this.cmbPaymentMethods.TabIndex = 35;
            this.cmbPaymentMethods.Visible = false;
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
            this.cmbAccounts.Location = new System.Drawing.Point(759, 31);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Required = false;
            this.cmbAccounts.Size = new System.Drawing.Size(66, 23);
            this.cmbAccounts.TabIndex = 49;
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
            this.cmbSubsidiaryDetail.Location = new System.Drawing.Point(759, 67);
            this.cmbSubsidiaryDetail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSubsidiaryDetail.Name = "cmbSubsidiaryDetail";
            this.cmbSubsidiaryDetail.Required = false;
            this.cmbSubsidiaryDetail.Size = new System.Drawing.Size(66, 23);
            this.cmbSubsidiaryDetail.TabIndex = 48;
            this.cmbSubsidiaryDetail.Visible = false;
            // 
            // tabPageJournalEntry
            // 
            this.tabPageJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageJournalEntry.Controls.Add(this.dataGridViewJournalEntry);
            this.tabPageJournalEntry.Location = new System.Drawing.Point(4, 24);
            this.tabPageJournalEntry.Name = "tabPageJournalEntry";
            this.tabPageJournalEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJournalEntry.Size = new System.Drawing.Size(825, 116);
            this.tabPageJournalEntry.TabIndex = 1;
            this.tabPageJournalEntry.Text = "Journal Entry";
            this.tabPageJournalEntry.UseVisualStyleBackColor = true;
            // 
            // ECashReceiptVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Cash Receipt Voucher";
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
            this.Name = "ECashReceiptVoucherForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 506);
            this.ZLoadMasterColumns = true;
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.ECashReceiptVoucherForm_SetupControl);
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
            this.tabControlPaymentDetails.ResumeLayout(false);
            this.tabPagePaymentDetails.ResumeLayout(false);
            this.splitContainerPaymentDetails.Panel1.ResumeLayout(false);
            this.splitContainerPaymentDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPaymentDetails)).EndInit();
            this.splitContainerPaymentDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentDetails)).EndInit();
            this.flowLayoutPanelPaymentDetails.ResumeLayout(false);
            this.flowLayoutPanelPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalEntry)).EndInit();
            this.tabPageJournalEntry.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtTransactionNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtReferenceNo;
        private System.Windows.Forms.Label label1;
        private JkComponents.JkTextBox txtReferenceNo2;
        private System.Windows.Forms.Label label2;
        private JkComponents.JkLookUpComboBox cmbSubsidiary;
        private System.Windows.Forms.Label label9;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.TabControl tabControlPaymentDetails;
        private System.Windows.Forms.TabPage tabPagePaymentDetails;
        private System.Windows.Forms.SplitContainer splitContainerPaymentDetails;
        private JkComponents.JkDetailDataSet dstJournalEntry;
        private JkComponents.JkDataGridView dataGridViewPaymentDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPaymentDetails;
        private System.Windows.Forms.Label label5;
        private JkComponents.JkTextBox txtAmountPaid;
        private System.Windows.Forms.Label label3;
        private JkComponents.JkTextBox txtAmountApplied;
        private System.Windows.Forms.Label label4;
        private JkComponents.JkTextBox txtBalance;
        private JkComponents.JkSeriesProvider jkSeriesProvider1;
        private JkComponents.JkDetailDataSet dstPaymentDetails;
        private JkComponents.JkLookUpComboBox cmbPaymentMethods;
        private JkComponents.JkLookUpComboBox cmbAccounts;
        private JkComponents.JkLookUpComboBox cmbSubsidiaryDetail;
        private System.Windows.Forms.TabPage tabPageJournalEntry;
        private JkComponents.JkDataGridView dataGridViewJournalEntry;
    }
}
