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
using Free_Accounting_Software.Internal.Classes;

namespace Free_Accounting_Software.Internal.Forms
{
    public partial class IReportForm : IMasterForm
    {
        public IReportForm()
        {
            InitializeComponent();
        }

        private void IReportForm_BeforeRun()
        {
            foreach (JkFormParameter param in Parameters)
                param.Value = IAppHandler.ConvertMaskValue(param.Value).ToString();

            CreateReportParameters();
        }

        private void IReportForm_AfterRun()
        {
            RefreshReport();
        }

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

                    toolStripReportParam.Items.Add(labelFrom);
                    toolStripReportParam.Items.Add(new ToolStripControlHost(dateTimePickerFrom));
                    toolStripReportParam.Items.Add(labelTo);
                    toolStripReportParam.Items.Add(new ToolStripControlHost(dateTimePickerTo));
                }

                foreach (JkFormParameter param in this.Parameters)
                {
                    if (param.Visible)
                    {
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
                    button.Text = "GO";
                    button.BackColor = Color.SteelBlue;
                    button.Click += delegate(object s, EventArgs ea)
                    {
                        try
                        {
                            IAppHandler.StartBusy("Generating Report");
                            RefreshReport();
                        }
                        finally
                        {
                            IAppHandler.EndBusy("Generating Report");
                        }
                    };

                    toolStripReportParam.Items.Add(btnSeparator);
                    toolStripReportParam.Items.Add(button);
                }
            }
        }

        protected virtual void RefreshReport()
        {
            String paramName = null;
            JkFormParameter param = null;

            reportViewer.Focus();
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
                        {
                            param.Value = ((item as ToolStripControlHost).Control as DateTimePicker).Value.ToShortDateString();
                        }
                    }
                }
            }
        }

        protected override void UpdateControls()
        {
            base.UpdateControls();

            btnHolder.Visible = false;
            btnNavigator.Visible = false;
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
    }
}
