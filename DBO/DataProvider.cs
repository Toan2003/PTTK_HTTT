﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTTK.DBO
{
    internal class DataProvider
    {
        ///*TOAN*/ string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True";
        /*HOA*/
        string connectionString = "Data Source=.;Initial Catalog=PTTK;Integrated Security=True";
        ///*TOAN*/ string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True";
        /*DUY*/ string connectionString = "Data Source=LAPTOP-C56AI2D0;Initial Catalog=PTTK;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public DataProvider() { con = new SqlConnection(connectionString);}
        public void OpenConect() { con.Open(); }
        public void CloseConect() { con.Close();}
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine("Lỗi khi thực thi câu truy vấn: " + ex.Message);
                return null;
            }
            
        }

    }
}
