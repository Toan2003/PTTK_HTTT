using System;
using System.Data.SqlClient;
using WindowsFormsApp2.BUS;

namespace WindowsFormsApp2.DBO
{
    public class DoanhNghiepDBO
    {
        private static DoanhNghiepDBO instance;

        public static DoanhNghiepDBO Instance { get { if (instance == null) instance = new DoanhNghiepDBO(); return instance; } private set => instance = value; }

        private DoanhNghiepDBO() { }

        public bool Them(DoanhNghiepBUS doanhNghiep)
        {

            return false;
        }

        public bool KiemTraTonTai(String username, String mst)
        {
            string query = "SELECT * FROM DOANHNGHIEP WHERE DN_USERNAME = @username OR MST = @mst";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
                ,new SqlParameter("@mst", mst)
            };
            int result = DataProvider.DataProvider.Instance.ExecuteNonQuery(query, parameters);
            //Return true if there is a record with the same username or MST
            return result > 0;
        }
    }
}
