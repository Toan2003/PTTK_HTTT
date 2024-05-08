using System.Data;
using WindowsFormsApp2.DBO;

namespace WindowsFormsApp2.BUS
{
    public class HoSoUngVienBUS
    {
        private static HoSoUngVienBUS instance;

        public static HoSoUngVienBUS Instance { get { if (instance == null) instance = new HoSoUngVienBUS(); return instance; } private set => instance = value; }

        public DataTable LayTatCaHoSo()
        {
            return HoSoUngVienDBO.Instance.LayTatCaHoSo();
        }
    }
}
