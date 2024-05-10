using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2.DataProvider
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";

        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set => DataProvider.instance = value; }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(data);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }

                }
            }

            return data;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.Add(param);
                        }
                    }
                    try
                    {
                        data = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }

            }
            return data;
        }

        public object ExecuteScalar(string query) { return null; }
    }
}
