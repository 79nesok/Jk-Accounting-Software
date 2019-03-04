namespace Jk_Accounting_Software.Internal.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ILookupProvider));
            this.dstSecurityUsers = new JkComponents.JkDataSet();
            this.cnConnection = new JkComponents.JkConnection();
            this.dstSubsidiaryTypes = new JkComponents.JkDataSet();
            this.dstJournalTypes = new JkComponents.JkDataSet();
            this.dstAccountTypes = new JkComponents.JkDataSet();
            this.dstSubsidiaries = new JkComponents.JkDataSet();
            this.dstAccounts = new JkComponents.JkDataSet();
            this.dstSystemPrintouts = new JkComponents.JkDataSet();
            this.dstSystemAccountCodes = new JkComponents.JkDataSet();
            this.dstVATTypes = new JkComponents.JkDataSet();
            this.dstPaymentMethods = new JkComponents.JkDataSet();
            this.dstItems = new JkComponents.JkDataSet();
            this.dstItemTypes = new JkComponents.JkDataSet();
            this.dstATC = new JkComponents.JkDataSet();
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
            // dstSubsidiaries
            // 
            this.dstSubsidiaries.BackColor = System.Drawing.Color.Khaki;
            this.dstSubsidiaries.CommandText = resources.GetString("dstSubsidiaries.CommandText");
            this.dstSubsidiaries.Connection = this.cnConnection;
            this.dstSubsidiaries.Location = new System.Drawing.Point(454, 4);
            this.dstSubsidiaries.Name = "dstSubsidiaries";
            this.dstSubsidiaries.Parameters.Add(((JkComponents.JkDataSetParameter)(resources.GetObject("dstSubsidiaries.Parameters"))));
            this.dstSubsidiaries.Size = new System.Drawing.Size(77, 20);
            this.dstSubsidiaries.TabIndex = 5;
            this.dstSubsidiaries.Text = "jkDataSet1";
            this.dstSubsidiaries.ZLoadColumns = false;
            // 
            // dstAccounts
            // 
            this.dstAccounts.BackColor = System.Drawing.Color.Khaki;
            this.dstAccounts.CommandText = resources.GetString("dstAccounts.CommandText");
            this.dstAccounts.Connection = this.cnConnection;
            this.dstAccounts.Location = new System.Drawing.Point(4, 30);
            this.dstAccounts.Name = "dstAccounts";
            this.dstAccounts.Parameters.Add(((JkComponents.JkDataSetParameter)(resources.GetObject("dstAccounts.Parameters"))));
            this.dstAccounts.Size = new System.Drawing.Size(64, 20);
            this.dstAccounts.TabIndex = 6;
            this.dstAccounts.Text = "jkDataSet1";
            this.dstAccounts.ZLoadColumns = false;
            // 
            // dstSystemPrintouts
            // 
            this.dstSystemPrintouts.BackColor = System.Drawing.Color.Khaki;
            this.dstSystemPrintouts.CommandText = "SELECT FormCaption, Report, PrintoutFormName\r\nFROM tblSystemPrintouts\r\nORDER BY F" +
    "ormCaption, Report";
            this.dstSystemPrintouts.Connection = this.cnConnection;
            this.dstSystemPrintouts.Location = new System.Drawing.Point(73, 30);
            this.dstSystemPrintouts.Name = "dstSystemPrintouts";
            this.dstSystemPrintouts.Parameters.Add(((JkComponents.JkDataSetParameter)(resources.GetObject("dstSystemPrintouts.Parameters"))));
            this.dstSystemPrintouts.Size = new System.Drawing.Size(98, 20);
            this.dstSystemPrintouts.TabIndex = 7;
            this.dstSystemPrintouts.Text = "jkDataSet1";
            this.dstSystemPrintouts.ZLoadColumns = false;
            // 
            // dstSystemAccountCodes
            // 
            this.dstSystemAccountCodes.BackColor = System.Drawing.Color.Khaki;
            this.dstSystemAccountCodes.CommandText = "SELECT Id, Code, Name, Active\r\nFROM tblSystemAccountCodes\r\nORDER BY Name";
            this.dstSystemAccountCodes.Connection = this.cnConnection;
            this.dstSystemAccountCodes.Location = new System.Drawing.Point(177, 30);
            this.dstSystemAccountCodes.Name = "dstSystemAccountCodes";
            this.dstSystemAccountCodes.Size = new System.Drawing.Size(123, 20);
            this.dstSystemAccountCodes.TabIndex = 8;
            this.dstSystemAccountCodes.Text = "jkDataSet3";
            this.dstSystemAccountCodes.ZLoadColumns = false;
            // 
            // dstVATTypes
            // 
            this.dstVATTypes.BackColor = System.Drawing.Color.Khaki;
            this.dstVATTypes.CommandText = "SELECT Id, Code, Name, Rate, Active\r\nFROM tblVATTypes";
            this.dstVATTypes.Connection = this.cnConnection;
            this.dstVATTypes.Location = new System.Drawing.Point(306, 30);
            this.dstVATTypes.Name = "dstVATTypes";
            this.dstVATTypes.Size = new System.Drawing.Size(68, 20);
            this.dstVATTypes.TabIndex = 9;
            this.dstVATTypes.Text = "jkDataSet3";
            this.dstVATTypes.ZLoadColumns = false;
            // 
            // dstPaymentMethods
            // 
            this.dstPaymentMethods.BackColor = System.Drawing.Color.Khaki;
            this.dstPaymentMethods.CommandText = "SELECT Id, Code, Name, AccountId, Active\r\nFROM tblPaymentMethods\r\nWHERE CompanyId" +
    " = @CompanyId\r\nORDER BY Name";
            this.dstPaymentMethods.Connection = this.cnConnection;
            this.dstPaymentMethods.Location = new System.Drawing.Point(380, 30);
            this.dstPaymentMethods.Name = "dstPaymentMethods";
            this.dstPaymentMethods.Parameters.Add(((JkComponents.JkDataSetParameter)(resources.GetObject("dstPaymentMethods.Parameters"))));
            this.dstPaymentMethods.Size = new System.Drawing.Size(103, 20);
            this.dstPaymentMethods.TabIndex = 10;
            this.dstPaymentMethods.Text = "jkDataSet3";
            this.dstPaymentMethods.ZLoadColumns = false;
            // 
            // dstItems
            // 
            this.dstItems.BackColor = System.Drawing.Color.Khaki;
            this.dstItems.CommandText = "SELECT Id, Code, Name, TypeId, Active\r\nFROM tblItems\r\nWHERE CompanyId = @CompanyI" +
    "d\r\nORDER BY Name";
            this.dstItems.Connection = this.cnConnection;
            this.dstItems.Location = new System.Drawing.Point(489, 30);
            this.dstItems.Name = "dstItems";
            this.dstItems.Parameters.Add(((JkComponents.JkDataSetParameter)(resources.GetObject("dstItems.Parameters"))));
            this.dstItems.Size = new System.Drawing.Size(48, 20);
            this.dstItems.TabIndex = 11;
            this.dstItems.Text = "jkDataSet3";
            this.dstItems.ZLoadColumns = false;
            // 
            // dstItemTypes
            // 
            this.dstItemTypes.BackColor = System.Drawing.Color.Khaki;
            this.dstItemTypes.CommandText = "SELECT Id, Code, Name, Active\r\nFROM tblItemTypes";
            this.dstItemTypes.Connection = this.cnConnection;
            this.dstItemTypes.Location = new System.Drawing.Point(4, 56);
            this.dstItemTypes.Name = "dstItemTypes";
            this.dstItemTypes.Size = new System.Drawing.Size(72, 20);
            this.dstItemTypes.TabIndex = 12;
            this.dstItemTypes.Text = "jkDataSet3";
            this.dstItemTypes.ZLoadColumns = false;
            // 
            // dstATC
            // 
            this.dstATC.BackColor = System.Drawing.Color.Khaki;
            this.dstATC.CommandText = "SELECT Id, Code, NewRate AS Rate, Active,\r\n\tCode + \' - \' + CAST(NewRate AS VARCHA" +
    "R) + \'%\' AS CodeRate\r\nFROM tblAlphaNumericTaxCodes";
            this.dstATC.Connection = this.cnConnection;
            this.dstATC.Location = new System.Drawing.Point(82, 56);
            this.dstATC.Name = "dstATC";
            this.dstATC.Size = new System.Drawing.Size(40, 20);
            this.dstATC.TabIndex = 13;
            this.dstATC.Text = "jkDataSet3";
            this.dstATC.ZLoadColumns = false;
            // 
            // ILookupProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.dstATC);
            this.Controls.Add(this.dstItemTypes);
            this.Controls.Add(this.dstItems);
            this.Controls.Add(this.dstPaymentMethods);
            this.Controls.Add(this.dstVATTypes);
            this.Controls.Add(this.dstSystemAccountCodes);
            this.Controls.Add(this.dstSystemPrintouts);
            this.Controls.Add(this.dstAccounts);
            this.Controls.Add(this.dstSubsidiaries);
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
        public JkComponents.JkDataSet dstSystemPrintouts;
        public JkComponents.JkDataSet dstSubsidiaries;
        public JkComponents.JkDataSet dstAccounts;
        public JkComponents.JkDataSet dstSystemAccountCodes;
        public JkComponents.JkDataSet dstVATTypes;
        public JkComponents.JkDataSet dstPaymentMethods;
        public JkComponents.JkDataSet dstItems;
        public JkComponents.JkDataSet dstItemTypes;
        public JkComponents.JkDataSet dstATC;
    }
}
