using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DBO
{
    internal class DichVuDBO
    {
        DataProvider DataProvider { get; set; }
        public DichVuDBO()
        {
            DataProvider = new DataProvider();
        }

        public DataTable LayMaDV(string tendv)
        {
            string query = $"SELECT MADV FROM DICHVU WHERE TENDICHVU LIKE N'%{tendv}%';";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
