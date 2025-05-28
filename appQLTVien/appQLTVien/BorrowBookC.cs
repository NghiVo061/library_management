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
    public partial class BorrowBookC : UserControl
    {
        TextBox txtLoanID, txtMemberID, txtIDbook, txtQuantity;
        DateTimePicker dtBorrowDate, dtReturnDate;
        Button btnSubmit;

        public BorrowBookC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(400, 350);
            this.Text = "Ghi nhận mượn sách";

            txtLoanID = new TextBox() { Location = new Point(150, 20), Width = 200, ReadOnly = true };
            txtLoanID.Text = GenerateLoanID();

            txtMemberID = new TextBox() { Location = new Point(150, 60), Width = 200 };
            txtIDbook = new TextBox() { Location = new Point(150, 100), Width = 200 };
            txtQuantity = new TextBox() { Location = new Point(150, 140), Width = 200 };

            dtBorrowDate = new DateTimePicker() { Location = new Point(150, 180), Width = 200 };
            dtReturnDate = new DateTimePicker() { Location = new Point(150, 220), Width = 200 };

            btnSubmit = new Button() { Text = "Ghi nhận", Location = new Point(150, 260) };
            btnSubmit.Click += BtnSubmit_Click;

            this.Controls.AddRange(new Control[]
            {
                new Label() { Text = "Mã đơn mượn:", Location = new Point(20, 20) },
                txtLoanID,
                new Label() { Text = "Mã thành viên:", Location = new Point(20, 60) },
                txtMemberID,
                new Label() { Text = "Mã sách:", Location = new Point(20, 100) },
                txtIDbook,
                new Label() { Text = "Số lượng:", Location = new Point(20, 140) },
                txtQuantity,
                new Label() { Text = "Ngày mượn:", Location = new Point(20, 180) },
                dtBorrowDate,
                new Label() { Text = "Ngày trả dự kiến:", Location = new Point(20, 220) },
                dtReturnDate,
                btnSubmit
            });

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

        }

        private string GenerateLoanID()
        {
            // Ví dụ: MD20240528001
            return "MD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}




