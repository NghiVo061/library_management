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
        
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

