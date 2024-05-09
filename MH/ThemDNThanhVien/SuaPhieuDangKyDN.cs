using PTTK.BUS;
using System;
using System.Windows.Forms;

namespace PTTK.MH.ThemDNThanhVien
{
    public partial class SuaPhieuDangKyDN : Form
    {
        private DoanhNghiepBUS thongTinHienTai;

        private Timer debounceUsernameTimer = new Timer();
        private Timer debounceMSTTimer = new Timer();
        public SuaPhieuDangKyDN(DoanhNghiepBUS thongTinDaChon)
        {
            InitializeComponent();
            thongTinHienTai = thongTinDaChon;
            SuaPhieuDangKyDN_Load(null, null);
            debounceUsernameTimer.Interval = 300;
            debounceUsernameTimer.Tick += (sender, e) =>
            {
                debounceUsernameTimer.Stop();
                KiemTraTenDangNhap();
            };

            debounceMSTTimer.Interval = 300;
            debounceMSTTimer.Tick += (sender, e) =>
            {
                debounceMSTTimer.Stop();
                KiemTraMaSoThue();
            };
        }

        private void SuaPhieuDangKyDN_Load(object sender, EventArgs e)
        {
            txt_DiaChi.Text = thongTinHienTai.DiaChi;
            txt_EmailLienHe.Text = thongTinHienTai.EmailLienHe;
            txt_MaSoThue.Text = thongTinHienTai.MST;
            txt_NguoiDaiDien.Text = thongTinHienTai.NguoiDaiDien;
            txt_SDT.Text = thongTinHienTai.SDT;
            txt_TenCongTy.Text = thongTinHienTai.TenCongTy;
            txt_Username.Text = thongTinHienTai.Username;
        }

        private void KiemTraTenDangNhap()
        {
            string username = txt_Username.Text;
            if (username == thongTinHienTai.Username) return;
            if (username == "")
            {
                lbl_CheckValidUsername.Text = "Vui lòng nhập tên đăng nhập";
                return;
            }
            else if (DoanhNghiepBUS.Instance.KiemTraTonTai(username, "Tên đăng nhập"))
            {
                lbl_CheckValidUsername.Text = "Tên đăng nhập đã tồn tại";
            }
            else
            {
                lbl_CheckValidUsername.Text = "Tên đăng nhập hợp lệ";
            }
        }

        private void KiemTraMaSoThue()
        {
            string maSoThue = txt_MaSoThue.Text;
            if (maSoThue == thongTinHienTai.MST) return;
            if (maSoThue == "")
            {
                lbl_CheckValidMST.Text = "Vui lòng nhập mã số thuế";
                return;
            }
            else if (DoanhNghiepBUS.Instance.KiemTraTonTai(maSoThue, "MST"))
            {
                lbl_CheckValidMST.Text = "Mã số thuế đã tồn tại";
            }
            else
            {
                lbl_CheckValidMST.Text = "Mã số thuế hợp lệ";
            }
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (txt_TenCongTy.Text == "" || txt_DiaChi.Text == "" || txt_EmailLienHe.Text == "" || txt_MaSoThue.Text == "" ||
                txt_Username.Text == "" || txt_NguoiDaiDien.Text == "" || txt_SDT.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else if (txt_DiaChi.Text == thongTinHienTai.DiaChi && txt_EmailLienHe.Text == thongTinHienTai.EmailLienHe && txt_MaSoThue.Text == thongTinHienTai.MST &&
                txt_NguoiDaiDien.Text == thongTinHienTai.NguoiDaiDien && txt_SDT.Text == thongTinHienTai.SDT && txt_TenCongTy.Text == thongTinHienTai.TenCongTy &&
                txt_Username.Text == thongTinHienTai.Username)
            {
                MessageBox.Show("Không có thông tin nào thay đổi");
                Dispose();
            }
            else
            {
                bool tonTaiCheck = DoanhNghiepBUS.Instance.KiemTraThanhVien(txt_Username.Text, txt_MaSoThue.Text);
                if (tonTaiCheck)
                {
                    MessageBox.Show("Tên đăng nhập hoặc MST đã tồn tại");
                    return;
                }
                if (!PTTK.Program.AppConfig.IsValidTaxIdentificationNumber(txt_MaSoThue.Text))
                {
                    MessageBox.Show("Mã số thuế không hợp lệ");
                    return;
                }

                if (!PTTK.Program.AppConfig.IsValidEmail(txt_EmailLienHe.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                    return;
                }
                if (!PTTK.Program.AppConfig.IsValidPhoneNumber(txt_SDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
                thongTinHienTai.DiaChi = txt_DiaChi.Text;
                thongTinHienTai.EmailLienHe = txt_EmailLienHe.Text;
                thongTinHienTai.MST = txt_MaSoThue.Text;
                thongTinHienTai.NguoiDaiDien = txt_NguoiDaiDien.Text;
                thongTinHienTai.SDT = txt_SDT.Text;
                thongTinHienTai.TenCongTy = txt_TenCongTy.Text;
                thongTinHienTai.Username = txt_Username.Text;

                bool result = DoanhNghiepBUS.Instance.SuaPhieuDangKy(thongTinHienTai);
                if (result)
                {
                    MessageBox.Show("Sửa phiếu đăng ký thành công");
                    this.DialogResult = DialogResult.OK;
                    Close();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa phiếu đăng ký thất bại");
                }
            }
            return;
        }


        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            debounceUsernameTimer.Stop();
            debounceUsernameTimer.Start();
        }

        private void txt_MaSoThue_TextChanged(object sender, EventArgs e)
        {
            debounceMSTTimer.Stop();
            debounceMSTTimer.Start();
        }
    }
}
