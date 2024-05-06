using System;

namespace WindowsFormsApp2.DTO
{
    public class HoSoUngVienDTO
    {
        private int maHoSo;
        private String doUuTien;
        private String trangThai;

        public String TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public String DoUuTien
        {
            get { return doUuTien; }
            set { doUuTien = value; }
        }

        public int MaHoSo
        {
            get { return maHoSo; }
            set { maHoSo = value; }
        }
    }
}
