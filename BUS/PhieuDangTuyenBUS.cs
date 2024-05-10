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
        public string PheDuyet {  get; set; }
        public PhieuDangTuyenBUS(string MaPDT, DateTime ThoiGianBD, string ViTriUngTuyen, DateTime ThoiGianKetThuc,
                                int SoLuongTuyen, string ThongTinYeuCau, string PheDuyet, string HinhThucTT, string TrangThaiTT, string MaDN, string MaDV)
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
        public int ThemPhieuDangTuyen (PhieuDangTuyenBUS pdt)
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
            if (pdt.ViTriUngTuyen.Length >20)
            {
                MessageBox.Show("Vị trí ứng tuyển không quá 20 chữ");
                return -5;
            }
            pdt.MaPDT = TaoMaPDT();
            if (pdt.MaPDT == null)
            {
                MessageBox.Show("Không thể thêm thành công");
                return -6;
            }
            MessageBox.Show(pdt.MaPDT);
            pdt.MaDV=DichVuBUS.LayMaDichVu(pdt.MaDV);
            int result = pdtDBO.ThemPhieuDangTuyen(pdt);
            return result;
        }
        public static string LayTenDoanhNghiep(string MaDN)
        {
            PhieuDangTuyenDBO pdt = new PhieuDangTuyenDBO();
            
            DataTable table = pdt.LayTenDN(MaDN);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                MessageBox.Show(row["TENCTY"].ToString());
                return row["TENCTY"].ToString();
            }
            return null;
        }
        
        public static string TaoMaPDT()
        {
            PhieuDangTuyenDBO pdt = new PhieuDangTuyenDBO();

            DataTable table = pdt.LayMaPDTMoiNhat();
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                string mapdt = row["MAPDT"].ToString();
                MessageBox.Show($"{mapdt}: {mapdt}");
                string numberPart = mapdt.Substring(3);
                int number = int.Parse(numberPart);  
                number += 1;
                string newNumberStr = number.ToString("D3");
                return "PDT"+newNumberStr;
            }
            return null;
        }
        
        public static DataTable  LayToanBoPDT()
        {
            PhieuDangTuyenDBO pdtdbo = new PhieuDangTuyenDBO();
            DataTable table = pdtdbo.LayToanBoPDT();
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                return table;
            }
            
        }
        
        public static DataTable LayPDTChuaPheDuyet()
        {
            PhieuDangTuyenDBO pdtdbo = new PhieuDangTuyenDBO();
            DataTable table = pdtdbo.LayPDTChuaPheDuyet();
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                return table;
            }
        }
        public static DataTable LayToanBoPDTDN(string MaDN)
        {
            PhieuDangTuyenDBO pdtdbo = new PhieuDangTuyenDBO();
            DataTable table = pdtdbo.LayToanBoPDTDN(MaDN);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                return table;
            }

        }

        public static DataTable LayPDTChuaPheDuyetDN(string MaDN)
        {
            PhieuDangTuyenDBO pdtdbo = new PhieuDangTuyenDBO();
            DataTable table = pdtdbo.LayPDTChuaPheDuyetDN(MaDN);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                return table;
            }
        }
    }
}
