using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class SearchPenaltyForm : Form
    {
        private string penaltyId; private string connectionString;

        public SearchPenaltyForm(string penaltyId, string connectionString)
        {
            this.penaltyId = penaltyId;
            this.connectionString = connectionString;
            InitializeComponent();
            LoadPenaltyDetails();
        }

        private void LoadPenaltyDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT MemberID, BookID, LateDays, PenaltyAmount, BookStatus, PaymentStatus
                    FROM PenaltyReceipts
                    WHERE PenaltyID = @penaltyId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@penaltyId", penaltyId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtPenaltyIDResult.Text = penaltyId;
                            txtMemberID.Text = reader["MemberID"].ToString();
                            txtBookID.Text = reader["BookID"].ToString();
                            txtLateDays.Text = reader["LateDays"].ToString();
                            txtPenaltyAmount.Text = Convert.ToDecimal(reader["PenaltyAmount"]).ToString("N0") + " VNĐ";
                            txtBookStatus.Text = reader["BookStatus"].ToString();

                            // Cấu hình ComboBox cho PaymentStatus
                            cboPaymentStatus.Items.Clear();
                            cboPaymentStatus.Items.Add("Unpaid");
                            cboPaymentStatus.Items.Add("Paid");
                            string currentPaymentStatus = reader["PaymentStatus"].ToString();
                            cboPaymentStatus.SelectedItem = currentPaymentStatus;

                            // Nếu đã Paid, vô hiệu hóa Unpaid
                            if (currentPaymentStatus == "Paid")
                            {
                                cboPaymentStatus.Enabled = false;
                            }
                            else
                            {
                                cboPaymentStatus.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin cho mã phiếu phạt này!");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPaymentStatus = cboPaymentStatus.SelectedItem?.ToString();
            if (newPaymentStatus != null)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Bắt đầu giao dịch để đảm bảo tính nhất quán
                        MySqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Cập nhật trạng thái thanh toán trong PenaltyReceipts
                            string updateQuery = @"
                            UPDATE PenaltyReceipts 
                            SET PaymentStatus = @paymentStatus 
                            WHERE PenaltyID = @penaltyId";
                            MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@paymentStatus", newPaymentStatus);
                            cmd.Parameters.AddWithValue("@penaltyId", penaltyId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0 && newPaymentStatus == "Paid")
                            {
                                // Lấy MemberID và BookID từ PenaltyReceipts
                                string selectQuery = @"
                                SELECT MemberID, BookID 
                                FROM PenaltyReceipts 
                                WHERE PenaltyID = @penaltyId";
                                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn, transaction);
                                selectCmd.Parameters.AddWithValue("@penaltyId", penaltyId);
                                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string memberId = reader["MemberID"].ToString();
                                        string bookId = reader["BookID"].ToString();

                                        // Xóa bản ghi trong BorrowReceipts
                                        reader.Close();
                                        string deleteQuery = @"
                                        DELETE FROM BorrowReceipts 
                                        WHERE MemberID = @memberId AND BookID = @bookId";
                                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn, transaction);
                                        deleteCmd.Parameters.AddWithValue("@memberId", memberId);
                                        deleteCmd.Parameters.AddWithValue("@bookId", bookId);
                                        deleteCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Hoàn tất giao dịch nếu mọi thứ thành công
                            transaction.Commit();
                            MessageBox.Show("Cập nhật trạng thái thanh toán và xóa bản ghi trong BorrowReceipts thành công!");
                        }
                        catch (Exception ex)
                        {
                            // Hoàn tác giao dịch nếu có lỗi
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi cập nhật hoặc xóa: " + ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi kết nối: " + ex.Message);
                    }
                }
            }
            this.Close();
        }
    }

}