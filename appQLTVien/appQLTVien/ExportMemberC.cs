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
    public partial class ExportMemberC : UserControl
    {


        public ExportMemberC()
        {
            InitializeComponent(); // giữ nguyên cái này để Designer hoạt động
            InitCustomControls();  // thêm các control tự tạo vào đây
        }

        private void InitCustomControls()
        {
            TextBox txtMemberID = new TextBox() { Location = new Point(20, 20), Width = 200, Text = "Nhập mã thành viên" };
            TextBox txtMemberName = new TextBox() { Location = new Point(20, 50), Width = 200, Text = "Nhập tên thành viên" };
            Button btnSearch = new Button() { Text = "Tìm kiếm", Location = new Point(240, 35) };
            DataGridView dgvResult = new DataGridView() { Location = new Point(20, 90), Width = 600, Height = 250 };

            this.Controls.Add(txtMemberID);
            this.Controls.Add(txtMemberName);
            this.Controls.Add(btnSearch);
            this.Controls.Add(dgvResult);
        }
    }
}
