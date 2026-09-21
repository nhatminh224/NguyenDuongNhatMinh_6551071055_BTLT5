using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai1C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. Cập nhật đồng hồ thời gian thực
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            // 2. Kiểm tra khung giờ hoạt động (6h - 22h)
            int gioHienTai = DateTime.Now.Hour;

            if (gioHienTai >= 6 && gioHienTai < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void mnuDoiMauNen_Click(object sender, EventArgs e)
        {
            // Mở ColorDialog để đổi màu nền Form
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}