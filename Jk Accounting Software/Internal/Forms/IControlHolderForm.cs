using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Jk_Accounting_Software.Internal.Forms;
using Jk_Accounting_Software.Internal.Classes;

namespace Jk_Accounting_Software
{
    public partial class IControlHolderForm : Form
    {
        # region Variable Declarations
            int day, hour, min, sec;
        #endregion

        #region Built-in Events
            public IControlHolderForm()
            {
                InitializeComponent();
                GetCategories();
                GetSubCategories();
                IAppHandler.ParentPanel = splitContainerBase.Panel2;
                IAppHandler.StatusLabel = statusLabel;
                IAppHandler.StatusProgressBar = statusProgressBar;

                //todo: should be based on login
                ISecurityHandler.CompanyId = 1;
                ISecurityHandler.SecurityUserId = 1;
                ISecurityHandler.CompanyName = "Jk Computer Systems Inc.";
                ISecurityHandler.SecurityUserName = "Systems Developer";
            }

            private void BaseForm_Load(object sender, EventArgs e)
            {
                CreateCategories();
                SetProductName();
                SetLoginDetails();
            }

            private void timerDuration_Tick(object sender, EventArgs e)
            {
                sec += 1;
                if(sec > 59)
                {
                    sec = 0;
                    min += 1;
                }
                if(min > 59)
                {
                    min = 0;
                    hour += 1;
                }
                if(hour > 23)
                {
                    hour = 0;
                    day += 1;
                }

                if (day > 0)
                    lblDurationValue.Text = String.Format("{0} day and {1}:{2}:{3}", day, hour.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                else
                    lblDurationValue.Text = String.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }

            private void MenuItemRefresh_Click(object sender, EventArgs e)
            {
                IParentForm form = IAppHandler.FindActiveForm();

                if (form != null)
                {
                    try
                    {
                        IAppHandler.StartBusy("Executing Refresh");
                        form.Run();
                    }
                    finally
                    {
                        IAppHandler.EndBusy("Executing Refresh");
                    }
                }
            }

            private void MenuItemLogout_Click(object sender, EventArgs e)
            {
                if (IMessageHandler.Confirm(ISystemMessages.LogoutQuestion) == DialogResult.Yes)
                    Application.Exit();
            }

            private void MenuItemRestart_Click(object sender, EventArgs e)
            {
                if (IMessageHandler.Confirm(ISystemMessages.RestartQuestion) == DialogResult.Yes)
                    Application.Restart();
            }

            private void MenuItemHelp_Click(object sender, EventArgs e)
            {
                IMessageHandler.Inform("Show Help Form");
            }

            private void MenuItemAbout_Click(object sender, EventArgs e)
            {
                IMessageHandler.Inform(ISystemMessages.AboutMessage);
            }

            private void IControlHolderForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                    e.Cancel = (IMessageHandler.Confirm(ISystemMessages.LogoutQuestion) == DialogResult.No);
            }

            private void IControlHolderForm_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyData == Keys.F5)
                    MenuItemRefresh_Click(null, null);

                if (e.KeyData == (Keys.Control | Keys.N))
                    IAppHandler.FindActiveForm().btnNew.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.E))
                    IAppHandler.FindActiveForm().btnEdit.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.S))
                    IAppHandler.FindActiveForm().btnSave.PerformClick();

                if (e.KeyData == Keys.Escape)
                    IAppHandler.FindActiveForm().btnCancel.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.P))
                    IAppHandler.FindActiveForm().btnPreview.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.F4))
                    IAppHandler.FindActiveForm().btnClose.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.F))
                {
                    if (IAppHandler.FindActiveForm().IsListForm())
                        IAppHandler.FindActiveForm().toolStriptxtFind.Focus();
                }

                if (e.KeyData == (Keys.Control | Keys.Home))
                    IAppHandler.FindActiveForm().btnFirstRecord.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.Left))
                    IAppHandler.FindActiveForm().btnFirstRecord.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.Right))
                    IAppHandler.FindActiveForm().btnNextRecord.PerformClick();

                if (e.KeyData == (Keys.Control | Keys.End))
                    IAppHandler.FindActiveForm().btnLastRecord.PerformClick();
            }
        #endregion

        #region Custom Procedures and Functions
            public void GetCategories()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                String VCommandText =
                    "SELECT Id, Name, [Index] " +
                    "FROM tblSystemCategories " +
                    "ORDER BY [Index]";

                VTransactionHandler.LoadData(VCommandText, ref IAppHandler.Categories, null);
            }

            public void GetSubCategories()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                String  VCommandText =
                    "SELECT sc.Name AS Category, ssc.Name, ssc.Structure, ssc.ListForm, ssc.MasterForm " +
                    "FROM tblSystemSubCategories ssc " +
                    "   INNER JOIN tblSystemCategories sc ON sc.Id = ssc.CategoryId " +
                    "ORDER BY sc.[Index], ssc.[Index]";
                
                VTransactionHandler.LoadData(VCommandText, ref IAppHandler.SubCategories, null);
            }

            public GroupBox AddCategories(string caption)
            {
                GroupBox box = new GroupBox();
                TreeView treeView = new TreeView();
                string subcat;
                string oldNode = "";

                box.Name = "groupBox" + caption;
                box.Text = caption;
                box.Dock = DockStyle.Fill;
                box.BackColor = Color.Silver;
                box.Font = new Font(Font.Name, 11, FontStyle.Bold);
                box.ForeColor = Color.Maroon;

                treeView.Name = "treeView" + caption;
                treeView.Dock = DockStyle.Fill;
                treeView.Font = new Font(Font.Name, 8, FontStyle.Regular);
                treeView.ImageList = imageList;
                treeView.ImageIndex = 0;
                treeView.Indent = 19;
                treeView.ItemHeight = 18;
                treeView.Cursor = Cursors.Hand;
                treeView.BackColor = Color.Silver;
                treeView.NodeMouseClick += treeView_NodeMouseClick;
                treeView.Tag = caption;

                try
                {
                    treeView.BeginUpdate();                  
                    for (int i = 0; i <= IAppHandler.SubCategories.Rows.Count - 1; i++)
                    {
                        subcat = IAppHandler.SubCategories.Rows[i]["Structure"].ToString();
                        if (subcat.Contains(caption))
                        {
                            string[] str = subcat.Split('.');
                            TreeNode node;

                            if (!oldNode.Contains(str[1]))
                            {
                                node = new TreeNode(str[1]);
                                oldNode = str[1];
                                treeView.Nodes.Add(node);
                            }
                            else
                            {
                                treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add(str[2]);
                            }
                        }
                    }
                }
                finally
                {
                    treeView.EndUpdate();
                }
                box.Controls.Add(treeView);

                return box;
            }

            private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
            {
                string formname = null;
                IParentForm form;

                if (e.Node.Nodes.Count == 0)
                {
                    try
                    {
                        IAppHandler.StartBusy("Opening list form");
                        if (IAppHandler.FindActiveForm() != null)
                        {
                            IAppHandler.AddUsedForm(IAppHandler.FindActiveForm());
                            IAppHandler.FindActiveForm().Hide();
                        }

                        formname = IAppHandler.GetSubCategory(e.Node.Text, e.Node.TreeView.Tag.ToString(), "ListForm");

                        if (formname != null)
                        {
                            form = IAppHandler.FindForm(formname, e.Node.Text);

                            if (form != null)
                            {
                                form.SubCategory = e.Node.Text;
                                form.Run();
                            }
                            else
                                IMessageHandler.Inform(ISystemMessages.NoFormMessage);
                        }
                    }
                    finally
                    {
                        IAppHandler.EndBusy("Opening list form");
                    }
                }
            }

            public void CreateCategories()
            { 
                int RowHeight = tableLayoutPanelSide.Height / IAppHandler.Categories.Rows.Count;

                for (int i = 0; i <= IAppHandler.Categories.Rows.Count - 1; i++)
                {
                    if (i > 0)
                        tableLayoutPanelSide.RowCount = tableLayoutPanelSide.RowCount + 1;
                    tableLayoutPanelSide.RowStyles.Add(new RowStyle(SizeType.Absolute, RowHeight));
                    tableLayoutPanelSide.Controls.Add(AddCategories(IAppHandler.Categories.Rows[i]["Name"].ToString()), 0, i);
                }
            }

            public void SetProductName()
            {
                ITransactionHandler VTransactionHandler = new ITransactionHandler();
                DataTable VDataTable = new DataTable();
                String CommandText = "SELECT ProductName, ProductVersion FROM tblSystemConfiguration";

                try
                {
                    VTransactionHandler.LoadData(CommandText, ref VDataTable, null);
                    ISecurityHandler.ProductName = VDataTable.Rows[0]["ProductName"].ToString();
                    ISecurityHandler.ProductVersion = VDataTable.Rows[0]["ProductVersion"].ToString();
                    this.Text = ISecurityHandler.ProductName + " - Version " + ISecurityHandler.ProductVersion;
                    IMessageHandler.MessageCaption = this.Text;
                }
                finally
                {
                    VDataTable.Dispose();
                }
            }

            public void SetLoginDetails()
            {
                lblCompanyValue.Text = ISecurityHandler.CompanyName;
                lblUserValue.Text = ISecurityHandler.SecurityUserName;
                lblTimeValue.Text = IAppHandler.ConvertMaskValue("@Date").ToString();
                timerDuration.Start();
            }
        #endregion
    }
}
