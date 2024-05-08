using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.MH.DuyetHoSoUngTuyen
{
    public partial class CapNhatTrangThaiHoSo : Form
    {
        public CapNhatTrangThaiHoSo()
        {
            InitializeComponent();
        }

        public void HienThi(string trangThaiHienTai, string doUuTienHienTai)
        {
            switch (trangThaiHienTai)
            {
                case "ĐÃ TIẾP NHẬN":
                    cbx_TrangThaiXetDuyet.SelectedItem = "Đã tiếp nhận";
                    break;
                case "ĐỦ ĐIỀU KIỆN":
                    cbx_TrangThaiXetDuyet.SelectedItem = "Đủ điều kiện";
                    break;
                case "KHÔNG ĐỦ ĐIỀU KIỆN":
                    cbx_TrangThaiXetDuyet.SelectedItem = "Không đủ điều kiện";
                    break;
                case "ĐÃ XỬ LÝ":
                    cbx_TrangThaiXetDuyet.SelectedItem = "Đã xử lý";
                    break;
                case "ĐƯỢC DN PHẢN HỒI":
                    cbx_TrangThaiXetDuyet.SelectedItem = "Được DN phản hồi";
                    break;
            }

            switch (doUuTienHienTai)
            {
                case "CAO":
                    cbx_DoUuTien.SelectedItem = "Cao";
                    break;
                case "TRUNG BÌNH":
                    cbx_DoUuTien.SelectedItem = "Trung bình";
                    break;
                case "THẤP":
                    cbx_DoUuTien.SelectedItem = "Thấp";
                    break;
                case "CHƯA XÉT":
                    cbx_DoUuTien.SelectedItem = "Chưa xét";
                    break;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
