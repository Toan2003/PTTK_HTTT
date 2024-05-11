using PTTK.DBO;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static PTTK.Program;

namespace PTTK.BUS
{
    internal class LoginBUS
    {
        private LoginDBO loginDBO;

        public LoginBUS()
        {
            loginDBO = new LoginDBO();
        }

        public string Login(string username, string password)
        {
            // Kiểm tra đăng nhập của ứng viên
            if (loginDBO.CheckCandidateLogin(username, HashMatKhau(password)))
            {
                password = this.HashMatKhau(password);
                DataTable table = loginDBO.LayMaUV(username, password);
                DataRow row = table.Rows[0];
                AppConfig.UsernameID = row["MAUNGVIEN"].ToString();

                return "Candidate";
            }

            // Kiểm tra đăng nhập của doanh nghiệp
            if (loginDBO.CheckBusinessLogin(username, this.HashMatKhau(password)))
            {
                return "Business";
            }

            // Kiểm tra đăng nhập của nhân viên
            if (loginDBO.CheckEmployeeLogin(username, password))
            {
                DataTable table = loginDBO.LayMaNV(username, password);
                DataRow row = table.Rows[0];
                AppConfig.UsernameID = row["MANV"].ToString();

                return "Employee";
            }

            return null;
        }

        public string HashMatKhau(string matKhau)
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
