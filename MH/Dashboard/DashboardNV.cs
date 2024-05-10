using PTTK.MH.ThanhToan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK.MH.Dashboard
{
    public partial class DashboardNV : Form
    {
        public DashboardNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHThanhToan mhThanhToan = new MHThanhToan();
            this.Hide();
            mhThanhToan.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
