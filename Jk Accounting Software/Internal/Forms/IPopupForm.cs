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
using System.Drawing.Design;
using JkComponents;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class IPopupForm : Form
    {
        #region Added Properties
            [Editor(typeof(ITextPropertyTypeEditor), typeof(UITypeEditor))]
            [Category("(Custom)")]
            public String CommandText { get; set; }

            private List<JkFormParameter> _Parameters = new List<JkFormParameter>();
            [Category("(Custom)")]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public List<JkFormParameter> Parameters { get { return _Parameters; } set { _Parameters = value; } }

            private List<JkColumn> _Columns = new List<JkColumn>();
            [Category("(Custom)")]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public List<JkColumn> Columns { get { return _Columns; } set { _Columns = value; } }

            [Category("(Custom)")]
            public String Caption { get { return lblCaption.Text; } set { lblCaption.Text = value; } }

            private bool _ZLoadColumns;
            [Category("(Custom)")]
            public bool ZLoadColumns
            {
                get
                {
                    return _ZLoadColumns;
                }
                set
                {
                    _ZLoadColumns = value;
                    CreateColumns();
                }
            }
        #endregion

        #region Variable Declarations
            public DataTable VDataTable = new DataTable();
        #endregion

        #region Built-in Events
            public IPopupForm()
            {
                InitializeComponent();

                IAppHandler.ApplyStyleOnGrid(dataGridView);
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
            }
        #endregion

        #region Custom Functions and Procedures
            private void CreateColumns()
            {
            }
        #endregion
    }
}
