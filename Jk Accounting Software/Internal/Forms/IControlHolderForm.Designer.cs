namespace Jk_Accounting_Software
{
    partial class IControlHolderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IControlHolderForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.MenuItemActions = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerBase = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelSide = new System.Windows.Forms.TableLayoutPanel();
            this.panelSideBottom = new System.Windows.Forms.Panel();
            this.groupBoxLoginDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLoginDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCompanyValue = new System.Windows.Forms.Label();
            this.lblUserValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            this.panelSideBottom.SuspendLayout();
            this.groupBoxLoginDetails.SuspendLayout();
            this.tableLayoutPanelLoginDetails.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cabinet.png");
            // 
            // timerDuration
            // 
            this.timerDuration.Interval = 1000;
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemActions,
            this.MenuItemHelp,
            this.MenuItemAbout});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // MenuItemActions
            // 
            this.MenuItemActions.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRefresh,
            this.MenuItemLogout,
            this.MenuItemRestart});
            this.MenuItemActions.ForeColor = System.Drawing.Color.Black;
            this.MenuItemActions.Name = "MenuItemActions";
            this.MenuItemActions.Size = new System.Drawing.Size(70, 20);
            this.MenuItemActions.Text = "&ACTIONS";
            // 
            // MenuItemRefresh
            // 
            this.MenuItemRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemRefresh.ForeColor = System.Drawing.Color.Black;
            this.MenuItemRefresh.Name = "MenuItemRefresh";
            this.MenuItemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuItemRefresh.Size = new System.Drawing.Size(156, 22);
            this.MenuItemRefresh.Text = "&Refresh";
            this.MenuItemRefresh.Click += new System.EventHandler(this.MenuItemRefresh_Click);
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemLogout.ForeColor = System.Drawing.Color.Black;
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemLogout.Size = new System.Drawing.Size(156, 22);
            this.MenuItemLogout.Text = "&Logout";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // MenuItemRestart
            // 
            this.MenuItemRestart.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemRestart.ForeColor = System.Drawing.Color.Black;
            this.MenuItemRestart.Name = "MenuItemRestart";
            this.MenuItemRestart.Size = new System.Drawing.Size(156, 22);
            this.MenuItemRestart.Text = "R&estart";
            this.MenuItemRestart.Click += new System.EventHandler(this.MenuItemRestart_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemHelp.ForeColor = System.Drawing.Color.Black;
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(47, 20);
            this.MenuItemHelp.Text = "&HELP";
            this.MenuItemHelp.Click += new System.EventHandler(this.MenuItemHelp_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItemAbout.ForeColor = System.Drawing.Color.Black;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(59, 20);
            this.MenuItemAbout.Text = "&ABOUT";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.IsSplitterFixed = true;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 24);
            this.splitContainerBase.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerBase.Name = "splitContainerBase";
            // 
            // splitContainerBase.Panel1
            // 
            this.splitContainerBase.Panel1.Controls.Add(this.tableLayoutPanelSide);
            this.splitContainerBase.Panel1.Controls.Add(this.panelSideBottom);
            // 
            // splitContainerBase.Panel2
            // 
            this.splitContainerBase.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerBase.Size = new System.Drawing.Size(1008, 667);
            this.splitContainerBase.SplitterDistance = 218;
            this.splitContainerBase.SplitterIncrement = 10;
            this.splitContainerBase.SplitterWidth = 7;
            this.splitContainerBase.TabIndex = 3;
            // 
            // tableLayoutPanelSide
            // 
            this.tableLayoutPanelSide.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanelSide.ColumnCount = 1;
            this.tableLayoutPanelSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSide.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSide.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSide.Name = "tableLayoutPanelSide";
            this.tableLayoutPanelSide.RowCount = 1;
            this.tableLayoutPanelSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSide.Size = new System.Drawing.Size(218, 569);
            this.tableLayoutPanelSide.TabIndex = 2;
            // 
            // panelSideBottom
            // 
            this.panelSideBottom.BackColor = System.Drawing.Color.Silver;
            this.panelSideBottom.Controls.Add(this.groupBoxLoginDetails);
            this.panelSideBottom.Controls.Add(this.statusStrip);
            this.panelSideBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSideBottom.Location = new System.Drawing.Point(0, 569);
            this.panelSideBottom.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panelSideBottom.Name = "panelSideBottom";
            this.panelSideBottom.Size = new System.Drawing.Size(218, 98);
            this.panelSideBottom.TabIndex = 1;
            // 
            // groupBoxLoginDetails
            // 
            this.groupBoxLoginDetails.BackColor = System.Drawing.Color.Silver;
            this.groupBoxLoginDetails.Controls.Add(this.tableLayoutPanelLoginDetails);
            this.groupBoxLoginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoginDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxLoginDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLoginDetails.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLoginDetails.Name = "groupBoxLoginDetails";
            this.groupBoxLoginDetails.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxLoginDetails.Size = new System.Drawing.Size(218, 76);
            this.groupBoxLoginDetails.TabIndex = 15;
            this.groupBoxLoginDetails.TabStop = false;
            this.groupBoxLoginDetails.Text = "Login Details";
            // 
            // tableLayoutPanelLoginDetails
            // 
            this.tableLayoutPanelLoginDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLoginDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLoginDetails.ColumnCount = 2;
            this.tableLayoutPanelLoginDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85782F));
            this.tableLayoutPanelLoginDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.14218F));
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblDurationValue, 1, 3);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblTimeValue, 1, 2);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblDuration, 0, 3);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblCompany, 0, 0);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblCompanyValue, 1, 0);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblUserValue, 1, 1);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblUser, 0, 1);
            this.tableLayoutPanelLoginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLoginDetails.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanelLoginDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLoginDetails.Name = "tableLayoutPanelLoginDetails";
            this.tableLayoutPanelLoginDetails.RowCount = 4;
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.Size = new System.Drawing.Size(214, 54);
            this.tableLayoutPanelLoginDetails.TabIndex = 1;
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.AutoSize = true;
            this.lblDurationValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDurationValue.Location = new System.Drawing.Point(67, 40);
            this.lblDurationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(51, 13);
            this.lblDurationValue.TabIndex = 14;
            this.lblDurationValue.Text = "00:00:00";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeValue.Location = new System.Drawing.Point(67, 27);
            this.lblTimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(47, 12);
            this.lblTimeValue.TabIndex = 15;
            this.lblTimeValue.Text = "<TIME>";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuration.Location = new System.Drawing.Point(3, 40);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(52, 13);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Duration:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompany.Location = new System.Drawing.Point(3, 1);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(56, 12);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Company:";
            // 
            // lblCompanyValue
            // 
            this.lblCompanyValue.AutoSize = true;
            this.lblCompanyValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompanyValue.Location = new System.Drawing.Point(67, 1);
            this.lblCompanyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyValue.Name = "lblCompanyValue";
            this.lblCompanyValue.Size = new System.Drawing.Size(72, 12);
            this.lblCompanyValue.TabIndex = 12;
            this.lblCompanyValue.Text = "<COMPANY>";
            // 
            // lblUserValue
            // 
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserValue.Location = new System.Drawing.Point(67, 14);
            this.lblUserValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(49, 12);
            this.lblUserValue.TabIndex = 13;
            this.lblUserValue.Text = "<USER>";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(3, 27);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 12);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(3, 14);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 12);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User:";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Silver;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 76);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(218, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.BackColor = System.Drawing.Color.Silver;
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(60, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Silver;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 6.5F);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(75, 17);
            this.statusLabel.Text = "Login Successful...";
            // 
            // IControlHolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 691);
            this.Controls.Add(this.splitContainerBase);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IControlHolderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlHolderFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IControlHolderForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IControlHolderForm_KeyDown);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerBase.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            this.panelSideBottom.ResumeLayout(false);
            this.panelSideBottom.PerformLayout();
            this.groupBoxLoginDetails.ResumeLayout(false);
            this.tableLayoutPanelLoginDetails.ResumeLayout(false);
            this.tableLayoutPanelLoginDetails.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemActions;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSide;
        private System.Windows.Forms.Panel panelSideBottom;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRestart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox groupBoxLoginDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginDetails;
        private System.Windows.Forms.Label lblDurationValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCompanyValue;
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUser;

    }
}