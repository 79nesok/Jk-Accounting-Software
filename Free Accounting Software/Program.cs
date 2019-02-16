using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                else if (str == "/rr" || str == "-rr")
                {
                    using (OpenFileDialog dialog = new OpenFileDialog())
                    {
                        dialog.ValidateNames = false;
                        dialog.CheckFileExists = false;
                        dialog.CheckPathExists = true;
                        dialog.FileName = "Folder Selection";
                        dialog.Title = "Select Report Directory Folder";
                        if (Directory.Exists(Properties.Settings.Default.ReportPath))
                            dialog.InitialDirectory = Properties.Settings.Default.ReportPath;

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            Properties.Settings.Default.ReportPath = dialog.FileName.Replace("Folder Selection", "");
                            Properties.Settings.Default.Save();
                            Properties.Settings.Default.Reload();
                        }
                    }

                    return;
                }
            }

            Application.Run(new IControlHolderForm());
        }
    }
}
