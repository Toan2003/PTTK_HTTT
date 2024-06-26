﻿using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.DBO
{
    internal class HoaDonDBO
    {
        DataProvider DataProvider { get; set; }
        public HoaDonDBO()
        {
            DataProvider = new DataProvider();
        }
        public DataTable LayHoaDonTheoMAHD(string MAHD)
        {
            string query = "select * from HOADON where MAHD = '" + MAHD + "'";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
        public int ThemHoaDon(HoaDonBUS hoadon)
        {
            string MaHD = hoadon.MaHD;
            string MaPhieuDK = hoadon.MaPhieuDK;
            float TongTien = hoadon.TongTien;
            string HinhThucTT = hoadon.HinhThucTT;
            DateTime NgayLap = hoadon.NgayLap;
            string MaNV = hoadon.MaNV;
            string query = $"INSERT INTO HOADON (MAHD, MAPDT, TONGTIEN, HINHTHUCTT, NGAYLAP, MANV) VALUES ('{MaHD}', '{MaPhieuDK}', {TongTien}, N'{HinhThucTT}', '{NgayLap:yyyy-MM-dd HH:mm:ss}','{MaNV}')";
            //MessageBox.Show(query);
            DataProvider.OpenConect();
            int result = DataProvider.ExecuteNonQuery(query);
            DataProvider.CloseConect();

            return result;
        }
        public DataTable LayHoaDonGanNhat()
        {
            string query = "SELECT TOP 1 MaHD FROM HOADON ORDER BY MaHD DESC";
            DataTable result = null;
            DataProvider.OpenConect();
            result = DataProvider.ExecuteQuery(query);
            DataProvider.CloseConect();
            return result;
        }
    }
}
