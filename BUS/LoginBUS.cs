using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return "Candidate";
            }

            // Kiểm tra đăng nhập của doanh nghiệp
            if (loginDBO.CheckBusinessLogin(username, password))
            {
                return "Business";
            }

            // Kiểm tra đăng nhập của nhân viên
            if (loginDBO.CheckEmployeeLogin(username, password))
            {
                return "Employee";
            }

            return null;
        }
    }
}
