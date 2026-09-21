using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai4C4
{
    public partial class frmBenhNhan : Form
    {
        // Biến thành viên lưu dữ liệu độc lập cho từng phiên bản cửa sổ
        private List<string> danhSachBenhNhan = new List<string>();

        private TextBox txtHoTen;
        private NumericUpDown nudTuoi;
        private TextBox txtTrieuChung;
        private ListBox lstDanhSach;

        public frmBenhNhan()
        {
            this.Text = "Thông tin bệnh nhân - " + DateTime.Now.ToString("HH:mm:ss");
            this.Size = new Size(400, 350);

            Label lblName = new Label() { Text = "Họ tên:", Location = new Point(20, 20), AutoSize = true };
            txtHoTen = new TextBox() { Location = new Point(100, 20), Width = 200 };

            Label lblAge = new Label() { Text = "Tuổi:", Location = new Point(20, 60), AutoSize = true };
            nudTuoi = new NumericUpDown() { Location = new Point(100, 60), Width = 100, Minimum = 1, Maximum = 120 };

            Label lblSymp = new Label() { Text = "Triệu chứng:", Location = new Point(20, 100), AutoSize = true };
            txtTrieuChung = new TextBox() { Location = new Point(100, 100), Width = 200 };

            Button btnLuu = new Button() { Text = "Lưu tạm", Location = new Point(100, 140) };
            btnLuu.Click += BtnLuu_Click;

            lstDanhSach = new ListBox() { Location = new Point(20, 180), Width = 340, Height = 100 };

            this.Controls.AddRange(new Control[] { lblName, txtHoTen, lblAge, nudTuoi, lblSymp, txtTrieuChung, btnLuu, lstDanhSach });
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) return;

            string info = $"{txtHoTen.Text} - {nudTuoi.Value} tuổi - {txtTrieuChung.Text}";
            danhSachBenhNhan.Add(info);

            lstDanhSach.Items.Clear();
            lstDanhSach.Items.AddRange(danhSachBenhNhan.ToArray());

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            txtHoTen.Focus();
        }
    }
}