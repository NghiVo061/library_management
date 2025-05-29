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
    public partial class EditProfileC : UserControl
    {
        TextBox txtSearch, txtName, txtGender, txtDOB, txtPhone, txtEmail, txtAddress, txtHint, txtMemberID;
        Button btnSearch, btnConfirm;

        public EditProfileC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(1000, 550);

            Label title = new Label()
            {
                Text = "Chỉnh sửa thông tin thành viên",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(310, 20),
                AutoSize = true
            };

            Label lblSearch = new Label() { Text = "Nhập mã hoặc tên thành viên:", Location = new Point(50, 80), AutoSize = true };
            txtSearch = new TextBox() { Location = new Point(250, 76), Width = 250 };

            btnSearch = new Button()
            {
                Text = "Tìm kiếm",
                Location = new Point(520, 74),
                Width = 120,
                Height = 30,
                BackColor = Color.LightSteelBlue
            };
            btnSearch.Click += BtnSearch_Click;

            int labelX = 50, labelY = 130, spacingY = 40, textboxX = 180;

            txtMemberID = AddLabeledTextbox("Mã thành viên:", labelX, labelY + spacingY * 0, textboxX);
            txtName = AddLabeledTextbox("Họ tên:", labelX, labelY + spacingY * 1, textboxX);
            txtGender = AddLabeledTextbox("Giới tính:", labelX, labelY + spacingY * 2, textboxX);
            txtDOB = AddLabeledTextbox("Ngày sinh:", labelX, labelY + spacingY * 3, textboxX);
            txtPhone = AddLabeledTextbox("Số điện thoại:", labelX, labelY + spacingY * 4, textboxX);
            txtEmail = AddLabeledTextbox("Email:", labelX, labelY + spacingY * 5, textboxX);
            txtAddress = AddLabeledTextbox("Địa chỉ:", labelX, labelY + spacingY * 6, textboxX);
            txtHint = AddLabeledTextbox("Gợi ý (hint):", labelX, labelY + spacingY * 7, textboxX);

            btnConfirm = new Button()
            {
                Text = "Xác nhận",
                Location = new Point(400, labelY + spacingY * 8 + 20),
                Width = 160,
                Height = 35,
                BackColor = Color.LightGreen
            };
            btnConfirm.Click += BtnConfirm_Click;

            this.Controls.AddRange(new Control[] { title, lblSearch, txtSearch, btnSearch, btnConfirm });
        }

        private TextBox AddLabeledTextbox(string labelText, int labelX, int labelY, int textboxX)
        {
            Label lbl = new Label()
            {
                Text = labelText,
                Location = new Point(labelX, labelY),
                AutoSize = true
            };
            TextBox txt = new TextBox()
            {
                Location = new Point(textboxX, labelY - 4),
                Width = 250
            };
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            return txt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Vui lòng nhập mã hoặc tên thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            

            
            MessageBox.Show("Thông tin thành viên đã được cập nhật thành công.", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
