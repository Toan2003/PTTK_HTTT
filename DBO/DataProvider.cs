﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace PTTK.DBO
{
    internal class DataProvider
    {
        /*TOAN*/
        string connectionString = "Data Source=MSI;Initial Catalog=PTTK;Integrated Security=True;";
        /*HOA*/
        /*        string connectionString = "Data Source=.;Initial Catalog=PTTK;Integrated Security=True";
        */        /*TheAnh*/
        //string connectionString = @"Data Source=LAPTOP-I679ENGR;Initial Catalog=PTTK;Integrated Security=True;TrustServerCertificate=True";
        /*DUY*//* string connectionString = "Data Source=LAPTOP-C56AI2D0;Initial Catalog=PTTK;Integrated Security=True";
*/
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public DataProvider() { con = new SqlConnection(connectionString); }
        public void OpenConect() { con.Open(); }
        public void CloseConect() { con.Close(); }
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                dt = new DataTable();
                using (cmd = new SqlCommand(query, con))
                {
                    adt = new SqlDataAdapter(cmd);
                    adt.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR in Executing query: " + query, ex.Message);
                return null;
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (cmd = new SqlCommand(query, con))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                object result;
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    result = cmd.ExecuteScalar();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi câu truy vấn: " + query + ex.Message);
                return null;
            }

        }

    }
}
