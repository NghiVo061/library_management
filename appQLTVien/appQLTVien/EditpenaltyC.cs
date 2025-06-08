using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class EditpenaltyC : UserControl
    {  private string connectionString = "server=localhost;user id=root;password=123456;database=library";

        public EditpenaltyC()
        {
            InitializeComponent();
            LoadPenaltyIds();
        }

        private void LoadPenaltyIds()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PenaltyID FROM PenaltyReceipts";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboFineID.Items.Add(reader["PenaltyID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách mã phiếu phạt: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string penaltyId = cboFineID.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(penaltyId))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu phạt!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM PenaltyReceipts WHERE PenaltyID = @penaltyId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@penaltyId", penaltyId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        SearchPenaltyForm searchForm = new SearchPenaltyForm(penaltyId, connectionString);
                        searchForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã phiếu phạt trong cơ sở dữ liệu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã phiếu phạt: " + ex.Message);
                }
            }
        }
    }

}