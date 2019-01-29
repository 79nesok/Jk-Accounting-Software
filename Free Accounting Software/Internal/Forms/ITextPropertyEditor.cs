using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace Free_Accounting_Software
{
    public partial class ITextPropertyEditor : Form
    {
        public String Value { get { return txtInput.Text; } }

        public ITextPropertyEditor(String currentValue)
        {
            InitializeComponent();
            txtInput.Text = currentValue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ITextPropertyTypeEditor : UITypeEditor
    {
        public String sample;

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc;
            edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            ITextPropertyEditor editorForm;
            editorForm = new ITextPropertyEditor((string)value);
            edSvc.ShowDialog(editorForm);

            return editorForm.Value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
    }
}
