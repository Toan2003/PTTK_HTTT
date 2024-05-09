using PTTK.DBO;
using System;
using System.Data;

namespace PTTK.BUS
{
    public class DoanhNghiepBUS
    {
        private String maDN;
        private String tenCongTy;
        private String emailLienHe;
        private String mST;
        private String nguoiDaiDien;
        private String sDT;
        private String diaChi;
        private String username;
        private String password;
        private String trangThai;


        public String MaDN
        {
            get { return maDN; }
            set { maDN = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public String NguoiDaiDien
        {
            get { return nguoiDaiDien; }
            set { nguoiDaiDien = value; }
        }

        public String MST
        {
            get { return mST; }
            set { mST = value; }
        }

        public String EmailLienHe
        {
            get { return emailLienHe; }
            set { emailLienHe = value; }
        }

        public String TenCongTy
        {
            get { return tenCongTy; }
            set { tenCongTy = value; }
        }

        public String TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public DoanhNghiepBUS(String tenCongTy, String emailLienHe,
                       String mST, String nguoiDaiDien, String sDT, String diaChi, String username, String password, String trangThai)
        {
            this.tenCongTy = tenCongTy;
            this.emailLienHe = emailLienHe;
            this.mST = mST;
            this.nguoiDaiDien = nguoiDaiDien;
            this.sDT = sDT;
            this.diaChi = diaChi;
            this.username = username;
            this.password = password;
            this.trangThai = trangThai;
        }

        public DoanhNghiepBUS()
        {
        }

        private static DoanhNghiepBUS instance;

        public static DoanhNghiepBUS Instance { get { if (instance == null) instance = new DoanhNghiepBUS(); return instance; } private set => instance = value; }

        public bool SuaPhieuDangKy(DoanhNghiepBUS doanhNghiep)
        {
            bool result = DoanhNghiepDBO.Instance.Sua(doanhNghiep);
            return result;
        }

        public bool KiemTraThanhVien(String username, String mst)
        {
            bool result = DoanhNghiepDBO.Instance.KiemTraTonTai(mst, "MASOTHUE") || DoanhNghiepDBO.Instance.KiemTraTonTai(username, "USERNAME");
            return result;
        }

        public bool TaoPhieuDangKy(DoanhNghiepBUS doanhNghiep)
        {
            bool result = DoanhNghiepDBO.Instance.Them(doanhNghiep);
            return result;
        }

        public DataTable LayPhieuDangKyChuaDuyet()
        {
            DataTable result;
            result = DoanhNghiepDBO.Instance.LayDNChuaDuyet();
            return result;
        }

        public DataTable TimPhieuDangKy(string keyword, string option)
        {
            DataTable result = null;
            switch (option)
            {
                case "MST":
                    result = DoanhNghiepDBO.Instance.LayDNChuaDuyet(keyword, "MASOTHUE");
                    break;
                case "Tên công ty":
                    result = DoanhNghiepDBO.Instance.LayDNChuaDuyet(keyword, "TENCTY");
                    break;
                case "Tên đăng nhập":
                    result = DoanhNghiepDBO.Instance.LayDNChuaDuyet(keyword, "USERNAME");
                    break;
            }
            return result;
        }

        public bool DuyetPhieuDangKy(string maPhieuDangKy)
        {
            bool result = DoanhNghiepDBO.Instance.DuyetPhieu(maPhieuDangKy);
            return result;
        }

        public bool KiemTraTonTai(string keyword, string option)
        {
            // Neu ton tai thi tra ve true, khong thi tra ve false
            bool result = false;
            switch (option)
            {
                case "MST":
                    result = DoanhNghiepDBO.Instance.KiemTraTonTai(keyword, "MASOTHUE");
                    break;
                case "Tên đăng nhập":
                    result = DoanhNghiepDBO.Instance.KiemTraTonTai(keyword, "USERNAME");
                    break;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
