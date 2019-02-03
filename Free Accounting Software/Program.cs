using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Free_Accounting_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (String str in Environment.GetCommandLineArgs())
            {
                if (str == "/cc" || str == "-cc")
                {
                    Application.Run(new Free_Accounting_Software.Internal.Forms.IConnectionProvider("Free_Accounting_Software.Properties.Settings.FreeAccountingSoftwareConnectionString"));
                    return;
                }
            }

            Application.Run(new IControlHolderForm());
        }
    }
}
