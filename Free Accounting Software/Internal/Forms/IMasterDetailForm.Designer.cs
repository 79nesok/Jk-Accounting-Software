﻿namespace Free_Accounting_Software.Internal.Forms
{
    partial class IMasterDetailForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerMasterDetail = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VDetailDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).BeginInit();
            this.splitContainerMasterDetail.Panel2.SuspendLayout();
            this.splitContainerMasterDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.Location = new System.Drawing.Point(681, 0);
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerMasterDetail);
            this.splitContainer.Size = new System.Drawing.Size(789, 561);
            // 
            // splitContainerMasterDetail
            // 
            this.splitContainerMasterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMasterDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMasterDetail.IsSplitterFixed = true;
            this.splitContainerMasterDetail.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMasterDetail.Name = "splitContainerMasterDetail";
            this.splitContainerMasterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMasterDetail.Panel2
            // 
            this.splitContainerMasterDetail.Panel2.Controls.Add(this.dataGridView);
            this.splitContainerMasterDetail.Size = new System.Drawing.Size(789, 492);
            this.splitContainerMasterDetail.SplitterDistance = 218;
            this.splitContainerMasterDetail.SplitterWidth = 1;
            this.splitContainerMasterDetail.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.GridColor = System.Drawing.Color.Peru;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(789, 273);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // IMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Master Detail Form";
            this.Name = "IMasterDetailForm";
            this.Size = new System.Drawing.Size(789, 561);
            this.BeforeRun += new Free_Accounting_Software.Internal.Forms.IParentForm.BeforeRunHandler(this.IMasterDetailForm_BeforeRun);
            ((System.ComponentModel.ISupportInitialize)(this.VDetailDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMasterDetail)).EndInit();
            this.splitContainerMasterDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainerMasterDetail;
        private System.Windows.Forms.DataGridView dataGridView;

    }
}