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
    public partial class ExportBorrow : UserControl
    {
        TextBox txtMemberID;
        Button btnSearch;
        DataGridView dgvHistory;

        public ExportBorrow()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(700, 400);
            this.Text = "Lịch sử mượn/trả sách";

            Label lblMemberID = new Label() { Text = "Mã thành viên:", Location = new Point(20, 20) };
            txtMemberID = new TextBox() { Location = new Point(120, 18), Width = 200 };

            btnSearch = new Button() { Text = "Tìm kiếm", Location = new Point(340, 16) };
            btnSearch.Click += BtnSearch_Click;

            dgvHistory = new DataGridView()
            {
                Location = new Point(20, 60),
                Size = new Size(650, 300),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(lblMemberID);
            this.Controls.Add(txtMemberID);
            this.Controls.Add(btnSearch);
            this.Controls.Add(dgvHistory);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string memberId = txtMemberID.Text.Trim();

            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Vui lòng nhập mã thành viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        }

        
        private DataTable GetMockHistoryData(string memberId)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã sách");
            table.Columns.Add("Tên sách");
            table.Columns.Add("Ngày mượn");
            table.Columns.Add("Ngày trả dự kiến");
            table.Columns.Add("Trạng thái");

            

            return table;
        }
    }
}
