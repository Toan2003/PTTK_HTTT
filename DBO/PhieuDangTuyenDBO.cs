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
        public DataTable TimPhieuDangTuyenTheoMa(string MaPDT)
        {
            DataTable result = null;
            string query = "SELECT * FROM PHIEUDANGTUYEN WHERE MAPDT = '" + MaPDT +"'";
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        
        public int CapNhatHinhThucTT(PhieuDangTuyenBUS phieu)
        {
            string query = $"UPDATE PHIEUDANGTUYEN SET HINHTHUCTT = N'{phieu.HinhThucTT}' WHERE MAPDT = '{phieu.MaPDT}'";
            //MessageBox.Show(query);
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public int CapNhatTrangThaiTT(PhieuDangTuyenBUS phieu)
        {
            string query = $"UPDATE PHIEUDANGTUYEN SET TRANGTHAITT = N'{phieu.TrangThaiTT}' WHERE MAPDT = '{phieu.MaPDT}'";
            //MessageBox.Show(query);
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
