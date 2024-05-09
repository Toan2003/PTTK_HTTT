using PTTK.MH.ThemDNThanhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK.MH.DangKyUngTuyen;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PTTK.MH;

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
            Application.Run(new Login());
        }

        public static class AppConfig
        {
            // Biểu thức chính quy để kiểm tra số điện thoại Việt Nam
            private static readonly string phoneNumberPattern = @"^(0|\+84)(3[2-9]|5[689]|7[06-9]|8[1-689]|9[0-46-9])[0-9]{7}$";

            // Chuỗi kết nối mặc định
            //public static string connectionString = "Data Source=LAPTOP-C56AI2D0;Initial Catalog=QLHS;Integrated Security=True";
            // Tên người dùng hiện tại
            public static string UsernameID { get; set; }

            public static string HashMatKhau(string matKhau)
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    // Chuyển đổi mật khẩu thành mảng byte
                    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(matKhau));

                    // Tạo một StringBuilder để lưu trữ các byte đã được chuyển đổi thành chuỗi hex
                    StringBuilder stringBuilder = new StringBuilder();

                    // Lặp qua mỗi byte của mảng đã chuyển đổi và chuyển đổi nó thành một chuỗi hex
                    for (int i = 0; i < data.Length; i++)
                    {
                        stringBuilder.Append(data[i].ToString("x2"));
                    }

                    // Trả về chuỗi hex đã được tạo
                    return stringBuilder.ToString();
                }
            }

            public static bool IsValidEmail(string email)
            {
                // Biểu thức chính quy để kiểm tra địa chỉ email
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Tạo một đối tượng Regex từ biểu thức chính quy
                Regex regex = new Regex(pattern);

                // Kiểm tra xem địa chỉ email có khớp với biểu thức chính quy không
                return regex.IsMatch(email);
            }

            public static bool IsValidPhoneNumber(string phoneNumber)
            {
                if (string.IsNullOrEmpty(phoneNumber))
                    return false;

                // Remove spaces and hyphens for more lenient validation
                phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

                // Create a Regex based on the specified pattern
                Regex regex = new Regex(phoneNumberPattern);

                // Check if the phone number matches the pattern
                return regex.IsMatch(phoneNumber);
            }

            public static bool IsValidTaxIdentificationNumber(string taxCode)
            {
                if (string.IsNullOrWhiteSpace(taxCode))
                    return false;

                // Normalize by removing spaces
                taxCode = taxCode.Replace(" ", "");

                // Check if the tax code is either 10 or 13 digits long
                if (taxCode.Length != 10 && taxCode.Length != 13)
                    return false;

                // Check if all characters are digits
                foreach (char c in taxCode)
                {
                    if (!char.IsDigit(c))
                        return false;
                }

                return true;
            }

        }
    }
}
