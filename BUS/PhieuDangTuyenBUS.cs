using PTTK.DBO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.BUS
{
    public class PhieuDangTuyenBUS
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
            this.PheDuyet = PheDuyet;
        }
        public PhieuDangTuyenBUS(string MaPDT, DateTime ThoiGianBD, string ViTriUngTuyen, DateTime ThoiGianKetThuc,
                                int SoLuongTuyen, string ThongTinYeuCau, string HinhThucTT, string TrangThaiTT, string MaDN, string MaDV)
        {
            this.MaPDT = MaPDT;
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
                //MessageBox.Show("Thông tin yêu cầu lớn hơn 2000 chữ");
                return -1;
            }
            DateTime cur = DateTime.Now;
            if (pdt.ThoiGianBD <cur || pdt.ThoiGianKetThuc<cur)
            {
                //MessageBox.Show("Thời gian bắt đầu hoặc thời gian kết thúc không được nhỏ hơn thời gian hiện tại");
                return -2;
            }
            if (pdt.ThoiGianBD > pdt.ThoiGianKetThuc)
            {
                //MessageBox.Show("Thời gian bắt đầu không được sau thời gian kết thúc");
                return -3;
            }
            if(pdt.SoLuongTuyen == 0)
            {
                //MessageBox.Show("Số lượng tuyển phải lớn hơn 0");
                return -4;
            }
            if (pdt.ViTriUngTuyen.Length >20)
            {
                //MessageBox.Show("Vị trí ứng tuyển không quá 20 chữ");
                return -5;
            }
            pdt.MaPDT = TaoMaPDT();
            if (pdt.MaPDT == null)
            {
                //MessageBox.Show("Không thể thêm thành công");
                return -6;
            }
            //MessageBox.Show(pdt.MaPDT); 
            pdt.MaDV=DichVuBUS.LayMaDichVu(pdt.MaDV);
            int result = pdtDBO.ThemPhieuDangTuyen(pdt);
            return result;
        }
        
        public static string TaoMaPDT()
        {
            PhieuDangTuyenDBO pdt = new PhieuDangTuyenDBO();

            DataTable table = pdt.LayMaPDTMoiNhat();
            if (table == null || table.Rows.Count == 0)
            {
                //MessageBox.Show("Không có kết quả trả về");
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
                //MessageBox.Show("Không có kết quả trả về");
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
                //MessageBox.Show("Không có kết quả trả về");
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
                //MessageBox.Show("Không có kết quả trả về");
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
                //MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                return table;
            }
        }
        
        public static PhieuDangTuyenBUS TimPhieuDangTuyen (string MaPDT)
        {
            if (String.IsNullOrEmpty(MaPDT) || MaPDT.Length != 6) {
                //MessageBox.Show("Sai Ma Phieu Dang Tuyen");
                return null;
            }

            PhieuDangTuyenDBO pdtDBO = new PhieuDangTuyenDBO();

            DataTable table = pdtDBO.TimPhieuDangTuyenTheoMa(MaPDT);
            //foreach (DataColumn column in table.Columns)
            //{
            //    MessageBox.Show(column.ColumnName);
            //}
            //foreach (var item in table.Rows[0].ItemArray)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            if (table == null || table.Rows.Count ==0)
            {
                //MessageBox.Show("ERROR BUS: Khong Tim Thay Phieu Dang Tuyen");
                return null;
            } else
            {
                DataRow row = table.Rows[0];
                PhieuDangTuyenBUS result = new PhieuDangTuyenBUS(row["MAPDT"].ToString(), DateTime.Parse(row["THOIGIANBD"].ToString()),
                    row["VITRIUNGTUYEN"].ToString(), DateTime.Parse(row["THOIGIANKT"].ToString()), int.Parse(row["SOLUONGUNGTUYEN"].ToString()), row["THONGTINYEUCAU"].ToString(),
                    row["HINHTHUCTT"].ToString(), row["TRANGTHAITT"].ToString(), row["MADN"].ToString(), row["MADV"].ToString());
                return result;
            }
        }
        public bool KiemTraDuDKTraGop()
        {
            QuiDinhBUS QuiDinhThoiHanDangKyCoTheTraGop = QuiDinhBUS.LayQuiDinhTheoMaQuiDinh("QD001");
            TimeSpan ThoiHan = this.ThoiGianKetThuc.Subtract(this.ThoiGianBD);
            int numberOfDays = ThoiHan.Days;
            bool result = false;
            if (numberOfDays > int.Parse(QuiDinhThoiHanDangKyCoTheTraGop.SoSanh)) result = true;
            return result;
        }
        public float TinhTongTien()
        {
            DichVuBUS dichvu = DichVuBUS.TimDichVuTheoMaDV(this.MaDV);
            if (dichvu == null)
            {
                MessageBox.Show("Loi Khong Tim Thay Dich Vu");
                return -1;
            } else
            {
                return dichvu.GiaTien;
            }

        }
        
        public int CapNhatHinhThucTT(string HinhThucTT)
        {
            if (HinhThucTT != "Trả Thẳng" && HinhThucTT != "Trả Góp")
            {
                return -10;
            }
            this.HinhThucTT = HinhThucTT;
            PhieuDangTuyenDBO pdtDBO = new PhieuDangTuyenDBO();
            int result = pdtDBO.CapNhatHinhThucTT(this);
            return result;
        }
        public int CapNhatTrangThaiTT(string TrangThaiTT)
        {
            if (TrangThaiTT != "Đã Thanh Toán" && TrangThaiTT != "Đang Thanh Toán" && TrangThaiTT != "Chưa Thanh Toán")
            {
                return -10;
            }
            this.TrangThaiTT = TrangThaiTT;
            PhieuDangTuyenDBO pdtDBO = new PhieuDangTuyenDBO();
            int result = pdtDBO.CapNhatTrangThaiTT(this);
            return result;
        }

        public DataTable TaoLichTraGop()
        {
            DataTable LichTraGop = new DataTable();
            LichTraGop.Columns.Add("MAPDT", typeof(string));
            LichTraGop.Columns.Add("DOTTHANHTOAN", typeof(int));
            LichTraGop.Columns.Add("NGAYHEN", typeof(DateTime));
            LichTraGop.Columns.Add("TONGTIEN", typeof(float));
            LichTraGop.Columns.Add("TRANGTHAI", typeof(string));
            LichTraGop.Columns.Add("NGAYTHU",typeof(string));
            QuiDinhBUS QuiDinhSoTienThanhToanMoiDot = QuiDinhBUS.LayQuiDinhTheoMaQuiDinh("QD002");
            QuiDinhBUS QuiDinhThoiHanTraGop = QuiDinhBUS.LayQuiDinhTheoMaQuiDinh("QD003");
            float hesoTraGop = float.Parse(QuiDinhSoTienThanhToanMoiDot.SoSanh);
            int thoihan = int.Parse(QuiDinhThoiHanTraGop.SoSanh);
            
            float tongtien = this.TinhTongTien();
            int sodotTraGop = (int)Math.Round(1/hesoTraGop);
            //MessageBox.Show("Heso tra gop: " +hesoTraGop.ToString());
            //MessageBox.Show("Thoi han: " + thoihan.ToString());
            //MessageBox.Show("So dot tra gop: " + sodotTraGop.ToString());
            //MessageBox.Show("tongtien tra gop: " + tongtien.ToString());

            for (int i =1; i< sodotTraGop; i++)
            {
                DataRow newRow = LichTraGop.NewRow();
                newRow["MAPDT"] = this.MaPDT;
                newRow["DOTTHANHTOAN"] = i;
                newRow["NGAYHEN"] = DateTime.Now.Date.AddDays(thoihan*(i-1)) ;
                newRow["TONGTIEN"] = Math.Round(tongtien * hesoTraGop);
                newRow["TRANGTHAI"] = "Chưa Thanh Toán";
                newRow["NGAYTHU"] = null;
                LichTraGop.Rows.Add(newRow);
            }
            DataRow finalRow = LichTraGop.NewRow();
            finalRow["MAPDT"] = this.MaPDT;
            finalRow["DOTTHANHTOAN"] = sodotTraGop;
            finalRow["NGAYHEN"] = DateTime.Now.Date.AddDays(thoihan*(sodotTraGop-1));
            finalRow["TONGTIEN"] = tongtien - Math.Round(tongtien * hesoTraGop * (sodotTraGop-1));
            finalRow["TRANGTHAI"] = "Chưa Thanh Toán";
            finalRow["NGAYTHU"] = null;
            LichTraGop.Rows.Add(finalRow);

            return LichTraGop;
        }

        public static bool KiemTraHoanTatThanhToan(string MaPDT)
        {
            DataTable lich = LichTraGopBUS.TimLichTraGopTheoMaPDK(MaPDT);
            bool result = true;
            for (int i = 0; i < lich.Rows.Count; i++)
            {
                if (lich.Rows[i]["TRANGTHAI"].ToString() != "Đã Thanh Toán") { result = false; break; }
            }
            return result;
        }

    }
}
