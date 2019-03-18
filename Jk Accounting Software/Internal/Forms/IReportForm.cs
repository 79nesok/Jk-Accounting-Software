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
using JkComponents;
using Jk_Accounting_Software.Internal.Classes;
using Microsoft.Reporting.WinForms;

namespace Jk_Accounting_Software.Internal.Forms
{
    public partial class IReportForm : IMasterForm
    {
        #region Variable declarations
            [Browsable(false)]
            public String PrintoutHeader { get; set; }
        #endregion

        #region Built-in Events
        public IReportForm()
            {
                InitializeComponent();
                btnFilter.Click += btnFilter_Click;
                btnRemoveFilter.Click += btnRemoveFilter_Click;
            }

            private void btnRemoveFilter_Click(object sender, EventArgs e)
            {
                btnFilter.Checked = false;
                btnRemoveFilter.Enabled = false;
                GenerateReport();
            }

            private void btnFilter_Click(object sender, EventArgs e)
            {
                List<String> filters = new List<String>();

                filters.Add("(All)");
                filters.Add("Asset");
                filters.Add("Liability");
                filters.Add("Equity");
                filters.Add("Income");
                filters.Add("Expense");

                if (IPopupForm.ShowSelection("EReportFilterSelectionForm", "Type", filters) == DialogResult.OK)
                {
                    GenerateReport();
                    btnFilter.Checked = true;
                }

                btnRemoveFilter.Enabled = btnFilter.Checked;
            }

            private void IReportForm_BeforeRun()
            {
                foreach (JkFormParameter param in Parameters)
                    param.Value = IAppHandler.ConvertMaskValue(param.Value).ToString();

                CreateReportParameters();
            }

            private void IReportForm_AfterRun()
            {
                GenerateReport();
            }

            protected override void UpdateControls()
            {
                base.UpdateControls();

                btnHolder.Visible = false;

                btnFilter.Visible = this.Caption == "Report";
                btnRemoveFilter.Visible = this.Caption == "Report";
                btnRemoveFilter.Enabled = btnFilter.Checked;

                btnFirstRecord.Visible = false;
                NavigatorSeparatorFirst.Visible = false;
                btnPreviousRecord.Visible = false;
                btnNextRecord.Visible = false;
                NavigatorSeparatorSecond.Visible = false;
                btnLastRecord.Visible = false;

                lblCreatedBy.Visible = false;
                lblModifiedBy.Visible = false;
                lblMode.Visible = false;

                foreach (ToolStripItem item in toolStripReportParam.Items)
                    item.Enabled = true;
            }

            private void IReportForm_Resize(object sender, EventArgs e)
            {
                reportViewer.Size = new Size(splitContainerReport.Panel2.Width, splitContainerReport.Panel2.Height - FormFooter.Height);
            }

            private void reportViewer_ReportRefresh(object sender, CancelEventArgs e)
            {
                try
                {
                    IAppHandler.StartBusy("Reloading report");
                }
                finally
                {
                    IAppHandler.EndBusy("Reloading report");
                }
            }
        #endregion

        #region Custom Functions and Procedures
            private void CreateReportParameters()
            {
                if (toolStripReportParam.Items.Count == 0)
                {
                    if (Parameters.Find(p => p.Name == "FromDate") != null && Parameters.Find(p => p.Name == "ToDate") != null)
                    {
                        ToolStripLabel labelFrom = new ToolStripLabel();
                        ToolStripLabel labelTo = new ToolStripLabel();
                        DateTimePicker dateTimePickerFrom = new DateTimePicker();
                        DateTimePicker dateTimePickerTo = new DateTimePicker();
                        Button btnDateRangeSelection = new Button();
                        String FromDateDefault = Parameters.Find(p => p.Name == "FromDate").Value;
                        String ToDateDefault= Parameters.Find(p => p.Name == "ToDate").Value;

                        if (!String.IsNullOrWhiteSpace(FromDateDefault))
                            dateTimePickerFrom.Value = IDateHandler.Parse(IAppHandler.ConvertMaskValue(FromDateDefault).ToString());

                        if (!String.IsNullOrWhiteSpace(ToDateDefault))
                            dateTimePickerTo.Value = IDateHandler.Parse(IAppHandler.ConvertMaskValue(ToDateDefault).ToString());

                        labelFrom.Name = "ControlLabelFromDate";
                        labelFrom.Text = "From:";

                        dateTimePickerFrom.Name = "ControlFromDate";
                        dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
                        dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
                        dateTimePickerFrom.Width = 100;

                        labelTo.Name = "ControlLabelToDate";
                        labelTo.Text = "To:";

                        dateTimePickerTo.Name = "ControlToDate";
                        dateTimePickerTo.Format = DateTimePickerFormat.Custom;
                        dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
                        dateTimePickerTo.Width = 100;

                        btnDateRangeSelection.Name = "ControlDateRangeSelection";
                        btnDateRangeSelection.Text = "...";
                        btnDateRangeSelection.Width = 30;
                        btnDateRangeSelection.BackColor = Color.Gainsboro;
                        btnDateRangeSelection.Click += btnDateRangeSelection_Click;

                        toolStripReportParam.Items.Add(labelFrom);
                        toolStripReportParam.Items.Add(new ToolStripControlHost(dateTimePickerFrom));
                        toolStripReportParam.Items.Add(labelTo);
                        toolStripReportParam.Items.Add(new ToolStripControlHost(dateTimePickerTo));
                        toolStripReportParam.Items.Add(new ToolStripControlHost(btnDateRangeSelection));
                    }

                    foreach (JkFormParameter param in this.Parameters)
                    {
                        if (param.Visible)
                        {
                            if (toolStripReportParam.Items.Count > 0)
                            {
                                ToolStripSeparator separator = new ToolStripSeparator();

                                separator.Name = "Separator" + param.Name;
                                toolStripReportParam.Items.Add(separator);
                            }

                            //not lookup
                            if (String.IsNullOrWhiteSpace(param.ControlName))
                            {
                                if (param.Name != "FromDate" && param.Name != "ToDate")
                                {
                                    if (param.Type == SqlDbType.DateTime)
                                    {
                                        ToolStripLabel label = new ToolStripLabel();
                                        DateTimePicker dateTimePicker = new DateTimePicker();

                                        label.Name = "ControlLabel" + param.Name;
                                        label.Text = param.Caption + ":";

                                        dateTimePicker.Name = "Control" + param.Name;
                                        dateTimePicker.Format = DateTimePickerFormat.Custom;
                                        dateTimePicker.CustomFormat = "MM/dd/yyyy";
                                        dateTimePicker.Width = 100;

                                        toolStripReportParam.Items.Add(label);
                                        toolStripReportParam.Items.Add(new ToolStripControlHost(dateTimePicker));
                                    }
                                    else if (param.Type == SqlDbType.Bit)
                                    {
                                        ToolStripLabel label = new ToolStripLabel();
                                        CheckBox checkBox = new CheckBox();

                                        label.Name = "ControlLabel" + param.Name;
                                        label.Text = param.Caption + ":";

                                        checkBox.Name = "Control" + param.Name;
                                        checkBox.Checked = Boolean.Parse(param.Value);

                                        toolStripReportParam.Items.Add(label);
                                        toolStripReportParam.Items.Add(new ToolStripControlHost(checkBox));
                                    }
                                }
                            }
                            else
                            {
                                JkLookUpComboBox lookUp = (Controls.Find(param.ControlName, true).First() as JkLookUpComboBox);
                                ToolStripLabel label = new ToolStripLabel();
                                ComboBox comboBox = new ComboBox();

                                if (lookUp.Items.Count == 0)
                                    lookUp.LoadData();

                                label.Name = "ControlLabel" + param.Name;
                                label.Text = param.Caption + ":";

                                comboBox.Name = "Control" + param.Name;
                                comboBox.DataSource = lookUp.Items;
                                comboBox.DisplayMember = lookUp.DisplayText;
                                comboBox.ValueMember = lookUp.Key;
                                comboBox.Width = param.Width;

                                toolStripReportParam.Items.Add(label);
                                toolStripReportParam.Items.Add(new ToolStripControlHost(comboBox));
                            }
                        }
                    }

                    if (toolStripReportParam.Items.Count > 0)
                    {
                        ToolStripButton button = new ToolStripButton();
                        ToolStripSeparator btnSeparator = new ToolStripSeparator();

                        btnSeparator.Name = "SeparatorButtonGo";

                        button.Name = "ControlButtonGo";
                        button.DisplayStyle = ToolStripItemDisplayStyle.Text;
                        button.Text = "  GO  ";
                        button.BackColor = Color.SteelBlue;
                        button.Click += delegate(object s, EventArgs ea)
                        {
                            GenerateReport();
                        };

                        toolStripReportParam.Items.Add(btnSeparator);
                        toolStripReportParam.Items.Add(button);
                    }
                }
            }

            private void btnDateRangeSelection_Click(object sender, EventArgs e)
            {
                if (Parameters.Find(p => p.Name == "FromDate") != null && Parameters.Find(p => p.Name == "ToDate") != null)
                {
                    Control control = sender as Control;
                    DateTimePicker FromDate = (Controls.Find("ControlFromDate", true).First() as DateTimePicker);
                    DateTimePicker ToDate = (Controls.Find("ControlToDate", true).First() as DateTimePicker);
                    ContextMenu menu = new ContextMenu();

                    //init
                    MenuItem AllDates = new MenuItem();
                    MenuItem PreviousYear = new MenuItem();
                    MenuItem CurrentYear = new MenuItem();
                    MenuItem NextYear = new MenuItem();
                    MenuItem PreviousMonth = new MenuItem();
                    MenuItem CurrentMonth = new MenuItem();
                    MenuItem NextMonth = new MenuItem();
                    MenuItem Yesterday = new MenuItem();
                    MenuItem Today = new MenuItem();
                    MenuItem Tomorrow = new MenuItem();

                    //text
                    AllDates.Text = "All Dates";
                    PreviousYear.Text = "Previous Year";
                    CurrentYear.Text = "Current Year";
                    NextYear.Text = "Next Year";
                    PreviousMonth.Text = "Previous Month";
                    CurrentMonth.Text = "Current Month";
                    NextMonth.Text = "Next Month";
                    Yesterday.Text = "Yesterday";
                    Today.Text = "Today";
                    Tomorrow.Text = "Tomorrow";

                    //events
                    AllDates.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.AllDates(true);
                        ToDate.Value = IDateHandler.AllDates(false);

                        GenerateReport();
                    };
                    PreviousYear.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.PreviousYear(true);
                        ToDate.Value = IDateHandler.PreviousYear(false);

                        GenerateReport();
                    };
                    CurrentYear.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.CurrentYear(true);
                        ToDate.Value = IDateHandler.CurrentYear(false);

                        GenerateReport();
                    };
                    NextYear.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.NextYear(true);
                        ToDate.Value = IDateHandler.NextYear(false);

                        GenerateReport();
                    };
                    PreviousMonth.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.PreviousMonth(true);
                        ToDate.Value = IDateHandler.PreviousMonth(false);

                        GenerateReport();
                    };
                    CurrentMonth.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.CurrentMonth(true);
                        ToDate.Value = IDateHandler.CurrentMonth(false);

                        GenerateReport();
                    };
                    NextMonth.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = IDateHandler.NextMonth(true);
                        ToDate.Value = IDateHandler.NextMonth(false);

                        GenerateReport();
                    };
                    Yesterday.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = DateTime.Now.AddDays(-1);
                        ToDate.Value = DateTime.Now.AddDays(-1);

                        GenerateReport();
                    };
                    Today.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = DateTime.Now;
                        ToDate.Value = DateTime.Now;

                        GenerateReport();
                    };
                    Tomorrow.Click += delegate(object s, EventArgs ea)
                    {
                        FromDate.Value = DateTime.Now.AddDays(1);
                        ToDate.Value = DateTime.Now.AddDays(1);

                        GenerateReport();
                    };

                    //add
                    menu.MenuItems.Add(AllDates);
                    menu.MenuItems.Add("-");
                    menu.MenuItems.Add(PreviousYear);
                    menu.MenuItems.Add(CurrentYear);
                    menu.MenuItems.Add(NextYear);
                    menu.MenuItems.Add("-");
                    menu.MenuItems.Add(PreviousMonth);
                    menu.MenuItems.Add(CurrentMonth);
                    menu.MenuItems.Add(NextMonth);
                    menu.MenuItems.Add("-");
                    menu.MenuItems.Add(Yesterday);
                    menu.MenuItems.Add(Today);
                    menu.MenuItems.Add(Tomorrow);

                    menu.Show(this, new Point(control.Location.X + control.Size.Width, control.Location.Y));
                }
            }

            protected virtual void RefreshReport()
            {
                String paramName = null;
                JkFormParameter param = null;

                reportViewer.Focus();
                toolStripReportParam.Visible = true;
                foreach (ToolStripItem item in toolStripReportParam.Items)
                {
                    if (item is ToolStripControlHost)
                        paramName = (item as ToolStripControlHost).Control.Name.Replace("Control", "");
                    else
                        paramName = item.Name.Replace("Control", "");

                    param = Parameters.Find(p => p.Name == paramName);
                    if (param != null)
                    {
                        if (item is ToolStripControlHost)
                        {
                            if ((item as ToolStripControlHost).Control is DateTimePicker)
                                param.Value = ((item as ToolStripControlHost).Control as DateTimePicker).Value.ToShortDateString();
                            else if ((item as ToolStripControlHost).Control is CheckBox)
                                param.Value = ((item as ToolStripControlHost).Control as CheckBox).Checked.ToString();
                        }
                    }
                }
            }

            private void GenerateReport()
            {
                try
                {
                    IAppHandler.StartBusy("Generating report");
                    RefreshReport();
                }
                finally
                {
                    IAppHandler.EndBusy("Generating report");
                }
            }
        #endregion
    }
}
