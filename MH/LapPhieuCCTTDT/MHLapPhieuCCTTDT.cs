using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK.BUS;

namespace PTTK.MH.LapPhieuCCTTDT
{
    public partial class MHLapPhieuCCTTDT : Form
    {
        public MHLapPhieuCCTTDT()
        {
            InitializeComponent();
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime ThoiGianBD = NgayBD.Value;
            string ViTriUngTuyenText = ViTriUngTuyen.Text;
            DateTime ThoiGianKetThuc = NgayKT.Value;
            int SoLuongTuyen = (int) SoLuong.Value;
            string ThongTinYeuCau = TTYeuCau.Text;
            string HinhThucTT = null;
            string TrangThaiTT =null;
            string MaDN = "DN001";
            string MaDV = HinhThuc.SelectedItem.ToString();
            string MaPDT = null;
            PhieuDangTuyenBUS pdtbus = new PhieuDangTuyenBUS(MaPDT, ThoiGianBD, ViTriUngTuyenText, ThoiGianKetThuc,
                                SoLuongTuyen, ThongTinYeuCau,null, HinhThucTT, TrangThaiTT, MaDN, MaDV);
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
            string MaDN = "DN001";
            string maDN = PhieuDangTuyenBUS.LayTenDoanhNghiep(MaDN);
            tenCtyLabel.Text = maDN;

        }
    }
}
