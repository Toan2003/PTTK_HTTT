using PTTK.BUS;
using System;
using System.Windows.Forms;

namespace PTTK.MH.LapPhieuCCTTDT
{
    public partial class MHLapPhieuCCTTDT : Form
    {
        private Form parentForm;
        public MHLapPhieuCCTTDT(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            HienThi();
            this.FormClosing += MHLapPhieuCCTTDT_FormClosing;
        }

        private void MHLapPhieuCCTTDT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parentForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime ThoiGianBD = NgayBD.Value;
            string ViTriUngTuyenText = ViTriUngTuyen.Text;
            DateTime ThoiGianKetThuc = NgayKT.Value;
            int SoLuongTuyen = (int)SoLuong.Value;
            string ThongTinYeuCau = TTYeuCau.Text;
            string HinhThucTT = null;
            string TrangThaiTT = null;
            string MaDN = PTTK.Program.AppConfig.doanhNghiepDangNhap.MaDN;
            string MaDV = HinhThuc.SelectedItem.ToString();
            string MaPDT = null;
            PhieuDangTuyenBUS pdtbus = new PhieuDangTuyenBUS(MaPDT, ThoiGianBD, ViTriUngTuyenText, ThoiGianKetThuc,
                                SoLuongTuyen, ThongTinYeuCau, null, HinhThucTT, TrangThaiTT, MaDN, MaDV);
            int result = pdtbus.ThemPhieuDangTuyen(pdtbus);
            if (result > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Thêm không thành công");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void HienThi()
        {
            /*            string MaDN = "DN001";
            */
            string TenDN = PTTK.Program.AppConfig.doanhNghiepDangNhap.TenCongTy;
            tenCtyLabel.Text = TenDN;

        }
    }
}
