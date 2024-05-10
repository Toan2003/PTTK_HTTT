using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DBO
{
    public class PhieuThuDBO
    {
        DataProvider DataProvider { get; set; }
        public PhieuThuDBO()
        {
            DataProvider = new DataProvider();
        }
        public DataTable LayPhieuThuTheoMaPT(string MaPT)
        {
            string query = "select * from phieuthu where MaPT = '" + MaPT + "'";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public int ThemPhieuThu(PhieuThuBUS phieuthu)
        {
            string MaPT = phieuthu.MaPT;
            string MaPhieuDK = phieuthu.MaPDT;
            float TongTien = phieuthu.TongTien;
            string PhuongAnTT = phieuthu.PhuongAnTT;
            DateTime NgayLap = phieuthu.NgayLap;
            string MaNV = phieuthu.MaNV;

            string query = $"INSERT INTO PHIEUTHU (MAPT, MAPDT, TONGTIEN, PHUONGANTT, NGAYLAP, MANV) VALUES ('{MaPT}', '{MaPhieuDK}', {TongTien}, N'{PhuongAnTT}', '{NgayLap:yyyy-MM-dd HH:mm:ss}','{MaNV}')";
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public DataTable LayPhieuThuGanNhat()
        {
            string query = "SELECT TOP 1 MAPT FROM PHIEUTHU ORDER BY MAPT DESC";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
