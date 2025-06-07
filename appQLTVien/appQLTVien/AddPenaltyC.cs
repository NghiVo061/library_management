using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class AddPenaltyC : UserControl
    {
        ComboBox cboMemberID, cboIDbook, cboIssue, cboPaymentStatus; TextBox txtFineID, txtLate, txtCreateDate; Label lblTotalFine; Button btnCalculate, btnLoad; int quantity = 1; // Biến để lưu Quantity từ BorrowReceipts

        // ⚠️ Đổi password cho đúng thông tin MySQL của bạn
        string connectionString = "server=localhost;user id=root;password=123456;database=library";

        public AddPenaltyC()
        {
            InitializeComponent();
            InitControls();
            LoadMembers();
            LoadNextFineID();
        }

        private void InitControls()
        {
            this.Size = new Size(550, 430);

            Label title = new Label()
            {
                Text = "Tính phí phạt",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(180, 10),
                AutoSize = true
            };

            Label lblFineID = new Label() { Text = "Mã phiếu phạt:", Location = new Point(20, 50) };
            txtFineID = new TextBox() { Location = new Point(150, 48), Width = 200, ReadOnly = true };

            Label lblMember = new Label() { Text = "Mã thành viên:", Location = new Point(20, 90) };
            cboMemberID = new ComboBox() { Location = new Point(150, 88), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cboMemberID.SelectedIndexChanged += (s, e) => LoadBooksForMember();

            btnLoad = new Button() { Text = "Tải thông tin", Location = new Point(360, 88), Width = 120 };
            btnLoad.Click += (s, e) => LoadPenaltyInfo();

            Label lblBook = new Label() { Text = "Mã sách:", Location = new Point(20, 130) };
            cboIDbook = new ComboBox() { Location = new Point(150, 128), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            Label lblCreateDate = new Label() { Text = "Ngày lập phiếu:", Location = new Point(20, 170) };
            txtCreateDate = new TextBox()
            {
                Location = new Point(150, 168),
                Width = 200,
                ReadOnly = true,
                Text = DateTime.Now.ToString("dd/MM/yyyy")
            };

            Label lblDaysLate = new Label() { Text = "Số ngày trễ:", Location = new Point(20, 210) };
            txtLate = new TextBox() { Location = new Point(150, 208), Width = 200, ReadOnly = true };

            Label lblIssue = new Label() { Text = "Vi phạm:", Location = new Point(20, 250) };
            cboIssue = new ComboBox() { Location = new Point(150, 248), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            cboIssue.Items.AddRange(new string[] { "LateReturn", "Damaged", "Lost" });
            cboIssue.SelectedIndex = 0;
            cboIssue.SelectedIndexChanged += (s, e) => CalculateLateDays();

            Label lblPaymentStatus = new Label() { Text = "Trạng thái thanh toán:", Location = new Point(20, 290) };
            cboPaymentStatus = new ComboBox() { Location = new Point(150, 288), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };
            cboPaymentStatus.Items.Add("Unpaid");
            cboPaymentStatus.SelectedIndex = 0;

            btnCalculate = new Button() { Text = "Tính tiền phạt", Location = new Point(150, 330) };
            btnCalculate.Click += BtnCalculate_Click;

            lblTotalFine = new Label()
            {
                Text = "Tổng tiền phạt: 0 VNĐ",
                Location = new Point(150, 370),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = true
            };

            this.Controls.AddRange(new Control[] {
        title, lblFineID, txtFineID,
        lblMember, cboMemberID, btnLoad,
        lblBook, cboIDbook,
        lblCreateDate, txtCreateDate,
        lblDaysLate, txtLate,
        lblIssue, cboIssue,
        lblPaymentStatus, cboPaymentStatus,
        btnCalculate, lblTotalFine
    });

            // Tự động tính số ngày trễ khi chọn sách
            cboIDbook.SelectedIndexChanged += (s, e) => CalculateLateDays();
        }

        private void LoadNextFineID()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COALESCE(MAX(PenaltyID), 0) + 1 FROM PenaltyReceipts";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    txtFineID.Text = result != null ? result.ToString() : "1";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy mã phiếu phạt: " + ex.Message);
                    txtFineID.Text = "1";
                }
            }
        }

        private void LoadMembers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT MemberID FROM BorrowReceipts";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboMemberID.Items.Add(reader["MemberID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách thành viên: " + ex.Message);
                }
            }
        }

        private void LoadBooksForMember()
        {
            cboIDbook.Items.Clear();
            if (cboMemberID.SelectedItem == null)
            {
                return;
            }

            string memberId = cboMemberID.SelectedItem.ToString();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT BookID FROM BorrowReceipts WHERE MemberID = @memberId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@memberId", memberId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboIDbook.Items.Add(reader["BookID"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách sách: " + ex.Message);
                }
            }
        }

        private void CalculateLateDays()
        {
            if (cboMemberID.SelectedItem == null || cboIDbook.SelectedItem == null)
            {
                txtLate.Text = "0";
                quantity = 1;
                return;
            }

            string memberId = cboMemberID.SelectedItem.ToString();
            string bookId = cboIDbook.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT ExpectedReturnDate, Quantity
                FROM BorrowReceipts
                WHERE MemberID = @memberId AND BookID = @bookId
                ORDER BY BorrowDate DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@memberId", memberId);
                    cmd.Parameters.AddWithValue("@bookId", bookId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime expectedReturnDate = Convert.ToDateTime(reader["ExpectedReturnDate"]);
                            quantity = Convert.ToInt32(reader["Quantity"]);
                            DateTime today = DateTime.Now;
                            int lateDays = (today - expectedReturnDate).Days;
                            txtLate.Text = (lateDays > 0) ? lateDays.ToString() : "0";
                        }
                        else
                        {
                            txtLate.Text = "0";
                            quantity = 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính số ngày trễ: " + ex.Message);
                    txtLate.Text = "0";
                    quantity = 1;
                }
            }
        }

        private decimal GetBookPrice(string bookId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Price FROM Books WHERE BookID = @bookId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy giá sách: " + ex.Message);
                    return 0;
                }
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (cboIDbook.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã sách!");
                return;
            }

            int daysLate = 0;
            if (!int.TryParse(txtLate.Text, out daysLate) || daysLate < 0)
            {
                MessageBox.Show("Số ngày trễ không hợp lệ!");
                return;
            }

            decimal fine = 0;
            string issue = cboIssue.SelectedItem?.ToString() ?? "LateReturn"; // Xử lý null
            string paymentStatus = "Unpaid"; // Đặt cố định là Unpaid
            string bookId = cboIDbook.SelectedItem.ToString();

            if (issue == "LateReturn")
            {
                fine = (daysLate * 5000) * quantity;
            }
            else if (issue == "Damaged" || issue == "Lost")
            {
                fine = GetBookPrice(bookId) * quantity;
            }

            lblTotalFine.Text = $"Tổng tiền phạt: {fine:N0} VNĐ";

            // Cập nhật PenaltyAmount vào bảng PenaltyReceipts
            string penaltyId = txtFineID.Text;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"
                UPDATE PenaltyReceipts 
                SET PenaltyAmount = @penaltyAmount, BookStatus = @bookStatus, PaymentStatus = @paymentStatus 
                WHERE PenaltyID = @penaltyId";
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn);
                    cmdUpdate.Parameters.AddWithValue("@penaltyId", penaltyId);
                    cmdUpdate.Parameters.AddWithValue("@penaltyAmount", fine);
                    cmdUpdate.Parameters.AddWithValue("@bookStatus", issue);
                    cmdUpdate.Parameters.AddWithValue("@paymentStatus", paymentStatus);
                    int rowsAffected = cmdUpdate.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        // Nếu không tìm thấy bản ghi, chèn mới
                        string insertQuery = @"
                    INSERT INTO PenaltyReceipts (PenaltyID, MemberID, BookID, LateDays, PenaltyAmount, BookStatus, PaymentStatus, PenaltyDate)
                    VALUES (@penaltyId, @memberId, @bookId, @lateDays, @penaltyAmount, @bookStatus, @paymentStatus, @penaltyDate)";
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn);
                        cmdInsert.Parameters.AddWithValue("@penaltyId", penaltyId);
                        cmdInsert.Parameters.AddWithValue("@memberId", cboMemberID.SelectedItem.ToString());
                        cmdInsert.Parameters.AddWithValue("@bookId", bookId);
                        cmdInsert.Parameters.AddWithValue("@lateDays", daysLate);
                        cmdInsert.Parameters.AddWithValue("@penaltyAmount", fine);
                        cmdInsert.Parameters.AddWithValue("@bookStatus", issue);
                        cmdInsert.Parameters.AddWithValue("@paymentStatus", paymentStatus);
                        cmdInsert.Parameters.AddWithValue("@penaltyDate", DateTime.Now);
                        cmdInsert.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi im lặng để không hiển thị thông báo
                }
            }
        }

        private void LoadPenaltyInfo()
        {
            if (cboMemberID.SelectedItem == null || cboIDbook.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Mã thành viên và Mã sách.");
                return;
            }

            string memberId = cboMemberID.SelectedItem.ToString();
            string bookId = cboIDbook.SelectedItem.ToString();
            LoadNextFineID(); // Cập nhật mã phiếu phạt mới

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Kiểm tra trong PenaltyReceipts trước
                    string queryPenalty = @"
                SELECT p.LateDays, p.PenaltyAmount, p.BookStatus, p.PaymentStatus, p.PenaltyDate
                FROM PenaltyReceipts p
                WHERE p.MemberID = @memberId AND p.BookID = @bookId
                ORDER BY p.PenaltyDate DESC LIMIT 1";
                    MySqlCommand cmdPenalty = new MySqlCommand(queryPenalty, conn);
                    cmdPenalty.Parameters.AddWithValue("@memberId", memberId);
                    cmdPenalty.Parameters.AddWithValue("@bookId", bookId);

                    using (MySqlDataReader readerPenalty = cmdPenalty.ExecuteReader())
                    {
                        if (readerPenalty.Read())
                        {
                            txtLate.Text = readerPenalty["LateDays"].ToString();
                            cboIssue.SelectedItem = readerPenalty["BookStatus"].ToString();
                            cboPaymentStatus.SelectedItem = readerPenalty["PaymentStatus"].ToString();
                            lblTotalFine.Text = $"Tổng tiền phạt: {Convert.ToDecimal(readerPenalty["PenaltyAmount"]):N0} VNĐ";
                            txtCreateDate.Text = readerPenalty["PenaltyDate"] != DBNull.Value
                                ? Convert.ToDateTime(readerPenalty["PenaltyDate"]).ToString("dd/MM/yyyy")
                                : DateTime.Now.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            // Nếu không tìm thấy trong PenaltyReceipts, lấy từ BorrowReceipts
                            readerPenalty.Close();
                            string queryBorrow = @"
                        SELECT ExpectedReturnDate, Quantity
                        FROM BorrowReceipts
                        WHERE MemberID = @memberId AND BookID = @bookId
                        ORDER BY BorrowDate DESC LIMIT 1";
                            MySqlCommand cmdBorrow = new MySqlCommand(queryBorrow, conn);
                            cmdBorrow.Parameters.AddWithValue("@memberId", memberId);
                            cmdBorrow.Parameters.AddWithValue("@bookId", bookId);

                            using (MySqlDataReader readerBorrow = cmdBorrow.ExecuteReader())
                            {
                                if (readerBorrow.Read())
                                {
                                    DateTime expectedReturnDate = Convert.ToDateTime(readerBorrow["ExpectedReturnDate"]);
                                    quantity = Convert.ToInt32(readerBorrow["Quantity"]);
                                    DateTime today = DateTime.Now;
                                    int lateDays = (today - expectedReturnDate).Days;
                                    txtLate.Text = (lateDays > 0) ? lateDays.ToString() : "0";
                                    cboIssue.SelectedIndex = 0; // LateReturn mặc định
                                    cboPaymentStatus.SelectedItem = "Unpaid"; // Đặt cố định Unpaid
                                    lblTotalFine.Text = "Tổng tiền phạt: 0 VNĐ";
                                    txtCreateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                                    // Chèn dữ liệu vào PenaltyReceipts
                                    readerBorrow.Close();
                                    string insertQuery = @"
                                INSERT INTO PenaltyReceipts (PenaltyID, MemberID, BookID, LateDays, PenaltyAmount, BookStatus, PaymentStatus, PenaltyDate)
                                VALUES (@penaltyId, @memberId, @bookId, @lateDays, 0, @bookStatus, @paymentStatus, @penaltyDate)";
                                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn);
                                    cmdInsert.Parameters.AddWithValue("@penaltyId", txtFineID.Text);
                                    cmdInsert.Parameters.AddWithValue("@memberId", memberId);
                                    cmdInsert.Parameters.AddWithValue("@bookId", bookId);
                                    cmdInsert.Parameters.AddWithValue("@lateDays", lateDays);
                                    cmdInsert.Parameters.AddWithValue("@penaltyAmount", 0); // Sẽ cập nhật sau khi tính
                                    cmdInsert.Parameters.AddWithValue("@bookStatus", cboIssue.SelectedItem?.ToString() ?? "LateReturn");
                                    cmdInsert.Parameters.AddWithValue("@paymentStatus", "Unpaid");
                                    cmdInsert.Parameters.AddWithValue("@penaltyDate", DateTime.Now);
                                    int rowsAffected = cmdInsert.ExecuteNonQuery();
                                    if (rowsAffected == 0)
                                    {
                                        MessageBox.Show("Lỗi khi chèn dữ liệu vào PenaltyReceipts. Vui lòng kiểm tra khóa chính hoặc dữ liệu.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dữ liệu đã được chèn vào PenaltyReceipts thành công.");
                                    }
                                }
                                else
                                {
                                    txtLate.Text = "0";
                                    cboIssue.SelectedIndex = 0;
                                    cboPaymentStatus.SelectedItem = "Unpaid"; // Đặt cố định Unpaid
                                    lblTotalFine.Text = "Tổng tiền phạt: 0 VNĐ";
                                    txtCreateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                                    MessageBox.Show("Không tìm thấy dữ liệu trong BorrowReceipts.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc truy vấn: " + ex.Message);
                }
            }
        }
    }

}