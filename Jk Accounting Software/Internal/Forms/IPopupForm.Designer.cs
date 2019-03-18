namespace Jk_Accounting_Software.Internal.Forms
{
    partial class IPopupForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPopupForm));
            this.splitContainerBase = new System.Windows.Forms.SplitContainer();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dstMaster = new JkComponents.JkDetailDataSet();
            this.dataGridView = new JkComponents.JkDataGridView();
            this.btnHolder = new System.Windows.Forms.ToolStrip();
            this.btnDone = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.lblFilter = new System.Windows.Forms.ToolStripLabel();
            this.cmbFilter = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.Panel2.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.btnHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBase.IsSplitterFixed = true;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBase.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerBase.Name = "splitContainerBase";
            this.splitContainerBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBase.Panel1
            // 
            this.splitContainerBase.Panel1.Controls.Add(this.lblCaption);
            // 
            // splitContainerBase.Panel2
            // 
            this.splitContainerBase.Panel2.Controls.Add(this.dstMaster);
            this.splitContainerBase.Panel2.Controls.Add(this.dataGridView);
            this.splitContainerBase.Panel2.Controls.Add(this.btnHolder);
            this.splitContainerBase.Size = new System.Drawing.Size(489, 452);
            this.splitContainerBase.SplitterDistance = 30;
            this.splitContainerBase.SplitterWidth = 1;
            this.splitContainerBase.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Maroon;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Gold;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(489, 30);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Popup Form";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dstMaster
            // 
            this.dstMaster.BackColor = System.Drawing.Color.Tan;
            this.dstMaster.CommandText = null;
            this.dstMaster.ConnectionString = "Data Source=.\\sqlexpress2014;Persist Security Info=True;User ID=sa;Password=maste" +
    "rkey;Initial Catalog=FreeAccountingSoftware";
            this.dstMaster.GridAutoSize = false;
            this.dstMaster.GridView = this.dataGridView;
            this.dstMaster.LinkToMaster = false;
            this.dstMaster.Location = new System.Drawing.Point(424, 43);
            this.dstMaster.Name = "dstMaster";
            this.dstMaster.Size = new System.Drawing.Size(53, 20);
            this.dstMaster.TabIndex = 2;
            this.dstMaster.Visible = false;
            this.dstMaster.ZLoadColumns = false;
            this.dstMaster.ZLoadGrid = false;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSet = this.dstMaster;
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
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(489, 396);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // btnHolder
            // 
            this.btnHolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDone,
            this.btnCancel,
            this.lblFilter,
            this.cmbFilter});
            this.btnHolder.Location = new System.Drawing.Point(0, 0);
            this.btnHolder.Name = "btnHolder";
            this.btnHolder.Size = new System.Drawing.Size(489, 25);
            this.btnHolder.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(55, 22);
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.Margin = new System.Windows.Forms.Padding(180, 1, 0, 2);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(33, 22);
            this.lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 25);
            this.cmbFilter.TextChanged += new System.EventHandler(this.cmbFilter_TextChanged);
            // 
            // IPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 452);
            this.Controls.Add(this.splitContainerBase);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IPopupForm";
            this.Text = "IPopupForm";
            this.splitContainerBase.Panel1.ResumeLayout(false);
            this.splitContainerBase.Panel2.ResumeLayout(false);
            this.splitContainerBase.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.btnHolder.ResumeLayout(false);
            this.btnHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.ToolStrip btnHolder;
        private System.Windows.Forms.ToolStripButton btnDone;
        private System.Windows.Forms.ToolStripButton btnCancel;
        public JkComponents.JkDetailDataSet dstMaster;
        public JkComponents.JkDataGridView dataGridView;
        private System.Windows.Forms.ToolStripLabel lblFilter;
        private System.Windows.Forms.ToolStripComboBox cmbFilter;
    }
}