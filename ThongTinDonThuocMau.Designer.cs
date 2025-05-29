namespace InventoryApp
{
    partial class ThongTinDonThuocMau
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
            txtTenDonThuoc = new TextBox();
            label1 = new Label();
            dgvDonThuoc = new DataGridView();
            label2 = new Label();
            txtTimKiemThuoc = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            txtSoLuong = new TextBox();
            label3 = new Label();
            txtLieuDung = new TextBox();
            richTextBox1 = new RichTextBox();
            btnThemThuoc = new CuoreUI.Controls.cuiButton();
            btnLuuThongTin = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)dgvDonThuoc).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTenDonThuoc
            // 
            txtTenDonThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDonThuoc.Location = new Point(12, 34);
            txtTenDonThuoc.Name = "txtTenDonThuoc";
            txtTenDonThuoc.Size = new Size(437, 29);
            txtTenDonThuoc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên Đơn Thuốc";
            // 
            // dgvDonThuoc
            // 
            dgvDonThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonThuoc.Location = new Point(12, 72);
            dgvDonThuoc.Name = "dgvDonThuoc";
            dgvDonThuoc.Size = new Size(643, 451);
            dgvDonThuoc.TabIndex = 4;
            dgvDonThuoc.CellClick += dgvDonThuoc_CellClick;
            dgvDonThuoc.CellContentClick += dgvDonThuoc_CellContentClick;
            dgvDonThuoc.CellFormatting += dgvDonThuoc_CellFormatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(660, 10);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 6;
            label2.Text = "Tìm Kiếm Thuốc";
            // 
            // txtTimKiemThuoc
            // 
            txtTimKiemThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiemThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiemThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemThuoc.Location = new Point(661, 34);
            txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            txtTimKiemThuoc.Size = new Size(296, 29);
            txtTimKiemThuoc.TabIndex = 5;
            txtTimKiemThuoc.TextChanged += txtTimKiemThuoc_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLieuDung);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(btnThemThuoc);
            panel1.Location = new Point(661, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 395);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(3, 279);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 12;
            label4.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(3, 304);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(290, 27);
            txtSoLuong.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 222);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 9;
            label3.Text = "Liều Dùng";
            // 
            // txtLieuDung
            // 
            txtLieuDung.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLieuDung.Location = new Point(3, 247);
            txtLieuDung.Name = "txtLieuDung";
            txtLieuDung.Size = new Size(290, 27);
            txtLieuDung.TabIndex = 11;
            txtLieuDung.TextChanged += txtLieuDung_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(290, 213);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.CheckButton = false;
            btnThemThuoc.Checked = false;
            btnThemThuoc.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThemThuoc.CheckedForeColor = Color.White;
            btnThemThuoc.CheckedImageTint = Color.White;
            btnThemThuoc.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThemThuoc.Content = "Thêm Thuốc";
            btnThemThuoc.DialogResult = DialogResult.None;
            btnThemThuoc.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThemThuoc.ForeColor = Color.White;
            btnThemThuoc.HoverBackground = Color.White;
            btnThemThuoc.HoveredImageTint = Color.White;
            btnThemThuoc.HoverForeColor = Color.Black;
            btnThemThuoc.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThemThuoc.Image = null;
            btnThemThuoc.ImageAutoCenter = true;
            btnThemThuoc.ImageExpand = new Point(0, 0);
            btnThemThuoc.ImageOffset = new Point(0, 0);
            btnThemThuoc.Location = new Point(146, 344);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.NormalBackground = Color.Green;
            btnThemThuoc.NormalForeColor = Color.White;
            btnThemThuoc.NormalImageTint = Color.White;
            btnThemThuoc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.OutlineThickness = 1F;
            btnThemThuoc.PressedBackground = Color.WhiteSmoke;
            btnThemThuoc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThemThuoc.PressedImageTint = Color.White;
            btnThemThuoc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.Rounding = new Padding(8);
            btnThemThuoc.Size = new Size(145, 40);
            btnThemThuoc.TabIndex = 9;
            btnThemThuoc.TextAlignment = StringAlignment.Center;
            btnThemThuoc.TextOffset = new Point(0, 0);
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.CheckButton = false;
            btnLuuThongTin.Checked = false;
            btnLuuThongTin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLuuThongTin.CheckedForeColor = Color.White;
            btnLuuThongTin.CheckedImageTint = Color.White;
            btnLuuThongTin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLuuThongTin.Content = "Lưu Thông Tin";
            btnLuuThongTin.DialogResult = DialogResult.None;
            btnLuuThongTin.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnLuuThongTin.ForeColor = Color.White;
            btnLuuThongTin.HoverBackground = Color.White;
            btnLuuThongTin.HoveredImageTint = Color.White;
            btnLuuThongTin.HoverForeColor = Color.Black;
            btnLuuThongTin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLuuThongTin.Image = null;
            btnLuuThongTin.ImageAutoCenter = true;
            btnLuuThongTin.ImageExpand = new Point(0, 0);
            btnLuuThongTin.ImageOffset = new Point(0, 0);
            btnLuuThongTin.Location = new Point(660, 476);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.NormalBackground = Color.OrangeRed;
            btnLuuThongTin.NormalForeColor = Color.White;
            btnLuuThongTin.NormalImageTint = Color.White;
            btnLuuThongTin.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLuuThongTin.OutlineThickness = 1F;
            btnLuuThongTin.PressedBackground = Color.WhiteSmoke;
            btnLuuThongTin.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLuuThongTin.PressedImageTint = Color.White;
            btnLuuThongTin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLuuThongTin.Rounding = new Padding(8);
            btnLuuThongTin.Size = new Size(297, 47);
            btnLuuThongTin.TabIndex = 8;
            btnLuuThongTin.TextAlignment = StringAlignment.Center;
            btnLuuThongTin.TextOffset = new Point(0, 0);
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // ThongTinDonThuocMau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 535);
            Controls.Add(btnLuuThongTin);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtTimKiemThuoc);
            Controls.Add(dgvDonThuoc);
            Controls.Add(label1);
            Controls.Add(txtTenDonThuoc);
            Name = "ThongTinDonThuocMau";
            Text = "ThongTinDonThuocMau";
            Load += ThongTinDonThuocMau_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonThuoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDonThuoc;
        private Label label1;
        private DataGridView dgvDonThuoc;
        private Label label2;
        private TextBox txtTimKiemThuoc;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private CuoreUI.Controls.cuiButton btnThemThuoc;
        private CuoreUI.Controls.cuiButton btnLuuThongTin;
        private Label label3;
        private TextBox txtLieuDung;
        private Label label4;
        private TextBox txtSoLuong;
    }
}