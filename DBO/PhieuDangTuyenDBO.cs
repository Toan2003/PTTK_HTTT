using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DBO
{
    internal class PhieuDangTuyenDBO
    {
        DataProvider DataProvider { get; set; }
        public PhieuDangTuyenDBO()
        {
            DataProvider = new DataProvider();
        }
        
        public int ThemPhieuDangTuyen(PhieuDangTuyenBUS pdt)
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

            string query = $"INSERT INTO PHIEUDANGTUYEN (MAPDT, THOIGIANBD, VITRIUNGTUYEN,SOLUONGUNGTUYEN, THONGTINYEUCAU, THOIGIANKT, PHEDUYET, HINHTHUCTT,TRANGTHAITT,MADN,MADV) VALUES '{MaPDT}', '{ThoiGianBD}', {ViTriUngTuyen}, {SoLuongTuyen}, '{ThongTinYeuCau}', '{ThoiGianKetThuc}', 'Chưa phê duyệt', '{HinhThucTT}', '{TrangThaiTT}', '{MaDN}', '{MaDV}' )";
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result;
        }
        
    }
}
