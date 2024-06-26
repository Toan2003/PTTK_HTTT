﻿using PTTK.DBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.BUS
{
    internal class DichVuBUS
    {
        public string MaDV { get; set; }
        public string TenDichVu { get; set; }
        public float GiaTien { get; set; }
        public DichVuBUS(string MaDV, string TenDichVu, float GiaTien) { 
            this.MaDV = MaDV;
            this.TenDichVu = TenDichVu;
            this.GiaTien = GiaTien;
        }

        public static string LayMaDichVu(string tenDV)
        {
            DichVuDBO dv = new DichVuDBO();
            DataTable dataTable = new DataTable();
            dataTable = dv.LayMaDV(tenDV);            

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                //MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                //MessageBox.Show(row["MADV"].ToString());
                return row["MADV"].ToString();
            }
            return null;

        }
        public static DichVuBUS TimDichVuTheoMaDV(string MaDV)
        {
            if (String.IsNullOrEmpty(MaDV) || MaDV.Length != 5)
            {
                MessageBox.Show("Sai Ma Dich Vu");
                return null;
            }

            DichVuDBO dichvuDBO = new DichVuDBO();

            DataTable table = dichvuDBO.TimDichVuTheoMaDV(MaDV);
            if (table == null || table.Rows.Count == 0)
            {
                //MessageBox.Show("ERROR BUS: Khong Tim Thay Ma Dich Vu");
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                DichVuBUS result = new DichVuBUS(row["MADV"].ToString(), row["TENDICHVU"].ToString(), float.Parse(row["GIATIEN"].ToString()));
                return result;
            }
        }
    }
}
