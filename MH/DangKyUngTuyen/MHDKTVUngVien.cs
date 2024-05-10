using PTTK.BUS;
using PTTK.MH.Dashboard;
using System;
using System.Windows.Forms;

namespace PTTK.MH.DangKyUngTuyen
{
    public partial class MHDKTVUngVien : Form
    {
        private UngVienBUS ungVienBUS;
        private Form parent;

        public MHDKTVUngVien(Form parent)
        {
            InitializeComponent();
            this.FormClosing += MHDKTVUngVien_FormClosing;
            this.parent = parent;
        }

        private void MHDKTVUngVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parent.Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            string hoTen = txtHoTen.Text;
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string matKhau = txtMatKhau.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;

            ungVienBUS = new UngVienBUS(hoTen, email, diaChi, soDienThoai, matKhau);

            // Kiểm tra thông tin
            if (!ungVienBUS.KiemTraThongTin(hoTen, email, diaChi, soDienThoai, matKhau, xacNhanMatKhau))
                return;



            // Thêm thành viên
            int kq = ungVienBUS.ThemUngVien(ungVienBUS);
            if (kq == 1)
            {
                MessageBox.Show("Đăng ký thành viên thành công!");
                this.Close(); // Đóng form đăng ký sau khi đăng nhập thành công
                DashboardUV dashboardForm = new DashboardUV();
                dashboardForm.Show();
            }
            else if (kq == 100)
            {
                DialogResult result = MessageBox.Show("Tài khoản đã tồn tại. Bạn có muốn đăng ký tài khoản khác không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Xóa thông tin người dùng nhập và quay lại bước 2
                    txtSoDienThoai.Text = "";
                    txtMatKhau.Text = "";
                    txtXacNhanMatKhau.Text = "";
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công, vui lòng thử lại sau !");
            }
        }
    }
}
