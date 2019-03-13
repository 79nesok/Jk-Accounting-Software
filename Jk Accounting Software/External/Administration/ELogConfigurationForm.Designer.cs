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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELogConfigurationForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTableName = new JkComponents.JkTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCaption = new JkComponents.JkTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkTrack = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTriggerName = new JkComponents.JkTextBox();
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
            this.SuspendLayout();
            // 
            // splitContainerMasterDetail
            // 
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(836, 433);
            this.splitContainerMasterDetail.SplitterDistance = 170;
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
            this.dstDetail.CommandText = "SELECT Id, TableId, ColumnName, Caption,\r\n\tDataType, [Index], Track, TableSource\r" +
    "\nFROM tblSystemLogColumnConfig\r\nWHERE TableId = @Id";
            this.dstDetail.Location = new System.Drawing.Point(779, 158);
            this.dstDetail.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("dstDetail.Parameters"))));
            this.dstDetail.ZLoadColumns = true;
            this.dstDetail.ZLoadGrid = true;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Size = new System.Drawing.Size(836, 259);
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Size = new System.Drawing.Size(828, 231);
            // 
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(728, 0);
            // 
            // FormFooter
            // 
            this.FormFooter.Size = new System.Drawing.Size(836, 34);
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
            this.flowLayoutPanel2.Controls.Add(this.txtTableName);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtCaption);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.chkTrack);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.chkEnable);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtTriggerName);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 170);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Table Name:";
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.White;
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Location = new System.Drawing.Point(151, 5);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Required = false;
            this.txtTableName.Size = new System.Drawing.Size(230, 16);
            this.txtTableName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Caption:";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(151, 31);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Required = false;
            this.txtCaption.Size = new System.Drawing.Size(230, 23);
            this.txtCaption.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Track:";
            // 
            // chkTrack
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkTrack, true);
            this.chkTrack.Location = new System.Drawing.Point(151, 64);
            this.chkTrack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkTrack.Name = "chkTrack";
            this.chkTrack.Size = new System.Drawing.Size(15, 25);
            this.chkTrack.TabIndex = 5;
            this.chkTrack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enable:";
            // 
            // chkEnable
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkEnable, true);
            this.chkEnable.Location = new System.Drawing.Point(151, 99);
            this.chkEnable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(15, 25);
            this.chkEnable.TabIndex = 9;
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trigger Name:";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.BackColor = System.Drawing.Color.White;
            this.txtTriggerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTriggerName.Location = new System.Drawing.Point(151, 134);
            this.txtTriggerName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.ReadOnly = true;
            this.txtTriggerName.Required = false;
            this.txtTriggerName.Size = new System.Drawing.Size(230, 16);
            this.txtTriggerName.TabIndex = 12;
            // 
            // ELogConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Log Configuration";
            this.CommandText = "SELECT Id, TableName, Caption, Track,\r\n\t[Enable], TriggerName\r\nFROM tblSystemLogT" +
    "ableConfig\r\nWHERE Id = @Id";
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns1"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns2"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns3"))));
            this.MasterColumns.Add(((JkComponents.JkMasterColumn)(resources.GetObject("$this.MasterColumns4"))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtTableName;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtCaption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label label2;
        private JkComponents.JkTextBox txtTriggerName;
    }
}
