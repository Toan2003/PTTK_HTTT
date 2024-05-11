using PTTK.BUS;
using PTTK.MH.Dashboard;
using System;
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

        private void Clear_Textboxes()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBUS loginBUS = new LoginBUS();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string role = loginBUS.Login(username, password);

            if (role == "Candidate")
            {
                this.Hide();
                DashboardUV dashboardForm = new DashboardUV(this);
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else if (role == "Business")
            {
                this.Hide();
                AppConfig.doanhNghiepDangNhap = new DoanhNghiepBUS(username);
                DashboardDN dashboardForm = new DashboardDN(this);
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else if (role == "Employee")
            {
                this.Hide();
                DashboardNV dashboardForm = new DashboardNV(this);
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập sai hoặc tài khoản chưa được duyệt", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDki_Click(object sender, EventArgs e)
        {
            this.Hide();
            DkiDN_UV f = new DkiDN_UV(this);
            f.ShowDialog();
        }
    }
}
