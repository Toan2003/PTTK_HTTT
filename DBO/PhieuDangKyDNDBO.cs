using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp2.DTO;


namespace WindowsFormsApp2.DBO
{
    public class PhieuDangKyDNDBO
    {
        private static PhieuDangKyDNDBO instance;

        public static PhieuDangKyDNDBO Instance { get { if (instance == null) instance = new PhieuDangKyDNDBO(); return instance; } private set => instance = value; }

        private PhieuDangKyDNDBO() { }

        public bool Them(PhieuDangKyDNDTO Phieu)
        {
            string query = "INSERT INTO PHIEUDANGKYDN(TENCONGTY, MST, DIACHI, EMAIL, SDT, NGUOIDAIDIEN, DN_USERNAME, DN_PASSWORD, TRANGTHAI)\r\nVALUES ( @tencongty , @mst , @diachi , @email , @sdt , @nguoidaidien , @dn_username , @dn_password , @trangthai )";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tencongty", Phieu.TenCongTy),
                new SqlParameter("@mst", Phieu.MST),
                new SqlParameter("@diachi", Phieu.DiaChi),
                new SqlParameter("@email", Phieu.EmailLienHe),
                new SqlParameter("@sdt", Phieu.SDT),
                new SqlParameter("@nguoidaidien", Phieu.NguoiDaiDien),
                new SqlParameter("@dn_username", Phieu.Username),
                new SqlParameter("@dn_password", Phieu.Password),
                new SqlParameter("@trangthai", Phieu.TrangThai)

            };
            int result = DataProvider.DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DuyetPhieuDangKy(String maPhieuDangKy)
        {
            // Convert maPhieuDangKy to an integer
            if (!int.TryParse(maPhieuDangKy, out int maPhieuDangKyInt))
            {
                // Handle the case where the conversion fails
                Console.WriteLine("Invalid input for MAPHIEU. It must be an integer.");
                return false; // Return false or throw an exception as needed
            }

            string query = "UPDATE PHIEUDANGKYDN SET TRANGTHAI = N'ĐÃ DUYỆT' WHERE MAPHIEU = @maphieu";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@maphieu", maPhieuDangKyInt)
            };
            int result = DataProvider.DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public DataTable LayDanhSachPhieuChuaDuyet()
        {
            string query = "SELECT MAPHIEU, TENCONGTY, MST, DIACHI, EMAIL, SDT, NGUOIDAIDIEN FROM PHIEUDANGKYDN WHERE TRANGTHAI = N'CHƯA DUYỆT'";

            DataTable result = DataProvider.DataProvider.Instance.ExecuteQuery(query);

            return result;
        }

        public DataTable TimPhieuDangKy(String keyword, String option)
        {
            string query = "";
            switch (option)
            {
                case "Tên công ty":
                    query = "SELECT MAPHIEU, TENCONGTY, MST, DIACHI, EMAIL, SDT, NGUOIDAIDIEN FROM PHIEUDANGKYDN WHERE TENCONGTY LIKE N'%" + keyword + "%' AND TRANGTHAI = N'CHƯA DUYỆT'";
                    break;
                case "MST":
                    query = "SELECT MAPHIEU, TENCONGTY, MST, DIACHI, EMAIL, SDT, NGUOIDAIDIEN FROM PHIEUDANGKYDN WHERE MST LIKE N'%" + keyword + "%' AND TRANGTHAI = N'CHƯA DUYỆT'";
                    break;
                case "Tên đăng nhập":
                    query = "SELECT MAPHIEU, TENCONGTY, MST, DIACHI, EMAIL, SDT, NGUOIDAIDIEN FROM PHIEUDANGKYDN WHERE DN_USERNAME LIKE N'%" + keyword + "%' AND TRANGTHAI = N'CHƯA DUYỆT'";
                    break;
            }
            DataTable result = DataProvider.DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
