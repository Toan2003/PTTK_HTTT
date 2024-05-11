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
using System.Windows.Forms.VisualStyles;
using static PTTK.Program;

namespace PTTK.MH.ThanhToan
{
    public partial class MHThanhToanTraGop : Form
    {
        PhieuDangTuyenBUS phieu;
        string MaNV = AppConfig.UsernameID;
        bool isFirstTime;
        DataTable Lich;
        public MHThanhToanTraGop(PhieuDangTuyenBUS phieu, bool isFirstTime)
        {
            InitializeComponent();
            LichTraGopGridView.AllowUserToAddRows = false;
            this.isFirstTime = isFirstTime;
            this.phieu = phieu;
            MaPDTTxtBox.Text = phieu.MaPDT;
            MaDoanhNghiepTxtBox.Text = phieu.MaDN;
            MaDichVuTxtBox.Text = phieu.MaDV;
            DataTable LichTraGop = null;
            if (isFirstTime)
            {
                LichTraGop = phieu.TaoLichTraGop();
                
            } else
            {
                LichTraGop = LichTraGopBUS.TimLichTraGopTheoMaPDK(phieu.MaPDT);
            }

            LichTraGopGridView.DataSource = LichTraGop;
            this.Lich = LichTraGop;
            for (int i = 0; i < LichTraGop.Rows.Count; i++)
            {
                if (LichTraGop.Rows[i]["TRANGTHAI"].ToString() == "Chưa Thanh Toán")
                {
                    DotThanhToanTxtBox.Text = LichTraGop.Rows[i]["DOTTHANHTOAN"].ToString();
                    TongTienTxtBox.Text = LichTraGop.Rows[i]["TONGTIEN"].ToString();
                    NgayHenTxtBox.Text = LichTraGop.Rows[i]["NGAYHEN"].ToString();
                    break;
                }
            }

            NgayThanhToanTxtBox.Text = DateTime.Now.ToString();
            MaNVTxtBox.Text = MaNV;
            this.isFirstTime = isFirstTime;
        }

        private void ThanhToanTraGop_Load(object sender, EventArgs e)
        {

        }

        private void TienMatCheckBox_Click(object sender, EventArgs e)
        {
            if (QuaTheCheckBox.Checked)
            {
                QuaTheCheckBox.Checked = false;
            }
        }

        private void QuaTheCheckBox_Click(object sender, EventArgs e)
        {
            if (TienMatCheckBox.Checked)
            {
                TienMatCheckBox.Checked = false;
            }
        }

        private void ThanhToanBtn_Click(object sender, EventArgs e)
        {
            if (QuaTheCheckBox.Checked == false && TienMatCheckBox.Checked == false)
            {
                MessageBox.Show("Hãy chọn hình thức thanh toán");
                return;
            }
            string PhuongAnTT;
            if (TienMatCheckBox.Checked)
            {
                PhuongAnTT = "Tiền Mặt";
            }
            else
            {
                PhuongAnTT = "Thẻ";
            }
            if (isFirstTime)
            {
                //Thêm lịch trả góp lần đầu tiên
                for (int i = 0; i < this.Lich.Rows.Count; i++)
                {
                    string MaPDT = this.Lich.Rows[i]["MAPDT"].ToString();
                    int DotThanhToan = int.Parse(this.Lich.Rows[i]["DOTTHANHTOAN"].ToString());
                    DateTime NgayHen = DateTime.Parse(this.Lich.Rows[i]["NGAYHEN"].ToString());
                    string TrangThai = this.Lich.Rows[i]["TRANGTHAI"].ToString();
                    DateTime? NgayThu = null;
                    float TongTien = float.Parse(Lich.Rows[i]["TONGTIEN"].ToString());
                    LichTraGopBUS lich = new LichTraGopBUS(MaPDT, DotThanhToan, NgayHen, TrangThai, NgayThu, TongTien);
                    int isThemLichThanhCong = LichTraGopBUS.ThemLichTraGop(lich);
                    if (isThemLichThanhCong != 1)
                    {
                        MessageBox.Show("Thêm lịch không thành công");
                        return;
                    }
                }
                // Cập nhật trạng thái lần đầu tiên
                int isCapNhatHinhThucTT = phieu.CapNhatHinhThucTT("Trả Góp");
                int isCapNhatTrangThaiTT = phieu.CapNhatTrangThaiTT("Đang Thanh Toán");
                if (isCapNhatHinhThucTT <= 0 && isCapNhatTrangThaiTT <= 0)
                {
                    MessageBox.Show("Không cập nhật trạng thái thành công: " + isCapNhatHinhThucTT.ToString() + " " + isCapNhatTrangThaiTT.ToString());
                    return;
                }
            }

            DateTime ngaythu = DateTime.Parse(NgayThanhToanTxtBox.Text);

            //Thêm phiếu thu
            PhieuThuBUS phieuthu = new PhieuThuBUS(PhieuThuBUS.GenerateMaPT(), ngaythu, PhuongAnTT, float.Parse(TongTienTxtBox.Text), MaPDTTxtBox.Text, MaNV);
            int isSuccessfullPhieuThu = PhieuThuBUS.ThemPhieuThu(phieuthu);
            if (isSuccessfullPhieuThu != 1 )
            {
                MessageBox.Show("Thêm phiếu thu không thành công");
                return;
            }

            //Cập nhật lịch thanh toán
            LichTraGopBUS lichThu = new LichTraGopBUS(MaPDTTxtBox.Text, int.Parse(DotThanhToanTxtBox.Text), DateTime.Parse(NgayHenTxtBox.Text), "Đã Thanh Toán", ngaythu, float.Parse(TongTienTxtBox.Text));
            int isSuccessfullLich = lichThu.CapNhatTrangThaiNgayThuLich("Đã Thanh Toán", ngaythu);
            if (isSuccessfullLich != 1 )
            {
                MessageBox.Show("Cập nhật lịch thanh toán không thành công");
                return;
            }
            //MessageBox.Show(LichTraGopGridView.Rows.Count.ToString());
            //MessageBox.Show(Lich.Rows.Count.ToString());

            //Thêm hóa đơn khi thanh toán cuối cùng
            if (!isFirstTime)
            {
                if (PhieuDangTuyenBUS.KiemTraHoanTatThanhToan(MaPDTTxtBox.Text))
                {
                    HoaDonBUS hoadon = new HoaDonBUS(HoaDonBUS.GenerateMaHD(), MaPDTTxtBox.Text, float.Parse(TongTienTxtBox.Text), "Trả Góp", ngaythu, MaNV);
                    int isSuccesfullHoaDon = HoaDonBUS.ThemHoaDon(hoadon);
                    if (isSuccesfullHoaDon == 1)
                    {

                        int isCapNhatTrangThaiTT = phieu.CapNhatTrangThaiTT("Đã Thanh Toán");
                        if (isCapNhatTrangThaiTT <= 0)
                        {
                            MessageBox.Show("Không cập nhật trạng thái thành công: " + isCapNhatTrangThaiTT.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán không thành công: ");
                    }
                }
            }
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }
    }
}
