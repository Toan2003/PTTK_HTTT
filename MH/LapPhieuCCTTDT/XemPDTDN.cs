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

namespace PTTK.MH.LapPhieuCCTTDT
{
    public partial class XemPDTDN : Form
    {
        public XemPDTDN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToanBoBTN_Click(object sender, EventArgs e)
        {
            string MaDN = "DN001";
            DataTable result = PhieuDangTuyenBUS.LayToanBoPDTDN(MaDN);
            DSPDT.DataSource = result;
        }

        private void ChuaPheDuyetBtn_Click(object sender, EventArgs e)
        {
            string MaDN = "DN001";
            DataTable result = PhieuDangTuyenBUS.LayPDTChuaPheDuyetDN(MaDN);
            DSPDT.DataSource = result;
        }
    }
}
