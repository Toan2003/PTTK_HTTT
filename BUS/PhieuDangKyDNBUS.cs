using System;
using System.Data;
using WindowsFormsApp2.DBO;
using WindowsFormsApp2.DTO;

namespace WindowsFormsApp2.BUS
{
    public class PhieuDangKyDNBUS
    {
        private static PhieuDangKyDNBUS instance;

        public static PhieuDangKyDNBUS Instance { get { if (instance == null) instance = new PhieuDangKyDNBUS(); return instance; } private set => instance = value; }

        public bool TaoPhieuDangKy(PhieuDangKyDNDTO phieuDangKyDNDTO)
        {

            bool result = PhieuDangKyDNDBO.Instance.Them(phieuDangKyDNDTO);

            return result;
        }


        public DataTable TimPhieuDangKy(String keyword, String option)
        {
            DataTable result = PhieuDangKyDNDBO.Instance.TimPhieuDangKy(keyword, option);

            return result;
        }
        public bool DuyetPhieuDangKy(String maPhieuDangKy)
        {
            bool result = PhieuDangKyDNDBO.Instance.DuyetPhieuDangKy(maPhieuDangKy);

            return result;
        }

        public DataTable LayDanhSachPhieuDangKy()
        {
            DataTable result = PhieuDangKyDNDBO.Instance.LayDanhSachPhieuChuaDuyet();
            return result;
        }

    }
}
