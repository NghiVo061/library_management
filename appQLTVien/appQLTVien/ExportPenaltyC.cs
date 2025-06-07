using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class ExportPenaltyC : UserControl
    {
        ComboBox cboMemberID; DateTimePicker dtFrom, dtTo; Button btnExport; DataGridView dgvResult;

        // ⚠️ Đổi password cho đúng thông tin MySQL của bạn
        string connectionString = "server=localhost;user id=root;password=123456;database=library";

        public ExportPenaltyC()
        {
            InitializeComponent();
            InitControls();
            LoadMembers();
        }

        private void InitControls()
        {
            this.Size = new Size(1000, 500);

            Label title = new Label()
            {
                Text = "Xuất bảng phí phạt",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(380, 20),
                AutoSize = true
            };

            Label lblMemberID = new Label() { Text = "Mã thành viên:", Location = new Point(50, 80), AutoSize = true };
            cboMemberID = new ComboBox() { Location = new Point(160, 76), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            Label lblFrom = new Label() { Text = "Từ ngày:", Location = new Point(400, 80), AutoSize = true };
            dtFrom = new DateTimePicker() { Location = new Point(470, 76), Width = 150 };

            Label lblTo = new Label() { Text = "Đến ngày:", Location = new Point(650, 80), AutoSize = true };
            dtTo = new DateTimePicker() { Location = new Point(730, 76), Width = 150 };

            btnExport = new Button()
            {
                Text = "Xuất thông tin",
                Location = new Point(430, 120),
                Width = 140,
                Height = 35,
                BackColor = Color.LightSteelBlue
            };
            btnExport.Click += BtnExport_Click;

            dgvResult = new DataGridView()
            {
                Location = new Point(50, 180),
                Width = 880,
                Height = 280,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
            title, lblMemberID, cboMemberID,
            lblFrom, dtFrom, lblTo, dtTo,
            btnExport, dgvResult
            });
        }

        private void LoadMembers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT MemberID FROM PenaltyReceipts";
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

        private void BtnExport_Click(object sender, EventArgs e)
        {
            string memberId = cboMemberID.SelectedItem?.ToString();
            DateTime fromDate = dtFrom.Value;
            DateTime toDate = dtTo.Value;

            if (string.IsNullOrEmpty(memberId))
            {
                MessageBox.Show("Vui lòng chọn mã thành viên!");
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Mã phiếu phạt");
            table.Columns.Add("Mã thành viên");
            table.Columns.Add("Mã sách");
            table.Columns.Add("Số ngày trễ");
            table.Columns.Add("Phí phạt");
            table.Columns.Add("Tình trạng");
            table.Columns.Add("Trạng thái thanh toán");
            table.Columns.Add("Ngày phạt");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT PenaltyID, MemberID, BookID, LateDays, PenaltyAmount, BookStatus, PaymentStatus, PenaltyDate
                    FROM PenaltyReceipts
                    WHERE MemberID = @memberId 
                    AND PenaltyDate BETWEEN @fromDate AND @toDate
                    ORDER BY PenaltyDate DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@memberId", memberId);
                    cmd.Parameters.AddWithValue("@fromDate", fromDate);
                    cmd.Parameters.AddWithValue("@toDate", toDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            table.Rows.Add(
                                reader["PenaltyID"],
                                reader["MemberID"],
                                reader["BookID"],
                                reader["LateDays"],
                                reader["PenaltyAmount"],
                                reader["BookStatus"],
                                reader["PaymentStatus"],
                                reader["PenaltyDate"] != DBNull.Value ? ((DateTime)reader["PenaltyDate"]).ToString("dd/MM/yyyy") : ""
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message);
                }
            }

            dgvResult.DataSource = table;
        }
    }

}