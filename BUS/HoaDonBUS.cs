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
        public string MaNV { get; set; }
        public HoaDonBUS(string MaHD, string MaPhieuDK, float TongTien, string HinhThucTT, DateTime NgayLap, string MaNV)
        {
            this.MaHD = MaHD;
            this.MaPhieuDK = MaPhieuDK;
            this.TongTien = TongTien;
            this.HinhThucTT = HinhThucTT;
            this.NgayLap = NgayLap;
            this.MaNV = MaNV;
        }
        public static int ThemHoaDon(HoaDonBUS hoadon)
        {
            HoaDonDBO hoaDonDBO = new HoaDonDBO();
            if (hoadon.MaHD == null || hoadon.MaHD.Length != 5)
            {
                //MessageBox.Show("Mã hóa đơn không hợp lệ: " + hoadon.MaHD);
                return -5;
            }
            if (hoadon.MaPhieuDK == null || hoadon.MaPhieuDK.Length != 6)
            {
                //MessageBox.Show("Mã phiếu đăng ký không hợp lệ: " + hoadon.MaPhieuDK);
                return -6;
            }
            if (hoadon.TongTien < 0)
            {
                //MessageBox.Show("Tổng tiền không hợp lệ");
                return -7;
            }
            if ((hoadon.HinhThucTT != "Trả Thẳng" && hoadon.HinhThucTT != "Trả Góp")|| hoadon.HinhThucTT == null)
            {
                //MessageBox.Show("HinhThucTT không hợp lệ");
                return -8;
            }
            if (hoadon.NgayLap.Date != DateTime.Now.Date)
            {
                //MessageBox.Show("Không được tạo hóa đơn trong tương lai hoặc quá khứ");
                return -9;
            }
            int result = hoaDonDBO.ThemHoaDon(hoadon);
            return result;
        }
        public static string GenerateMaHD()
        {
            HoaDonDBO hoaDonDBO = new HoaDonDBO();
            DataTable table = hoaDonDBO.LayHoaDonGanNhat();
            if (table is null ||  table.Rows.Count == 0)
            {
                return "HD001";
            }
            string MaHDGanNhat = table.Rows[0]["MAHD"].ToString();
            int soHienTai = int.Parse(MaHDGanNhat.Substring(2));
            soHienTai++;
            string MaHoaDonMoi = "HD" + soHienTai.ToString("000");
            return MaHoaDonMoi;
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
                return new HoaDonBUS(row["MAHD"].ToString(), row["MAPHIEUDK"].ToString(),float.Parse(row["TONGTIEN"].ToString()), row["HINHTHUCTT"].ToString(), DateTime.Parse(row["NGAYLAP"].ToString()), row["MANV"].ToString());
            }
        }
        
    }
}
