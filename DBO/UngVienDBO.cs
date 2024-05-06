using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Program;

namespace WindowsFormsApp2.DBO
{
    public class UngVienDBO
    {
        private string connectionString;

        public UngVienDBO()
        {
            connectionString = AppConfig.connectionString;
        }

        public bool KiemTraTonTai(string soDienThoai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UNGVIEN WHERE SODIENTHOAI = @SoDienThoai";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public string GetMaxMaUngVien()
        {
            string maxMaUngVien = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(MAUNGVIEN) FROM UNGVIEN";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    maxMaUngVien = result.ToString();

                }
            }

            return maxMaUngVien;
        }

        public bool ThemUngVien(string maUngVien, string hoTen, string email, string diaChi, string soDienThoai, string matKhau)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UNGVIEN (MAUNGVIEN, HOTEN, SODIENTHOAI, DIACHI, EMAIL, MATKHAU) " +
                               "VALUES (@MaUngVien, @HoTen, @SoDienThoai, @DiaChi, @Email, @MatKhau)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaUngVien", maUngVien);
                command.Parameters.AddWithValue("@HoTen", hoTen);
                command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
