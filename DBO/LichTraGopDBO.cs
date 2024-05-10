using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.DBO
{
    public class LichTraGopDBO
    {
        DataProvider DataProvider { get; set; }
        public LichTraGopDBO()
        {
            DataProvider = new DataProvider();
        }
        public DataTable TimLichTraGopTheoMaPhieuDangKy(string MaPDT)
        {
            string query = "select * from LICHTRAGOP where MAPDT = '" + MaPDT + "' order by DOTTHANHTOAN ASC";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public int ThemLichTraGop(LichTraGopBUS lich)
        {
            string MAPDT = lich.MaPDT;
            int DotThanhToan = lich.DotThanhToan;
            DateTime NgayHen = lich.NgayHen;
            string TrangThai = lich.TrangThai;
            DateTime? NgayThu = lich.NgayThu;
            float TongTien = lich.TongTien;
            string query;
            if (NgayThu == null)
            {
                query = $"INSERT INTO LICHTRAGOP (MAPDT, DOTTHANHTOAN, NGAYHEN, TRANGTHAI, NGAYTHU, TONGTIEN) VALUES ('{MAPDT}', '{DotThanhToan}', '{NgayHen:yyyy-MM-dd}', N'{TrangThai}', null, {TongTien})";
            }
            else
            {
                query = $"INSERT INTO LICHTRAGOP (MAPDT, DOTTHANHTOAN, NGAYHEN, TRANGTHAI, NGAYTHU, TONGTIEN) VALUES ('{MAPDT}', '{DotThanhToan}', '{NgayHen:yyyy-MM-dd}', N'{TrangThai}', '{NgayThu:yyyy-MM-dd HH:mm:ss}', {TongTien})";
            }
            //MessageBox.Show(query);
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result;
        }
        public int CapNhatTrangThaiNgayThuLich(LichTraGopBUS lich)
        {
            string query = $"UPDATE LICHTRAGOP SET TRANGTHAI = N'{lich.TrangThai}', NGAYTHU ='{lich.NgayThu:yyyy-MM-dd HH:mm:ss}' WHERE MAPDT = '{lich.MaPDT}' AND DOTTHANHTOAN = {lich.DotThanhToan}";
            //MessageBox.Show(query);
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
