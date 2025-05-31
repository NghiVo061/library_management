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
            string name = txtName.Text.Trim();
            string memberID = txtMemberID.Text.Trim();


            // Dữ liệu giả để test giao diện
            string gender = "Nam";
            string address = "123 Đường ABC";
            string dob = "01/01/2000";
            string phone = "0123456789";
            string email = "test@example.com";
            string password = "******";
            string hint = "Không có";

            MemberInfoForm infoForm = new MemberInfoForm(memberID, name, gender, address, dob, phone, email, password, hint);
            infoForm.ShowDialog();
        }

    }
}
