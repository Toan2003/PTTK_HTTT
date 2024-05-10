using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DBO
{
    public class DoanhNghiepDBO
    {
        DataProvider DataProvider { get; set; }
        public DoanhNghiepDBO() { 
            DataProvider = new DataProvider();
        }
        public DataTable TimDoanhNghiepTheoMaDoanhNghiep(string MaDN)
        {
            string query = "select * from DOANHNGHIEP where MADN = '" + MaDN + "'";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
