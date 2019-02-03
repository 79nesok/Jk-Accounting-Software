using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Free_Accounting_Software.Internal.Forms
{
    public partial class IReportForm : IMasterForm
    {
        public IReportForm()
        {
            InitializeComponent();
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            btnHolder.Visible = false;
            btnNavigator.Visible = false;
            lblCreatedBy.Visible = false;
            lblModifiedBy.Visible = false;
            lblMode.Visible = false;
        }
    }
}
