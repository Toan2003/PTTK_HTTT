using PTTK.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PTTK.Program;

namespace PTTK.MH.ThanhToan
{
    public partial class MHThanhToanTraThang : Form
    {
        PhieuDangTuyenBUS phieu;
        string MANV = AppConfig.UsernameID;
        public MHThanhToanTraThang(PhieuDangTuyenBUS phieu, string TongTien)
        {
            InitializeComponent();
            this.phieu = phieu;
            MaPhieuDangTuyenTxtBox.Text = phieu.MaPDT;
            MaDoanhNghiepTxtBox.Text = phieu.MaDN;
            MaDichVuTxtBox.Text = phieu.MaDV;
            TongTienTxtBox.Text = TongTien;
            NgayThanhToanTxtBox.Text = DateTime.Now.ToString();
            NhanVienThuTxtBox.Text = "NV001";
            MaDichVuTxtBox.Text = phieu.MaDV;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void ThanhToanBtn_Click(object sender, EventArgs e)
        {
            if (TienMatCheckBox.Checked == false && QuaTheCheckBox.Checked == false)
            {
                MessageBox.Show("Hãy chọn phương án thanh toán");
                return;
            }
            string PhuongAnTT;
            if (TienMatCheckBox.Checked)
            {
                PhuongAnTT = "Tiền Mặt";
            } else
            {
                PhuongAnTT = "Thẻ";
            }
            HoaDonBUS hoadon = new HoaDonBUS(HoaDonBUS.GenerateMaHD(),MaPhieuDangTuyenTxtBox.Text,float.Parse(TongTienTxtBox.Text),"Trả Thẳng",DateTime.Now,MANV);
            PhieuThuBUS phieuthu = new PhieuThuBUS(PhieuThuBUS.GenerateMaPT(), DateTime.Now, PhuongAnTT, float.Parse(TongTienTxtBox.Text), MaPhieuDangTuyenTxtBox.Text, MANV);
            int isSuccessfullPhieuThu = PhieuThuBUS.ThemPhieuThu(phieuthu);
            int isSuccesfullHoaDon = HoaDonBUS.ThemHoaDon(hoadon);
            if (isSuccesfullHoaDon == 1 && isSuccessfullPhieuThu == 1)
            {
                MessageBox.Show("Thanh toán thành công");
                int isCapNhatHinhThucTT = phieu.CapNhatHinhThucTT("Trả Thẳng");
                int isCapNhatTrangThaiTT = phieu.CapNhatTrangThaiTT("Đã Thanh Toán");
                if (isCapNhatHinhThucTT <= 0 && isCapNhatTrangThaiTT <= 0)
                {
                    MessageBox.Show("Không cập nhật trạng thái thành công: " + isCapNhatHinhThucTT.ToString() + " " +isCapNhatTrangThaiTT.ToString());
                } else
                {
                    this.Close();
                }
                
            } else
            {
                MessageBox.Show("Thanh toán không thành công: " + isSuccesfullHoaDon.ToString() + " " + isSuccessfullPhieuThu.ToString());
                this.Close();
            }
        }

        private void QuaTheCheckBox_Click(object sender, EventArgs e)
        {
            if (TienMatCheckBox.Checked)
            {
                TienMatCheckBox.Checked = false;
            }
        }

        private void TienMatCheckBox_Click(object sender, EventArgs e)
        {
            if(QuaTheCheckBox.Checked)
            {
                QuaTheCheckBox.Checked = false;
            }
        }

        private void QuaTheCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
