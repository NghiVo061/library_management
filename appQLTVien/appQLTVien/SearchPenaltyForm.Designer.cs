using System;

namespace appQLTVien
{
    partial class SearchPenaltyForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPenaltyIDResult;
        private System.Windows.Forms.TextBox txtPenaltyIDResult;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.TextBox txtLateDays;
        private System.Windows.Forms.Label lblPenaltyAmount;
        private System.Windows.Forms.TextBox txtPenaltyAmount;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.TextBox txtBookStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cboPaymentStatus;
        private System.Windows.Forms.Button btnConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPenaltyIDResult = new System.Windows.Forms.Label();
            this.txtPenaltyIDResult = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.txtLateDays = new System.Windows.Forms.TextBox();
            this.lblPenaltyAmount = new System.Windows.Forms.Label();
            this.txtPenaltyAmount = new System.Windows.Forms.TextBox();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.txtBookStatus = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cboPaymentStatus = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(17, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chỉnh sửa thông tin phí phạt";
            // 
            // lblPenaltyIDResult
            // 
            this.lblPenaltyIDResult.AutoSize = true;
            this.lblPenaltyIDResult.Location = new System.Drawing.Point(20, 130);
            this.lblPenaltyIDResult.Name = "lblPenaltyIDResult";
            this.lblPenaltyIDResult.Size = new System.Drawing.Size(92, 16);
            this.lblPenaltyIDResult.TabIndex = 2;
            this.lblPenaltyIDResult.Text = "Mã phiếu phạt:";
            // 
            // txtPenaltyIDResult
            // 
            this.txtPenaltyIDResult.Location = new System.Drawing.Point(130, 130);
            this.txtPenaltyIDResult.Name = "txtPenaltyIDResult";
            this.txtPenaltyIDResult.Size = new System.Drawing.Size(200, 22);
            this.txtPenaltyIDResult.TabIndex = 3;
            this.txtPenaltyIDResult.ReadOnly = true;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(20, 170);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(92, 16);
            this.lblMemberID.TabIndex = 3;
            this.lblMemberID.Text = "Mã thành viên:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(130, 170);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(200, 22);
            this.txtMemberID.TabIndex = 3;
            this.txtMemberID.ReadOnly = true;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(20, 220);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(61, 16);
            this.lblBookID.TabIndex = 4;
            this.lblBookID.Text = "Mã sách:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(130, 220);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(200, 22);
            this.txtBookID.TabIndex = 4;
            this.txtBookID.ReadOnly = true;
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Location = new System.Drawing.Point(20, 270);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(78, 16);
            this.lblLateDays.TabIndex = 5;
            this.lblLateDays.Text = "Số ngày trễ:";
            // 
            // txtLateDays
            // 
            this.txtLateDays.Location = new System.Drawing.Point(130, 270);
            this.txtLateDays.Name = "txtLateDays";
            this.txtLateDays.Size = new System.Drawing.Size(200, 22);
            this.txtLateDays.TabIndex = 5;
            this.txtLateDays.ReadOnly = true;
            // 
            // lblPenaltyAmount
            // 
            this.lblPenaltyAmount.AutoSize = true;
            this.lblPenaltyAmount.Location = new System.Drawing.Point(20, 320);
            this.lblPenaltyAmount.Name = "lblPenaltyAmount";
            this.lblPenaltyAmount.Size = new System.Drawing.Size(80, 16);
            this.lblPenaltyAmount.TabIndex = 6;
            this.lblPenaltyAmount.Text = "Số tiền phạt:";
            // 
            // txtPenaltyAmount
            // 
            this.txtPenaltyAmount.Location = new System.Drawing.Point(130, 320);
            this.txtPenaltyAmount.Name = "txtPenaltyAmount";
            this.txtPenaltyAmount.Size = new System.Drawing.Size(200, 22);
            this.txtPenaltyAmount.TabIndex = 6;
            this.txtPenaltyAmount.ReadOnly = true;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Location = new System.Drawing.Point(20, 370);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(101, 16);
            this.lblBookStatus.TabIndex = 7;
            this.lblBookStatus.Text = "Tình trạng sách:";
            // 
            // txtBookStatus
            // 
            this.txtBookStatus.Location = new System.Drawing.Point(130, 370);
            this.txtBookStatus.Name = "txtBookStatus";
            this.txtBookStatus.Size = new System.Drawing.Size(200, 22);
            this.txtBookStatus.TabIndex = 7;
            this.txtBookStatus.ReadOnly = true;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(20, 420);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(133, 16);
            this.lblPaymentStatus.TabIndex = 8;
            this.lblPaymentStatus.Text = "Tình trạng thanh toán:";
            // 
            // cboPaymentStatus
            // 
            this.cboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentStatus.FormattingEnabled = true;
            this.cboPaymentStatus.Location = new System.Drawing.Point(130, 420);
            this.cboPaymentStatus.Name = "cboPaymentStatus";
            this.cboPaymentStatus.Size = new System.Drawing.Size(200, 24);
            this.cboPaymentStatus.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnConfirm.Location = new System.Drawing.Point(130, 480);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 25);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SearchPenaltyForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 530);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPenaltyIDResult);
            this.Controls.Add(this.txtPenaltyIDResult);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblLateDays);
            this.Controls.Add(this.txtLateDays);
            this.Controls.Add(this.lblPenaltyAmount);
            this.Controls.Add(this.txtPenaltyAmount);
            this.Controls.Add(this.lblBookStatus);
            this.Controls.Add(this.txtBookStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.cboPaymentStatus);
            this.Controls.Add(this.btnConfirm);
            this.Name = "SearchPenaltyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin phí phạt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}