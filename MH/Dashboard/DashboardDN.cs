using PTTK.BUS;
using System;
using System.Windows.Forms;

namespace PTTK.MH.Dashboard
{
    public partial class DashboardDN : Form
    {
        private DoanhNghiepBUS doanhNghiepHienTai = new DoanhNghiepBUS();
        private Form parentForm;
        public DashboardDN(Form parent, DoanhNghiepBUS doanhNghiepDangNhap)
        {
            InitializeComponent();
            doanhNghiepHienTai = doanhNghiepDangNhap;
            lbl_TenDoanhNghiep.Text = doanhNghiepHienTai.TenCongTy;
            parentForm = parent;
            this.FormClosing += DashboardDN_FormClosing;
        }

        private void DashboardDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parentForm.Show();
            }
        }

        private void btn_XemPhieuDangTuyen_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TenCongTy_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }

        private void lbl_TenDoanhNghiep_Click(object sender, EventArgs e)
        {

        }
    }
}
