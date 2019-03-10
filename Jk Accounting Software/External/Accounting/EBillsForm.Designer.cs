﻿namespace Jk_Accounting_Software.External.Accounting
{
    partial class EBillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EBillsForm));
            this.jkSeriesProvider1 = new JkComponents.JkSeriesProvider();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrossAmount = new JkComponents.JkTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWTAX = new JkComponents.JkTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVATAmount = new JkComponents.JkTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new JkComponents.JkTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNetAmount = new JkComponents.JkTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new JkComponents.JkTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalance = new JkComponents.JkTextBox();
            this.cmbAccounts = new JkComponents.JkLookUpComboBox();
            this.cmbSubsidiaryDetail = new JkComponents.JkLookUpComboBox();
            this.cmbVATTypes = new JkComponents.JkLookUpComboBox();
            this.tabPageJournalEntry = new System.Windows.Forms.TabPage();
            this.dataGridViewJournalEntry = new JkComponents.JkDataGridView();
            this.dstJournalEntry = new JkComponents.JkDetailDataSet();
            this.cmbItems = new JkComponents.JkLookUpComboBox();
            this.flowLayoutPanelWTAX = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbATC = new JkComponents.JkLookUpComboBox();
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
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbATC);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanelWTAX);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbItems);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstJournalEntry);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbVATTypes);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbAccounts);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbSubsidiaryDetail);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.jkSeriesProvider1);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(837, 433);
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
            this.dstDetail.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstDetail.Columns14"))));
            this.dstDetail.CommandText = resources.GetString("dstDetail.CommandText");
            this.dstDetail.Location = new System.Drawing.Point(780, 228);
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageJournalEntry);
            this.tabControlDetails.Size = new System.Drawing.Size(837, 174);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageJournalEntry, 0);
            this.tabControlDetails.Controls.SetChildIndex(this.tabPageDetails, 0);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Size = new System.Drawing.Size(829, 146);
            // 
            // splitContainer
            // 
            this.splitContainer.Size = new System.Drawing.Size(837, 536);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(804, 0);
            // 
            // jkSeriesProvider1
            // 
            this.jkSeriesProvider1.BackColor = System.Drawing.Color.Tan;
            this.jkSeriesProvider1.Code = "B";
            this.jkSeriesProvider1.CompanyId = null;
            this.jkSeriesProvider1.ConnectionString = null;
            this.jkSeriesProvider1.Location = new System.Drawing.Point(739, 202);
            this.jkSeriesProvider1.Name = "jkSeriesProvider1";
            this.jkSeriesProvider1.Size = new System.Drawing.Size(89, 20);
            this.jkSeriesProvider1.TabIndex = 1;
            this.jkSeriesProvider1.Text = "jkSeriesProvider1";
            this.jkSeriesProvider1.TransactionColumn = "TransactionNo";
            this.jkSeriesProvider1.Value = null;
            this.jkSeriesProvider1.Visible = false;
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 255);
            this.flowLayoutPanel2.TabIndex = 16;
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
            this.label7.Text = "Reference No.:";
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
            this.label1.Text = "Reference No 2.:";
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
            this.cmbSubsidiary.SelectedKey = 0;
            this.cmbSubsidiary.Size = new System.Drawing.Size(205, 23);
            this.cmbSubsidiary.TabIndex = 15;
            this.cmbSubsidiary.SelectedValueChanged += new System.EventHandler(this.cmbSubsidiary_SelectedValueChanged);
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
            this.txtRemarks.Size = new System.Drawing.Size(205, 76);
            this.txtRemarks.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtGrossAmount);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.txtWTAX);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtVATAmount);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtDiscountAmount);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txtNetAmount);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txtPaidAmount);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txtBalance);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(342, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 255);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gross Amount:";
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
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label13.Size = new System.Drawing.Size(116, 27);
            this.label13.TabIndex = 3;
            this.label13.Text = "Withholding Tax:";
            // 
            // txtWTAX
            // 
            this.txtWTAX.BackColor = System.Drawing.Color.White;
            this.txtWTAX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWTAX.Location = new System.Drawing.Point(122, 32);
            this.txtWTAX.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtWTAX.Name = "txtWTAX";
            this.txtWTAX.ReadOnly = true;
            this.txtWTAX.Required = false;
            this.txtWTAX.Size = new System.Drawing.Size(90, 16);
            this.txtWTAX.TabIndex = 4;
            this.txtWTAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "VAT Amount:";
            // 
            // txtVATAmount
            // 
            this.txtVATAmount.BackColor = System.Drawing.Color.White;
            this.txtVATAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVATAmount.Location = new System.Drawing.Point(122, 59);
            this.txtVATAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtVATAmount.Name = "txtVATAmount";
            this.txtVATAmount.ReadOnly = true;
            this.txtVATAmount.Required = false;
            this.txtVATAmount.Size = new System.Drawing.Size(90, 16);
            this.txtVATAmount.TabIndex = 4;
            this.txtVATAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discount Amount:";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BackColor = System.Drawing.Color.White;
            this.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscountAmount.Location = new System.Drawing.Point(122, 86);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Required = false;
            this.txtDiscountAmount.Size = new System.Drawing.Size(90, 16);
            this.txtDiscountAmount.TabIndex = 6;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label10.Size = new System.Drawing.Size(116, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "Net Amount:";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.Color.White;
            this.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNetAmount.Location = new System.Drawing.Point(122, 113);
            this.txtNetAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Required = false;
            this.txtNetAmount.Size = new System.Drawing.Size(90, 16);
            this.txtNetAmount.TabIndex = 8;
            this.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label11.Size = new System.Drawing.Size(116, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "Paid Amount:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.Color.White;
            this.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmount.Location = new System.Drawing.Point(122, 140);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Required = false;
            this.txtPaidAmount.Size = new System.Drawing.Size(90, 16);
            this.txtPaidAmount.TabIndex = 10;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label12.Size = new System.Drawing.Size(116, 27);
            this.label12.TabIndex = 11;
            this.label12.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Location = new System.Drawing.Point(122, 167);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Required = false;
            this.txtBalance.Size = new System.Drawing.Size(90, 16);
            this.txtBalance.TabIndex = 12;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cmbAccounts.Location = new System.Drawing.Point(762, 144);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Required = false;
            this.cmbAccounts.SelectedKey = 0;
            this.cmbAccounts.Size = new System.Drawing.Size(66, 23);
            this.cmbAccounts.TabIndex = 20;
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
            this.cmbSubsidiaryDetail.Location = new System.Drawing.Point(762, 175);
            this.cmbSubsidiaryDetail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbSubsidiaryDetail.Name = "cmbSubsidiaryDetail";
            this.cmbSubsidiaryDetail.Required = false;
            this.cmbSubsidiaryDetail.SelectedKey = 0;
            this.cmbSubsidiaryDetail.Size = new System.Drawing.Size(66, 23);
            this.cmbSubsidiaryDetail.TabIndex = 19;
            this.cmbSubsidiaryDetail.Visible = false;
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
            this.cmbVATTypes.Location = new System.Drawing.Point(762, 114);
            this.cmbVATTypes.Name = "cmbVATTypes";
            this.cmbVATTypes.Required = false;
            this.cmbVATTypes.SelectedKey = 0;
            this.cmbVATTypes.Size = new System.Drawing.Size(66, 23);
            this.cmbVATTypes.TabIndex = 21;
            this.cmbVATTypes.Visible = false;
            // 
            // tabPageJournalEntry
            // 
            this.tabPageJournalEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageJournalEntry.Controls.Add(this.dataGridViewJournalEntry);
            this.tabPageJournalEntry.Location = new System.Drawing.Point(4, 24);
            this.tabPageJournalEntry.Name = "tabPageJournalEntry";
            this.tabPageJournalEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJournalEntry.Size = new System.Drawing.Size(825, 146);
            this.tabPageJournalEntry.TabIndex = 1;
            this.tabPageJournalEntry.Text = "Journal Entry";
            this.tabPageJournalEntry.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJournalEntry
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridViewJournalEntry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJournalEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridViewJournalEntry.Size = new System.Drawing.Size(815, 136);
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
            this.dstJournalEntry.Location = new System.Drawing.Point(747, 54);
            this.dstJournalEntry.Name = "dstJournalEntry";
            this.dstJournalEntry.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstJournalEntry.Parameters"))));
            this.dstJournalEntry.Size = new System.Drawing.Size(81, 20);
            this.dstJournalEntry.TabIndex = 22;
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
            this.cmbItems.Location = new System.Drawing.Point(762, 85);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Required = false;
            this.cmbItems.SelectedKey = 0;
            this.cmbItems.Size = new System.Drawing.Size(66, 23);
            this.cmbItems.TabIndex = 23;
            this.cmbItems.Visible = false;
            // 
            // flowLayoutPanelWTAX
            // 
            this.flowLayoutPanelWTAX.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelWTAX.Location = new System.Drawing.Point(572, 0);
            this.flowLayoutPanelWTAX.Name = "flowLayoutPanelWTAX";
            this.flowLayoutPanelWTAX.Size = new System.Drawing.Size(169, 255);
            this.flowLayoutPanelWTAX.TabIndex = 24;
            // 
            // cmbATC
            // 
            this.cmbATC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbATC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbATC.DataSet = "dstATC";
            this.cmbATC.DisplayText = "CodeRate";
            this.cmbATC.ForeColor = System.Drawing.Color.Black;
            this.cmbATC.FormattingEnabled = true;
            this.cmbATC.Key = "Id";
            this.cmbATC.Location = new System.Drawing.Point(762, 24);
            this.cmbATC.Name = "cmbATC";
            this.cmbATC.Required = false;
            this.cmbATC.SelectedKey = 0;
            this.cmbATC.Size = new System.Drawing.Size(66, 23);
            this.cmbATC.TabIndex = 25;
            this.cmbATC.Visible = false;
            // 
            // EBillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Bill";
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
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns21"))));
            this.Name = "EBillsForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(837, 536);
            this.ZLoadMasterColumns = true;
            this.BeforeSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.BeforeSaveHandler(this.EPurchaseVoucherForm_BeforeSave);
            this.AfterRun += new Jk_Accounting_Software.Internal.Forms.IParentForm.AfterRunHandler(this.EPurchaseVoucherForm_AfterRun);
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

        private JkComponents.JkSeriesProvider jkSeriesProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtTransactionNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtReferenceNo;
        private System.Windows.Forms.Label label1;
        private JkComponents.JkTextBox txtReferenceNo2;
        private System.Windows.Forms.Label label9;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private JkComponents.JkLookUpComboBox cmbSubsidiary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private JkComponents.JkTextBox txtGrossAmount;
        private System.Windows.Forms.Label label4;
        private JkComponents.JkTextBox txtVATAmount;
        private System.Windows.Forms.Label label5;
        private JkComponents.JkTextBox txtDiscountAmount;
        private System.Windows.Forms.Label label10;
        private JkComponents.JkTextBox txtNetAmount;
        private System.Windows.Forms.Label label11;
        private JkComponents.JkTextBox txtPaidAmount;
        private System.Windows.Forms.Label label12;
        private JkComponents.JkTextBox txtBalance;
        private JkComponents.JkLookUpComboBox cmbVATTypes;
        private JkComponents.JkLookUpComboBox cmbAccounts;
        private JkComponents.JkLookUpComboBox cmbSubsidiaryDetail;
        private JkComponents.JkDataGridView dataGridViewJournalEntry;
        private System.Windows.Forms.TabPage tabPageJournalEntry;
        private JkComponents.JkDetailDataSet dstJournalEntry;
        private JkComponents.JkLookUpComboBox cmbItems;
        private JkComponents.JkTextBox txtWTAX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWTAX;
        private JkComponents.JkLookUpComboBox cmbATC;
    }
}