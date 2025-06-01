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
    public partial class EditMemberC : UserControl
    {
        public EditMemberC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Giả sử đây là dữ liệu bạn lấy được từ nguồn nào đó
            string memberId = "TV001";
            string name = "Nguyễn Văn A";
            string gender = "Nam";
            string dob = "01/01/2000";
            string phone = "0123456789";
            string email = "nguyenvana@example.com";
            string address = "123 Đường ABC, Quận 1";
            string password = "123456";
            string hint = "Tên thú cưng";

            // Truyền dữ liệu vào constructor của form
            MemberInfoForm memberInfoForm = new MemberInfoForm(memberId, name, gender, dob, phone, email, address, password, hint);
            memberInfoForm.Show();
        }


    }
}
