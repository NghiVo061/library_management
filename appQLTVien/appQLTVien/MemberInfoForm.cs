using System;
using System.Windows.Forms;

namespace appQLTVien { public partial class MemberInfoForm : Form { public MemberInfoForm(string memberID, string name, string gender, string address, string dob, string phone, string email, string password, string hint) { InitializeComponent(); lblMemberID.Text = memberID; lblName.Text = name; lblGender.Text = gender; lblAddress.Text = address; lblDOB.Text = dob; lblPhone.Text = phone; lblEmail.Text = email; lblPassword.Text = password; lblHint.Text = hint; } } }