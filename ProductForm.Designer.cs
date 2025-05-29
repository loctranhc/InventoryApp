namespace InventoryApp
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenHang = new TextBox();
            txtSoLuongNhap = new TextBox();
            txtDonViTinh = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtGiaVon = new TextBox();
            label6 = new Label();
            txtGiaNhap = new TextBox();
            label7 = new Label();
            txtGiaBan = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTenHang
            // 
            txtTenHang.Font = new Font("Segoe UI", 11.25F);
            txtTenHang.Location = new Point(32, 53);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(438, 27);
            txtTenHang.TabIndex = 1;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Font = new Font("Segoe UI", 11.25F);
            txtSoLuongNhap.Location = new Point(32, 166);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(438, 27);
            txtSoLuongNhap.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 11.25F);
            txtDonViTinh.Location = new Point(32, 107);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(438, 27);
            txtDonViTinh.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(32, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(32, 88);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(32, 147);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Số Lượng Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(32, 275);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Giá Vốn";
            // 
            // txtGiaVon
            // 
            txtGiaVon.Font = new Font("Segoe UI", 11.25F);
            txtGiaVon.Location = new Point(32, 294);
            txtGiaVon.Name = "txtGiaVon";
            txtGiaVon.Size = new Size(438, 27);
            txtGiaVon.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(30, 330);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 11;
            label6.Text = "Giá Nhập";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI", 11.25F);
            txtGiaNhap.Location = new Point(30, 349);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(438, 27);
            txtGiaNhap.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(30, 388);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 13;
            label7.Text = "Giá Bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 11.25F);
            txtGiaBan.Location = new Point(30, 407);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(438, 27);
            txtGiaBan.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(316, 453);
            button1.Name = "button1";
            button1.Size = new Size(152, 42);
            button1.TabIndex = 14;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(438, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(32, 207);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 16;
            label1.Text = "Danh Mục Hàng";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 530);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtGiaBan);
            Controls.Add(label6);
            Controls.Add(txtGiaNhap);
            Controls.Add(label5);
            Controls.Add(txtGiaVon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoLuongNhap);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtTenHang);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTenHang;
        private TextBox txtSoLuongNhap;
        private TextBox txtDonViTinh;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGiaVon;
        private Label label6;
        private TextBox txtGiaNhap;
        private Label label7;
        private TextBox txtGiaBan;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}