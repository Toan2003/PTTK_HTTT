using System;
using System.Windows.Forms;
using WindowsFormsApp2.BUS;
using WindowsFormsApp2.DTO;

namespace WindowsFormsApp2.MH.ThemDNThanhVien
{
    public partial class ThemDoanhNghiepMoi : Form
    {
        private Timer debounceTimer = new Timer();
        public ThemDoanhNghiepMoi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (txt_TenCongTy.Text == "" || txt_Email.Text == "" || txt_MST.Text == "" || txt_NguoiDaiDien.Text == "" || txt_SDT.Text == "" || txt_DiaChi.Text == "" || txt_Username.Text == "" || txt_Password.Text == "" || txt_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            PhieuDangKyDNDTO phieuDangKy = new PhieuDangKyDNDTO(txt_TenCongTy.Text, txt_Email.Text, txt_MST.Text, txt_NguoiDaiDien.Text, txt_SDT.Text, txt_DiaChi.Text, txt_Username.Text, txt_Password.Text);
            bool tonTaiCheck = DoanhNghiepBUS.Instance.KiemTraThanhVien(txt_Username.Text, txt_MST.Text);
            if (tonTaiCheck)
            {
                MessageBox.Show("Tên đăng nhập hoặc MST đã tồn tại");
                return;
            }

            bool result = PhieuDangKyDNBUS.Instance.TaoPhieuDangKy(phieuDangKy);
            if (result)
            {
                MessageBox.Show("Đăng ký thành công");
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
    }
}
