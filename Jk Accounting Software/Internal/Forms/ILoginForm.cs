using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class ILoginForm : Form
    {
        public ILoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ISecurityHandler.LoginCredentialAccepted(txtUsername.Text, txtPassword.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                IMessageHandler.Inform(ISystemMessages.InvalidLoginCredential);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static DialogResult LoginSuccessful()
        {
            ILoginForm login = new ILoginForm();
            try
            {
                IMessageHandler.MessageCaption = "Application";
                login.ShowDialog();
            }
            finally
            {
                login.Dispose();
            }

            return login.DialogResult;
        }

        private void txtKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk.PerformClick();
        }
    }
}
