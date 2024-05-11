using PTTK.BUS;
using PTTK.MH;
using System;
using System.Windows.Forms;

namespace PTTK
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            AppConfig.UsernameID = "NV001";

            Application.Run(new Login());
        }

        public static class AppConfig
        {
            // Biểu thức chính quy để kiểm tra số điện thoại Việt Nam
            private static readonly string phoneNumberPattern = @"^(0|\+84)(3[2-9]|5[689]|7[06-9]|8[1-689]|9[0-46-9])[0-9]{7}$";

            // Chuỗi kết nối mặc định
            //public static string connectionString = "Data Source=LAPTOP-C56AI2D0;Initial Catalog=QLHS;Integrated Security=True";

            // Tên người dùng hiện tại
            public static DoanhNghiepBUS doanhNghiepDangNhap;
            public static string UsernameID { get; set; }

        }
    }
}
