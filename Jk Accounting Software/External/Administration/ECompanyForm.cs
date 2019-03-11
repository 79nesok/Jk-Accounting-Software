using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using System.Drawing.Imaging;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software.External.Administration
{
    public partial class ECompanyForm : IMasterForm
    {
        public ECompanyForm()
        {
            InitializeComponent();

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            String codecFilter = "Image Files|";
            foreach (ImageCodecInfo codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            openFileDialog.Filter = codecFilter;
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            btnNew.Visible = false;
            btnNavigatorHolder.Visible = false;
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            if (FormState == FormStates.fsView)
                return;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(openFileDialog.FileName);

                try
                {
                    logoBox.Image = IImageHandler.ResizeImage(img, logoBox.Width - 10, logoBox.Height - 10);
                }
                finally
                {
                    img.Dispose();
                }
            }
        }

        private void ECompanyForm_AfterRun()
        {
            if (FormState == FormStates.fsView)
                lblLink.Text = "Logo";
            else
                lblLink.Text = "Change Logo";
        }
    }
}
