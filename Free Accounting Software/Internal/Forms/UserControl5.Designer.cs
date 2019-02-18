namespace Free_Accounting_Software.Internal.Forms
{
    partial class UserControl5
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
            this.jkDataGridView1 = new JkComponents.JkDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jkDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jkDataGridView1
            // 
            this.jkDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jkDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.jkDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jkDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.jkDataGridView1.Name = "jkDataGridView1";
            this.jkDataGridView1.Size = new System.Drawing.Size(526, 358);
            this.jkDataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jkDataGridView1);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(526, 358);
            ((System.ComponentModel.ISupportInitialize)(this.jkDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JkComponents.JkDataGridView jkDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
