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
    public partial class EditpenaltyC : UserControl
    {
        public EditpenaltyC()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPenaltyForm searchForm = new SearchPenaltyForm();
            searchForm.ShowDialog();
        }
    }
}
