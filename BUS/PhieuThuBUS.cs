using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.BUS
{
    public class PhieuThuBUS
    {
        public string MaPT { get; set; }
        public DateTime NgayLap { get; set; }
        public string PhuongAnTT { get; set; }
        public float TongTien { get; set; }
        public string MaPDT { get; set; }
        public string MaNV { get; set; }
        public PhieuThuBUS(string MaPT, DateTime NgayLap, string PhuongAnTT, float TongTien, string MaPDT, string MaNV) {
            this.MaPT = MaPT;
            this.NgayLap = NgayLap; 
            this.PhuongAnTT = PhuongAnTT; 
            this.MaPDT = MaPDT;
            this.MaNV = MaNV;
            this.TongTien = TongTien;
        }
        public static string GenerateMaPT()
        {
            PhieuThuDBO PhieuThuDBO = new PhieuThuDBO();
            DataTable table = PhieuThuDBO.LayPhieuThuGanNhat();
            if (table is null || table.Rows.Count == 0)
            {
                return "PT001";
            }
            string MaPTGanNhat = table.Rows[0]["MAPT"].ToString();
            int soHienTai = int.Parse(MaPTGanNhat.Substring(2));
            soHienTai++;
            string MaPTMoi = "PT" + soHienTai.ToString("000");
            return MaPTMoi;
        }
        public static int ThemPhieuThu(PhieuThuBUS phieuthu)
        {
            PhieuThuDBO phieuthuDBO = new PhieuThuDBO();
            if (phieuthu.MaPT == null || phieuthu.MaPT.Length != 5)
            {
                return -5;
            }
            if (phieuthu.MaPDT == null || phieuthu.MaPDT.Length != 6)
            {
                return -6;
            }
            if (phieuthu.TongTien < 0)
            {
                return -7;
            }
            if ((phieuthu.PhuongAnTT != "Tiền Mặt" && phieuthu.PhuongAnTT != "Thẻ") || phieuthu.PhuongAnTT == null)
            {
                return -8;
            }
            if (phieuthu.NgayLap.Date != DateTime.Now.Date)
            {
                return -9;
            }
            int result = phieuthuDBO.ThemPhieuThu(phieuthu);
            return result;
        }

    }
}
