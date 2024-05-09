using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK.BUS;
using static PTTK.Program;

namespace PTTK.DBO
{
    internal class UngVienDBO
    {
        DataProvider DataProvider { get; set; }

        public UngVienDBO()
        {
            DataProvider = new DataProvider();
        }

        public bool KiemTraTonTai(string soDienThoai)
        {
            string query = "SELECT COUNT(*) FROM UNGVIEN WHERE SODIENTHOAI = '" + soDienThoai + "'";

            DataProvider.OpenConect();
            
            int result = (int)DataProvider.ExecuteScalar(query);
            DataProvider.CloseConect();

            if (result > 0)//result != null && result.Rows.Count > 0)
            {
                return true;
            }

            
            return false;
        }

        public string GetMaxMaUngVien()
        {
            string query = "SELECT MAX(MAUNGVIEN) FROM UNGVIEN";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();

            if (result != null && result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
            {
                return result.Rows[0][0].ToString();
            }

            return "";
        }

        public bool ThemUngVien(UngVienBUS ungVien)
        {
            string maUngVien = ungVien.MaUngVien;
            string hoTen = ungVien.HoTen;
            string email = ungVien.Email;
            string diaChi = ungVien.DiaChi;
            string soDienThoai = ungVien.SoDienThoai;
            string matKhau = ungVien.MatKhau;

            string query = $"INSERT INTO UNGVIEN (MAUNGVIEN, HOTEN, SODIENTHOAI, DIACHI, EMAIL, MATKHAU) " +
                           $"VALUES ('{maUngVien}', '{hoTen}', '{soDienThoai}', '{diaChi}', '{email}', '{matKhau}')";

            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            if (result > 0)
            {
                return true;
            } else
            {
                return false;
            }
           
            
        }
    }
}
