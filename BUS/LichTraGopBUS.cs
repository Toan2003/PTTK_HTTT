using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.BUS
{
    public class LichTraGopBUS
    {
        public string MaPDT { get; set; }
        public int DotThanhToan { get; set; }
        public DateTime NgayHen { get; set; }
        public string TrangThai { get; set; }
        public DateTime? NgayThu { get; set; }
        public float TongTien { get; set; }
        public LichTraGopBUS(string MaPDT, int DotThanhToan, DateTime NgayHen, string TrangThai, DateTime? NgayThu, float tongTien)
        {
            this.MaPDT = MaPDT;
            this.DotThanhToan = DotThanhToan;
            this.NgayHen = NgayHen;
            this.TrangThai = TrangThai;
            this.NgayThu = NgayThu;
            this.TongTien = tongTien;
        }
        public static int ThemLichTraGop(LichTraGopBUS lich)
        {
            if (string.IsNullOrEmpty(lich.MaPDT) || lich.MaPDT.Length != 6)
            {
                return -2;
            }
            if (lich.DotThanhToan <= 0)
            {
                return -3;
            }
            if (lich.NgayHen < DateTime.Now.Date)
            {
                return -4;
            }
            if (lich.TrangThai != "Chưa Thanh Toán" && lich.TrangThai != "Đã Thanh Toán")
            {
                return -5;
            }
            if (lich.NgayThu < DateTime.Now.Date)
            {
                return -6;
            }
            LichTraGopDBO lichDBO = new LichTraGopDBO();
            int result = lichDBO.ThemLichTraGop(lich);
            return result;
        }
        public static DataTable TimLichTraGopTheoMaPDK(string MaPDT)
        {
            if (string.IsNullOrEmpty(MaPDT))
            {
                return null;
            }
            LichTraGopDBO lichDBO = new LichTraGopDBO();
            DataTable table = lichDBO.TimLichTraGopTheoMaPhieuDangKy(MaPDT);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("ERROR BUS: Khong Tim Thay lich Tra Gop");
                return null;
            }
            else
            {
                return table;
            }
        }

        public int CapNhatTrangThaiNgayThuLich(string TrangThai, DateTime? NgayThu)
        {
            if (TrangThai != "Đã Thanh Toán" && TrangThai != "Chưa Thanh Toán")
            {
                return -10;
            }
            this.TrangThai = TrangThai;
            this.NgayThu = NgayThu;
            LichTraGopDBO lichDBO = new LichTraGopDBO();
            int result = lichDBO.CapNhatTrangThaiNgayThuLich(this);
            return result;
        }
    }
}
