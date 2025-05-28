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
    public partial class ExtendBorrowC : UserControl
    {
        TextBox txtNameBook;
        Button btnCheckStatus;
        DataGridView dgvResult;

        public ExtendBorrowC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(600, 350);
            this.Text = "Kiểm tra trạng thái mượn";

            Label lblNameBook = new Label() { Text = "Tên sách:", Location = new Point(20, 20) };
            txtNameBook = new TextBox() { Location = new Point(100, 18), Width = 250 };

            btnCheckStatus = new Button() { Text = "Xác nhận", Location = new Point(370, 16) };
            btnCheckStatus.Click += BtnCheckStatus_Click;

            dgvResult = new DataGridView()
            {
                Location = new Point(20, 60),
                Size = new Size(540, 250),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(lblNameBook);
            this.Controls.Add(txtNameBook);
            this.Controls.Add(btnCheckStatus);
            this.Controls.Add(dgvResult);
        }

        private void BtnCheckStatus_Click(object sender, EventArgs e)
        {
            
        }

        
        private DataTable GetMockBookStatus(string NameBook)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã sách");
            table.Columns.Add("Tên sách");
            table.Columns.Add("Trạng thái");
            return table;
        }
    }
}
