using PTTK.MH.LapPhieuCCTTDT;
using System;
using System.Windows.Forms;

namespace PTTK.MH.Dashboard
{
    public partial class DashboardDN : Form
    {
        private Form parentForm;
        public DashboardDN(Form parent)
        {
            InitializeComponent();
            lbl_TenDoanhNghiep.Text = PTTK.Program.AppConfig.doanhNghiepDangNhap.TenCongTy;
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
            this.Hide();
            XemPDTDN xemPhieuDangTuyen = new XemPDTDN(this);
            xemPhieuDangTuyen.Show();
        }

        private void lbl_TenCongTy_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            PTTK.Program.AppConfig.doanhNghiepDangNhap = null;
            this.Close();
        }

        private void lbl_TenDoanhNghiep_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoPhieuDangTuyen_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHLapPhieuCCTTDT lapPhieuDangTuyen = new MHLapPhieuCCTTDT(this);
            lapPhieuDangTuyen.Show();
        }
    }
}
