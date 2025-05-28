using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class UserForm : Form
    {
        private bool isBorrowSubMenuVisible = false;
        private bool isProfileSubMenuVisible = false;

        public UserForm()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }
        private void btnManageBorrow_Click(object sender, EventArgs e)
        {
            isBorrowSubMenuVisible = !isBorrowSubMenuVisible;
            btnSearchBook.Visible = isBorrowSubMenuVisible;
            btnBorrowHistory.Visible = isBorrowSubMenuVisible;

            if (isBorrowSubMenuVisible)
            {
                int baseY = btnManageBorrow.Location.Y + btnManageBorrow.Height + 10;
                btnSearchBook.Location = new Point(20, baseY);
                btnBorrowHistory.Location = new Point(20, baseY + btnSearchBook.Height + 5);

                int nextY = btnBorrowHistory.Location.Y + btnBorrowHistory.Height + 10;
                btnManageProfile.Location = new Point(0, nextY);
                btnLogout.Location = new Point(0, nextY + btnManageProfile.Height + 5);
            }
            else
            {
                btnManageProfile.Location = new Point(0, 130);
                btnLogout.Location = new Point(0, 530);
                UpdateProfileSubMenu();
            }
        }

        private void btnManageProfile_Click(object sender, EventArgs e)
        {
            isProfileSubMenuVisible = !isProfileSubMenuVisible;
            btnViewProfile.Visible = isProfileSubMenuVisible;
            btnEditProfile.Visible = isProfileSubMenuVisible;
            btnCheckFine.Visible = isProfileSubMenuVisible;

            UpdateProfileSubMenu();
        }

        private void UpdateProfileSubMenu()
        {
            int baseY = btnManageProfile.Location.Y + btnManageProfile.Height + 10;
            if (isProfileSubMenuVisible)
            {
                btnViewProfile.Location = new Point(20, baseY);
                btnEditProfile.Location = new Point(20, baseY + btnViewProfile.Height + 5);
                btnCheckFine.Location = new Point(20, baseY + (btnViewProfile.Height + 5) * 2);

                int nextY = btnCheckFine.Location.Y + btnCheckFine.Height + 10;
                btnLogout.Location = new Point(0, nextY);
            }
            else
            {
                if (isBorrowSubMenuVisible)
                {
                    int nextY = btnBorrowHistory.Location.Y + btnBorrowHistory.Height + 10;
                    btnManageProfile.Location = new Point(0, nextY);
                    btnLogout.Location = new Point(0, nextY + btnManageProfile.Height + 5);
                }
                else
                {
                    btnManageProfile.Location = new Point(0, 130);
                    btnLogout.Location = new Point(0, 530);
                }
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SearchBookC());
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BorrowHistoryC());
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ViewProfileC());
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EditProfileC());
        }

        private void btnCheckFine_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CheckFineC());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Đăng xuất");
        }
    }
}