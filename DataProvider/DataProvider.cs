using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.DataProvider
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=helloworld;Integrated Security=True;Trust Server Certificate=True";

        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance }; set => instance = value; }

        public DataTable ExecuteQuery()
        {
            SqlConnecti
        }
    }
}
