using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using Free_Accounting_Software.Internal.Forms;
using System.Threading;
using JkComponents;

namespace Free_Accounting_Software.Internal.Classes
{
    static class IAppHandler
    {
        public static List<IParentForm> Classes = new List<IParentForm>();
        public static Panel ParentPanel;
        public static DataTable Categories = new DataTable();
        public static DataTable SubCategories = new DataTable();
        public static ToolStripStatusLabel StatusLabel;
        public static ToolStripProgressBar StatusProgressBar;
        private static String InitialStatus;

        public static String GetSubCategory(String Name, String Result)
        {
            try
            {
                return SubCategories.Select("Name = '" + Name + "'")[0][Result].ToString();
            }
            catch (Exception ex)
            {
                IMessageHandler.ShowError(ISystemMessages.DevelopmentError(ex.Message));
            }

            return null;
        }

        public static void AddForm(IParentForm PClassname)
        {
            if(Classes.Find(frm => frm.Name == PClassname.Name) == null)
                Classes.Add(PClassname);
        }

        public static IParentForm FindForm(String PClassname)
        {
            IParentForm form = null;

            for (int i = 0; i <= Classes.Count - 1; i++)
                if (Classes[i].Name == PClassname)
                    form = Classes[i];

            foreach (DataRow category in Categories.Rows)
            {
                if (form == null && Type.GetType("Free_Accounting_Software.External." + category["Name"] + "." + PClassname) != null)
                    form = Activator.CreateInstance(Type.GetType("Free_Accounting_Software.External." + category["Name"] + "." + PClassname)) as IParentForm;
            }

            if (form != null)
                form.Parent = ParentPanel;

            return form;
        }

        public static IParentForm FindActiveForm()
        {
            if (ParentPanel != null)
                foreach (Control control in ParentPanel.Controls)
                    if (control.Visible)
                        return control as IParentForm;

            return null;
        }

        public static void StartBusy(String status)
        {
            if (String.IsNullOrWhiteSpace(InitialStatus))
                InitialStatus = status;

            SetStatusLabel(status);
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            
            Cursor.Current = Cursors.WaitCursor;
            StatusProgressBar.Value = 0;
            StatusProgressBar.Step = 10;
            StatusProgressBar.PerformStep();
        }

        public static void EndBusy(String status)
        {
            if (status != InitialStatus)
                return;

            Cursor.Current = Cursors.Default;
            StatusProgressBar.Step = 100;
            StatusProgressBar.PerformStep();
            SetStatusLabel("Done");
            InitialStatus = String.Empty;
        }

        private static void SetStatusLabel(String status)
        {
            StatusLabel.Text = status + "...";
            StatusLabel.GetCurrentParent().Refresh();
        }

        public static Object GetControlsValue(Control PControl)
        {
            Object result = null;

            if (PControl.GetType().Name == "TextBox")
                result = (PControl as TextBox).Text;
            else if (PControl.GetType().Name == "CheckBox")
                result = (PControl as CheckBox).Checked;
            else if (PControl.GetType().Name == "DateTimePicker")
                result = (PControl as DateTimePicker).Value.ToString();
            else if (PControl.GetType().Name == "PictureBox")
                result = IImageHandler.ConvertImageToByte((PControl as PictureBox).Image);
            else if (PControl.GetType().Name == "JkLookUpComboBox")
                result = (PControl as JkLookUpComboBox).SelectedKey;
            else if (PControl.GetType().Name == "JkTextBox")
                result = (PControl as JkTextBox).Text;

            return result;
        }

        public static void SetControlsValue(Control PControl, Object PValue)
        {
            if (PControl.GetType().Name == "TextBox")
                (PControl as TextBox).Text = Convert.ToString(PValue);
            else if (PControl.GetType().Name == "CheckBox")
                (PControl as CheckBox).Checked = Convert.ToBoolean(PValue);
            else if (PControl.GetType().Name == "DateTimePicker")
                (PControl as DateTimePicker).Value = new DateTime(Convert.ToDateTime(PValue).Year, Convert.ToDateTime(PValue).Month, Convert.ToDateTime(PValue).Day);
            else if (PControl.GetType().Name == "PictureBox")
                (PControl as PictureBox).Image = IImageHandler.ConvertByteToImage(PValue as byte[]);
            else if (PControl.GetType().Name == "JkLookUpComboBox")
                (PControl as JkLookUpComboBox).SelectedKey = Convert.ToInt32(PValue);
            else if (PControl.GetType().Name == "JkTextBox")
                (PControl as JkTextBox).Text = Convert.ToString(PValue);
        }

        public static void ClearControlsValue(Control PControl)
        {
            if (PControl.GetType().Name == "TextBox")
                (PControl as TextBox).Text = String.Empty;
            else if (PControl.GetType().Name == "CheckBox")
                (PControl as CheckBox).Checked = false;
            else if (PControl.GetType().Name == "PictureBox")
                (PControl as PictureBox).Image = null;
            else if (PControl.GetType().Name == "JkLookUpComboBox")
                    (PControl as JkLookUpComboBox).Text = String.Empty;
            else if (PControl.GetType().Name == "JkTextBox")
                (PControl as JkTextBox).Text = String.Empty;
        }

        public static Object ConvertMaskValue(Object PDefaultValue)
        {
            Object value;

            if (String.IsNullOrWhiteSpace(Convert.ToString(PDefaultValue)))
                return null;

            switch (PDefaultValue.ToString())
            { 
                case "@CompanyId":
                    value = ISecurityHandler.CompanyId;
                    break;
                case "@SecurityUserId":
                    value = ISecurityHandler.SecurityUserId;
                    break;
                case "@Date":
                    ITransactionHandler VTransactionHandler = new ITransactionHandler();
                    DataTable VDataTable = new DataTable();

                    try
                    {
                        VTransactionHandler.LoadData("SELECT GETDATE() AS CurrentDate", ref VDataTable, null);
                        value = VDataTable.Rows[0][0].ToString();
                    }
                    finally
                    {
                        VDataTable.Dispose();
                    }
                    break;
                default:
                    value = PDefaultValue;
                    break;
            }

            return value;
        }

        public static String SetColumnsDefaultValue(String ColumnName)
        {
            String value = null;

            switch (ColumnName)
            { 
                case "CompanyId":
                    value = "@CompanyId";
                    break;
                case "CreatedById":
                    value = "@SecurityUserId";
                    break;
                case "DateCreated":
                    value = "@Date";
                    break;
                case "ModifiedById":
                    value = "@SecurityUserId";
                    break;
                case "DateModified":
                    value = "@Date";
                    break;
                case "Active":
                    value = "True";
                    break;
            }

            return value;
        }

        public static List<Control> FindControlByType(String type, Control start)
        {
            List<Control> list = new List<Control>();

            foreach (Control control in start.Controls)
            {
                if (control.GetType().Name == type && list.Find(l => (l as Control).Name == control.Name) == null)
                    list.Add(control);

                foreach (Control c in FindControlByType(type, control))
                    list.Add(c);
            }

            return list;
        }
    }
}
