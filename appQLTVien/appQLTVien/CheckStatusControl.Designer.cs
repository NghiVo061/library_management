namespace appQLTVien
{
    partial class CheckStatusControl
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
            this.cboBookTitle = new System.Windows.Forms.ComboBox();
            this.cboIDbook = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBookTitle
            // 
            this.cboBookTitle.FormattingEnabled = true;
            this.cboBookTitle.Location = new System.Drawing.Point(352, 107);
            this.cboBookTitle.Name = "cboBookTitle";
            this.cboBookTitle.Size = new System.Drawing.Size(222, 24);
            this.cboBookTitle.TabIndex = 0;
            
            // 
            // cboIDbook
            // 
            this.cboIDbook.FormattingEnabled = true;
            this.cboIDbook.Location = new System.Drawing.Point(352, 166);
            this.cboIDbook.Name = "cboIDbook";
            this.cboIDbook.Size = new System.Drawing.Size(222, 24);
            this.cboIDbook.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn mã sách";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(349, 220);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 16);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Số lượng tồn kho: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(349, 258);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Trạng thái: ";
            // 
            // CheckStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIDbook);
            this.Controls.Add(this.cboBookTitle);
            this.Name = "CheckStatusControl";
            this.Size = new System.Drawing.Size(796, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBookTitle;
        private System.Windows.Forms.ComboBox cboIDbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStatus;
    }
}
