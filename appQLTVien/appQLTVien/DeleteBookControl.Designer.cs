namespace appQLTVien
{
    partial class DeleteBookControl
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDbook = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(322, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 65);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa sách";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã sách muốn xóa";
            // 
            // txtIDbook
            // 
            this.txtIDbook.Location = new System.Drawing.Point(394, 140);
            this.txtIDbook.Name = "txtIDbook";
            this.txtIDbook.Size = new System.Drawing.Size(237, 22);
            this.txtIDbook.TabIndex = 2;
            // 
            // DeleteBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIDbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Name = "DeleteBookControl";
            this.Size = new System.Drawing.Size(787, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDbook;
    }
}
