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
    public partial class ViewProfileC : UserControl
    {
        TextBox txtSearch;
        Button btnViewInfo;
        DataGridView dgvMemberInfo;

        public ViewProfileC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(1000, 500);

            Label title = new Label()
            {
                Text = "Xem thông tin cá nhân",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(360, 20),
                AutoSize = true
            };

            Label lblSearch = new Label()
            {
                Text = "Nhập tên hoặc mã thành viên:",
                Location = new Point(50, 80),
                AutoSize = true
            };

            txtSearch = new TextBox()
            {
                Location = new Point(250, 76),
                Width = 250
            };

            btnViewInfo = new Button()
            {
                Text = "Hiển thị thông tin",
                Location = new Point(530, 74),
                Width = 150,
                Height = 30,
                BackColor = Color.LightSteelBlue
            };
            btnViewInfo.Click += BtnViewInfo_Click;

            dgvMemberInfo = new DataGridView()
            {
                Location = new Point(50, 130),
                Width = 880,
                Height = 300,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
                title, lblSearch, txtSearch, btnViewInfo, dgvMemberInfo
            });
        }

        private void BtnViewInfo_Click(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("Mã thành viên");
            table.Columns.Add("Họ tên");
            table.Columns.Add("Giới tính");
            table.Columns.Add("Ngày sinh");
            table.Columns.Add("Số điện thoại");
            table.Columns.Add("Email");
            table.Columns.Add("Địa chỉ");
            table.Columns.Add("Gợi ý (hint)");

            dgvMemberInfo.DataSource = table;
        }
    }
}

