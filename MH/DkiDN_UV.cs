using PTTK.MH.DangKyUngTuyen;
using PTTK.MH.ThemDNThanhVien;
using System;
using System.Windows.Forms;

namespace PTTK.MH
{
    public partial class DkiDN_UV : Form
    {
        private Form parent;
        public DkiDN_UV(Form parent)
        {
            InitializeComponent();
            this.FormClosing += DkiDN_UV_FormClosing;
            this.parent = parent;
        }

        private void DkiDN_UV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Chuyển về form DashBoardNV
                parent.Show();
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemDoanhNghiepMoi f = new ThemDoanhNghiepMoi(this);
            f.ShowDialog();
        }

        private void btnUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHDKTVUngVien f = new MHDKTVUngVien(this);
            f.ShowDialog();
        }
    }
}
