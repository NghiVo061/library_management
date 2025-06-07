namespace appQLTVien
{
    partial class EditpenaltyC
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
            this.lblFineID = new System.Windows.Forms.Label();
            this.txtFineID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFineID
            // 
            this.lblFineID.AutoSize = true;
            this.lblFineID.Location = new System.Drawing.Point(167, 154);
            this.lblFineID.Name = "lblFineID";
            this.lblFineID.Size = new System.Drawing.Size(127, 16);
            this.lblFineID.TabIndex = 0;
            this.lblFineID.Text = "Nhập mã phiếu phạt";
            // 
            // txtFineID
            // 
            this.txtFineID.Location = new System.Drawing.Point(330, 154);
            this.txtFineID.Name = "txtFineID";
            this.txtFineID.Size = new System.Drawing.Size(239, 22);
            this.txtFineID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 248);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 53);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EditpenaltyC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFineID);
            this.Controls.Add(this.lblFineID);
            this.Name = "EditpenaltyC";
            this.Size = new System.Drawing.Size(1475, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFineID;
        private System.Windows.Forms.TextBox txtFineID;
        private System.Windows.Forms.Button btnSearch;
    }
}