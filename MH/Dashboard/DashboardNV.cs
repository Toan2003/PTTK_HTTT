using PTTK.MH.LapPhieuCCTTDT;
using PTTK.MH.ThanhToan;
using PTTK.MH.ThemDNThanhVien;
using System;
using System.Windows.Forms;

namespace PTTK.MH.Dashboard
{
    public partial class DashboardNV : Form
    {
        private Form parentForm;
        public DashboardNV(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.FormClosing += DashboardNV_FormClosing;
        }

        private void DashboardNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parentForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHThanhToan mhThanhToan = new MHThanhToan();
            this.Hide();
            mhThanhToan.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XemPhieuDangTuyen mhXemPhieuDangTuyen = new XemPhieuDangTuyen();
            this.Hide();
            mhXemPhieuDangTuyen.ShowDialog();
            this.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }

        private void btn_DuyetDoanhNghiep_Click(object sender, EventArgs e)
        {
            this.Hide();
            DuyetPhieuDangKyDN duyetPhieuDangKyDN = new DuyetPhieuDangKyDN(this);
            duyetPhieuDangKyDN.ShowDialog();

        }
    }
}
