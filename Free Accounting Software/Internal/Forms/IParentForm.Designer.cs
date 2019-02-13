namespace Free_Accounting_Software.Internal.Forms
{
    partial class IParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IParentForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnNavigator = new System.Windows.Forms.ToolStrip();
            this.btnFirstRecord = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSeparatorFirst = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreviousRecord = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSeparatorSecond = new System.Windows.Forms.ToolStripSeparator();
            this.txtRecordCount = new System.Windows.Forms.ToolStripTextBox();
            this.NavigatorSeparatorThird = new System.Windows.Forms.ToolStripSeparator();
            this.btnNextRecord = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSeparatorFourth = new System.Windows.Forms.ToolStripSeparator();
            this.btnLastRecord = new System.Windows.Forms.ToolStripButton();
            this.btnHolder = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanelTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.btnNavigator.SuspendLayout();
            this.btnHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanelTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Size = new System.Drawing.Size(852, 476);
            this.splitContainer.SplitterDistance = 68;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 3;
            // 
            // flowLayoutPanelTop
            // 
            this.flowLayoutPanelTop.AutoSize = true;
            this.flowLayoutPanelTop.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelTop.Controls.Add(this.panelTop);
            this.flowLayoutPanelTop.Controls.Add(this.panelButton);
            this.flowLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            this.flowLayoutPanelTop.Size = new System.Drawing.Size(852, 68);
            this.flowLayoutPanelTop.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.lblCaption);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(852, 40);
            this.panelTop.TabIndex = 7;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Maroon;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(815, 40);
            this.lblCaption.TabIndex = 10;
            this.lblCaption.Text = "Parent Form";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Location = new System.Drawing.Point(815, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panelButton
            // 
            this.panelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButton.Controls.Add(this.btnNavigator);
            this.panelButton.Controls.Add(this.btnHolder);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 40);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(852, 26);
            this.panelButton.TabIndex = 12;
            // 
            // btnNavigator
            // 
            this.btnNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNavigator.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstRecord,
            this.NavigatorSeparatorFirst,
            this.btnPreviousRecord,
            this.NavigatorSeparatorSecond,
            this.txtRecordCount,
            this.NavigatorSeparatorThird,
            this.btnNextRecord,
            this.NavigatorSeparatorFourth,
            this.btnLastRecord});
            this.btnNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.btnNavigator.Location = new System.Drawing.Point(626, 0);
            this.btnNavigator.Name = "btnNavigator";
            this.btnNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.btnNavigator.Size = new System.Drawing.Size(226, 26);
            this.btnNavigator.Stretch = true;
            this.btnNavigator.TabIndex = 18;
            this.btnNavigator.Text = "toolStrip1";
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstRecord.Image")));
            this.btnFirstRecord.ImageTransparentColor = System.Drawing.Color.White;
            this.btnFirstRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(23, 26);
            this.btnFirstRecord.Tag = "1";
            this.btnFirstRecord.ToolTipText = "Shows the first record";
            // 
            // NavigatorSeparatorFirst
            // 
            this.NavigatorSeparatorFirst.Name = "NavigatorSeparatorFirst";
            this.NavigatorSeparatorFirst.Size = new System.Drawing.Size(6, 26);
            // 
            // btnPreviousRecord
            // 
            this.btnPreviousRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPreviousRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousRecord.Image")));
            this.btnPreviousRecord.ImageTransparentColor = System.Drawing.Color.White;
            this.btnPreviousRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreviousRecord.Name = "btnPreviousRecord";
            this.btnPreviousRecord.Size = new System.Drawing.Size(31, 26);
            this.btnPreviousRecord.Tag = "2";
            this.btnPreviousRecord.Text = " ";
            this.btnPreviousRecord.ToolTipText = "Shows the previous record";
            // 
            // NavigatorSeparatorSecond
            // 
            this.NavigatorSeparatorSecond.Name = "NavigatorSeparatorSecond";
            this.NavigatorSeparatorSecond.Size = new System.Drawing.Size(6, 26);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Margin = new System.Windows.Forms.Padding(0);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(75, 26);
            this.txtRecordCount.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecordCount.ToolTipText = "Shows the current record count";
            // 
            // NavigatorSeparatorThird
            // 
            this.NavigatorSeparatorThird.Name = "NavigatorSeparatorThird";
            this.NavigatorSeparatorThird.Size = new System.Drawing.Size(6, 26);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnNextRecord.Image")));
            this.btnNextRecord.ImageTransparentColor = System.Drawing.Color.White;
            this.btnNextRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(31, 26);
            this.btnNextRecord.Tag = "3";
            this.btnNextRecord.Text = " ";
            this.btnNextRecord.ToolTipText = "Shows the next record";
            // 
            // NavigatorSeparatorFourth
            // 
            this.NavigatorSeparatorFourth.Name = "NavigatorSeparatorFourth";
            this.NavigatorSeparatorFourth.Size = new System.Drawing.Size(6, 26);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnLastRecord.Image")));
            this.btnLastRecord.ImageTransparentColor = System.Drawing.Color.White;
            this.btnLastRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(31, 26);
            this.btnLastRecord.Tag = "4";
            this.btnLastRecord.Text = " ";
            this.btnLastRecord.ToolTipText = "Shows the last record";
            // 
            // btnHolder
            // 
            this.btnHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnSave,
            this.btnCancel,
            this.btnPrint});
            this.btnHolder.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.btnHolder.Location = new System.Drawing.Point(0, 0);
            this.btnHolder.Name = "btnHolder";
            this.btnHolder.Size = new System.Drawing.Size(307, 26);
            this.btnHolder.Stretch = true;
            this.btnHolder.TabIndex = 16;
            this.btnHolder.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 23);
            this.btnNew.Text = "&New";
            this.btnNew.ToolTipText = "Create new transaction (Alt+N)";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 23);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.ToolTipText = "Modify the transaction (Alt+E)";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.Text = "&Save";
            this.btnSave.ToolTipText = "Save the transaction (Alt+S)";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.ToolTipText = "Cancel the current transaction (Alt+C)";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 23);
            this.btnPrint.Text = "&Print";
            this.btnPrint.ToolTipText = "Opens the printing window";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // IParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IParentForm";
            this.Size = new System.Drawing.Size(852, 476);
            this.Resize += new System.EventHandler(this.IParentForm_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanelTop.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.btnNavigator.ResumeLayout(false);
            this.btnNavigator.PerformLayout();
            this.btnHolder.ResumeLayout(false);
            this.btnHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTop;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelButton;
        protected System.Windows.Forms.ToolStrip btnNavigator;
        protected System.Windows.Forms.ToolStripButton btnFirstRecord;
        private System.Windows.Forms.ToolStripSeparator NavigatorSeparatorFirst;
        protected System.Windows.Forms.ToolStripButton btnPreviousRecord;
        private System.Windows.Forms.ToolStripSeparator NavigatorSeparatorSecond;
        protected System.Windows.Forms.ToolStripTextBox txtRecordCount;
        private System.Windows.Forms.ToolStripSeparator NavigatorSeparatorThird;
        protected System.Windows.Forms.ToolStripButton btnNextRecord;
        private System.Windows.Forms.ToolStripSeparator NavigatorSeparatorFourth;
        protected System.Windows.Forms.ToolStripButton btnLastRecord;
        protected System.Windows.Forms.ToolStrip btnHolder;
        protected System.Windows.Forms.ToolStripButton btnNew;
        protected System.Windows.Forms.ToolStripButton btnEdit;
        protected System.Windows.Forms.ToolStripButton btnSave;
        protected System.Windows.Forms.ToolStripButton btnCancel;
        protected System.Windows.Forms.ToolStripButton btnPrint;
    }
}

