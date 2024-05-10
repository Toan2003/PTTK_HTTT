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
    public partial class MHThanhToan : Form
    {
        string MaNV = AppConfig.UsernameID;
        PhieuDangTuyenBUS phieu;
        public MHThanhToan()
        {
            InitializeComponent();
            phieu = null;
            ThanhToanThangBtn.Visible = false;
            ThanhToanTraGopBtn.Visible = false;
            TiepTucThanhToanBtn.Visible = false;
            MaNhanVienLabel.Text = MaNV;
        }

        private void TimBtn_Click(object sender, EventArgs e)
        {
            string MaPhieu = MaPhieuDangKyTxtBox.Text;
            this.phieu = PhieuDangTuyenBUS.TimPhieuDangTuyen(MaPhieu);
            if (phieu == null)
            {
                MessageBox.Show("Khong tim thay phieu dang tuyen");
                return;
            } else
            {
                DichVuBUS dichvu = DichVuBUS.TimDichVuTheoMaDV(phieu.MaDV);
                DoanhNghiepBUS doanhghiep = DoanhNghiepBUS.TimDoanhNghiepTheoMaDoanhNghiep(phieu.MaDN);
                this.MaDoanhNghiepTxtBox.Text = phieu.MaDN;
                this.MaDVTxtBox.Text = phieu.MaDV;
                this.TongTienTxtBox.Text = phieu.TinhTongTien().ToString();
                this.TinhTrangTxtBox.Text = phieu.TrangThaiTT;
                this.HinhThucThanhToanTxtBox.Text = phieu.HinhThucTT;
                this.TenDichVuTxtBox.Text = dichvu.TenDichVu;
                this.TenDoanhNghiepTxtBox.Text = doanhghiep.TenCongTy;
                if (phieu.TrangThaiTT == "Chưa Thanh Toán")
                {
                    ThanhToanThangBtn.Visible = true;
                    ThanhToanTraGopBtn.Visible = true;
                    TiepTucThanhToanBtn.Visible = false;
                } else if (phieu.TrangThaiTT == "Đang Thanh Toán")
                {
                    
                    ThanhToanThangBtn.Visible = false;
                    ThanhToanTraGopBtn.Visible = false;
                    TiepTucThanhToanBtn.Visible = true;
                }                 
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void ThanhToanTraGopBtn_Click(object sender, EventArgs e)
        {
            bool conditionTraGop = phieu.KiemTraDuDKTraGop();
            if (conditionTraGop) { 
                MHThanhToanTraGop MHTraGop = new MHThanhToanTraGop(phieu, true);
                this.Hide();
                MHTraGop.ShowDialog();
                
                phieu = null;
                ThanhToanThangBtn.Visible = false;
                ThanhToanTraGopBtn.Visible = false;
                TiepTucThanhToanBtn.Visible = false;
                this.MaDoanhNghiepTxtBox.Text = null;
                this.MaDVTxtBox.Text = null;
                this.TongTienTxtBox.Text = null;
                this.TinhTrangTxtBox.Text = null;
                this.HinhThucThanhToanTxtBox.Text = null;
                this.TenDichVuTxtBox.Text = null;
                this.TenDoanhNghiepTxtBox.Text = null;
                this.Show();
            } else
            {
                MessageBox.Show("Không đủ điều kiện trả góp");
            }
        }

        private void ThanhToanThangBtn_Click(object sender, EventArgs e)
        {
            MHThanhToanTraThang MHTraThang = new MHThanhToanTraThang(phieu, TongTienTxtBox.Text);
            this.Hide();
            MHTraThang.ShowDialog();
            phieu = null;
            ThanhToanThangBtn.Visible = false;
            ThanhToanTraGopBtn.Visible = false;
            TiepTucThanhToanBtn.Visible = false;
            this.MaDoanhNghiepTxtBox.Text = null;
            this.MaDVTxtBox.Text = null;
            this.TongTienTxtBox.Text = null;
            this.TinhTrangTxtBox.Text = null;
            this.HinhThucThanhToanTxtBox.Text = null;
            this.TenDichVuTxtBox.Text = null;
            this.TenDoanhNghiepTxtBox.Text = null;
            this.Show();
        }

        private void TiepTucThanhToanBtn_Click(object sender, EventArgs e)
        {
            MHThanhToanTraGop MHTraGop = new MHThanhToanTraGop(phieu, false);
            this.Hide();
            MHTraGop.ShowDialog();
            
            phieu = null;
            ThanhToanThangBtn.Visible = false;
            ThanhToanTraGopBtn.Visible = false;
            TiepTucThanhToanBtn.Visible = false;
            this.MaDoanhNghiepTxtBox.Text = null;
            this.MaDVTxtBox.Text = null;
            this.TongTienTxtBox.Text = null;
            this.TinhTrangTxtBox.Text = null;
            this.HinhThucThanhToanTxtBox.Text = null;
            this.TenDichVuTxtBox.Text = null;
            this.TenDoanhNghiepTxtBox.Text = null;
            this.Show();
        }
    }
}
