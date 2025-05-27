using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace appQLTVien
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnBookManagement;
        private System.Windows.Forms.Button btnMemberManagement;
        private System.Windows.Forms.Button btnManageBookBorrow;
        private System.Windows.Forms.Button btnPenaltyFeeManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnExportBook;
        private System.Windows.Forms.Button btnCheckBookStatus;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnExportMember;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnExportBorrow;
        private System.Windows.Forms.Button btnExtendBorrow;
        private System.Windows.Forms.Button btnAddPenalty;
        private System.Windows.Forms.Button btnExportPenalty;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPenaltyFeeManagement = new System.Windows.Forms.Button();
            this.btnManageBookBorrow = new System.Windows.Forms.Button();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnExportBook = new System.Windows.Forms.Button();
            this.btnCheckBookStatus = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnExportMember = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnExportBorrow = new System.Windows.Forms.Button();
            this.btnExtendBorrow = new System.Windows.Forms.Button();
            this.btnAddPenalty = new System.Windows.Forms.Button();
            this.btnExportPenalty = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnPenaltyFeeManagement);
            this.panelMenu.Controls.Add(this.btnManageBookBorrow);
            this.panelMenu.Controls.Add(this.btnMemberManagement);
            this.panelMenu.Controls.Add(this.btnBookManagement);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.btnAddBook);
            this.panelMenu.Controls.Add(this.btnEditBook);
            this.panelMenu.Controls.Add(this.btnDeleteBook);
            this.panelMenu.Controls.Add(this.btnExportBook);
            this.panelMenu.Controls.Add(this.btnCheckBookStatus);
            this.panelMenu.Controls.Add(this.btnAddMember);
            this.panelMenu.Controls.Add(this.btnEditMember);
            this.panelMenu.Controls.Add(this.btnDeleteMember);
            this.panelMenu.Controls.Add(this.btnExportMember);
            this.panelMenu.Controls.Add(this.btnBorrowBook);
            this.panelMenu.Controls.Add(this.btnReturnBook);
            this.panelMenu.Controls.Add(this.btnExportBorrow);
            this.panelMenu.Controls.Add(this.btnExtendBorrow);
            this.panelMenu.Controls.Add(this.btnAddPenalty);
            this.panelMenu.Controls.Add(this.btnExportPenalty);

            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(297, 600);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.AutoScroll = true;
            
            
                        // btnBookManagement
            this.btnBookManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnBookManagement.FlatAppearance.BorderSize = 0;
            this.btnBookManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBookManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnBookManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManagement.Location = new System.Drawing.Point(0, 80);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBookManagement.Size = new System.Drawing.Size(250, 50);
            this.btnBookManagement.TabIndex = 1;
            this.btnBookManagement.Text = "  Quản lý sách ";
            this.btnBookManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookManagement.UseVisualStyleBackColor = false;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click); 

            // Cấu hình btnAddBook
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddBook.Size = new System.Drawing.Size(230, 40);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "  Thêm sách";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            // Cấu hình btnEditBook
            this.btnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnEditBook.FlatAppearance.BorderSize = 0;
            this.btnEditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditBook.Size = new System.Drawing.Size(230, 40);
            this.btnEditBook.TabIndex = 7;
            this.btnEditBook.Text = "  Chỉnh sửa thông tin sách";
            this.btnEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);

            // Cấu hình btnDeleteBook
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDeleteBook.Size = new System.Drawing.Size(230, 40);
            this.btnDeleteBook.TabIndex = 8;
            this.btnDeleteBook.Text = "  Xóa sách";
            this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // btnExportBook
            // 
            this.btnExportBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnExportBook.FlatAppearance.BorderSize = 0;
            this.btnExportBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnExportBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnExportBook.Location = new System.Drawing.Point(20, 400); // Ngay dưới btnDeleteBook
            this.btnExportBook.Name = "btnExportBook";
            this.btnExportBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExportBook.Size = new System.Drawing.Size(230, 40);
            this.btnExportBook.TabIndex = 9;
            this.btnExportBook.Text = "  Xuất thông tin sách";
            this.btnExportBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportBook.Visible = false;
            this.btnExportBook.Click += new System.EventHandler(this.btnExportBook_Click);

            // btnCheckBookStatus
            // 
            this.btnCheckBookStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnCheckBookStatus.FlatAppearance.BorderSize = 0;
            this.btnCheckBookStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnCheckBookStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBookStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCheckBookStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnCheckBookStatus.Location = new System.Drawing.Point(20, 440); // Ngay dưới btnExportBook
            this.btnCheckBookStatus.Name = "btnCheckBookStatus";
            this.btnCheckBookStatus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCheckBookStatus.Size = new System.Drawing.Size(230, 40);
            this.btnCheckBookStatus.TabIndex = 10;
            this.btnCheckBookStatus.Text = "  Kiểm tra trạng thái sách";
            this.btnCheckBookStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBookStatus.Visible = false;
            this.btnCheckBookStatus.Click += new System.EventHandler(this.btnCheckBookStatus_Click);


            // btnMemberManagement
            // 
            this.btnMemberManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnMemberManagement.FlatAppearance.BorderSize = 0;
            this.btnMemberManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnMemberManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMemberManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnMemberManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberManagement.Location = new System.Drawing.Point(0, 130);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMemberManagement.Size = new System.Drawing.Size(250, 50);
            this.btnMemberManagement.TabIndex = 2;
            this.btnMemberManagement.Text = "  Quản lý thành viên";
            this.btnMemberManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberManagement.UseVisualStyleBackColor = false;
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);

            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnAddMember.Location = new System.Drawing.Point(20, 480);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddMember.Size = new System.Drawing.Size(230, 40);
            this.btnAddMember.TabIndex = 11;
            this.btnAddMember.Text = "  Thêm thành viên";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Visible = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnEditMember.Location = new System.Drawing.Point(20, 520);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEditMember.Size = new System.Drawing.Size(230, 40);
            this.btnEditMember.TabIndex = 12;
            this.btnEditMember.Text = "  Chỉnh Sửa thông tin thành viên";
            this.btnEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMember.Visible = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnDeleteMember.Location = new System.Drawing.Point(20, 560);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDeleteMember.Size = new System.Drawing.Size(230, 40);
            this.btnDeleteMember.TabIndex = 13;
            this.btnDeleteMember.Text = "  Xóa thành viên";
            this.btnDeleteMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.Visible = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnExportMember
            // 
            this.btnExportMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnExportMember.FlatAppearance.BorderSize = 0;
            this.btnExportMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnExportMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnExportMember.Location = new System.Drawing.Point(20, 600);
            this.btnExportMember.Name = "btnViewMember";
            this.btnExportMember.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExportMember.Size = new System.Drawing.Size(230, 40);
            this.btnExportMember.TabIndex = 14;
            this.btnExportMember.Text = "  Xuất thông tin thành viên";
            this.btnExportMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportMember.Visible = false;
            this.btnExportMember.Click += new System.EventHandler(this.btnExportMember_Click);

            // btnManageBookBorrow
            // 
            this.btnManageBookBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnManageBookBorrow.FlatAppearance.BorderSize = 0;
            this.btnManageBookBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnManageBookBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBookBorrow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageBookBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnManageBookBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBookBorrow.Location = new System.Drawing.Point(0, 180);
            this.btnManageBookBorrow.Name = "btnManageBookBorrow";
            this.btnManageBookBorrow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBookBorrow.Size = new System.Drawing.Size(250, 50);
            this.btnManageBookBorrow.TabIndex = 3;
            this.btnManageBookBorrow.Text = "  Quản lý mượn/trả sách";
            this.btnManageBookBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBookBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBookBorrow.UseVisualStyleBackColor = false;
            this.btnManageBookBorrow.Click += new System.EventHandler(this.btnManageBookBorrow_Click);

            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnBorrowBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBorrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnBorrowBook.Location = new System.Drawing.Point(20, 640);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBorrowBook.Size = new System.Drawing.Size(230, 40);
            this.btnBorrowBook.TabIndex = 15;
            this.btnBorrowBook.Text = "  Ghi nhận mượn sách";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Visible = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnReturnBook.Location = new System.Drawing.Point(20, 680);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(230, 40);
            this.btnReturnBook.TabIndex = 16;
            this.btnReturnBook.Text = "  Ghi nhận trả sách";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Visible = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnExportBorrow
            // 
            this.btnExportBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnExportBorrow.FlatAppearance.BorderSize = 0;
            this.btnExportBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnExportBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportBorrow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnExportBorrow.Location = new System.Drawing.Point(20, 720);
            this.btnExportBorrow.Name = "btnViewBorrow";
            this.btnExportBorrow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExportBorrow.Size = new System.Drawing.Size(230, 40);
            this.btnExportBorrow.TabIndex = 17;
            this.btnExportBorrow.Text = "  Xuất lịch sử mượn/trả sách";
            this.btnExportBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportBorrow.Visible = false;
            this.btnExportBorrow.Click += new System.EventHandler(this.btnExportBorrow_Click);
            // 
            // btnExtendBorrow
            // 
            this.btnExtendBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnExtendBorrow.FlatAppearance.BorderSize = 0;
            this.btnExtendBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnExtendBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendBorrow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExtendBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnExtendBorrow.Location = new System.Drawing.Point(20, 760);
            this.btnExtendBorrow.Name = "btnExtendBorrow";
            this.btnExtendBorrow.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExtendBorrow.Size = new System.Drawing.Size(230, 40);
            this.btnExtendBorrow.TabIndex = 18;
            this.btnExtendBorrow.Text = "  Kiểm tra trạng thái mượn";
            this.btnExtendBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtendBorrow.Visible = false;
            this.btnExtendBorrow.Click += new System.EventHandler(this.btnExtendBorrow_Click);

            // btnPenaltyFeeManagement
            // 
            this.btnPenaltyFeeManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnPenaltyFeeManagement.FlatAppearance.BorderSize = 0;
            this.btnPenaltyFeeManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnPenaltyFeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenaltyFeeManagement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPenaltyFeeManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnPenaltyFeeManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenaltyFeeManagement.Location = new System.Drawing.Point(0, 230);
            this.btnPenaltyFeeManagement.Name = "btnPenaltyFeeManagement";
            this.btnPenaltyFeeManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPenaltyFeeManagement.Size = new System.Drawing.Size(250, 50);
            this.btnPenaltyFeeManagement.TabIndex = 4;
            this.btnPenaltyFeeManagement.Text = "  Quản lý phí phạt";
            this.btnPenaltyFeeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenaltyFeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPenaltyFeeManagement.UseVisualStyleBackColor = false;
            this.btnPenaltyFeeManagement.Click += new System.EventHandler(this.btnPenaltyFeeManagement_Click);

            // btnAddPenalty
            // 
            this.btnAddPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnAddPenalty.FlatAppearance.BorderSize = 0;
            this.btnAddPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnAddPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPenalty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnAddPenalty.Location = new System.Drawing.Point(20, 800);
            this.btnAddPenalty.Name = "btnAddPenalty";
            this.btnAddPenalty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddPenalty.Size = new System.Drawing.Size(230, 40);
            this.btnAddPenalty.TabIndex = 19;
            this.btnAddPenalty.Text = "  Tính phí phạt";
            this.btnAddPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPenalty.Visible = false;
            this.btnAddPenalty.Click += new System.EventHandler(this.btnAddPenalty_Click);
            // 
            // btnExportPenalty
            // 
            this.btnExportPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnExportPenalty.FlatAppearance.BorderSize = 0;
            this.btnExportPenalty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.btnExportPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPenalty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnExportPenalty.Location = new System.Drawing.Point(20, 840);
            this.btnExportPenalty.Name = "btnViewPenalty";
            this.btnExportPenalty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExportPenalty.Size = new System.Drawing.Size(230, 40);
            this.btnExportPenalty.TabIndex = 20;
            this.btnExportPenalty.Text = "  Xuất phí phạt";
            this.btnExportPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPenalty.Visible = false;
            this.btnExportPenalty.Click += new System.EventHandler(this.btnExportPenalty_Click);



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
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;

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
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Thư Viện - Admin";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}