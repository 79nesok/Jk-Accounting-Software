namespace Free_Accounting_Software.Internal.Forms
{
    partial class IMasterForm
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
            this.FormFooter = new System.Windows.Forms.Panel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            this.FormFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Size = new System.Drawing.Size(775, 409);
            // 
            // FormFooter
            // 
            this.FormFooter.AutoScroll = true;
            this.FormFooter.BackColor = System.Drawing.Color.Silver;
            this.FormFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormFooter.Controls.Add(this.lblCreatedBy);
            this.FormFooter.Controls.Add(this.lblModifiedBy);
            this.FormFooter.Controls.Add(this.lblMode);
            this.FormFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FormFooter.Location = new System.Drawing.Point(0, 375);
            this.FormFooter.Name = "FormFooter";
            this.FormFooter.Size = new System.Drawing.Size(775, 34);
            this.FormFooter.TabIndex = 4;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(0, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCreatedBy.Size = new System.Drawing.Size(136, 15);
            this.lblCreatedBy.TabIndex = 1;
            this.lblCreatedBy.Text = "Created by:   <Creator>";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedBy.ForeColor = System.Drawing.Color.Black;
            this.lblModifiedBy.Location = new System.Drawing.Point(0, 15);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblModifiedBy.Size = new System.Drawing.Size(143, 15);
            this.lblModifiedBy.TabIndex = 2;
            this.lblModifiedBy.Text = "Modified by: <Modifier>";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(667, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Padding = new System.Windows.Forms.Padding(5);
            this.lblMode.Size = new System.Drawing.Size(104, 25);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "Mode:  <Mode>";
            // 
            // IMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Caption = "Master Form";
            this.Controls.Add(this.FormFooter);
            this.Name = "IMasterForm";
            this.Size = new System.Drawing.Size(775, 409);
            this.BeforeRun += new Free_Accounting_Software.Internal.Forms.IParentForm.BeforeRunHandler(this.IMasterForm_BeforeRun);
            this.BeforeSave += new Free_Accounting_Software.Internal.Forms.IParentForm.BeforeSaveHandler(this.IMasterForm_BeforeSave);
            this.AfterRun += new Free_Accounting_Software.Internal.Forms.IParentForm.AfterRunHandler(this.IMasterForm_AfterRun);
            this.Controls.SetChildIndex(this.splitContainer, 0);
            this.Controls.SetChildIndex(this.FormFooter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.VDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.FormFooter.ResumeLayout(false);
            this.FormFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormFooter;
        protected System.Windows.Forms.Label lblCreatedBy;
        protected System.Windows.Forms.Label lblModifiedBy;
        protected System.Windows.Forms.Label lblMode;







    }
}
