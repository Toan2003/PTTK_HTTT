using System;

namespace WindowsFormsApp2.DTO
{
    public class PhieuDangKyDNDTO
    {
        private String MaPhieuDangKy;
        private String tenCongTy;
        private String emailLienHe;
        private String mST;
        private String nguoiDaiDien;
        private String sDT;
        private String diaChi;
        private String username;
        private String password;
        private String trangThai;

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
        public PhieuDangKyDNDTO(String tenCongTy, String emailLienHe,
                       String mST, String nguoiDaiDien, String sDT, String diaChi, String username, String password)
        {
            this.MaPhieuDangKy = "";
            this.tenCongTy = tenCongTy;
            this.emailLienHe = emailLienHe;
            this.mST = mST;
            this.nguoiDaiDien = nguoiDaiDien;
            this.sDT = sDT;
            this.diaChi = diaChi;
            this.username = username;
            this.password = password;
            trangThai = "CHƯA DUYỆT";
        }

        public PhieuDangKyDNDTO(String maPhieuDangKy, String tenCongTy, String emailLienHe,
                                  String mST, String nguoiDaiDien, String sDT, String diaChi, String username, String password, String trangThai)
        {
            this.MaPhieuDangKy = maPhieuDangKy;
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
    }
}
