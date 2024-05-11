using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (loginDBO.CheckCandidateLogin(username, password))
            {
                password = AppConfig.HashMatKhau(password);
                DataTable table = loginDBO.LayMaUV(username, password);
                DataRow row = table.Rows[0];
                AppConfig.UsernameID = row["MAUNGVIEN"].ToString();

                return "Candidate";
            }

            // Kiểm tra đăng nhập của doanh nghiệp
            if (loginDBO.CheckBusinessLogin(username, password))
            {
                password = AppConfig.HashMatKhau(password);
                DataTable table = loginDBO.LayMaDN(username, password);
                DataRow row = table.Rows[0];
                AppConfig.UsernameID = row["MADN"].ToString();

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
    }
}
