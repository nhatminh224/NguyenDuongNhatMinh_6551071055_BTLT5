namespace Bai3C4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCongViecMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
            }
        }

        private void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void đánhDấuHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    lstCongViec.Items[lstCongViec.SelectedIndex] = "[Hoàn thành] " + congViec;
                }
            }
        }

        private void xóaCôngViệcNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xóaTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả công việc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

