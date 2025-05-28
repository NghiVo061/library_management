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
    public partial class SearchBookC : UserControl
    {
        TextBox txtNameBook;
        Button btnSearch;
        DataGridView dgvBooks;
        public SearchBookC()
        {
            InitializeComponent();
            InitControls();
            LoadSampleData();
        }

        private void InitControls()
        {
            this.Size = new Size(700, 400);

            Label title = new Label()
            {
                Text = "Tìm kiếm sách",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(280, 20),
                AutoSize = true
            };

            Label lblNameBook = new Label()
            {
                Text = "Tên sách:",
                Location = new Point(50, 80),
                AutoSize = true
            };

            txtNameBook = new TextBox()
            {
                Location = new Point(130, 75),
                Width = 300
            };

            btnSearch = new Button()
            {
                Text = "Tìm kiếm",
                Location = new Point(450, 73),
                Width = 100,
                Height = 30,
                BackColor = Color.LightSteelBlue
            };
            btnSearch.Click += BtnSearch_Click;

            dgvBooks = new DataGridView()
            {
                Location = new Point(50, 120),
                Width = 600,
                Height = 250,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            this.Controls.AddRange(new Control[]
            {
                title, lblNameBook, txtNameBook,
                btnSearch, dgvBooks
            });
        }

        private void LoadSampleData()
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
          
            // Hiển thị kết quả
            var dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Tác giả");
        
            dgvBooks.DataSource = dt;
        }
    }

    // Lớp dữ liệu sách
    
}

