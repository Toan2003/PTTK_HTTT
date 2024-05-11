using PTTK.BUS;
using System;
using System.Windows.Forms;

namespace PTTK.MH.ThemDNThanhVien
{
    public partial class ThemDoanhNghiepMoi : Form
    {
        private Form parent;
        private Timer debounceUsernameTimer = new Timer();
        private Timer debounceMSTTimer = new Timer();
        public ThemDoanhNghiepMoi(Form parent)
        {
            InitializeComponent();
            this.FormClosing += ThemDoanhNghiepMoi_FormClosing;
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
            this.parent = parent;
        }

        private void ThemDoanhNghiepMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Chuyển về form DN
                parent.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void KiemTraTenDangNhap()
        {
            string username = txt_Username.Text;
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
            string maSoThue = txt_MST.Text;
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
            if (txt_TenCongTy.Text == "" || txt_Email.Text == "" || txt_MST.Text == "" || txt_NguoiDaiDien.Text == "" || txt_SDT.Text == "" || txt_DiaChi.Text == "" || txt_Username.Text == "" || txt_Password.Text == "" || txt_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            DoanhNghiepBUS phieuDangKy = new DoanhNghiepBUS(txt_TenCongTy.Text, txt_Email.Text.Trim(), txt_MST.Text.Trim(), txt_NguoiDaiDien.Text, txt_SDT.Text.Trim(), txt_DiaChi.Text, txt_Username.Text.Trim(), DoanhNghiepBUS.Instance.HashMatKhau(txt_Password.Text), "CHƯA DUYỆT");
            bool tonTaiCheck = DoanhNghiepBUS.Instance.KiemTraThanhVien(txt_Username.Text, txt_MST.Text);
            if (tonTaiCheck)
            {
                MessageBox.Show("Tên đăng nhập hoặc MST đã tồn tại");
                return;
            }
            if (!DoanhNghiepBUS.Instance.IsValidTaxIdentificationNumber(txt_MST.Text.Trim()))
            {
                MessageBox.Show("Mã số thuế không hợp lệ");
                return;
            }
            if (txt_ConfirmPassword.Text != txt_Password.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            if (!DoanhNghiepBUS.Instance.IsValidEmail(txt_Email.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if (!DoanhNghiepBUS.Instance.IsValidPhoneNumber(txt_SDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            bool result = DoanhNghiepBUS.Instance.TaoPhieuDangKy(phieuDangKy);
            if (result)
            {
                MessageBox.Show("Đăng ký thành công");
                Close();
                Dispose();
                return;
            }

            else
            {
                MessageBox.Show("Đăng ký thất bại");
                return;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }


        private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txt_ConfirmPassword.Text != txt_Password.Text)
            {
                lbl_checkConfirmPwd.Text = "Mật khẩu không khớp";
            }
            else
            {
                lbl_checkConfirmPwd.Text = "";
            }
        }

        private void ThemDoanhNghiepMoi_Load(object sender, EventArgs e)
        {

        }



        private void lbl_CheckEmail_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                lbl_CheckEmail.Text = "Vui lòng nhập email";
                return;
            }
            else if (!DoanhNghiepBUS.Instance.IsValidEmail(txt_Email.Text))
            {
                lbl_CheckEmail.Text = "Email không hợp lệ";
                return;
            }
            else
            {
                lbl_CheckEmail.Text = "";
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            debounceUsernameTimer.Stop();
            debounceUsernameTimer.Start();
        }


        private void txt_MST_TextChanged(object sender, EventArgs e)
        {
            debounceMSTTimer.Stop();
            debounceMSTTimer.Start();
        }
    }
}
