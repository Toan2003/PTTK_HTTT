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
    public partial class XemPhieuDangTuyen : Form
    {
        public XemPhieuDangTuyen()
        {
            InitializeComponent();
        }

        private void ToanBoBTN_Click(object sender, EventArgs e)
        {
            DataTable result = PhieuDangTuyenBUS.LayToanBoPDT();
            DSPDT.DataSource = result;
        }

        private void ChuaPheDuyetBtn_Click(object sender, EventArgs e)
        {
            DataTable result = PhieuDangTuyenBUS.LayPDTChuaPheDuyet();
            DSPDT.DataSource = result;
        }
    }
}
