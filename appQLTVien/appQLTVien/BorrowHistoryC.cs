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
    public partial class BorrowHistoryC : UserControl
    {
        TextBox txtMemberID;
        Button btnExport;
        DataGridView dgvHistory;

        List<LoanRecord> loanData;

        public BorrowHistoryC()
        {
            InitializeComponent();
            InitControls();
            
        }

        private void InitControls()
        {
            this.Size = new Size(800, 400);

            Label title = new Label()
            {
                Text = "Lịch sử mượn / trả sách",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(250, 20),
                AutoSize = true
            };

            Label lblMemberID = new Label()
            {
                Text = "Mã thành viên:",
                Location = new Point(50, 80),
                AutoSize = true
            };

            txtMemberID = new TextBox()
            {
                Location = new Point(160, 76),
                Width = 250
            };

            btnExport = new Button()
            {
                Text = "Xuất lịch sử",
                Location = new Point(430, 74),
                Width = 120,
                Height = 30,
                BackColor = Color.LightSteelBlue
            };
            btnExport.Click += BtnExport_Click;

            dgvHistory = new DataGridView()
            {
                Location = new Point(50, 130),
                Width = 680,
                Height = 220,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
                title, lblMemberID, txtMemberID,
                btnExport, dgvHistory
            });
        }

        

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã sách");
            table.Columns.Add("Tên sách");
            table.Columns.Add("Ngày mượn");
            table.Columns.Add("Ngày trả dự kiến");
            table.Columns.Add("Tình trạng");
            dgvHistory.DataSource = table;
        }
    }

    public class LoanRecord
    {
        public string MemberID { get; set; }
        public string BookID { get; set; }
        public string BookName { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDue { get; set; }
        public string Status { get; set; }
    }
}

