using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class MemberInfoForm : Form
    {
        public MemberInfoForm(string memberId, string name, string gender, string dob, string phone, string email, string address, string password, string hint)
        {
            InitializeComponent();
            InitializeForm(memberId, name, gender, dob, phone, email, address, password, hint);
        }

        private void InitializeForm(string memberId, string name, string gender, string dob, string phone, string email, string address, string password, string hint)
        {
            txtMemberID.Text = memberId;
            txtName.Text = name;
            txtGender.Text = gender;
            txtDOB.Text = dob;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtAddress.Text = address;
            txtPassword.Text = password;
            txtHint.Text = hint;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}