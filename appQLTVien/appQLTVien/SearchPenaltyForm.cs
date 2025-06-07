using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class SearchPenaltyForm : Form
    {
        public SearchPenaltyForm()
        {
            InitializeComponent();
        }

        private void SearchPenaltyDetails(string penaltyID)
        {
            // Placeholder for search logic
            // In a real application, this would query a database or data source
            MessageBox.Show($"Tìm kiếm phí phạt với ID: {penaltyID}");
        }

        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}