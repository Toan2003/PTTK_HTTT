using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.DBO
{
    internal class LoginDBO
    {
        private DataProvider dataProvider { get; set; }

        public LoginDBO()
        {
            dataProvider = new DataProvider();
        }

        public bool CheckCandidateLogin(string phoneNumber, string password)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM UNGVIEN WHERE SODIENTHOAI = '{phoneNumber}' AND MATKHAU = '{password}'";
                dataProvider.OpenConect();
                object result = dataProvider.ExecuteScalar(query);
                dataProvider.CloseConect();

                // Kiểm tra nếu result không phải là null và là một số nguyên
                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    return count > 0;
                }
                else
                {
                    // Xử lý trường hợp không nhận được kết quả hợp lệ từ ExecuteScalar
                    return false;
                }
            } 
            catch
            {
                return false;
            }
            
        }

        public bool CheckBusinessLogin(string username, string password)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM DOANHNGHIEP WHERE USERNAME = '{username}' AND PASSWORD = '{password}'";
                dataProvider.OpenConect();
                object result = dataProvider.ExecuteScalar(query);
                dataProvider.CloseConect();

                // Kiểm tra nếu result không phải là null và là một số nguyên
                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    return count > 0;
                }
                else
                {
                    // Xử lý trường hợp không nhận được kết quả hợp lệ từ ExecuteScalar
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
        }

        public bool CheckEmployeeLogin(string employeeId, string password)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '{employeeId}' AND MATKHAU = '{password}'";
                dataProvider.OpenConect();
                object result = dataProvider.ExecuteScalar(query);
                dataProvider.CloseConect();

                // Kiểm tra nếu result không phải là null và là một số nguyên
                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    return count > 0;
                }
                else
                {
                    // Xử lý trường hợp không nhận được kết quả hợp lệ từ ExecuteScalar
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
        }
    }
}
