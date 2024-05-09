using PTTK.MH.DangKyUngTuyen;
using PTTK.MH.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.MH
{
    public partial class DkiDN_UV : Form
    {
        public DkiDN_UV()
        {
            InitializeComponent();
            this.FormClosing += DkiDN_UV_FormClosing;
        }

        private void DkiDN_UV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Chuyển về form DashBoardNV
                Login f = new Login();
                f.Show();
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {

        }

        private void btnUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHDKTVUngVien f = new MHDKTVUngVien();
            f.ShowDialog();
        }
    }
}
