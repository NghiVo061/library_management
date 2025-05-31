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
    public partial class AddPenaltyC : UserControl
    {
        TextBox txtMemberID, txtIDbook, txtFineID, txtLate;
        ComboBox  cboIssue;
        Label lblTotalFine;
        Button btnCalculate;

        public AddPenaltyC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(500, 350);

            Label title = new Label()
            {
                Text = "Tính phí phạt",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(180, 10),
                AutoSize = true
            };

            Label lblFineID = new Label() { Text = "Mã phiếu phạt:", Location = new Point(20, 50) };
            txtFineID = new TextBox() { Location = new Point(150, 48), Width = 200, ReadOnly = true };
            txtFineID.Text = GenerateFineID();

            Label lblMember = new Label() { Text = "Mã thành viên:", Location = new Point(20, 90) };
            txtMemberID = new TextBox() { Location = new Point(150, 88), Width = 200 };

            Label lblBook = new Label() { Text = "Mã sách:", Location = new Point(20, 130) };
            txtIDbook = new TextBox() { Location = new Point(150, 128), Width = 200 };

            Label lblDaysLate = new Label() { Text = "Số ngày trễ:", Location = new Point(20, 170) };
            txtLate = new TextBox() { Location = new Point(150, 168), Width = 200 };

            Label lblIssue = new Label() { Text = "Vi phạm:", Location = new Point(20, 210) };
            cboIssue = new ComboBox() { Location = new Point(150, 208), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            cboIssue.Items.AddRange(new string[] { "Không", "Hư hỏng", "Mất sách" });

            btnCalculate = new Button() { Text = "Tính tiền phạt", Location = new Point(150, 250) };
            btnCalculate.Click += BtnCalculate_Click;

            lblTotalFine = new Label()
            {
                Text = "Tổng tiền phạt: 0 VNĐ",
                Location = new Point(150, 290),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true
            };

            this.Controls.AddRange(new Control[] {
                title, lblFineID, txtFineID,
                lblMember, txtMemberID,
                lblBook, txtIDbook,
                lblDaysLate, txtLate,
                lblIssue, cboIssue,
                btnCalculate, lblTotalFine
            });
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           
        }

        private string GenerateFineID()
        {
            return "PP" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
