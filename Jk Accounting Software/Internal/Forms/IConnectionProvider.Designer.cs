namespace Jk_Accounting_Software.Internal.Forms
{
    partial class IConnectionProvider
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.radiobtnOne = new System.Windows.Forms.RadioButton();
            this.radiobtnTwo = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.lblServerName);
            this.flowLayoutPanel.Controls.Add(this.txtServerName);
            this.flowLayoutPanel.Controls.Add(this.radiobtnOne);
            this.flowLayoutPanel.Controls.Add(this.radiobtnTwo);
            this.flowLayoutPanel.Controls.Add(this.lblUsername);
            this.flowLayoutPanel.Controls.Add(this.txtUsername);
            this.flowLayoutPanel.Controls.Add(this.lblPassword);
            this.flowLayoutPanel.Controls.Add(this.txtPassword);
            this.flowLayoutPanel.Controls.Add(this.lblDatabase);
            this.flowLayoutPanel.Controls.Add(this.cmbDatabase);
            this.flowLayoutPanel.Controls.Add(this.btnTestConnection);
            this.flowLayoutPanel.Controls.Add(this.btnOk);
            this.flowLayoutPanel.Controls.Add(this.btnCancel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(256, 271);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lblServerName
            // 
            this.lblServerName.Location = new System.Drawing.Point(6, 5);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(80, 15);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(98, 5);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(150, 23);
            this.txtServerName.TabIndex = 1;
            // 
            // radiobtnOne
            // 
            this.radiobtnOne.AutoSize = true;
            this.radiobtnOne.Location = new System.Drawing.Point(6, 38);
            this.radiobtnOne.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radiobtnOne.Name = "radiobtnOne";
            this.radiobtnOne.Size = new System.Drawing.Size(216, 19);
            this.radiobtnOne.TabIndex = 3;
            this.radiobtnOne.TabStop = true;
            this.radiobtnOne.Text = "Use Windows NT Integrated security";
            this.radiobtnOne.UseVisualStyleBackColor = true;
            this.radiobtnOne.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // radiobtnTwo
            // 
            this.radiobtnTwo.AutoSize = true;
            this.radiobtnTwo.Location = new System.Drawing.Point(6, 67);
            this.radiobtnTwo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radiobtnTwo.Name = "radiobtnTwo";
            this.radiobtnTwo.Size = new System.Drawing.Size(227, 19);
            this.radiobtnTwo.TabIndex = 4;
            this.radiobtnTwo.TabStop = true;
            this.radiobtnTwo.Text = "Use a specific username and password";
            this.radiobtnTwo.UseVisualStyleBackColor = true;
            this.radiobtnTwo.CheckedChanged += new System.EventHandler(this.radiobtn_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(6, 96);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 96);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 23);
            this.txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(6, 129);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 129);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(6, 162);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(80, 13);
            this.lblDatabase.TabIndex = 9;
            this.lblDatabase.Text = "Database:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(98, 162);
            this.cmbDatabase.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(150, 23);
            this.cmbDatabase.TabIndex = 10;
            this.cmbDatabase.DropDown += new System.EventHandler(this.cmbDatabase_DropDown);
            // 
            // btnTestConnection
            // 
            this.flowLayoutPanel.SetFlowBreak(this.btnTestConnection, true);
            this.btnTestConnection.Location = new System.Drawing.Point(75, 195);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(75, 5, 6, 5);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(108, 28);
            this.btnTestConnection.TabIndex = 11;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(40, 233);
            this.btnOk.Margin = new System.Windows.Forms.Padding(40, 5, 6, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 25);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IConnectionProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 271);
            this.Controls.Add(this.flowLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IConnectionProvider";
            this.Text = "Connection Provider";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IConnectionProvider_FormClosed);
            this.Load += new System.EventHandler(this.IConnectionProvider_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.RadioButton radiobtnOne;
        private System.Windows.Forms.RadioButton radiobtnTwo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}