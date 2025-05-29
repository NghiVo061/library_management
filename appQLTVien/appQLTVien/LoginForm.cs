using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Thoát ứng dụng khi nhấn X
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm(this); 
            forgotForm.Show();
            this.Hide();
        }
    }
}