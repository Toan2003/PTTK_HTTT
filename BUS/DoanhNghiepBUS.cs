using System;
using WindowsFormsApp2.DBO;

namespace WindowsFormsApp2.BUS
{
    public class DoanhNghiepBUS
    {
        private static DoanhNghiepBUS instance;

        public static DoanhNghiepBUS Instance { get { if (instance == null) instance = new DoanhNghiepBUS(); return instance; } private set => instance = value; }

        /*bool ThemDoanhNghiep(PhieuDangKyDNBUS phieuDangKy)
        {

        }

        bool LayTTCongTy(String MaDoanhNghiep)
        {

        }*/

        public bool KiemTraThanhVien(String username, String mst)
        {
            bool result = DoanhNghiepDBO.Instance.KiemTraTonTai(username, mst);

            return result;
        }


    }
}
