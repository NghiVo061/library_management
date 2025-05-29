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
    public partial class CheckFineC : UserControl
    {
        TextBox txtMemberID;
        Button btnCheckFine;
        DataGridView dgvFineResult;

        public CheckFineC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(1000, 500);

            Label title = new Label()
            {
                Text = "Kiểm tra phí phạt",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(380, 20),
                AutoSize = true
            };

            Label lblMemberID = new Label()
            {
                Text = "Nhập mã thành viên:",
                Location = new Point(60, 80),
                AutoSize = true
            };

            txtMemberID = new TextBox()
            {
                Location = new Point(220, 76),
                Width = 250
            };

            btnCheckFine = new Button()
            {
                Text = "Kiểm tra",
                Location = new Point(490, 74),
                Width = 120,
                Height = 30,
                BackColor = Color.LightSteelBlue
            };
            btnCheckFine.Click += BtnCheckFine_Click;

            dgvFineResult = new DataGridView()
            {
                Location = new Point(60, 140),
                Width = 880,
                Height = 300,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
                title, lblMemberID, txtMemberID, btnCheckFine, dgvFineResult
            });
        }

        private void BtnCheckFine_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã phiếu phạt");
            table.Columns.Add("Mã thành viên");
            table.Columns.Add("Mã sách");
            table.Columns.Add("Tên sách");
            table.Columns.Add("Ngày mượn");
            table.Columns.Add("Số ngày trễ");
            table.Columns.Add("Phí phạt");
            table.Columns.Add("Tình trạng");

            dgvFineResult.DataSource = table;
        }
    }
}
