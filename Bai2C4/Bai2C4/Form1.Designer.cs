namespace Bai2C4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblGoiTap = new Label();
            lblSoBuoi = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(171, 50);
            txtHoTen.Margin = new Padding(4, 5, 4, 5);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(284, 31);
            txtHoTen.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(171, 117);
            txtSDT.Margin = new Padding(4, 5, 4, 5);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(284, 31);
            txtSDT.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 183);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 31);
            txtEmail.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(171, 250);
            dtpNgaySinh.Margin = new Padding(4, 5, 4, 5);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(284, 31);
            dtpNgaySinh.TabIndex = 5;
            // 
            // cboGoiTap
            // 
            cboGoiTap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboGoiTap.Location = new Point(171, 317);
            cboGoiTap.Margin = new Padding(4, 5, 4, 5);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(284, 33);
            cboGoiTap.TabIndex = 3;
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(171, 383);
            numSoBuoiTuan.Margin = new Padding(4, 5, 4, 5);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(286, 31);
            numSoBuoiTuan.TabIndex = 1;
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(171, 467);
            btnDangKy.Margin = new Padding(4, 5, 4, 5);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(143, 58);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(43, 55);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(70, 25);
            lblHoTen.TabIndex = 12;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(43, 122);
            lblSDT.Margin = new Padding(4, 0, 4, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(121, 25);
            lblSDT.TabIndex = 10;
            lblSDT.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(43, 188);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(43, 255);
            lblNgaySinh.Margin = new Padding(4, 0, 4, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 25);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGoiTap
            // 
            lblGoiTap.AutoSize = true;
            lblGoiTap.Location = new Point(43, 322);
            lblGoiTap.Margin = new Padding(4, 0, 4, 0);
            lblGoiTap.Name = "lblGoiTap";
            lblGoiTap.Size = new Size(74, 25);
            lblGoiTap.TabIndex = 4;
            lblGoiTap.Text = "Gói tập:";
            // 
            // lblSoBuoi
            // 
            lblSoBuoi.AutoSize = true;
            lblSoBuoi.Location = new Point(43, 388);
            lblSoBuoi.Margin = new Padding(4, 0, 4, 0);
            lblSoBuoi.Name = "lblSoBuoi";
            lblSoBuoi.Size = new Size(120, 25);
            lblSoBuoi.TabIndex = 2;
            lblSoBuoi.Text = "Số buổi/tuần:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 583);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(lblSoBuoi);
            Controls.Add(cboGoiTap);
            Controls.Add(lblGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Hội Viên FitLife";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;

        // Khai báo nhãn (Labels)
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.Label lblSoBuoi;
    }
}