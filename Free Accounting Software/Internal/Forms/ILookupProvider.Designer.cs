namespace Free_Accounting_Software.Internal.Forms
{
    partial class ILookupProvider
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
            this.dstSecurityUsers = new JkComponents.JkDataSet();
            this.cnConnection = new JkComponents.JkConnection();
            this.dstSubsidiaryTypes = new JkComponents.JkDataSet();
            this.dstJournalTypes = new JkComponents.JkDataSet();
            this.dstAccountTypes = new JkComponents.JkDataSet();
            this.SuspendLayout();
            // 
            // dstSecurityUsers
            // 
            this.dstSecurityUsers.BackColor = System.Drawing.Color.Khaki;
            this.dstSecurityUsers.CommandText = "SELECT Id, UserName, FormalName\r\nFROM tblSecurityUsers";
            this.dstSecurityUsers.Connection = this.cnConnection;
            this.dstSecurityUsers.Location = new System.Drawing.Point(80, 4);
            this.dstSecurityUsers.Name = "dstSecurityUsers";
            this.dstSecurityUsers.Size = new System.Drawing.Size(86, 20);
            this.dstSecurityUsers.TabIndex = 0;
            this.dstSecurityUsers.Text = "jkDataSet1";
            this.dstSecurityUsers.ZLoadColumns = false;
            // 
            // cnConnection
            // 
            this.cnConnection.BackColor = System.Drawing.Color.LightGray;
            this.cnConnection.ConnectionString = "Data Source=.\\sqlexpress2014;Persist Security Info=True;User ID=sa;Password=maste" +
    "rkey;Initial Catalog=FreeAccountingSoftware";
            this.cnConnection.Location = new System.Drawing.Point(4, 4);
            this.cnConnection.Name = "cnConnection";
            this.cnConnection.Size = new System.Drawing.Size(71, 20);
            this.cnConnection.TabIndex = 3;
            this.cnConnection.Text = "jkConnection1";
            // 
            // dstSubsidiaryTypes
            // 
            this.dstSubsidiaryTypes.BackColor = System.Drawing.Color.Khaki;
            this.dstSubsidiaryTypes.CommandText = "SELECT Id, Name\r\nFROM tblSubsidiaryTypes";
            this.dstSubsidiaryTypes.Connection = this.cnConnection;
            this.dstSubsidiaryTypes.Location = new System.Drawing.Point(170, 4);
            this.dstSubsidiaryTypes.Name = "dstSubsidiaryTypes";
            this.dstSubsidiaryTypes.Size = new System.Drawing.Size(98, 20);
            this.dstSubsidiaryTypes.TabIndex = 1;
            this.dstSubsidiaryTypes.Text = "jkDataSet2";
            this.dstSubsidiaryTypes.ZLoadColumns = false;
            // 
            // dstJournalTypes
            // 
            this.dstJournalTypes.BackColor = System.Drawing.Color.Khaki;
            this.dstJournalTypes.CommandText = "SELECT Id, Code, Name\r\nFROM tblJournalTypes";
            this.dstJournalTypes.Connection = this.cnConnection;
            this.dstJournalTypes.Location = new System.Drawing.Point(273, 4);
            this.dstJournalTypes.Name = "dstJournalTypes";
            this.dstJournalTypes.Size = new System.Drawing.Size(84, 20);
            this.dstJournalTypes.TabIndex = 2;
            this.dstJournalTypes.Text = "jkDataSet3";
            this.dstJournalTypes.ZLoadColumns = false;
            // 
            // dstAccountTypes
            // 
            this.dstAccountTypes.BackColor = System.Drawing.Color.Khaki;
            this.dstAccountTypes.CommandText = "SELECT Id, Code, Name\r\nFROM tblAccountTypes";
            this.dstAccountTypes.Connection = this.cnConnection;
            this.dstAccountTypes.Location = new System.Drawing.Point(361, 4);
            this.dstAccountTypes.Name = "dstAccountTypes";
            this.dstAccountTypes.Size = new System.Drawing.Size(87, 20);
            this.dstAccountTypes.TabIndex = 4;
            this.dstAccountTypes.Text = "jkDataSet3";
            this.dstAccountTypes.ZLoadColumns = false;
            // 
            // ILookupProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dstAccountTypes);
            this.Controls.Add(this.cnConnection);
            this.Controls.Add(this.dstJournalTypes);
            this.Controls.Add(this.dstSubsidiaryTypes);
            this.Controls.Add(this.dstSecurityUsers);
            this.Name = "ILookupProvider";
            this.Size = new System.Drawing.Size(577, 331);
            this.ResumeLayout(false);

        }

        #endregion

        public JkComponents.JkDataSet dstSecurityUsers;
        public JkComponents.JkDataSet dstSubsidiaryTypes;
        public JkComponents.JkDataSet dstJournalTypes;
        private JkComponents.JkConnection cnConnection;
        public JkComponents.JkDataSet dstAccountTypes;
    }
}
