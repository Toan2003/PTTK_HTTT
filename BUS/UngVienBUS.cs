using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PTTK.DBO;

namespace PTTK.BUS
{
    internal class UngVienBUS
    {
        private UngVienDBO ungVienDBO;

        public string MaUngVien { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MatKhau { get; set; }

        public UngVienBUS(string hoTen, string email, string diaChi, string soDienThoai, string matKhau)
        {
            ungVienDBO = new UngVienDBO();

            string maUngVien = "UV000001"; // Giả sử mã ứng viên bắt đầu từ UV00000001

            string maxMaUngVien = ungVienDBO.GetMaxMaUngVien();
            if (!string.IsNullOrEmpty(maxMaUngVien))
            {
                string currentNumberString = maxMaUngVien.Substring(2); // Lấy phần số từ mã ứng viên hiện tại
                if (int.TryParse(currentNumberString, out int currentNumber))
                {
                    currentNumber++; // Tăng giá trị số hiện tại lên 1
                    maUngVien = "UV" + currentNumber.ToString().PadLeft(6, '0'); // Tạo mã ứng viên mới
                }

            }
            this.MaUngVien = maUngVien;
            this.HoTen = hoTen;
            this.Email = email;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.MatKhau = matKhau;
            
        }

        public bool KiemTraThongTin(string hoTen, string email, string diaChi, string soDienThoai, string matKhau, string xacNhanMatKhau)
        {
            // Kiểm tra thông tin đầy đủ và hợp lệ
            // Bạn có thể triển khai kiểm tra ở đây dựa trên yêu cầu

            if (string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return false;
            }

            if (!(soDienThoai.Length == 10 && soDienThoai[0] == '0' && soDienThoai.Substring(1).All(char.IsDigit)))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return false;
            }
            if (matKhau.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.");
                return false;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp.");
                return false;
            }

            return true;
        }

        public int ThemUngVien(UngVienBUS ungVien)
        {            

            // Kiểm tra xem tài khoản đã tồn tại chưa
            if (ungVienDBO.KiemTraTonTai(ungVien.SoDienThoai))
            {
                return 100;
            }

            ungVien.MatKhau = HashMatKhau(ungVien.MatKhau); 
            if (ungVienDBO.ThemUngVien(ungVien))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra địa chỉ email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Tạo một đối tượng Regex từ biểu thức chính quy
            Regex regex = new Regex(pattern);

            // Kiểm tra xem địa chỉ email có khớp với biểu thức chính quy không
            return regex.IsMatch(email);
        }

        string HashMatKhau(string matKhau)
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

    }
}
