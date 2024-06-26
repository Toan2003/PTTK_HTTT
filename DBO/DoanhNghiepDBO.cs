﻿using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK.DBO
{
    public class DoanhNghiepDBO
    {
        DataProvider DataProvider { get; set; }
        public DoanhNghiepDBO() { 
            DataProvider = new DataProvider();
        }

        private static DoanhNghiepDBO instance;

        public static DoanhNghiepDBO Instance { get { if (instance == null) instance = new DoanhNghiepDBO(); return instance; } private set => instance = value; }


        public bool Them(DoanhNghiepBUS doanhNghiep)
        {
            string query = $"EXEC ThemDoanhNghiep @tencty=N'{doanhNghiep.TenCongTy}', @email=N'{doanhNghiep.EmailLienHe}'"
                + $", @mst='{doanhNghiep.MST}', @nguoidaidien=N'{doanhNghiep.NguoiDaiDien}', @sdt='{doanhNghiep.SDT}', @diachi=N'{doanhNghiep.DiaChi}', @username='{doanhNghiep.Username}', @password='{doanhNghiep.Password}', @trangthai=N'{doanhNghiep.TrangThai}'";

            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result > 0;
        }

        public bool KiemTraTonTai(string keyword, string option)
        {

            string query = $"select * from doanhnghiep where {option} = '{keyword}'";
            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            //return true if there is a record with the same username or mst
            return result.Rows.Count > 0;
        }

        public bool Sua(DoanhNghiepBUS phieuDaSua)
        {
            string query = $"update doanhnghiep set tencty = N'{phieuDaSua.TenCongTy}', email = N'{phieuDaSua.EmailLienHe}', masothue = '{phieuDaSua.MST}', nguoidaidien = N'{phieuDaSua.NguoiDaiDien}', sdt = '{phieuDaSua.SDT}', diachi = N'{phieuDaSua.DiaChi}', username = '{phieuDaSua.Username}' where madn = '{phieuDaSua.MaDN}'";
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();
            return result > 0;
        }

        public DataTable LayDNChuaDuyet()
        {
            string query = "select madn as N'Mã doanh nghiệp', username as N'Tên đăng nhập', tencty as N'Tên công ty', masothue as N'Mã số thuế', nguoidaidien as N'Người đại diện', diachi as N'Địa chỉ', email as N'Email', sdt as N'Số điện thoại' from doanhnghiep where trangthai = N'CHƯA DUYỆT'";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();

            return result;
        }

        public DataTable LayDNChuaDuyet(string keyword, string option)
        {
            string query = $"select madn as N'Mã doanh nghiệp', username as N'Tên đăng nhập', tencty as N'Tên công ty', masothue as N'Mã số thuế', nguoidaidien as N'Người đại diện', diachi as N'Địa chỉ', email as N'Email', sdt as N'Số điện thoại' from doanhnghiep where {option} like N'%{keyword}%'";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();

            return result;
        }

        public bool DuyetPhieu(string maDN)
        {
            string query = $"update doanhnghiep set trangthai = N'ĐÃ DUYỆT' where madn = '{maDN}'";

            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result > 0;
        }

        public DataTable LayThongTin(string username)
        {
            string query = $"select MADN, TENCTY, MASOTHUE, DIACHI, EMAIL, SDT, NGUOIDAIDIEN, USERNAME from doanhnghiep where username = '{username}'";

            DataProvider.OpenConect();
            DataTable result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();

            return result;
        }
        public DataTable TimDoanhNghiepTheoMaDoanhNghiep(string MaDN)
        {
            string query = "select * from DOANHNGHIEP where MADN = '" + MaDN + "'";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
