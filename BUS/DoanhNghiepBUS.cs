﻿using PTTK.DBO;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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
        public DoanhNghiepBUS(String maDN, String tenCongTy, String emailLienHe,
               String mST, String nguoiDaiDien, String sDT, String diaChi, String username, String password, String trangThai)
        {
            this.maDN = maDN;
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

        public DoanhNghiepBUS(string username)
        {
            DataTable result = DoanhNghiepDBO.Instance.LayThongTin(username);
            this.MaDN = result.Rows[0]["MADN"].ToString();
            this.TenCongTy = result.Rows[0]["TENCTY"].ToString();
            this.EmailLienHe = result.Rows[0]["EMAIL"].ToString();
            this.MST = result.Rows[0]["MASOTHUE"].ToString();
            this.NguoiDaiDien = result.Rows[0]["NGUOIDAIDIEN"].ToString();
            this.SDT = result.Rows[0]["SDT"].ToString();
            this.DiaChi = result.Rows[0]["DIACHI"].ToString();
            this.Username = result.Rows[0]["USERNAME"].ToString();
        }

        public string HashMatKhau(string matKhau)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Chuyển đổi mật khẩu thành mảng byte
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(matKhau));

                // Tạo một StringBuilder để lưu trữ các byte đã được chuyển đổi thành chuỗi hex
                StringBuilder stringBuilder = new StringBuilder();

                // Lặp qua mỗi byte của mảng đã chuyển đổi và chuyển đổi nó thành một chuỗi hex
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                // Trả về chuỗi hex đã được tạo
                return stringBuilder.ToString();
            }
        }

        public bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra địa chỉ email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Tạo một đối tượng Regex từ biểu thức chính quy
            Regex regex = new Regex(pattern);

            // Kiểm tra xem địa chỉ email có khớp với biểu thức chính quy không
            return regex.IsMatch(email);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string phoneNumberPattern = @"^(0|\+84)(3[2-9]|5[689]|7[06-9]|8[1-689]|9[0-46-9])[0-9]{7}$";
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            // Remove spaces and hyphens for more lenient validation
            phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

            // Create a Regex based on the specified pattern
            Regex regex = new Regex(phoneNumberPattern);

            // Check if the phone number matches the pattern
            return regex.IsMatch(phoneNumber);
        }

        public bool IsValidTaxIdentificationNumber(string taxCode)
        {
            if (string.IsNullOrWhiteSpace(taxCode))
                return false;

            // Normalize by removing spaces
            taxCode = taxCode.Replace(" ", "");

            // Check if the tax code is either 10 or 13 digits long
            if (taxCode.Length != 10 && taxCode.Length != 13)
                return false;

            // Check if all characters are digits
            foreach (char c in taxCode)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public static DoanhNghiepBUS TimDoanhNghiepTheoMaDoanhNghiep(string MaDN)
        {
            if (string.IsNullOrEmpty(MaDN) || MaDN.Length != 5)
            {
                return null;
            }
            DoanhNghiepDBO doanhnghiepDBO = new DoanhNghiepDBO();
            DataTable table = doanhnghiepDBO.TimDoanhNghiepTheoMaDoanhNghiep(MaDN);
            if (table == null || table.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                DoanhNghiepBUS result = new DoanhNghiepBUS(row["MADN"].ToString(), row["TENCTY"].ToString(), row["EMAIL"].ToString(), row["MASOTHUE"].ToString(), row["NGUOIDAIDIEN"].ToString(), row["SDT"].ToString(), row["DIACHI"].ToString(),
                     row["USERNAME"].ToString(), row["PASSWORD"].ToString(), row["TRANGTHAI"].ToString());
                return result;
            }
        }


    }
}
