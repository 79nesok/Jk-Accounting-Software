using System;
using System.Windows.Forms;

namespace Jk_Accounting_Software.Internal.Classes
{
    static class IMessageHandler
    {
        public static String MessageCaption = "Development";

        public static void Inform(String Message)
        {
            MessageBox.Show(Message, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirm(String Message)
        {
            return MessageBox.Show(Message, MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowError(String Message)
        {
            MessageBox.Show(Message, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
