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
        ComboBox cboMemberID, cboIDbook, cboIssue, cboPaymentStatus; TextBox txtFineID, txtLate, txtCreateDate; Label lblTotalFine; Button btnCalculate, btnLoad;


        public AddPenaltyC()
        {
            InitializeComponent();
            InitControls();

        }

        private void InitControls()
        {
            this.Size = new Size(550, 430);

            Label title = new Label()
            {
                Text = "Tính phí phạt",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(180, 10),
                AutoSize = true
            };

            Label lblFineID = new Label() { Text = "Mã phiếu phạt:", Location = new Point(20, 50) };
            txtFineID = new TextBox() { Location = new Point(150, 48), Width = 200, ReadOnly = true };

            Label lblMember = new Label() { Text = "Mã thành viên:", Location = new Point(20, 90) };
            cboMemberID = new ComboBox() { Location = new Point(150, 88), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };


            btnLoad = new Button() { Text = "Tải thông tin", Location = new Point(360, 88), Width = 120 };


            Label lblBook = new Label() { Text = "Mã sách:", Location = new Point(20, 130) };
            cboIDbook = new ComboBox() { Location = new Point(150, 128), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            Label lblCreateDate = new Label() { Text = "Ngày lập phiếu:", Location = new Point(20, 170) };
            txtCreateDate = new TextBox()
            {
                Location = new Point(150, 168),
                Width = 200,
                ReadOnly = true,
                Text = DateTime.Now.ToString("dd/MM/yyyy")
            };
            Label lblDaysLate = new Label() { Text = "Số ngày trễ:", Location = new Point(20, 210) };
            txtLate = new TextBox() { Location = new Point(150, 208), Width = 200, ReadOnly = true };

            Label lblIssue = new Label() { Text = "Vi phạm:", Location = new Point(20, 250) };
            cboIssue = new ComboBox() { Location = new Point(150, 248), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            cboIssue.Items.AddRange(new string[] { "LateReturn", "Damaged", "Lost" });
            cboIssue.SelectedIndex = 0;


            Label lblPaymentStatus = new Label() { Text = "Trạng thái thanh toán:", Location = new Point(20, 290) };
            cboPaymentStatus = new ComboBox() { Location = new Point(150, 288), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
            cboPaymentStatus.Items.Add("Unpaid");
            cboPaymentStatus.SelectedIndex = 0;

            btnCalculate = new Button() { Text = "Tính tiền phạt", Location = new Point(150, 330) };


            lblTotalFine = new Label()
            {
                Text = "Tổng tiền phạt: 0 VNĐ",
                Location = new Point(150, 370),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true
            };


            this.Controls.AddRange(new Control[] {
                title, lblFineID, txtFineID,
                lblMember, cboMemberID, btnLoad,
                lblBook, cboIDbook,
                lblCreateDate, txtCreateDate,
                lblDaysLate, txtLate,
                lblIssue, cboIssue,
                lblPaymentStatus, cboPaymentStatus,
                btnCalculate, lblTotalFine
            });
        }
    }
}



















