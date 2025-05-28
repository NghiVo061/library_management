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
    public partial class ExportPenaltyC : UserControl
    {
        TextBox txtMemberID;
        DateTimePicker dtFrom, dtTo;
        Button btnExport;
        DataGridView dgvResult;

        public ExportPenaltyC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(1000, 500);  

            Label title = new Label()
            {
                Text = "Xuất bảng phí phạt",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(380, 20),
                AutoSize = true
            };

            Label lblMemberID = new Label() { Text = "Mã thành viên:", Location = new Point(50, 80), AutoSize = true };
            txtMemberID = new TextBox() { Location = new Point(160, 76), Width = 200 };

            Label lblFrom = new Label() { Text = "Từ ngày:", Location = new Point(400, 80), AutoSize = true };
            dtFrom = new DateTimePicker() { Location = new Point(470, 76), Width = 150 };

            Label lblTo = new Label() { Text = "Đến ngày:", Location = new Point(650, 80), AutoSize = true };
            dtTo = new DateTimePicker() { Location = new Point(730, 76), Width = 150 };

            btnExport = new Button()
            {
                Text = "Xuất thông tin",
                Location = new Point(430, 120),
                Width = 140,
                Height = 35,
                BackColor = Color.LightSteelBlue
            };
            btnExport.Click += BtnExport_Click;

            dgvResult = new DataGridView()
            {
                Location = new Point(50, 180),
                Width = 880,
                Height = 280,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
                title, lblMemberID, txtMemberID,
                lblFrom, dtFrom, lblTo, dtTo,
                btnExport, dgvResult
            });
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("Mã phiếu phạt");
            table.Columns.Add("Mã thành viên");
            table.Columns.Add("Mã sách");
            table.Columns.Add("Tên sách");
            table.Columns.Add("Ngày mượn");
            table.Columns.Add("Phí phạt");
            table.Columns.Add("Tình trạng");

            dgvResult.DataSource = table;
        }
    }
}
