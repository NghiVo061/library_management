namespace appQLTVien
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManageBorrow;
        private System.Windows.Forms.Button btnManageProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnBorrowHistory;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnChangePassword;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageProfile = new System.Windows.Forms.Button();
            this.btnManageBorrow = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnBorrowHistory = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnManageProfile);
            this.panelMenu.Controls.Add(this.btnManageBorrow);
            this.panelMenu.Controls.Add(this.btnSearchBook);
            this.panelMenu.Controls.Add(this.btnBorrowHistory);
            this.panelMenu.Controls.Add(this.btnViewProfile);
            this.panelMenu.Controls.Add(this.btnEditProfile);
            this.panelMenu.Controls.Add(this.btnChangePassword);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(297, 600);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.AutoScroll = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(215)))), ((int)(((byte)(195)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 530);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageProfile
            // 
            this.btnManageProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnManageProfile.FlatAppearance.BorderSize = 0;
            this.btnManageProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnManageProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnManageProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProfile.Location = new System.Drawing.Point(0, 130);
            this.btnManageProfile.Name = "btnManageProfile";
            this.btnManageProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageProfile.Size = new System.Drawing.Size(250, 50);
            this.btnManageProfile.TabIndex = 2;
            this.btnManageProfile.Text = "  Quản lý thông tin cá nhân";
            this.btnManageProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProfile.UseVisualStyleBackColor = false;
            this.btnManageProfile.Click += new System.EventHandler(this.btnManageProfile_Click);
            // 
            // btnManageBorrow
            // 
            this.btnManageBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnManageBorrow.FlatAppearance.BorderSize = 0;
            this.btnManageBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnManageBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBorrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnManageBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBorrow.Location = new System.Drawing.Point(0, 80);
            this.btnManageBorrow.Name = "btnManageBorrow";
            this.btnManageBorrow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBorrow.Size = new System.Drawing.Size(250, 50);
            this.btnManageBorrow.TabIndex = 1;
            this.btnManageBorrow.Text = "  Quản lý mượn sách";
            this.btnManageBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBorrow.UseVisualStyleBackColor = false;
            this.btnManageBorrow.Click += new System.EventHandler(this.btnManageBorrow_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnSearchBook.FlatAppearance.BorderSize = 0;
            this.btnSearchBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnSearchBook.Location = new System.Drawing.Point(20, 280);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSearchBook.Size = new System.Drawing.Size(230, 40);
            this.btnSearchBook.TabIndex = 4;
            this.btnSearchBook.Text = "  Tìm kiếm";
            this.btnSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBook.Visible = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnBorrowHistory
            // 
            this.btnBorrowHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnBorrowHistory.FlatAppearance.BorderSize = 0;
            this.btnBorrowHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBorrowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBorrowHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnBorrowHistory.Location = new System.Drawing.Point(20, 320);
            this.btnBorrowHistory.Name = "btnBorrowHistory";
            this.btnBorrowHistory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBorrowHistory.Size = new System.Drawing.Size(230, 40);
            this.btnBorrowHistory.TabIndex = 5;
            this.btnBorrowHistory.Text = "  Lịch sử mượn/trả";
            this.btnBorrowHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowHistory.Visible = false;
            this.btnBorrowHistory.Click += new System.EventHandler(this.btnBorrowHistory_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnViewProfile.Location = new System.Drawing.Point(20, 360);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnViewProfile.Size = new System.Drawing.Size(230, 40);
            this.btnViewProfile.TabIndex = 6;
            this.btnViewProfile.Text = "  Xem thông tin";
            this.btnViewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProfile.Visible = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnEditProfile.Location = new System.Drawing.Point(20, 400);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditProfile.Size = new System.Drawing.Size(230, 40);
            this.btnEditProfile.TabIndex = 7;
            this.btnEditProfile.Text = "  Sửa thông tin";
            this.btnEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfile.Visible = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnChangePassword.Location = new System.Drawing.Point(20, 440);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(230, 40);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "  Đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(297, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(703, 600);
            this.panelContent.TabIndex = 0;
            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Thư Viện - Người Dùng";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}