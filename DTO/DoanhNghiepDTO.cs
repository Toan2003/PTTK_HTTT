using System;

namespace WindowsFormsApp2.DTO
{
    public class DoanhNghiepDTO
    {
        private String tenCongTy;
        private String emailLienHe;
        private String mST;
        private String nguoiDaiDien;
        private String sDT;
        private String diaChi;
        private String username;
        private String password;

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

        public DoanhNghiepDTO(String tenCongTy, String emailLienHe,
                       String mST, String nguoiDaiDien, String sDT, String diaChi, String username, String password)
        {
            this.tenCongTy = tenCongTy;
            this.emailLienHe = emailLienHe;
            this.mST = mST;
            this.nguoiDaiDien = nguoiDaiDien;
            this.sDT = sDT;
            this.diaChi = diaChi;
            this.username = username;
            this.password = password;
        }
    }
}
