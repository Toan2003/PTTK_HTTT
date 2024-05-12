using PTTK.BUS;
using System;
using System.Data;

namespace PTTK.DBO
{
    internal class UngVienDBO
    {
        DataProvider DataProvider { get; set; }

        public UngVienDBO()
        {
            DataProvider = new DataProvider();
        }

        public int LayThongTinUV(string soDienThoai)
        {
            string query = "SELECT COUNT(*) FROM UNGVIEN WHERE SODIENTHOAI = '" + soDienThoai + "'";

            DataProvider.OpenConect();

            int result = (int)DataProvider.ExecuteScalar(query);
            DataProvider.CloseConect();

            return result;
        }

        public DataTable LayMaxMaUngVien()
        {
            string query = "SELECT MAX(MAUNGVIEN) FROM UNGVIEN";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();

            return result;

            
        }

        public int ThemUngVien(UngVienBUS ungVien)
        {
            string maUngVien = ungVien.MaUngVien;
            string hoTen = ungVien.HoTen;
            string email = ungVien.Email;
            string diaChi = ungVien.DiaChi;
            string soDienThoai = ungVien.SoDienThoai;
            string matKhau = ungVien.MatKhau;

            string query = $"INSERT INTO UNGVIEN (MAUNGVIEN, HOTEN, SODIENTHOAI, DIACHI, EMAIL, MATKHAU) " +
                           $"VALUES ('{maUngVien}', N'{hoTen}', '{soDienThoai}', N'{diaChi}', '{email}', '{matKhau}')";

            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result;

        }
    }
}
