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
    public partial class ReturnBookC : UserControl
    {
        TextBox txtMemberID;
        ComboBox cboIDbook, cboStatus, cboLateDays;
        Button btnConfirm;

        public ReturnBookC()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            this.Size = new Size(400, 300);
            this.Text = "Ghi nhận trả sách";

            Label lblMemberID = new Label() { Text = "Mã thành viên:", Location = new Point(20, 20) };
            txtMemberID = new TextBox() { Location = new Point(150, 20), Width = 200 };
            txtMemberID.Leave += TxtMemberID_Leave; // Load sách khi nhập xong mã thành viên

            Label lblIDbook = new Label() { Text = "mã sách đã mượn:", Location = new Point(20, 60) };
            cboIDbook = new ComboBox() { Location = new Point(150, 60), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            Label lblStatus = new Label() { Text = "Tình trạng trả:", Location = new Point(20, 100) };
            cboStatus = new ComboBox() { Location = new Point(150, 100), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cboStatus.Items.AddRange(new string[] { "Đúng hẹn", "Trễ hẹn" });
            cboStatus.SelectedIndexChanged += CboStatus_SelectedIndexChanged;

            Label lblLateDays = new Label() { Text = "Số ngày trễ:", Location = new Point(20, 140) };
            cboLateDays = new ComboBox() { Location = new Point(150, 140), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            for (int i = 1; i <= 100; i++) cboLateDays.Items.Add(i.ToString());
            cboLateDays.Visible = true;

            btnConfirm = new Button() { Text = "Xác nhận trả sách", Location = new Point(150, 190) };
            btnConfirm.Click += BtnConfirm_Click;

            this.Controls.AddRange(new Control[]
            {
                lblMemberID, txtMemberID,
                lblIDbook, cboIDbook,
                lblStatus, cboStatus,
                lblLateDays, cboLateDays,
                btnConfirm
            });





        }
        private void TxtMemberID_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Thành viên này không có sách đang mượn hoặc không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

