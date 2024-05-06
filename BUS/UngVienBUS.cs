using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DBO;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2.BUS
{
    public class UngVienBUS
    {
        private UngVienDBO ungVienDBO;

        public UngVienBUS()
        {
            ungVienDBO = new UngVienDBO();
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
            
            if (!AppConfig.IsValidEmail(email))
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

        public int ThemUngVien(string hoTen, string email, string diaChi, string soDienThoai, string matKhau)
        {
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

            // Kiểm tra xem tài khoản đã tồn tại chưa
            if (ungVienDBO.KiemTraTonTai(soDienThoai))
            {
                return 100;
            }

            string hashedMatKhau = AppConfig.HashMatKhau(matKhau); 
            if (ungVienDBO.ThemUngVien(maUngVien, hoTen, email, diaChi, soDienThoai, hashedMatKhau))
            {
                return 1;
            } else
            {
                return 0;
            }
             
        }

        public void DangNhap(string soDienThoai, string matKhau)
        {
            MessageBox.Show("Khúc này đăng nhập nha");
        }
    }
}
