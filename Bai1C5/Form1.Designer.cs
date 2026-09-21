namespace FormBanHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstSP = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(163, 22);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(325, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(163, 72);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(325, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.KeyPress += OnlyDigit_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(163, 128);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(325, 27);
            txtDonGia.TabIndex = 1;
            txtDonGia.KeyPress += OnlyDigit_KeyPress;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(129, 205);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.FromArgb(255, 128, 128);
            btnXoaTrang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTrang.Location = new Point(298, 205);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(118, 40);
            btnXoaTrang.TabIndex = 2;
            btnXoaTrang.Text = "Xóa Trang";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstSP
            // 
            lstSP.FormattingEnabled = true;
            lstSP.Location = new Point(546, 39);
            lstSP.Name = "lstSP";
            lstSP.Size = new Size(242, 224);
            lstSP.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 72);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 131);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 9);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 4;
            label4.Text = "Danh sách sản phẩm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lstSP);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstSP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
