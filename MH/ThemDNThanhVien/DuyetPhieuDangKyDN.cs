using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2.MH.ThemDNThanhVien
{
    public partial class DuyetPhieuDangKyDN : Form
    {
        public DuyetPhieuDangKyDN()
        {
            InitializeComponent();
            HienThi();
        }

        public void HienThi()
        {
            gridview_DanhSachPhieu.DataSource = BUS.PhieuDangKyDNBUS.Instance.LayDanhSachPhieuDangKy();
            foreach (DataGridViewColumn column in gridview_DanhSachPhieu.Columns)
            {
                // Set the AutoSizeMode to display all content without clipping
                if (column.Name != "MST" && column.Name != "TENCONGTY")
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            cbx_TimKiemTheo.SelectedItem = "Tên công ty";

        }

        private void btn_Duyet_Click(object sender, System.EventArgs e)
        {
            if (gridview_DanhSachPhieu.SelectedRows.Count > 0)
            {
                string maPhieuDangKy = gridview_DanhSachPhieu.SelectedRows[0].Cells[0].Value.ToString();
                bool result = BUS.PhieuDangKyDNBUS.Instance.DuyetPhieuDangKy(maPhieuDangKy);
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
            DataTable result = BUS.PhieuDangKyDNBUS.Instance.TimPhieuDangKy(keyword, option);
            gridview_DanhSachPhieu.DataSource = result;
            return;

        }

        private void cbx_TimKiemTheo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {

        }
    }
}
