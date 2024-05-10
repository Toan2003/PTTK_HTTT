using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK.DBO;

namespace PTTK.BUS
{
    internal class QuiDinhBUS
    {
        public string MaQD { get; }
        public string PhanLoai { get; }
        public string NoiDung { get; }
        public string SoSanh { get; }
        public string MACN { get; }
        public QuiDinhBUS(string maQD, string phanLoai, string noiDung, string soSanh, string maCN)
        {
            MaQD = maQD;
            PhanLoai = phanLoai;
            NoiDung = noiDung;
            SoSanh = soSanh;
            MACN = maCN;
        }
        
        static public QuiDinhBUS LayQuiDinhTheoMaQuiDinh(string MaQD)
        {
            if (string.IsNullOrEmpty(MaQD))
            {
                return null;
            }
            QuiDinhDBO quiDinhDBO = new QuiDinhDBO();
            DataTable table = quiDinhDBO.LayQuiDinhTheoMaQuiDinh(MaQD);
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("ERROR BUS: Khong Tim Thay Qui Dinh");
                return null;
            }
            else
            {
                DataRow row = table.Rows[0];
                return new QuiDinhBUS(row["MAQD"].ToString(), row["PHANLOAI"].ToString(), row["NOIDUNG"].ToString(), row["SOSANH"].ToString(), row["MACN"].ToString());
            }
        }
    }
}
