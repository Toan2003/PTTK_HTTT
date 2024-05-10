using PTTK.DBO;
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
        public string MaDV;
        public string TenDV;
        public float GiaTien;
        public DichVuBUS(string MaDV, string TenDV, float GiaTien) {
            this.MaDV = MaDV;
            this.TenDV = TenDV;
            this.GiaTien = GiaTien;
        }

        public static string LayMaDichVu(string tenDV)
        {
            DichVuDBO dv = new DichVuDBO();
            DataTable dataTable = new DataTable();
            dataTable = dv.LayMaDV(tenDV);            

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả trả về");
                return null;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                MessageBox.Show(row["MADV"].ToString());
                return row["MADV"].ToString();
            }
            return null;

        }
    }
}
