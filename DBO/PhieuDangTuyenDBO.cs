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
    internal class PhieuDangTuyenDBO
    {
        DataProvider DataProvider { get; set; }
        public PhieuDangTuyenDBO()
        {
            DataProvider = new DataProvider();
        }
        
        public  int ThemPhieuDangTuyen(PhieuDangTuyenBUS pdt)
        {
            string MaPDT = pdt.MaPDT;
            DateTime ThoiGianBD = pdt.ThoiGianBD;
            string ViTriUngTuyen = pdt.ViTriUngTuyen;
            DateTime ThoiGianKetThuc = pdt.ThoiGianKetThuc;
            
            int SoLuongTuyen = pdt.SoLuongTuyen;
            string ThongTinYeuCau = pdt.ThongTinYeuCau;
            string HinhThucTT = pdt.HinhThucTT;
            string TrangThaiTT = pdt.TrangThaiTT;
            string MaDN = pdt.MaDN;
            string MaDV = pdt.MaDV;
            
            string query = $"INSERT INTO PHIEUDANGTUYEN (MAPDT, THOIGIANBD, VITRIUNGTUYEN,SOLUONGUNGTUYEN, THONGTINYEUCAU, THOIGIANKT, PHEDUYET, HINHTHUCTT,TRANGTHAITT,MADN,MADV) VALUES ('{MaPDT}', '{ThoiGianBD.ToString("yyyy-MM-dd")}', N'{ViTriUngTuyen}', {SoLuongTuyen}, N'{ThongTinYeuCau}', '{ThoiGianKetThuc.ToString("yyyy-MM-dd")}', N'CHƯA PHÊ DUYỆT', NULL, NULL, '{MaDN}', '{MaDV}' )";
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            MessageBox.Show(result.ToString());
            MessageBox.Show(query);
            return result;
        }


        public DataTable LayTenDN(string MaDN)
        {
            string query = $"SELECT TENCTY FROM DOANHNGHIEP WHERE MADN='{MaDN}'";
           
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public DataTable LayMaPDTMoiNhat()
        {
            string query = $"SELECT TOP 1 MAPDT FROM PHIEUDANGTUYEN ORDER BY MAPDT DESC";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }

        public DataTable LayToanBoPDT()
        {
            string query = $"SELECT PDT.MAPDT,PDT.VITRIUNGTUYEN, PDT.SOLUONGUNGTUYEN" +
                $", PDT.THONGTINYEUCAU,  PDT.THOIGIANBD, PDT.THOIGIANKT, PDT.PHEDUYET, PDT.HINHTHUCTT, PDT.TRANGTHAITT, DN.TENCTY, DV.TENDICHVU FROM PHIEUDANGTUYEN PDT JOIN DICHVU dv ON PDT.MADV=DV.MADV JOIN DOANHNGHIEP DN ON DN.MADN=PDT.MADN ORDER BY MAPDT DESC";
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }

        public DataTable LayPDTChuaPheDuyet()
        {
            string query = $"SELECT PDT.MAPDT,PDT.VITRIUNGTUYEN, PDT.SOLUONGUNGTUYEN" +
                $", PDT.THONGTINYEUCAU, PDT.THOIGIANBD, PDT.THOIGIANKT, PDT.PHEDUYET, PDT.HINHTHUCTT, PDT.TRANGTHAITT, DN.TENCTY, DV.TENDICHVU FROM PHIEUDANGTUYEN PDT JOIN DICHVU dv ON PDT.MADV=DV.MADV JOIN DOANHNGHIEP DN ON DN.MADN=PDT.MADN WHERE PDT.PHEDUYET= N'CHƯA PHÊ DUYỆT'";
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }

        public DataTable LayToanBoPDTDN(string MaDN)
        {
            string query = $"SELECT PDT.MAPDT,PDT.VITRIUNGTUYEN, PDT.SOLUONGUNGTUYEN" +
                $", PDT.THONGTINYEUCAU,  PDT.THOIGIANBD, PDT.THOIGIANKT, PDT.PHEDUYET, PDT.HINHTHUCTT, PDT.TRANGTHAITT, DN.TENCTY, DV.TENDICHVU FROM PHIEUDANGTUYEN PDT JOIN DICHVU dv ON PDT.MADV=DV.MADV JOIN DOANHNGHIEP DN ON DN.MADN=PDT.MADN WHERE PDT.MADN='{MaDN}' ORDER BY MAPDT DESC";
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }

        public DataTable LayPDTChuaPheDuyetDN(string MaDN)
        {
            string query = $"SELECT PDT.MAPDT,PDT.VITRIUNGTUYEN, PDT.SOLUONGUNGTUYEN" +
                $", PDT.THONGTINYEUCAU, PDT.THOIGIANBD, PDT.THOIGIANKT, PDT.PHEDUYET, PDT.HINHTHUCTT, PDT.TRANGTHAITT, DN.TENCTY, DV.TENDICHVU FROM PHIEUDANGTUYEN PDT JOIN DICHVU dv ON PDT.MADV=DV.MADV JOIN DOANHNGHIEP DN ON DN.MADN=PDT.MADN WHERE PDT.PHEDUYET= N'CHƯA PHÊ DUYỆT' AND PDT.MADN='{MaDN}'";
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
