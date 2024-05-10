using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.BUS
{
    public class DoanhNghiepBUS
    {
        public string MaDN { get; set; }
        public string TenCTY { get; set; }
        public string MaSoThue { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string NguoiDaiDien { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TrangThai { get; set; }
        public DoanhNghiepBUS(string maDN, string tenCTY, string maSoThue, string diaChi, string email, string sDT, string nguoiDaiDien, string userName, string password, string trangThai)
        {
            this.MaDN = maDN;
            this.TenCTY = tenCTY;
            this.MaSoThue = maSoThue;
            this.DiaChi = diaChi;
            this.Email = email;
            this.SDT = sDT;
            this.NguoiDaiDien = nguoiDaiDien;
            this.UserName = userName;
            this.Password = password;
            this.TrangThai = trangThai;
        }
        public static DoanhNghiepBUS TimDoanhNghiepTheoMaDoanhNghiep(string MaDN)
        {
            if (string.IsNullOrEmpty(MaDN) || MaDN.Length != 5) {
                return null;
            }
            DoanhNghiepDBO doanhnghiepDBO = new DoanhNghiepDBO();
            DataTable table = doanhnghiepDBO.TimDoanhNghiepTheoMaDoanhNghiep(MaDN);
            if (table == null || table.Rows.Count == 0)
            {
                return null;
            } else
            {
                DataRow row = table.Rows[0];
                DoanhNghiepBUS result = new DoanhNghiepBUS(row["MADN"].ToString(), row["TENCTY"].ToString(), row["MASOTHUE"].ToString(), row["DIACHI"].ToString(),
                    row["EMAIL"].ToString(), row["SDT"].ToString(), row["NGUOIDAIDIEN"].ToString(), row["USERNAME"].ToString(), row["PASSWORD"].ToString(), row["TRANGTHAI"].ToString());
                return result;
            }
        }
    }
}
