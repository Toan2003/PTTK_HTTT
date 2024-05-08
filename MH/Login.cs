using PTTK.BUS;
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
using static PTTK.Program;

namespace PTTK.MH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += Login_FormClosing;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBUS loginBUS = new LoginBUS();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            password = AppConfig.HashMatKhau(password);

            string role = loginBUS.Login(username, password);

            if (role == "Candidate")
            {
                this.Hide();
                DashboardUV dashboardForm = new DashboardUV();
                dashboardForm.Show();
            } else if (role == "Business")
            {
                this.Hide();
                DashboardDN dashboardForm = new DashboardDN();
                dashboardForm.Show();
            } else if (role == "Employee")
            {
                this.Hide();
                DashboardNV dashboardForm = new DashboardNV();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDki_Click(object sender, EventArgs e)
        {
            this.Hide();
            DkiDN_UV f = new DkiDN_UV();
            f.ShowDialog();
        }
    }
}
