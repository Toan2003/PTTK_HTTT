using System;
using System.Data;

namespace WindowsFormsApp2.DBO
{
    public class HoSoUngVienDBO
    {
        private static HoSoUngVienDBO instance;

        public static HoSoUngVienDBO Instance { get { if (instance == null) instance = new HoSoUngVienDBO(); return instance; } private set => instance = value; }

        public DataTable LayTatCaHoSo()
        {
            String query = "SELECT UV.HOTEN, PDT.VITRIUNGTUYEN, CTUT.TRANGTHAIXETDUYET, H.DOUUTIEN, H.TRANGTHAI AS TRANGTHAITIEPNHAN FROM HOSO H JOIN CHITIETUNGTUYEN CTUT ON H.MAHOSO = CTUT.MAHOSO JOIN UNGVIEN UV ON UV.MAUNGVIEN = CTUT.MAUNGVIEN JOIN PHIEUDANGTUYEN PDT ON PDT.MAPHIEU = CTUT.MAPHIEU";
            DataTable result = DataProvider.DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
