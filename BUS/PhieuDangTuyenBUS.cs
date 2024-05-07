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
    internal class PhieuDangTuyenBUS
    {
        public string MaPDT { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public string ViTriUngTuyen { get; set; }
        public int SoLuongTuyen { get; set; }
        public string ThongTinYeuCau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string HinhThucTT { get; set; }
        public string TrangThaiTT { get; set; }
        public string MaDN {  get; set; }
        public string MaDV { get; set; }
        public PhieuDangTuyenBUS(string MaPDT, DateTime ThoiGianBD, string ViTriUngTuyen, DateTime ThoiGianKetThuc,
                                int SoLuongTuyen, string ThongTinYeuCau, string HinhThucTT, string TrangThaiTT, string MaDN, string MaDV)
        {
            this.MaPDT= MaPDT;
            this.ThoiGianBD = ThoiGianBD;
            this.ViTriUngTuyen = ViTriUngTuyen;
            this.HinhThucTT = HinhThucTT;
            this.ThongTinYeuCau = ThongTinYeuCau;
            this.ThoiGianKetThuc = ThoiGianKetThuc;
            this.TrangThaiTT = TrangThaiTT;
            this.MaDN = MaDN;
            this.MaDV = MaDV;
            this.SoLuongTuyen = SoLuongTuyen;
        }
        public static int ThemPhieuDangTuyen (PhieuDangTuyenBUS pdt)
        {
            PhieuDangTuyenDBO pdtDBO = new PhieuDangTuyenDBO();
            
            if (pdt.ThongTinYeuCau.Length > 2000)
            {
                MessageBox.Show("Thông tin yêu cầu lớn hơn 2000 chữ");
                return -1;
            }
            DateTime cur = DateTime.Now;
            if (pdt.ThoiGianBD <cur || pdt.ThoiGianKetThuc<cur)
            {
                MessageBox.Show("Thời gian bắt đầu hoặc thời gian kết thúc không được nhỏ hơn thời gian hiện tại");
                return -2;
            }
            if (pdt.ThoiGianBD > pdt.ThoiGianKetThuc)
            {
                MessageBox.Show("Thời gian bắt đầu không được sau thời gian kết thúc");
                return -3;
            }
            if(pdt.SoLuongTuyen == 0)
            {
                MessageBox.Show("Số lượng tuyển phải lớn hơn 0");
                return -4;
            }
            return 0;
            
        }
       
        
    }
}
