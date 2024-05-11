using System.Windows.Forms;

namespace PTTK.MH.Dashboard
{
    public partial class DashboardUV : Form
    {
        private Form parentForm;
        public DashboardUV(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.FormClosing += DashboardUV_FormClosing;
        }

        private void DashboardUV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                parentForm.Show();
            }
        }

        private void btn_DangXuat_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }
    }
}
