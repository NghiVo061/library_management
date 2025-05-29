using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly LoginForm _loginForm;

        public ForgotPasswordForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            this.FormClosing += ForgotPasswordForm_FormClosing; 
        }

        private void ForgotPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                _loginForm.Show(); // Hiển thị lại LoginForm khi nhấn X
            }
        }

        private void btnShowHint_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _loginForm.Show(); // Hiển thị lại LoginForm
            this.Close();
        }
    }
}