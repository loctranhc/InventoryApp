namespace InventoryApp
{
    partial class HoaDonToaThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            lblTenNhanVien = new Label();
            lblTenKhachHang = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 438);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(480, 109);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(696, 438);
            dataGridView2.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(94, 52);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(380, 35);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 3;
            label1.Text = "Nhập mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 16);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 8;
            label2.Text = "Tìm kiếm theo mã";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 29);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTenNhanVien);
            panel1.Controls.Add(lblTenKhachHang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(483, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 90);
            panel1.TabIndex = 9;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenNhanVien.Location = new Point(198, 52);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(85, 21);
            lblTenNhanVien.TabIndex = 3;
            lblTenNhanVien.Text = "Họ và Tên";
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenKhachHang.Location = new Point(198, 12);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(85, 21);
            lblTenKhachHang.TabIndex = 2;
            lblTenKhachHang.Text = "Họ và Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(90, 12);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 1;
            label4.Text = "Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 52);
            label3.Name = "label3";
            label3.Size = new Size(173, 21);
            label3.TabIndex = 0;
            label3.Text = "Nhân Viên Bán Hàng:";
            // 
            // HoaDonToaThuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(txtTimKiem);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "HoaDonToaThuoc";
            Size = new Size(1194, 579);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox txtTimKiem;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label lblTenNhanVien;
        private Label lblTenKhachHang;
        private Label label4;
        private Label label3;
    }
}
