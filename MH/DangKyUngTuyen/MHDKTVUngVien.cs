using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.BUS;

namespace WindowsFormsApp2.MH.DangKyUngTuyen
{
    public partial class MHDKTVUngVien : Form
    {
        private UngVienBUS ungVienBUS;

        public MHDKTVUngVien()
        {
            InitializeComponent();
            ungVienBUS = new UngVienBUS();
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

            // Kiểm tra thông tin
            if (!ungVienBUS.KiemTraThongTin(hoTen, email, diaChi, soDienThoai, matKhau, xacNhanMatKhau))
                return;

            // Thêm thành viên
            int kq = ungVienBUS.ThemUngVien(hoTen, email, diaChi, soDienThoai, matKhau);
            if ( kq == 1)
            {
                MessageBox.Show("Đăng ký thành viên thành công!");
                // Thực hiện đăng nhập
                ungVienBUS.DangNhap(soDienThoai, matKhau);
                this.Close(); // Đóng form đăng ký sau khi đăng nhập thành công
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
                    // Thoát chức năng đăng ký
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Đăng ký không thành công, vui lòng thử lại sau !");
            }
        }
    }
}
