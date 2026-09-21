namespace FormBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu 2: chỉ cho nhập số và Backspace
        private void OnlyDigit_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;   // chặn ký tự, không hiện vào TextBox
            }
        }

        // Yêu cầu 3: thêm dòng vào ListBox
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
            string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
            string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstSP.Items.Add($"{txtMaSP.Text} | {txtSoLuong.Text} | {txtDonGia.Text}");
        }

        // Yêu cầu 4: xóa trắng và focus về txtMaSP
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        // Yêu cầu 3, 4, 5: phím tắt toàn form
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btnThem.PerformClick();      // giả lập việc bấm nút
                    e.Handled = true;
                    break;

                case Keys.F5:
                    btnXoaTrang.PerformClick();
                    e.Handled = true;
                    break;

                case Keys.Escape:
                    var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Close();
                    }
                    break;
            }
        }
    }
}
