﻿using PTTK.BUS;
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
            password = AppConfig.HashMatKhau(password);

            string role = loginBUS.Login(username, password);

            if (role == "Candidate")
            {
                this.Hide();
                DashboardUV dashboardForm = new DashboardUV();
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else if (role == "Business")
            {
                this.Hide();
                DashboardDN dashboardForm = new DashboardDN(this, new DoanhNghiepBUS(username));
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else if (role == "Employee")
            {
                this.Hide();
                DashboardNV dashboardForm = new DashboardNV();
                dashboardForm.Show();
                Clear_Textboxes();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
