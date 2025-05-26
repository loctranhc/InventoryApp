namespace InventoryApp
{
    partial class frmToaThuocMau
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
            dgvDonThuocMau = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            txtTenDonThuoc = new TextBox();
            label3 = new Label();
            txtThongTin = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            txtLieuDung = new TextBox();
            txtTenThuoc = new TextBox();
            btnLuuThongTin = new CuoreUI.Controls.cuiButton();
            btnXoa = new CuoreUI.Controls.cuiButton();
            dgvChiTietDon = new DataGridView();
            btnKeDon = new CuoreUI.Controls.cuiButton();
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDonThuocMau).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDon).BeginInit();
            SuspendLayout();
            // 
            // dgvDonThuocMau
            // 
            dgvDonThuocMau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonThuocMau.Location = new Point(11, 103);
            dgvDonThuocMau.Name = "dgvDonThuocMau";
            dgvDonThuocMau.Size = new Size(279, 377);
            dgvDonThuocMau.TabIndex = 0;
            dgvDonThuocMau.CellContentClick += dgvDonThuocMau_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(414, 9);
            label4.Name = "label4";
            label4.Size = new Size(191, 30);
            label4.TabIndex = 8;
            label4.Text = "ĐƠN THUỐC MẪU";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTenDonThuoc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtThongTin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLieuDung);
            panel1.Controls.Add(txtTenThuoc);
            panel1.Location = new Point(711, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 322);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 19;
            label5.Text = "Tên Đơn Thuốc";
            // 
            // txtTenDonThuoc
            // 
            txtTenDonThuoc.Location = new Point(12, 35);
            txtTenDonThuoc.Name = "txtTenDonThuoc";
            txtTenDonThuoc.Size = new Size(272, 23);
            txtTenDonThuoc.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 17;
            label3.Text = "Thông Tin";
            // 
            // txtThongTin
            // 
            txtThongTin.Location = new Point(12, 201);
            txtThongTin.Name = "txtThongTin";
            txtThongTin.Size = new Size(272, 106);
            txtThongTin.TabIndex = 16;
            txtThongTin.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 15;
            label2.Text = "Liều Dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 14;
            label1.Text = "Tên Thuốc";
            // 
            // txtLieuDung
            // 
            txtLieuDung.Location = new Point(12, 146);
            txtLieuDung.Name = "txtLieuDung";
            txtLieuDung.Size = new Size(272, 23);
            txtLieuDung.TabIndex = 13;
            txtLieuDung.TextChanged += txtLieuDung_TextChanged;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Location = new Point(12, 90);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(272, 23);
            txtTenThuoc.TabIndex = 12;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.CheckButton = false;
            btnLuuThongTin.Checked = false;
            btnLuuThongTin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLuuThongTin.CheckedForeColor = Color.White;
            btnLuuThongTin.CheckedImageTint = Color.White;
            btnLuuThongTin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLuuThongTin.Content = "Lưu";
            btnLuuThongTin.DialogResult = DialogResult.Yes;
            btnLuuThongTin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuThongTin.ForeColor = Color.White;
            btnLuuThongTin.HoverBackground = Color.White;
            btnLuuThongTin.HoveredImageTint = SystemColors.Window;
            btnLuuThongTin.HoverForeColor = Color.Black;
            btnLuuThongTin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLuuThongTin.Image = null;
            btnLuuThongTin.ImageAutoCenter = true;
            btnLuuThongTin.ImageExpand = new Point(0, 0);
            btnLuuThongTin.ImageOffset = new Point(0, 0);
            btnLuuThongTin.Location = new Point(564, 58);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.NormalBackground = Color.DarkGreen;
            btnLuuThongTin.NormalForeColor = Color.White;
            btnLuuThongTin.NormalImageTint = Color.White;
            btnLuuThongTin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLuuThongTin.OutlineThickness = 1F;
            btnLuuThongTin.PressedBackground = Color.WhiteSmoke;
            btnLuuThongTin.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLuuThongTin.PressedImageTint = Color.White;
            btnLuuThongTin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLuuThongTin.Rounding = new Padding(8);
            btnLuuThongTin.Size = new Size(66, 39);
            btnLuuThongTin.TabIndex = 20;
            btnLuuThongTin.TextAlignment = StringAlignment.Center;
            btnLuuThongTin.TextOffset = new Point(0, 0);
            // 
            // btnXoa
            // 
            btnXoa.CheckButton = false;
            btnXoa.Checked = false;
            btnXoa.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnXoa.CheckedForeColor = Color.White;
            btnXoa.CheckedImageTint = Color.White;
            btnXoa.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnXoa.Content = "Xoá";
            btnXoa.DialogResult = DialogResult.None;
            btnXoa.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.HoverBackground = Color.White;
            btnXoa.HoveredImageTint = Color.White;
            btnXoa.HoverForeColor = Color.Black;
            btnXoa.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnXoa.Image = null;
            btnXoa.ImageAutoCenter = true;
            btnXoa.ImageExpand = new Point(0, 0);
            btnXoa.ImageOffset = new Point(0, 0);
            btnXoa.Location = new Point(636, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.NormalBackground = Color.OrangeRed;
            btnXoa.NormalForeColor = Color.White;
            btnXoa.NormalImageTint = Color.White;
            btnXoa.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.OutlineThickness = 1F;
            btnXoa.PressedBackground = Color.WhiteSmoke;
            btnXoa.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnXoa.PressedImageTint = Color.White;
            btnXoa.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.Rounding = new Padding(8);
            btnXoa.Size = new Size(69, 39);
            btnXoa.TabIndex = 21;
            btnXoa.TextAlignment = StringAlignment.Center;
            btnXoa.TextOffset = new Point(0, 0);
            // 
            // dgvChiTietDon
            // 
            dgvChiTietDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDon.Location = new Point(296, 103);
            dgvChiTietDon.Name = "dgvChiTietDon";
            dgvChiTietDon.Size = new Size(409, 377);
            dgvChiTietDon.TabIndex = 22;
            // 
            // btnKeDon
            // 
            btnKeDon.CheckButton = false;
            btnKeDon.Checked = false;
            btnKeDon.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnKeDon.CheckedForeColor = Color.White;
            btnKeDon.CheckedImageTint = Color.White;
            btnKeDon.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnKeDon.Content = "Kê Thuốc";
            btnKeDon.DialogResult = DialogResult.Yes;
            btnKeDon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeDon.ForeColor = Color.White;
            btnKeDon.HoverBackground = Color.White;
            btnKeDon.HoveredImageTint = SystemColors.Window;
            btnKeDon.HoverForeColor = Color.Black;
            btnKeDon.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnKeDon.Image = null;
            btnKeDon.ImageAutoCenter = true;
            btnKeDon.ImageExpand = new Point(0, 0);
            btnKeDon.ImageOffset = new Point(0, 0);
            btnKeDon.Location = new Point(711, 386);
            btnKeDon.Name = "btnKeDon";
            btnKeDon.NormalBackground = Color.MidnightBlue;
            btnKeDon.NormalForeColor = Color.White;
            btnKeDon.NormalImageTint = Color.White;
            btnKeDon.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnKeDon.OutlineThickness = 1F;
            btnKeDon.PressedBackground = Color.WhiteSmoke;
            btnKeDon.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnKeDon.PressedImageTint = Color.White;
            btnKeDon.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnKeDon.Rounding = new Padding(8);
            btnKeDon.Size = new Size(296, 39);
            btnKeDon.TabIndex = 23;
            btnKeDon.TextAlignment = StringAlignment.Center;
            btnKeDon.TextOffset = new Point(0, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 75);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 20;
            label6.Text = "Tìm Kiếm";
            // 
            // frmToaThuocMau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 486);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(btnKeDon);
            Controls.Add(dgvChiTietDon);
            Controls.Add(btnXoa);
            Controls.Add(btnLuuThongTin);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(dgvDonThuocMau);
            Name = "frmToaThuocMau";
            Text = "frmToaThuocMau";
            ((System.ComponentModel.ISupportInitialize)dgvDonThuocMau).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDonThuocMau;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private RichTextBox txtThongTin;
        private Label label2;
        private Label label1;
        private TextBox txtLieuDung;
        private TextBox txtTenThuoc;
        private CuoreUI.Controls.cuiButton btnLuuThongTin;
        private CuoreUI.Controls.cuiButton btnXoa;
        private Label label5;
        private TextBox txtTenDonThuoc;
        private DataGridView dgvChiTietDon;
        private CuoreUI.Controls.cuiButton btnKeDon;
        private TextBox textBox1;
        private Label label6;
    }
}