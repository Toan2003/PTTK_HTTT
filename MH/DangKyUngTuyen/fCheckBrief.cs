using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fCheckBrief : Form
    {
        private DataTable dataTable1;
        private DataTable dataTable2;

        public fCheckBrief()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CreateTable1(); // Tạo cấu trúc bảng cho GridView 1
            CreateTable2(); // Tạo cấu trúc bảng cho GridView 2
            DisplayDummyData();
        }

        private void CreateTable1()
        {
            // Tạo cấu trúc bảng cho GridView 1
            dataTable1 = new DataTable();
            dataTable1.Columns.Add("Mã phiếu đăng kí");
            dataTable1.Columns.Add("Mã ứng viên");
            dataTable1.Columns.Add("Tên ứng viên");

            // Liên kết bảng với DataGridView 1
            dataGridView1.DataSource = dataTable1;
        }

        private void CreateTable2()
        {
            // Tạo cấu trúc bảng cho GridView 2
            dataTable2 = new DataTable();
            dataTable2.Columns.Add("Loại hồ sơ");

            // Liên kết bảng với DataGridView 2
            dataGridView2.DataSource = dataTable2;
        }

        private void DisplayDummyData()
        {
            // Dữ liệu dummy cho GridView 1
            dataTable1.Rows.Add("PD001", "UV001", "Nguyễn Văn A");
            dataTable1.Rows.Add("PD002", "UV002", "Trần Thị B");
            dataTable1.Rows.Add("PD003", "UV003", "Lê Văn C");
            dataTable1.Rows.Add("PD004", "UV004", "Phạm Thị D");
            dataTable1.Rows.Add("PD005", "UV005", "Hoàng Văn E");
            dataTable1.Rows.Add("PD006", "UV006", "Nguyễn Thị F");
            dataTable1.Rows.Add("PD007", "UV007", "Trần Văn G");

            // Dữ liệu dummy cho GridView 2
            dataTable2.Rows.Add("CCCD");
            dataTable2.Rows.Add("Chứng chỉ tiếng Anh");
            dataTable2.Rows.Add("CV");
            dataTable2.Rows.Add("Bằng tốt nghiệp");
            dataTable2.Rows.Add("Hộ chiếu");
            dataTable2.Rows.Add("Thẻ căn cước");
            dataTable2.Rows.Add("Chứng minh nhân dân");
        }
    }
}
