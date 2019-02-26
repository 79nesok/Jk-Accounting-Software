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

namespace Jk_Accounting_Software.External.Accounting
{
    public partial class ECustomerOverpaymentForm : IMasterForm
    {
        public ECustomerOverpaymentForm()
        {
            InitializeComponent();
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();
            btnHolder.Visible = false;
        }
    }
}
