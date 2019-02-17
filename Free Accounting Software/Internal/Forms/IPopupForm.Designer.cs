namespace Free_Accounting_Software.Internal.Forms
{
    partial class IPopupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerBase = new System.Windows.Forms.SplitContainer();
            this.lblCaption = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).BeginInit();
            this.splitContainerBase.Panel1.SuspendLayout();
            this.splitContainerBase.Panel2.SuspendLayout();
            this.splitContainerBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerBase
            // 
            this.splitContainerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBase.IsSplitterFixed = true;
            this.splitContainerBase.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBase.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerBase.Name = "splitContainerBase";
            this.splitContainerBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBase.Panel1
            // 
            this.splitContainerBase.Panel1.Controls.Add(this.lblCaption);
            // 
            // splitContainerBase.Panel2
            // 
            this.splitContainerBase.Panel2.Controls.Add(this.dataGridView);
            this.splitContainerBase.Size = new System.Drawing.Size(489, 452);
            this.splitContainerBase.SplitterDistance = 30;
            this.splitContainerBase.SplitterWidth = 1;
            this.splitContainerBase.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Maroon;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(489, 30);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Popup Form";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(489, 421);
            this.dataGridView.TabIndex = 0;
            // 
            // IPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 452);
            this.Controls.Add(this.splitContainerBase);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IPopupForm";
            this.Text = "IPopupForm";
            this.splitContainerBase.Panel1.ResumeLayout(false);
            this.splitContainerBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBase)).EndInit();
            this.splitContainerBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBase;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}