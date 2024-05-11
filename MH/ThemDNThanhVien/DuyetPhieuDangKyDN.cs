using PTTK.BUS;
using System.Data;
using System.Windows.Forms;

namespace PTTK.MH.ThemDNThanhVien
{
    public partial class DuyetPhieuDangKyDN : Form
    {
        private Form parent;
        public DuyetPhieuDangKyDN(Form parent)
        {
            InitializeComponent();
            HienThi();
            this.parent = parent;
            this.FormClosing += DuyetPhieuDangKyDN_FormClosing;
        }

        private void DuyetPhieuDangKyDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parent.Show();
            }
        }

        public void HienThi()
        {
            gridview_DanhSachPhieu.DataSource = DoanhNghiepBUS.Instance.LayPhieuDangKyChuaDuyet();
            foreach (DataGridViewColumn column in gridview_DanhSachPhieu.Columns)
            {
                // Set the AutoSizeMode to display all content without clipping
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            cbx_TimKiemTheo.SelectedItem = "Tên công ty";

        }

        private void btn_Duyet_Click(object sender, System.EventArgs e)
        {
            if (gridview_DanhSachPhieu.SelectedRows.Count > 0)
            {
                string maPhieuDangKy = gridview_DanhSachPhieu.SelectedRows[0].Cells[0].Value.ToString();
                bool result = DoanhNghiepBUS.Instance.DuyetPhieuDangKy(maPhieuDangKy);
                if (result)
                {
                    MessageBox.Show("Duyệt phiếu thành công");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Duyệt phiếu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu cần duyệt");
            }
        }

        private void Search_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_Tim_Click(object sender, System.EventArgs e)
        {
            string keyword = txt_TimKiem.Text;
            string option = cbx_TimKiemTheo.Text;
            DataTable result = DoanhNghiepBUS.Instance.TimPhieuDangKy(keyword, option);
            gridview_DanhSachPhieu.DataSource = result;
            foreach (DataGridViewColumn column in gridview_DanhSachPhieu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            return;

        }

        private void cbx_TimKiemTheo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            //madn, username, tencty, masothue, nguoidaidien, diachi, email, sdt
            string maPhieuDangKy = gridview_DanhSachPhieu.SelectedRows[0].Cells[0].Value.ToString();
            string username = gridview_DanhSachPhieu.SelectedRows[0].Cells[1].Value.ToString();
            string tenCongTy = gridview_DanhSachPhieu.SelectedRows[0].Cells[2].Value.ToString();
            string mst = gridview_DanhSachPhieu.SelectedRows[0].Cells[3].Value.ToString();
            string nguoiDaiDien = gridview_DanhSachPhieu.SelectedRows[0].Cells[4].Value.ToString();
            string diaChi = gridview_DanhSachPhieu.SelectedRows[0].Cells[5].Value.ToString();
            string email = gridview_DanhSachPhieu.SelectedRows[0].Cells[6].Value.ToString();
            string sdt = gridview_DanhSachPhieu.SelectedRows[0].Cells[7].Value.ToString();

            DoanhNghiepBUS doanhNghiep = new DoanhNghiepBUS();
            doanhNghiep.MaDN = maPhieuDangKy;
            doanhNghiep.Username = username;
            doanhNghiep.TenCongTy = tenCongTy;
            doanhNghiep.DiaChi = diaChi;
            doanhNghiep.EmailLienHe = email;
            doanhNghiep.MST = mst;
            doanhNghiep.NguoiDaiDien = nguoiDaiDien;
            doanhNghiep.SDT = sdt;

            SuaPhieuDangKyDN suaPhieuDangKyDN = new SuaPhieuDangKyDN(doanhNghiep);
            suaPhieuDangKyDN.ShowDialog();
            if (suaPhieuDangKyDN.DialogResult == DialogResult.OK)
            {
                HienThi();
            }
        }
    }
}
