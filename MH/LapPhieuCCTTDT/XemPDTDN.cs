using PTTK.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace PTTK.MH.LapPhieuCCTTDT
{
    public partial class XemPDTDN : Form
    {
        private Form parentForm;
        public XemPDTDN(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            this.FormClosing += XemPDTDN_FormClosing;
        }

        private void XemPDTDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                parentForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToanBoBTN_Click(object sender, EventArgs e)
        {
            string MaDN = PTTK.Program.AppConfig.doanhNghiepDangNhap.MaDN;
            DataTable result = PhieuDangTuyenBUS.LayToanBoPDTDN(MaDN);
            if (result == null)
            {
                MessageBox.Show("Không có kết quả trả về");
            }    
            else DSPDT.DataSource = result;
        }

        private void ChuaPheDuyetBtn_Click(object sender, EventArgs e)
        {
            string MaDN = PTTK.Program.AppConfig.doanhNghiepDangNhap.MaDN;
            DataTable result = PhieuDangTuyenBUS.LayPDTChuaPheDuyetDN(MaDN);
            if (result == null)
            {
                MessageBox.Show("Không có kết quả trả về");
            }
            else DSPDT.DataSource = result;
        }
    }
}
