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
    public partial class fApplicationRegister : Form
    {
        private DataTable dataTable;

        public fApplicationRegister()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CreateTable(); // Tạo cấu trúc bảng
            DisplayDummyData();
        }

        private void CreateTable()
        {
            // Tạo cấu trúc bảng với các cột tương ứng
            dataTable = new DataTable();
            dataTable.Columns.Add("Công ty");
            dataTable.Columns.Add("Vị trí");
            dataTable.Columns.Add("Thời gian tuyển");
            dataTable.Columns.Add("Số lượng");
            dataTable.Columns.Add("Yêu cầu");

            // Liên kết bảng với DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void DisplayDummyData()
        {
            // Tạo danh sách dữ liệu dummy
            List<RecruitmentProfile> dummyData = new List<RecruitmentProfile>
            {
                new RecruitmentProfile { Company = "ABC Company", Position = "Software Engineer", HiringTime = "May 2024", Quantity = 3, Requirements = "Bachelor's degree in Computer Science" },
                new RecruitmentProfile { Company = "XYZ Corporation", Position = "Data Analyst", HiringTime = "June 2024", Quantity = 2, Requirements = "Experience with data visualization tools" },
                new RecruitmentProfile { Company = "123 Inc.", Position = "Marketing Manager", HiringTime = "July 2024", Quantity = 1, Requirements = "Strong communication skills" },
                new RecruitmentProfile { Company = "DEF Ltd.", Position = "Project Manager", HiringTime = "August 2024", Quantity = 2, Requirements = "PMP certification required" },
                new RecruitmentProfile { Company = "456 Corporation", Position = "Sales Representative", HiringTime = "September 2024", Quantity = 5, Requirements = "Experience in sales field" },
                new RecruitmentProfile { Company = "GHI Solutions", Position = "HR Specialist", HiringTime = "October 2024", Quantity = 1, Requirements = "Experience in HR field" },
                new RecruitmentProfile { Company = "JKL Enterprises", Position = "Financial Analyst", HiringTime = "November 2024", Quantity = 2, Requirements = "Knowledge of financial software" },
                new RecruitmentProfile { Company = "MNO Group", Position = "Graphic Designer", HiringTime = "December 2024", Quantity = 3, Requirements = "Proficiency in Adobe Creative Suite" },
                new RecruitmentProfile { Company = "PQR Technologies", Position = "Quality Assurance Engineer", HiringTime = "January 2025", Quantity = 2, Requirements = "Experience in software testing" },
                new RecruitmentProfile { Company = "STU Innovations", Position = "Product Manager", HiringTime = "February 2025", Quantity = 1, Requirements = "Experience in product management" }
                // Thêm dữ liệu dummy khác nếu cần
            };

            // Thêm dữ liệu dummy vào DataTable
            foreach (var profile in dummyData)
            {
                dataTable.Rows.Add(profile.Company, profile.Position, profile.HiringTime, profile.Quantity, profile.Requirements);
            }
        }
    }

    public class RecruitmentProfile
    {
        public string Company { get; set; }
        public string Position { get; set; }
        public string HiringTime { get; set; }
        public int Quantity { get; set; }
        public string Requirements { get; set; }
    }
}
