namespace Jk_Accounting_Software.Internal.Forms
{
    partial class IListForm
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
            this.GridFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Panel2.Controls.Add(this.GridFooter);
            this.splitContainer.Size = new System.Drawing.Size(836, 481);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(803, 0);
            // 
            // GridFooter
            // 
            this.GridFooter.AutoScroll = true;
            this.GridFooter.BackColor = System.Drawing.Color.Ivory;
            this.GridFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridFooter.Location = new System.Drawing.Point(0, 378);
            this.GridFooter.Name = "GridFooter";
            this.GridFooter.Size = new System.Drawing.Size(836, 34);
            this.GridFooter.TabIndex = 0;
            this.GridFooter.WrapContents = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Size = new System.Drawing.Size(836, 378);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnWidthChanged);
            this.dataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_Scroll);
            // 
            // IListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "List Form";
            this.Name = "IListForm";
            this.Size = new System.Drawing.Size(836, 481);
            this.BeforeRun += new Jk_Accounting_Software.Internal.Forms.IParentForm.BeforeRunHandler(this.IListForm_BeforeRun);
            this.AfterRun += new Jk_Accounting_Software.Internal.Forms.IParentForm.AfterRunHandler(this.IListForm_AfterRun);
            ((System.ComponentModel.ISupportInitialize)(this.VMasterDataTable)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GridFooter;
        private System.Windows.Forms.DataGridView dataGridView;




    }
}
