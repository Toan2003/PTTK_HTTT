using System;
using System.Windows.Forms;
using WindowsFormsApp2.BUS;

namespace WindowsFormsApp2.MH.DuyetHoSoUngTuyen
{
    public partial class DSHoSoUngVien : Form
    {
        public DSHoSoUngVien()
        {
            InitializeComponent();
            HienThi();
        }

        void HienThi()
        {
            gridview_HoSoUngVien.DataSource = HoSoUngVienBUS.Instance.LayTatCaHoSo();
            foreach (DataGridViewColumn column in gridview_HoSoUngVien.Columns)
            {

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DSHoSoUngVien_Load(object sender, EventArgs e)
        {

        }

        private void txt_TimKiemTenCongTy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            CapNhatTrangThaiHoSo form = new CapNhatTrangThaiHoSo();
            string trangThaiHienTai = gridview_HoSoUngVien.SelectedRows[0].Cells["TRANGTHAIXETDUYET"].Value.ToString();
            string doUuTienHienTai = gridview_HoSoUngVien.SelectedRows[0].Cells["DOUUTIEN"].Value.ToString();
            form.HienThi(trangThaiHienTai, doUuTienHienTai);
            form.ShowDialog();
        }
    }
}
