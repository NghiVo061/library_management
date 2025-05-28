using System;
using System.Drawing;
using System.Windows.Forms;

namespace appQLTVien
{
    public partial class ExportBookControl : UserControl
    {
        private ComboBox cboBookTitle;
        private Button btnDisplay;
        private DataGridView dgvBooks;

        
        public ExportBookControl()
        {
            InitializeBookUI(); 
        }

        private void InitializeBookUI()
        {
            this.Size = new Size(786, 642); 

            // ComboBox - chọn tên sách
            cboBookTitle = new ComboBox();
            cboBookTitle.Name = "cboBookTitle";
            cboBookTitle.Location = new Point(20, 20);
            cboBookTitle.Size = new Size(200, 25);
            cboBookTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(cboBookTitle);

            // Button - hiển thị dữ liệu
            btnDisplay = new Button();
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Text = "Display";
            btnDisplay.Location = new Point(240, 20);
            btnDisplay.Size = new Size(100, 25);
            this.Controls.Add(btnDisplay);

            // DataGridView - danh sách sách
            dgvBooks = new DataGridView();
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Location = new Point(20, 60);
            dgvBooks.Size = new Size(740, 550);
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgvBooks);
        }
    }
}
