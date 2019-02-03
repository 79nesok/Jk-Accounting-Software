namespace Free_Accounting_Software.Internal.Forms
{
    partial class UserControl4
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            this.panelSideBottom.SuspendLayout();
            this.groupBoxLoginDetails.SuspendLayout();
            this.tableLayoutPanelLoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.IsSplitterFixed = true;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainerBase.Size = new System.Drawing.Size(401, 365);
            this.splitContainerBase.SplitterDistance = 87;
            this.splitContainerBase.SplitterIncrement = 10;
            this.splitContainerBase.SplitterWidth = 7;
            this.splitContainerBase.TabIndex = 2;
            // 
            // tableLayoutPanelSide
            // 
            this.tableLayoutPanelSide.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanelSide.ColumnCount = 1;
            this.tableLayoutPanelSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSide.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSide.Name = "tableLayoutPanelSide";
            this.tableLayoutPanelSide.RowCount = 1;
            this.tableLayoutPanelSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSide.Size = new System.Drawing.Size(87, 270);
            this.tableLayoutPanelSide.TabIndex = 2;
            // 
            // panelSideBottom
            // 
            this.panelSideBottom.BackColor = System.Drawing.Color.Silver;
            this.panelSideBottom.Controls.Add(this.groupBoxLoginDetails);
            this.panelSideBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSideBottom.Location = new System.Drawing.Point(0, 270);
            this.panelSideBottom.Name = "panelSideBottom";
            this.panelSideBottom.Size = new System.Drawing.Size(87, 95);
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
            this.groupBoxLoginDetails.Name = "groupBoxLoginDetails";
            this.groupBoxLoginDetails.Size = new System.Drawing.Size(87, 95);
            this.groupBoxLoginDetails.TabIndex = 0;
            this.groupBoxLoginDetails.TabStop = false;
            this.groupBoxLoginDetails.Text = "Login Details";
            // 
            // tableLayoutPanelLoginDetails
            // 
            this.tableLayoutPanelLoginDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLoginDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLoginDetails.ColumnCount = 2;
            this.tableLayoutPanelLoginDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelLoginDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblDurationValue, 1, 3);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblTimeValue, 1, 2);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblDuration, 0, 3);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblCompany, 0, 0);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblCompanyValue, 1, 0);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblUserValue, 1, 1);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanelLoginDetails.Controls.Add(this.lblUser, 0, 1);
            this.tableLayoutPanelLoginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLoginDetails.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanelLoginDetails.Name = "tableLayoutPanelLoginDetails";
            this.tableLayoutPanelLoginDetails.RowCount = 4;
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoginDetails.Size = new System.Drawing.Size(81, 75);
            this.tableLayoutPanelLoginDetails.TabIndex = 0;
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.AutoSize = true;
            this.lblDurationValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDurationValue.Location = new System.Drawing.Point(28, 55);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(45, 19);
            this.lblDurationValue.TabIndex = 14;
            this.lblDurationValue.Text = "00:00:00";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTimeValue.Location = new System.Drawing.Point(28, 37);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(47, 13);
            this.lblTimeValue.TabIndex = 15;
            this.lblTimeValue.Text = "<TIME>";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDuration.Location = new System.Drawing.Point(4, 55);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(17, 19);
            this.lblDuration.TabIndex = 11;
            this.lblDuration.Text = "Duration:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompany.Location = new System.Drawing.Point(4, 1);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(17, 17);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Company:";
            // 
            // lblCompanyValue
            // 
            this.lblCompanyValue.AutoSize = true;
            this.lblCompanyValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCompanyValue.Location = new System.Drawing.Point(28, 1);
            this.lblCompanyValue.Name = "lblCompanyValue";
            this.lblCompanyValue.Size = new System.Drawing.Size(44, 17);
            this.lblCompanyValue.TabIndex = 12;
            this.lblCompanyValue.Text = "<COMPANY>";
            // 
            // lblUserValue
            // 
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUserValue.Location = new System.Drawing.Point(28, 19);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(49, 13);
            this.lblUserValue.TabIndex = 13;
            this.lblUserValue.Text = "<USER>";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(4, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(17, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblUser.Location = new System.Drawing.Point(4, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(17, 17);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User:";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerBase);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(401, 365);
            this.splitContainerBase.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            this.panelSideBottom.ResumeLayout(false);
            this.groupBoxLoginDetails.ResumeLayout(false);
            this.tableLayoutPanelLoginDetails.ResumeLayout(false);
            this.tableLayoutPanelLoginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSide;
        private System.Windows.Forms.Panel panelSideBottom;
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
