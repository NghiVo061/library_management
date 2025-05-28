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
    public partial class ConfirmDeleteForm : Form
    {
        

        public ConfirmDeleteForm()
        {
            InitializeComponent();
        
            LoadMemberInfo();
        }

        private void LoadMemberInfo()
        {
            Label lblInfo = new Label()
            {

                Text = "Xác nhận xóa thành viên?",
                Location = new Point(20, 20),
                Size = new Size(300, 80)
            };

            Button btnConfirm = new Button() { Text = "Xác nhận xóa", Location = new Point(30, 120) };
            btnConfirm.Click += BtnConfirm_Click;

            this.Controls.Add(lblInfo);
            this.Controls.Add(btnConfirm);
            this.Size = new Size(380, 200);
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
           
        }
    }
}
