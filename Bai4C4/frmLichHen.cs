using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai4C4
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();

        private DateTimePicker dtpNgayGio;
        private TextBox txtTenBN;
        private ListBox lstDanhSach;

        public frmLichHen()
        {
            this.Text = "Đặt lịch hẹn - " + DateTime.Now.ToString("HH:mm:ss");
            this.Size = new Size(400, 300);

            Label lblDate = new Label() { Text = "Ngày giờ:", Location = new Point(20, 20), AutoSize = true };
            dtpNgayGio = new DateTimePicker() { Location = new Point(120, 20), Width = 200, Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm" };

            Label lblName = new Label() { Text = "Tên bệnh nhân:", Location = new Point(20, 60), AutoSize = true };
            txtTenBN = new TextBox() { Location = new Point(120, 60), Width = 200 };

            Button btnDatLich = new Button() { Text = "Đặt lịch", Location = new Point(120, 100) };
            btnDatLich.Click += BtnDatLich_Click;

            lstDanhSach = new ListBox() { Location = new Point(20, 140), Width = 340, Height = 100 };

            this.Controls.AddRange(new Control[] { lblDate, dtpNgayGio, lblName, txtTenBN, btnDatLich, lstDanhSach });
        }

        private void BtnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBN.Text)) return;

            string info = $"[{dtpNgayGio.Value.ToString("dd/MM/yyyy HH:mm")}] {txtTenBN.Text}";
            danhSachLichHen.Add(info);

            lstDanhSach.Items.Clear();
            lstDanhSach.Items.AddRange(danhSachLichHen.ToArray());

            txtTenBN.Clear();
            txtTenBN.Focus();
        }
    }
}