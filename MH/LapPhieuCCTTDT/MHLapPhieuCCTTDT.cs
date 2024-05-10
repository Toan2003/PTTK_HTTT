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

        private void LapPhieuBtn_Click(object sender, EventArgs e)
        {

            DateTime ThoiGianBD = NgayBD.Value;
            string ViTriUngTuyenText = ViTriUngTuyen.Text;
            DateTime ThoiGianKetThuc = NgayKT.Value;
            int SoLuongTuyen = (int)SoLuong.Value;
            string ThongTinYeuCau = TTYeuCau.Text;
            string HinhThucTT = null;
            string TrangThaiTT = "Chưa Thanh Toán";
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
           
            else if (result == -1)
            {
                MessageBox.Show("Thông tin yêu cầu lớn hơn 2000 chữ");
            }

            else if (result == -2)
            {
                MessageBox.Show("Thời gian bắt đầu hoặc thời gian kết thúc không được nhỏ hơn thời gian hiện tại");

            }
            else if (result == -3)
            {
                MessageBox.Show("Thời gian bắt đầu không được sau thời gian kết thúc");
            }
            else if (result == -4)
            {
                MessageBox.Show("Số lượng tuyển phải lớn hơn 0");            
            }
            else if (result == -5)
            {
                MessageBox.Show("Vị trí ứng tuyển không quá 20 chữ");               
            }
            else MessageBox.Show("Không thêm thành công");

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
