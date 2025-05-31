using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace appQLTVien
{
    public partial class AdminForm : Form
    {
        private bool isBookSubMenuVisible = false;
        private bool isMemberSubMenuVisible = false;
        private bool isBorrowSubMenuVisible = false;
        private bool isPenaltySubMenuVisible = false;

        public AdminForm()
        {
            InitializeComponent();
            btnLogout.Click += (s, e) => this.Close();
        }

        private Button selectedButton = null;
        private Button selectedButton1 = null;

        private void LoadUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(200, 235, 215);
            }

            
            if (clickedButton == selectedButton)
            {
                clickedButton.BackColor = Color.FromArgb(200, 235, 215); 
                selectedButton = null; 
            }
            else
            {
                
                clickedButton.BackColor = Color.FromArgb(160, 200, 180); 
                selectedButton = clickedButton; 
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Khôi phục màu nền của nút trước đó (nếu có)
            if (selectedButton1 != null)
            {
                selectedButton1.BackColor = Color.FromArgb(200, 235, 215); 
            }

            
            if (clickedButton == selectedButton1)
            {
                clickedButton.BackColor = Color.FromArgb(200, 235, 215); 
                selectedButton1 = null; 
            }
            else
            {
                
                clickedButton.BackColor = Color.FromArgb(160, 200, 180); 
                selectedButton1 = clickedButton; // Lưu nút đang được chọn
            }
        }
        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            

            isBookSubMenuVisible = !isBookSubMenuVisible;
            btnAddBook.Visible = isBookSubMenuVisible;
            btnEditBook.Visible = isBookSubMenuVisible;
            btnDeleteBook.Visible = isBookSubMenuVisible;
            btnExportBook.Visible = isBookSubMenuVisible;
            btnCheckBookStatus.Visible = isBookSubMenuVisible;

            if (isBookSubMenuVisible)
            {
                int baseY = btnBookManagement.Location.Y + btnBookManagement.Height + 10;
                btnAddBook.Location = new Point(20, baseY);
                btnEditBook.Location = new Point(20, baseY + btnAddBook.Height + 5);
                btnDeleteBook.Location = new Point(20, baseY + (btnAddBook.Height + 5) * 2);
                btnExportBook.Location = new Point(20, baseY + (btnAddBook.Height + 5) * 3);
                btnCheckBookStatus.Location = new Point(20, baseY + (btnAddBook.Height + 5) * 4);

                int nextY = btnCheckBookStatus.Location.Y + btnCheckBookStatus.Height + 10;
                btnMemberManagement.Location = new Point(0, nextY);
                btnManageBookBorrow.Location = new Point(0, nextY + btnMemberManagement.Height + 5);
                btnPenaltyFeeManagement.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 2);
                btnLogout.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 3);
            }
            else
            {
                btnMemberManagement.Location = new Point(0, 130);
                btnManageBookBorrow.Location = new Point(0, 180);
                btnPenaltyFeeManagement.Location = new Point(0, 230);
                btnLogout.Location = new Point(0, 530);
                UpdateMemberSubMenu();
                UpdateBorrowSubMenu();
                UpdatePenaltySubMenu();
            }
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            isMemberSubMenuVisible = !isMemberSubMenuVisible;
            btnAddMember.Visible = isMemberSubMenuVisible;
            btnEditMember.Visible = isMemberSubMenuVisible;
            btnDeleteMember.Visible = isMemberSubMenuVisible;
            btnExportMember.Visible = isMemberSubMenuVisible;

            UpdateMemberSubMenu();
        }

        private void UpdateMemberSubMenu()
        {
            int baseY = btnMemberManagement.Location.Y + btnMemberManagement.Height + 10;
            if (isMemberSubMenuVisible)
            {
                btnAddMember.Location = new Point(20, baseY);
                btnEditMember.Location = new Point(20, baseY + btnAddMember.Height + 5);
                btnDeleteMember.Location = new Point(20, baseY + (btnAddMember.Height + 5) * 2);
                btnExportMember.Location = new Point(20, baseY + (btnAddMember.Height + 5) * 3);

                int nextY = btnExportMember.Location.Y + btnExportMember.Height + 10;
                btnManageBookBorrow.Location = new Point(0, nextY);
                btnPenaltyFeeManagement.Location = new Point(0, nextY + btnManageBookBorrow.Height + 5);
                btnLogout.Location = new Point(0, nextY + (btnManageBookBorrow.Height + 5) * 2);
            }
            else
            {
                if (isBookSubMenuVisible)
                {
                    int nextY = btnCheckBookStatus.Location.Y + btnCheckBookStatus.Height + 10;
                    btnMemberManagement.Location = new Point(0, nextY);
                    btnManageBookBorrow.Location = new Point(0, nextY + btnMemberManagement.Height + 5);
                    btnPenaltyFeeManagement.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 2);
                    btnLogout.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 3);
                }
                else
                {
                    btnMemberManagement.Location = new Point(0, 130);
                    btnManageBookBorrow.Location = new Point(0, 180);
                    btnPenaltyFeeManagement.Location = new Point(0, 230);
                    btnLogout.Location = new Point(0, 530);
                }
                UpdateBorrowSubMenu();
                UpdatePenaltySubMenu();
            }
        }

        private void btnManageBookBorrow_Click(object sender, EventArgs e)
        {
            isBorrowSubMenuVisible = !isBorrowSubMenuVisible;
            btnBorrowBook.Visible = isBorrowSubMenuVisible;
            btnReturnBook.Visible = isBorrowSubMenuVisible;
            btnExportBorrow.Visible = isBorrowSubMenuVisible;
            

            UpdateBorrowSubMenu();
        }

        private void UpdateBorrowSubMenu()
        {
            int baseY = btnManageBookBorrow.Location.Y + btnManageBookBorrow.Height + 10;
            if (isBorrowSubMenuVisible)
            {
                btnBorrowBook.Location = new Point(20, baseY);
                btnReturnBook.Location = new Point(20, baseY + btnBorrowBook.Height + 5);
                btnExportBorrow.Location = new Point(20, baseY + (btnBorrowBook.Height + 5) * 2);
               

                
                int nextY = btnExportBorrow.Location.Y + btnExportBorrow.Height + 10; 
                btnPenaltyFeeManagement.Location = new Point(0, nextY);
                btnLogout.Location = new Point(0, nextY + btnPenaltyFeeManagement.Height + 5);
            }
            else
            {
                if (isMemberSubMenuVisible)
                {
                    int nextY = btnExportMember.Location.Y + btnExportMember.Height + 10;
                    btnManageBookBorrow.Location = new Point(0, nextY);
                    btnPenaltyFeeManagement.Location = new Point(0, nextY + btnManageBookBorrow.Height + 5);
                    btnLogout.Location = new Point(0, nextY + (btnManageBookBorrow.Height + 5) * 2);
                }
                else if (isBookSubMenuVisible)
                {
                    int nextY = btnCheckBookStatus.Location.Y + btnCheckBookStatus.Height + 10;
                    btnMemberManagement.Location = new Point(0, nextY);
                    btnManageBookBorrow.Location = new Point(0, nextY + btnMemberManagement.Height + 5);
                    btnPenaltyFeeManagement.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 2);
                    btnLogout.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 3);
                }
                else
                {
                    btnMemberManagement.Location = new Point(0, 130);
                    btnManageBookBorrow.Location = new Point(0, 180);
                    btnPenaltyFeeManagement.Location = new Point(0, 230);
                    btnLogout.Location = new Point(0, 530);
                }
                UpdatePenaltySubMenu();
            }
        }

        private void btnPenaltyFeeManagement_Click(object sender, EventArgs e)
        {
            isPenaltySubMenuVisible = !isPenaltySubMenuVisible;
            btnAddPenalty.Visible = isPenaltySubMenuVisible;
            btnExportPenalty.Visible = isPenaltySubMenuVisible;

            UpdatePenaltySubMenu();
        }

        private void UpdatePenaltySubMenu()
        {
            int baseY = btnPenaltyFeeManagement.Location.Y + btnPenaltyFeeManagement.Height + 10;
            if (isPenaltySubMenuVisible)
            {
                btnAddPenalty.Location = new Point(20, baseY);
                btnExportPenalty.Location = new Point(20, baseY + btnAddPenalty.Height + 5);

                int nextY = btnExportPenalty.Location.Y + btnExportPenalty.Height + 10;
                btnLogout.Location = new Point(0, nextY);
            }
            else
            {
                if (isBorrowSubMenuVisible)
                {
                    int nextY = btnExportBorrow.Location.Y + btnExportBorrow.Height + 10; 
                    btnPenaltyFeeManagement.Location = new Point(0, nextY);
                    btnLogout.Location = new Point(0, nextY + btnPenaltyFeeManagement.Height + 5);
                }
                else if (isMemberSubMenuVisible)
                {
                    int nextY = btnExportMember.Location.Y + btnExportMember.Height + 10;
                    btnManageBookBorrow.Location = new Point(0, nextY);
                    btnPenaltyFeeManagement.Location = new Point(0, nextY + btnManageBookBorrow.Height + 5);
                    btnLogout.Location = new Point(0, nextY + (btnManageBookBorrow.Height + 5) * 2);
                }
                else if (isBookSubMenuVisible)
                {
                    int nextY = btnCheckBookStatus.Location.Y + btnCheckBookStatus.Height + 10;
                    btnMemberManagement.Location = new Point(0, nextY);
                    btnManageBookBorrow.Location = new Point(0, nextY + btnMemberManagement.Height + 5);
                    btnPenaltyFeeManagement.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 2);
                    btnLogout.Location = new Point(0, nextY + (btnMemberManagement.Height + 5) * 3);
                }
                else
                {
                    btnMemberManagement.Location = new Point(0, 130);
                    btnManageBookBorrow.Location = new Point(0, 180);
                    btnPenaltyFeeManagement.Location = new Point(0, 230);
                    btnLogout.Location = new Point(0, 530);
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddBookControl());
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EditBookControl());
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DeleteBookControl());
        }

        private void btnExportBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ExportBookControl());
        }

        private void btnCheckBookStatus_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CheckStatusControl());
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddMemberC());
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EditMemberC());
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            LoadUserControl(new DeleteMemberC());
        }

        private void btnExportMember_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ExportMemberC());
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BorrowBookC());
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReturnBookC());
        }

        private void btnExportBorrow_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ExportBorrow());
        }

       

        private void btnAddPenalty_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddPenaltyC());
        }

        private void btnExportPenalty_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ExportPenaltyC());
        }

        
    }
}