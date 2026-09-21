using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai2C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 1. Cấu hình ToolTip1 theo đúng yêu cầu
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;

            // 2. Gán nội dung chú thích (ToolTip) cho các control
            toolTip1.SetToolTip(this.txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            toolTip1.SetToolTip(this.txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            toolTip1.SetToolTip(this.cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");

            // Chọn giá trị mặc định cho ComboBox
            if (cboGoiTap.Items.Count > 0)
            {
                cboGoiTap.SelectedIndex = 0;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra TextBox rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Tổng hợp thông tin
                string hoTen = txtHoTen.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                string goiTap = cboGoiTap.SelectedItem?.ToString();
                int soBuoi = (int)numSoBuoiTuan.Value;

                string thongTin = $"Họ tên: {hoTen}\n" +
                                  $"SĐT: {sdt}\n" +
                                  $"Email: {email}\n" +
                                  $"Ngày sinh: {ngaySinh}\n" +
                                  $"Gói tập: {goiTap}\n" +
                                  $"Số buổi/tuần: {soBuoi}";

                MessageBox.Show(thongTin, "Đăng ký thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}