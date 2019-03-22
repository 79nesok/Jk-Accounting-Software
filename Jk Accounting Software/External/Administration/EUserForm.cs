using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Administration
{
    public partial class EUserForm : IMasterForm
    {
        private bool PasswordModified;

        public EUserForm()
        {
            InitializeComponent();
        }

        private void EUserForm_SetupData()
        {
            PasswordModified = false;
            //temporary data to not show the actual length of encrypted password
            if (FormState != FormStates.fsNew)
                txtPassword.Text = "password";
        }

        private void EUserForm_SetupControl()
        {
            lblConfirmPassword.Visible = FormState == FormStates.fsNew;
            txtConfirmPassword.Visible = FormState == FormStates.fsNew;
            txtConfirmPassword.Enabled = true;
            txtConfirmPassword.Required = FormState == FormStates.fsNew;

            if (FormState == FormStates.fsView)
            {
                lblWeakPassword.Visible = false;
                lblPasswordNotMatch.Visible = false;
            }

            ResizeGroupBox();
        }

        private void ValidatePassword(object sender, EventArgs e)
        {
            if (FormState == FormStates.fsView
                || !EditingReady)
                return;

            if ((sender is TextBox)
                && (sender as TextBox).Name == "txtPassword")
            {
                lblConfirmPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                txtConfirmPassword.Required = true;
                PasswordModified = true;
            }

            if (txtPassword.TextLength > 0)
                lblWeakPassword.Visible = !ISecurityHandler.PasswordStrong(txtPassword.Text);

            if (txtPassword.TextLength > 0
                && txtConfirmPassword.TextLength > 0)
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                    lblPasswordNotMatch.Visible = true;
                else
                    lblPasswordNotMatch.Visible = false;
            }
            else
            {
                lblPasswordNotMatch.Visible = false;
            }
            ResizeGroupBox();
        }

        private void ResizeGroupBox()
        {
            int height = 0;

            foreach (Control item in flowLayoutLoginInformation.Controls)
            {
                if (item is Label && item.Visible)
                {
                    height += item.Height + item.Margin.Top + item.Margin.Bottom;
                }
            }

            grpBoxLoginInformation.Size = new Size(grpBoxLoginInformation.Width, height + 50);
        }

        private void EUserForm_ValidateSave()
        {
            if (txtConfirmPassword.Required
                && txtConfirmPassword.Text.Length == 0)
            {
                IMessageHandler.Inform(ISystemMessages.FillRequiredFieldMessage);
                ValidationFails = true;
            }

            if (lblWeakPassword.Visible || lblPasswordNotMatch.Visible)
            {
                ValidationFails = true;
            }
        }

        private void EUserForm_BeforeSave()
        {
            if (PasswordModified)
                txtPassword.Text = ISecurityHandler.Encrypt(txtPassword.Text);
            else
                txtPassword.Text = MasterColumns.Find(mc => mc.Name == "Password").Value.ToString();
            txtConfirmPassword.Clear();
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (FormState != FormStates.fsView)
                IAppHandler.SetLabelColorOnEnter(lblConfirmPassword);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            IAppHandler.SetLabelColorOnLeave(lblConfirmPassword);
        }
    }
}
