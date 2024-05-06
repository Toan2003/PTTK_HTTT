using PTTK.DBO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.BUS
{
    internal class HoaDonBUS
    {
        public string MaHD { get; set; }
        public string MaPhieuDK { get; set; }
        public float TongTien { get; set; }
        public string HinhThucTT { get; set; }
        public DateTime NgayLap { get; set; }
        public string NhanVienLap { get; set; }
        public HoaDonBUS(string MaHD, string MaPhieuDK, float TongTien, string HinhThucTT)
        {
            this.MaHD = MaHD;
            this.MaPhieuDK = MaPhieuDK;
            this.TongTien = TongTien;
            this.HinhThucTT = HinhThucTT;
            NgayLap = DateTime.Now;
        }
        public static int ThemHoaDon(HoaDonBUS hoadon)
        {
            HoaDonDBO hoaDonDBO = new HoaDonDBO();
            if (hoadon.MaHD == null || hoadon.MaHD.Length != 5)
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ");
                return -5;
            }
            if (hoadon.MaPhieuDK == null || hoadon.MaPhieuDK.Length != 5)
            {
                MessageBox.Show("Mã phiếu đăng ký không hợp lệ");
                return -6;
            }
            if (hoadon.TongTien < 0)
            {
                MessageBox.Show("Tổng tiền không hợp lệ");
                return -7;
            }
            if (hoadon.HinhThucTT.Length != 2 || hoadon.HinhThucTT == null)
            {
                MessageBox.Show("HinhThucTT không hợp lệ");
                return -8;
            }
            if (hoadon.NgayLap != DateTime.Now)
            {
                MessageBox.Show("HinhThucTT không hợp lệ");
                return -9;
            }
            int result = hoaDonDBO.ThemHoaDon(hoadon);
            return result;
        }
        public static string GenerateMaHD()
        {
            HoaDonDBO hoaDonDBO = new HoaDonDBO();
            DataTable table = hoaDonDBO.LayHoaDonGanNhat();
            return table.Rows[0]["MAHD"].ToString();
        }
        public static HoaDonBUS TimHoaDonTheoMaHD(string MaHD) {
            if (string.IsNullOrEmpty(MaHD))
            {
                return null;
            }
            HoaDonDBO hoaDonDBO = new HoaDonDBO();
            DataTable table = hoaDonDBO.LayHoaDonTheoMAHD(MaHD);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("ERROR BUS: Khong Tim Thay Hoa Don");
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                return new HoaDonBUS(row["MAHD"].ToString(), row["MAPHIEUDK"].ToString(),float.Parse(row["TONGTIEN"].ToString()), row["HINHTHUCTT"].ToString());
            }
        }
        
    }
}
