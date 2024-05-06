using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PTTK.DBO;

namespace PTTK.DBO
{
    internal class QuiDinhDBO
    {
        DataProvider DataProvider { get; set; }
        public QuiDinhDBO() { 
            DataProvider = new DataProvider();
        }
        public DataTable LayQuiDinhTheoMaQuiDinh(string MAQD)
        {
            string query = "select * from QUIDINH where MAQD = '" + MAQD + "'";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
