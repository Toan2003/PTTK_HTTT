using System.Data;

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
                string query = $"SELECT COUNT(*) FROM DOANHNGHIEP WHERE USERNAME = '{username}' AND PASSWORD = '{password}' AND TRANGTHAI = N'ĐÃ DUYỆT'";
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
                string query = $"SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '{employeeId}' AND MANV = '{password}'";
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

        public DataTable LayMaUV(string phoneNumber, string password)
        {
            string query = $"SELECT MAUNGVIEN FROM UNGVIEN WHERE SODIENTHOAI = '{phoneNumber}' AND MATKHAU = '{password}'";

            dataProvider.OpenConect();
            DataTable result = dataProvider.ExecuteQuery(query);
            dataProvider.CloseConect();
            return result;
        }

        public DataTable LayMaDN(string username)
        {
            string query = $"SELECT MADN FROM DOANHNGHIEP WHERE USERNAME = '{username}''";

            dataProvider.OpenConect();
            DataTable result = dataProvider.ExecuteQuery(query);
            dataProvider.CloseConect();
            return result;
        }

        public DataTable LayMaNV(string employeeId, string password)
        {
            string query = $"SELECT MANV FROM NHANVIEN WHERE MANV = '{employeeId}' AND MANV = '{password}'";

            dataProvider.OpenConect();
            DataTable result = dataProvider.ExecuteQuery(query);
            dataProvider.CloseConect();
            return result;
        }
    }
}
