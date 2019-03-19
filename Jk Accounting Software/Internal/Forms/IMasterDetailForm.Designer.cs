namespace Jk_Accounting_Software.Internal.Forms
{
    partial class IMasterDetailForm
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
            this.splitContainerMasterDetail = new System.Windows.Forms.SplitContainer();
            this.dstDetail = new JkComponents.JkDetailDataSet();
            this.dataGridView = new JkComponents.JkDataGridView();
            this.tabControlDetails = new System.Windows.Forms.TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).BeginInit();
            this.splitContainerMasterDetail.Panel1.SuspendLayout();
            this.splitContainerMasterDetail.Panel2.SuspendLayout();
            this.splitContainerMasterDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControlDetails.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 527);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerMasterDetail);
            this.splitContainer.Size = new System.Drawing.Size(836, 561);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(803, 0);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerMasterDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMasterDetail.IsSplitterFixed = true;
            this.splitContainerMasterDetail.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMasterDetail.Name = "splitContainerMasterDetail";
            this.splitContainerMasterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMasterDetail.Panel1
            // 
            this.splitContainerMasterDetail.Panel1.Controls.Add(this.dstDetail);
            // 
            // splitContainerMasterDetail.Panel2
            // 
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.tabControlDetails);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(836, 458);
            this.splitContainerMasterDetail.SplitterDistance = 195;
            this.splitContainerMasterDetail.SplitterWidth = 1;
            this.splitContainerMasterDetail.TabIndex = 0;
            // 
            // dstDetail
            // 
            this.dstDetail.BackColor = System.Drawing.Color.Tan;
            this.dstDetail.CommandText = "";
            this.dstDetail.ConnectionString = "Data Source=.\\sqlexpress2014;Initial Catalog=FreeAccountingSoftware;Persist Secur" +
    "ity Info=True;User ID=sa;Password=masterkey";
            this.dstDetail.GridAutoSize = false;
            this.dstDetail.GridView = this.dataGridView;
            this.dstDetail.LinkToMaster = true;
            this.dstDetail.Location = new System.Drawing.Point(731, 166);
            this.dstDetail.Name = "dstDetail";
            this.dstDetail.Size = new System.Drawing.Size(48, 20);
            this.dstDetail.TabIndex = 0;
            this.dstDetail.Visible = false;
            this.dstDetail.ZLoadColumns = false;
            this.dstDetail.ZLoadGrid = false;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSet = this.dstDetail;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Peru;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(818, 224);
            this.dataGridView.TabIndex = 19;
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageDetails);
            this.tabControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetails.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetails.Name = "tabControlDetails";
            this.tabControlDetails.SelectedIndex = 0;
            this.tabControlDetails.Size = new System.Drawing.Size(836, 262);
            this.tabControlDetails.TabIndex = 0;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageDetails.Controls.Add(this.dataGridView);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(828, 234);
            this.tabPageDetails.TabIndex = 0;
            this.tabPageDetails.Text = "Details";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // IMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Master Detail Form";
            this.Name = "IMasterDetailForm";
            this.Size = new System.Drawing.Size(836, 561);
            this.SetupData += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupDataHandler(this.IMasterDetailForm_SetupData);
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.IMasterDetailForm_SetupControl);
            this.ValidateSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.ValidateSaveHandler(this.IMasterDetailForm_ValidateSave);
            this.BeforeSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.BeforeSaveHandler(this.IMasterDetailForm_BeforeSave);
            this.Resize += new System.EventHandler(this.IMasterDetailForm_Resize);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel1.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).EndInit();
            this.splitContainerMasterDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControlDetails.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainerMasterDetail;
        protected JkComponents.JkDetailDataSet dstDetail;
        protected System.Windows.Forms.TabControl tabControlDetails;
        protected System.Windows.Forms.TabPage tabPageDetails;
        protected JkComponents.JkDataGridView dataGridView;

    }
}
