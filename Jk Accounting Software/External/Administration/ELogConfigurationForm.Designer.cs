namespace Jk_Accounting_Software.External.Administration
{
    partial class ELogConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELogConfigurationForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTableName = new JkComponents.JkTextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtCaption = new JkComponents.JkTextBox();
            this.lblIdentifierColumnName = new System.Windows.Forms.Label();
            this.txtIdentifierColumnName = new JkComponents.JkTextBox();
            this.lblSeparatorColumnName = new System.Windows.Forms.Label();
            this.txtSeparatorColumnName = new JkComponents.JkTextBox();
            this.lblSeparatorColumnId = new System.Windows.Forms.Label();
            this.txtSeparatorColumnId = new JkComponents.JkTextBox();
            this.lblTrack = new System.Windows.Forms.Label();
            this.chkTrack = new System.Windows.Forms.CheckBox();
            this.lblEnable = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.lblTriggerName = new System.Windows.Forms.Label();
            this.txtTriggerName = new JkComponents.JkTextBox();
            this.tabControlChildTables = new System.Windows.Forms.TabControl();
            this.tabPageChildTables = new System.Windows.Forms.TabPage();
            this.datagridViewChildTables = new JkComponents.JkDataGridView();
            this.dstChildTables = new JkComponents.JkDetailDataSet();
            this.cmbSystemLogTableConfig = new JkComponents.JkLookUpComboBox();
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
            this.tabControlChildTables.SuspendLayout();
            this.tabPageChildTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewChildTables)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMasterDetail
            // 
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.cmbSystemLogTableConfig);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstChildTables);
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.tabControlChildTables);
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
            this.dstDetail.CommandText = "SELECT Id, TableId, ColumnName, Caption, DataType,\r\n\t[Index], Track, TableSource," +
    " TableSourceResult\r\nFROM tblSystemLogColumnConfig\r\nWHERE TableId = @Id";
            this.dstDetail.Location = new System.Drawing.Point(779, 134);
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Size = new System.Drawing.Size(836, 184);
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
            this.flowLayoutPanel2.Controls.Add(this.lblTableName);
            this.flowLayoutPanel2.Controls.Add(this.txtTableName);
            this.flowLayoutPanel2.Controls.Add(this.lblCaption);
            this.flowLayoutPanel2.Controls.Add(this.txtCaption);
            this.flowLayoutPanel2.Controls.Add(this.lblIdentifierColumnName);
            this.flowLayoutPanel2.Controls.Add(this.txtIdentifierColumnName);
            this.flowLayoutPanel2.Controls.Add(this.lblSeparatorColumnName);
            this.flowLayoutPanel2.Controls.Add(this.txtSeparatorColumnName);
            this.flowLayoutPanel2.Controls.Add(this.lblSeparatorColumnId);
            this.flowLayoutPanel2.Controls.Add(this.txtSeparatorColumnId);
            this.flowLayoutPanel2.Controls.Add(this.lblTrack);
            this.flowLayoutPanel2.Controls.Add(this.chkTrack);
            this.flowLayoutPanel2.Controls.Add(this.lblEnable);
            this.flowLayoutPanel2.Controls.Add(this.chkEnable);
            this.flowLayoutPanel2.Controls.Add(this.lblTriggerName);
            this.flowLayoutPanel2.Controls.Add(this.txtTriggerName);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(402, 255);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // lblTableName
            // 
            this.lblTableName.Location = new System.Drawing.Point(0, 0);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTableName.Size = new System.Drawing.Size(155, 25);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.White;
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Location = new System.Drawing.Point(161, 5);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Required = false;
            this.txtTableName.Size = new System.Drawing.Size(230, 16);
            this.txtTableName.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(0, 26);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblCaption.Size = new System.Drawing.Size(155, 25);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Caption:";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(161, 31);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Required = false;
            this.txtCaption.Size = new System.Drawing.Size(230, 23);
            this.txtCaption.TabIndex = 2;
            // 
            // lblIdentifierColumnName
            // 
            this.lblIdentifierColumnName.Location = new System.Drawing.Point(0, 59);
            this.lblIdentifierColumnName.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdentifierColumnName.Name = "lblIdentifierColumnName";
            this.lblIdentifierColumnName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblIdentifierColumnName.Size = new System.Drawing.Size(155, 25);
            this.lblIdentifierColumnName.TabIndex = 13;
            this.lblIdentifierColumnName.Text = "Identifier Column Name:";
            // 
            // txtIdentifierColumnName
            // 
            this.txtIdentifierColumnName.Location = new System.Drawing.Point(161, 64);
            this.txtIdentifierColumnName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtIdentifierColumnName.Name = "txtIdentifierColumnName";
            this.txtIdentifierColumnName.Required = false;
            this.txtIdentifierColumnName.Size = new System.Drawing.Size(230, 23);
            this.txtIdentifierColumnName.TabIndex = 14;
            // 
            // lblSeparatorColumnName
            // 
            this.lblSeparatorColumnName.Location = new System.Drawing.Point(0, 92);
            this.lblSeparatorColumnName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeparatorColumnName.Name = "lblSeparatorColumnName";
            this.lblSeparatorColumnName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblSeparatorColumnName.Size = new System.Drawing.Size(155, 25);
            this.lblSeparatorColumnName.TabIndex = 15;
            this.lblSeparatorColumnName.Text = "Separator Column Name:";
            // 
            // txtSeparatorColumnName
            // 
            this.txtSeparatorColumnName.Location = new System.Drawing.Point(161, 97);
            this.txtSeparatorColumnName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSeparatorColumnName.Name = "txtSeparatorColumnName";
            this.txtSeparatorColumnName.Required = false;
            this.txtSeparatorColumnName.Size = new System.Drawing.Size(230, 23);
            this.txtSeparatorColumnName.TabIndex = 16;
            // 
            // lblSeparatorColumnId
            // 
            this.lblSeparatorColumnId.Location = new System.Drawing.Point(0, 125);
            this.lblSeparatorColumnId.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeparatorColumnId.Name = "lblSeparatorColumnId";
            this.lblSeparatorColumnId.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblSeparatorColumnId.Size = new System.Drawing.Size(155, 25);
            this.lblSeparatorColumnId.TabIndex = 17;
            this.lblSeparatorColumnId.Text = "Separator Column Id:";
            // 
            // txtSeparatorColumnId
            // 
            this.txtSeparatorColumnId.Location = new System.Drawing.Point(161, 130);
            this.txtSeparatorColumnId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSeparatorColumnId.Name = "txtSeparatorColumnId";
            this.txtSeparatorColumnId.Required = false;
            this.txtSeparatorColumnId.Size = new System.Drawing.Size(230, 23);
            this.txtSeparatorColumnId.TabIndex = 18;
            // 
            // lblTrack
            // 
            this.lblTrack.Location = new System.Drawing.Point(0, 158);
            this.lblTrack.Margin = new System.Windows.Forms.Padding(0);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTrack.Size = new System.Drawing.Size(155, 25);
            this.lblTrack.TabIndex = 8;
            this.lblTrack.Text = "Track:";
            // 
            // chkTrack
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkTrack, true);
            this.chkTrack.Location = new System.Drawing.Point(161, 163);
            this.chkTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTrack.Name = "chkTrack";
            this.chkTrack.Size = new System.Drawing.Size(15, 25);
            this.chkTrack.TabIndex = 5;
            this.chkTrack.UseVisualStyleBackColor = true;
            // 
            // lblEnable
            // 
            this.lblEnable.Location = new System.Drawing.Point(0, 193);
            this.lblEnable.Margin = new System.Windows.Forms.Padding(0);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblEnable.Size = new System.Drawing.Size(155, 25);
            this.lblEnable.TabIndex = 10;
            this.lblEnable.Text = "Enable:";
            // 
            // chkEnable
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkEnable, true);
            this.chkEnable.Location = new System.Drawing.Point(161, 198);
            this.chkEnable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(15, 25);
            this.chkEnable.TabIndex = 9;
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // lblTriggerName
            // 
            this.lblTriggerName.Location = new System.Drawing.Point(0, 228);
            this.lblTriggerName.Margin = new System.Windows.Forms.Padding(0);
            this.lblTriggerName.Name = "lblTriggerName";
            this.lblTriggerName.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblTriggerName.Size = new System.Drawing.Size(155, 25);
            this.lblTriggerName.TabIndex = 11;
            this.lblTriggerName.Text = "Trigger Name:";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.BackColor = System.Drawing.Color.White;
            this.txtTriggerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTriggerName.Location = new System.Drawing.Point(161, 233);
            this.txtTriggerName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.ReadOnly = true;
            this.txtTriggerName.Required = false;
            this.txtTriggerName.Size = new System.Drawing.Size(230, 16);
            this.txtTriggerName.TabIndex = 12;
            // 
            // tabControlChildTables
            // 
            this.tabControlChildTables.Controls.Add(this.tabPageChildTables);
            this.tabControlChildTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlChildTables.Location = new System.Drawing.Point(402, 0);
            this.tabControlChildTables.Name = "tabControlChildTables";
            this.tabControlChildTables.SelectedIndex = 0;
            this.tabControlChildTables.Size = new System.Drawing.Size(265, 255);
            this.tabControlChildTables.TabIndex = 15;
            // 
            // tabPageChildTables
            // 
            this.tabPageChildTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageChildTables.Controls.Add(this.datagridViewChildTables);
            this.tabPageChildTables.Location = new System.Drawing.Point(4, 24);
            this.tabPageChildTables.Name = "tabPageChildTables";
            this.tabPageChildTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChildTables.Size = new System.Drawing.Size(257, 227);
            this.tabPageChildTables.TabIndex = 0;
            this.tabPageChildTables.Text = "Child Tables";
            this.tabPageChildTables.UseVisualStyleBackColor = true;
            // 
            // datagridViewChildTables
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.datagridViewChildTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridViewChildTables.AutoGenerateColumns = false;
            this.datagridViewChildTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewChildTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridViewChildTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewChildTables.DataSet = this.dstChildTables;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewChildTables.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridViewChildTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridViewChildTables.GridColor = System.Drawing.Color.Peru;
            this.datagridViewChildTables.Location = new System.Drawing.Point(3, 3);
            this.datagridViewChildTables.Name = "datagridViewChildTables";
            this.datagridViewChildTables.Size = new System.Drawing.Size(247, 217);
            this.datagridViewChildTables.TabIndex = 0;
            // 
            // dstChildTables
            // 
            this.dstChildTables.BackColor = System.Drawing.Color.Tan;
            this.dstChildTables.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstChildTables.Columns"))));
            this.dstChildTables.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstChildTables.Columns1"))));
            this.dstChildTables.Columns.Add(((JkComponents.JkDetailColumn)(resources.GetObject("dstChildTables.Columns2"))));
            this.dstChildTables.CommandText = "SELECT Id, TableId, ChildTableId\r\nFROM tblSystemLogTableLinks\r\nWHERE TableId = @I" +
    "d";
            this.dstChildTables.ConnectionString = "Data Source=.\\sqlexpress2014;Initial Catalog=FreeAccountingSoftware;Persist Secur" +
    "ity Info=True;User ID=sa;Password=masterkey";
            this.dstChildTables.GridAutoSize = true;
            this.dstChildTables.GridView = this.datagridViewChildTables;
            this.dstChildTables.LinkToMaster = true;
            this.dstChildTables.Location = new System.Drawing.Point(741, 163);
            this.dstChildTables.Name = "dstChildTables";
            this.dstChildTables.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstChildTables.Parameters"))));
            this.dstChildTables.Size = new System.Drawing.Size(75, 20);
            this.dstChildTables.TabIndex = 16;
            this.dstChildTables.Visible = false;
            this.dstChildTables.ZLoadColumns = true;
            this.dstChildTables.ZLoadGrid = true;
            // 
            // cmbSystemLogTableConfig
            // 
            this.cmbSystemLogTableConfig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSystemLogTableConfig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSystemLogTableConfig.DataSet = "dstSystemLogTableConfig";
            this.cmbSystemLogTableConfig.DisplayText = "TableName";
            this.cmbSystemLogTableConfig.ForeColor = System.Drawing.Color.Black;
            this.cmbSystemLogTableConfig.FormattingEnabled = true;
            this.cmbSystemLogTableConfig.Key = "Id";
            this.cmbSystemLogTableConfig.Location = new System.Drawing.Point(770, 105);
            this.cmbSystemLogTableConfig.Name = "cmbSystemLogTableConfig";
            this.cmbSystemLogTableConfig.Required = false;
            this.cmbSystemLogTableConfig.Size = new System.Drawing.Size(57, 23);
            this.cmbSystemLogTableConfig.TabIndex = 17;
            this.cmbSystemLogTableConfig.Visible = false;
            // 
            // ELogConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Log Configuration";
            this.CommandText = "SELECT Id, TableName, Caption, IdentifierColumnName,\r\n\tSeparatorColumnName, Separ" +
    "atorColumnId, Track,\r\n\t[Enable], TriggerName\r\nFROM tblSystemLogTableConfig\r\nWHER" +
    "E Id = @Id";
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns1"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns2"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns3"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns4"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns5"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns6"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns7"))));
            this.Name = "ELogConfigurationForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.AfterSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.AfterSaveHandler(this.ELogConfigurationForm_AfterSave);
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
            this.tabControlChildTables.ResumeLayout(false);
            this.tabPageChildTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewChildTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblTableName;
        private JkComponents.JkTextBox txtTableName;
        private System.Windows.Forms.Label lblCaption;
        private JkComponents.JkTextBox txtCaption;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.CheckBox chkTrack;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label lblTriggerName;
        private JkComponents.JkTextBox txtTriggerName;
        private System.Windows.Forms.Label lblIdentifierColumnName;
        private JkComponents.JkTextBox txtIdentifierColumnName;
        private System.Windows.Forms.Label lblSeparatorColumnName;
        private JkComponents.JkTextBox txtSeparatorColumnName;
        private System.Windows.Forms.Label lblSeparatorColumnId;
        private JkComponents.JkTextBox txtSeparatorColumnId;
        private System.Windows.Forms.TabControl tabControlChildTables;
        private System.Windows.Forms.TabPage tabPageChildTables;
        private JkComponents.JkDetailDataSet dstChildTables;
        private JkComponents.JkDataGridView datagridViewChildTables;
        private JkComponents.JkLookUpComboBox cmbSystemLogTableConfig;
    }
}
