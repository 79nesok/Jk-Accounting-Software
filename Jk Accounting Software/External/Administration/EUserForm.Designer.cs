namespace Jk_Accounting_Software.External.Administration
{
    partial class EUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUserForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new JkComponents.JkTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMiddleName = new JkComponents.JkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new JkComponents.JkTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new JkComponents.JkTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.grpBoxLoginInformation = new System.Windows.Forms.GroupBox();
            this.flowLayoutLoginInformation = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new JkComponents.JkTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new JkComponents.JkTextBox();
            this.lblWeakPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new JkComponents.JkTextBox();
            this.lblPasswordNotMatch = new System.Windows.Forms.Label();
            this.FormFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpBoxLoginInformation.SuspendLayout();
            this.flowLayoutLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormFooter
            // 
            this.FormFooter.Location = new System.Drawing.Point(0, 502);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel2);
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
            this.flowLayoutPanel2.Controls.Add(this.txtFirstName);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtMiddleName);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtLastName);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtRemarks);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.chkActive);
            this.flowLayoutPanel2.Controls.Add(this.grpBoxLoginInformation);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 477);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 5);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Required = false;
            this.txtFirstName.Size = new System.Drawing.Size(230, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(151, 38);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Required = false;
            this.txtMiddleName.Size = new System.Drawing.Size(230, 23);
            this.txtMiddleName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 71);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Required = false;
            this.txtLastName.Size = new System.Drawing.Size(230, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(151, 104);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Required = false;
            this.txtRemarks.Size = new System.Drawing.Size(230, 90);
            this.txtRemarks.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Active:";
            // 
            // chkActive
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.chkActive, true);
            this.chkActive.Location = new System.Drawing.Point(151, 204);
            this.chkActive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 25);
            this.chkActive.TabIndex = 0;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // grpBoxLoginInformation
            // 
            this.grpBoxLoginInformation.Controls.Add(this.flowLayoutLoginInformation);
            this.grpBoxLoginInformation.Location = new System.Drawing.Point(3, 237);
            this.grpBoxLoginInformation.Name = "grpBoxLoginInformation";
            this.grpBoxLoginInformation.Size = new System.Drawing.Size(378, 200);
            this.grpBoxLoginInformation.TabIndex = 11;
            this.grpBoxLoginInformation.TabStop = false;
            this.grpBoxLoginInformation.Text = "Login Information";
            // 
            // flowLayoutLoginInformation
            // 
            this.flowLayoutLoginInformation.Controls.Add(this.label2);
            this.flowLayoutLoginInformation.Controls.Add(this.txtUsername);
            this.flowLayoutLoginInformation.Controls.Add(this.lblPassword);
            this.flowLayoutLoginInformation.Controls.Add(this.txtPassword);
            this.flowLayoutLoginInformation.Controls.Add(this.lblWeakPassword);
            this.flowLayoutLoginInformation.Controls.Add(this.lblConfirmPassword);
            this.flowLayoutLoginInformation.Controls.Add(this.txtConfirmPassword);
            this.flowLayoutLoginInformation.Controls.Add(this.lblPasswordNotMatch);
            this.flowLayoutLoginInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutLoginInformation.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutLoginInformation.Name = "flowLayoutLoginInformation";
            this.flowLayoutLoginInformation.Size = new System.Drawing.Size(372, 178);
            this.flowLayoutLoginInformation.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(145, 5);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Required = false;
            this.txtUsername.Size = new System.Drawing.Size(219, 23);
            this.txtUsername.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(0, 33);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblPassword.Size = new System.Drawing.Size(139, 25);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(145, 38);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Required = false;
            this.txtPassword.Size = new System.Drawing.Size(219, 23);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.ValidatePassword);
            // 
            // lblWeakPassword
            // 
            this.lblWeakPassword.ForeColor = System.Drawing.Color.Red;
            this.lblWeakPassword.Location = new System.Drawing.Point(0, 66);
            this.lblWeakPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblWeakPassword.Name = "lblWeakPassword";
            this.lblWeakPassword.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblWeakPassword.Size = new System.Drawing.Size(364, 42);
            this.lblWeakPassword.TabIndex = 24;
            this.lblWeakPassword.Text = "Please use strong password, combine alphanumeric and special characters";
            this.lblWeakPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWeakPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Location = new System.Drawing.Point(0, 108);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblConfirmPassword.Size = new System.Drawing.Size(139, 25);
            this.lblConfirmPassword.TabIndex = 23;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(145, 113);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Required = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(219, 23);
            this.txtConfirmPassword.TabIndex = 22;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.ValidatePassword);
            // 
            // lblPasswordNotMatch
            // 
            this.lblPasswordNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordNotMatch.Location = new System.Drawing.Point(0, 141);
            this.lblPasswordNotMatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblPasswordNotMatch.Name = "lblPasswordNotMatch";
            this.lblPasswordNotMatch.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblPasswordNotMatch.Size = new System.Drawing.Size(364, 25);
            this.lblPasswordNotMatch.TabIndex = 25;
            this.lblPasswordNotMatch.Text = "Password not match";
            this.lblPasswordNotMatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPasswordNotMatch.Visible = false;
            // 
            // EUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "User";
            this.CommandText = "SELECT Id, UserName, [Password], FirstName,\r\n\tMiddleName, LastName, Remarks, Acti" +
    "ve,\r\n\tCreatedById, DateCreated, ModifiedById,\r\n\tDateModified\r\nFROM tblSystemUser" +
    "s\r\nWHERE Id = @Id";
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
            this.Name = "EUserForm";
            this.Parameters.Add(((JkComponents.JkFormParameter)(resources.GetObject("$this.Parameters"))));
            this.Size = new System.Drawing.Size(836, 536);
            this.ZLoadMasterColumns = true;
            this.SetupData += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupDataHandler(this.EUserForm_SetupData);
            this.SetupControl += new Jk_Accounting_Software.Internal.Forms.IParentForm.SetupControlHandler(this.EUserForm_SetupControl);
            this.ValidateSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.ValidateSaveHandler(this.EUserForm_ValidateSave);
            this.BeforeSave += new Jk_Accounting_Software.Internal.Forms.IParentForm.BeforeSaveHandler(this.EUserForm_BeforeSave);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpBoxLoginInformation.ResumeLayout(false);
            this.flowLayoutLoginInformation.ResumeLayout(false);
            this.flowLayoutLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private JkComponents.JkTextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private JkComponents.JkTextBox txtMiddleName;
        private System.Windows.Forms.Label label1;
        private JkComponents.JkTextBox txtLastName;
        private System.Windows.Forms.Label label9;
        private JkComponents.JkTextBox txtRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.GroupBox grpBoxLoginInformation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutLoginInformation;
        private System.Windows.Forms.Label label2;
        private JkComponents.JkTextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private JkComponents.JkTextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private JkComponents.JkTextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblWeakPassword;
        private System.Windows.Forms.Label lblPasswordNotMatch;
    }
}
