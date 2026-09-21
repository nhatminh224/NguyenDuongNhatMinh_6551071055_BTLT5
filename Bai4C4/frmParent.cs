using System;
using System.Windows.Forms;

namespace Bai4C4
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            // Thiết lập Form cha
            this.Text = "Phần mềm quản lý phòng khám mini";
            this.IsMdiContainer = true; // Yêu cầu bắt buộc để chứa form con
            this.WindowState = FormWindowState.Maximized;

            // Khởi tạo Menu
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem mnuNghiepVu = new ToolStripMenuItem("Nghiệp vụ");
            ToolStripMenuItem mnuBenhNhan = new ToolStripMenuItem("Thông tin bệnh nhân");
            ToolStripMenuItem mnuLichHen = new ToolStripMenuItem("Đặt lịch hẹn");
            ToolStripMenuItem mnuCuaSo = new ToolStripMenuItem("Cửa sổ");

            mnuNghiepVu.DropDownItems.Add(mnuBenhNhan);
            mnuNghiepVu.DropDownItems.Add(mnuLichHen);
            menuStrip.Items.Add(mnuNghiepVu);
            menuStrip.Items.Add(mnuCuaSo);

            // Tự động liệt kê các form con đang mở vào menu "Cửa sổ"
            menuStrip.MdiWindowListItem = mnuCuaSo;

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);

            // Sự kiện mở form con (Tạo mới hoàn toàn mỗi lần bấm)
            mnuBenhNhan.Click += (s, e) =>
            {
                frmBenhNhan f = new frmBenhNhan();
                f.MdiParent = this;
                f.Show();
            };

            mnuLichHen.Click += (s, e) =>
            {
                frmLichHen f = new frmLichHen();
                f.MdiParent = this;
                f.Show();
            };
        }
    }
}