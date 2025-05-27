namespace InventoryApp
{
    partial class ToaThuocMauControl
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
            label6 = new Label();
            textBox1 = new TextBox();
            dgvDonThuocMau = new DataGridView();
            dgvChiTiet = new DataGridView();
            btnThem = new CuoreUI.Controls.cuiButton();
            btnThemThuoc = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            btnCapNhat = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)dgvDonThuocMau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 43);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 26;
            label6.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dgvDonThuocMau
            // 
            dgvDonThuocMau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonThuocMau.Location = new Point(14, 71);
            dgvDonThuocMau.Name = "dgvDonThuocMau";
            dgvDonThuocMau.Size = new Size(539, 377);
            dgvDonThuocMau.TabIndex = 25;
            dgvDonThuocMau.CellClick += dgvDonThuocMau_CellClick;
            dgvDonThuocMau.CellContentClick += dgvDonThuocMau_CellContentClick;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(559, 71);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(539, 377);
            dgvChiTiet.TabIndex = 28;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
            dgvChiTiet.CellFormatting += dgvChiTiet_CellFormatting_1;
            // 
            // btnThem
            // 
            btnThem.CheckButton = false;
            btnThem.Checked = false;
            btnThem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThem.CheckedForeColor = Color.White;
            btnThem.CheckedImageTint = Color.White;
            btnThem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThem.Content = "Tạo Đơn";
            btnThem.DialogResult = DialogResult.None;
            btnThem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThem.ForeColor = Color.White;
            btnThem.HoverBackground = Color.White;
            btnThem.HoveredImageTint = Color.White;
            btnThem.HoverForeColor = Color.Black;
            btnThem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThem.Image = null;
            btnThem.ImageAutoCenter = true;
            btnThem.ImageExpand = new Point(0, 0);
            btnThem.ImageOffset = new Point(0, 0);
            btnThem.Location = new Point(460, 21);
            btnThem.Name = "btnThem";
            btnThem.NormalBackground = Color.ForestGreen;
            btnThem.NormalForeColor = Color.White;
            btnThem.NormalImageTint = Color.White;
            btnThem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.OutlineThickness = 1F;
            btnThem.PressedBackground = Color.WhiteSmoke;
            btnThem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThem.PressedImageTint = Color.White;
            btnThem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.Rounding = new Padding(8);
            btnThem.Size = new Size(93, 45);
            btnThem.TabIndex = 29;
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.TextOffset = new Point(0, 0);
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
            btnThemThuoc.Location = new Point(891, 21);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.NormalBackground = SystemColors.HotTrack;
            btnThemThuoc.NormalForeColor = Color.White;
            btnThemThuoc.NormalImageTint = Color.White;
            btnThemThuoc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.OutlineThickness = 1F;
            btnThemThuoc.PressedBackground = Color.WhiteSmoke;
            btnThemThuoc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThemThuoc.PressedImageTint = Color.White;
            btnThemThuoc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.Rounding = new Padding(8);
            btnThemThuoc.Size = new Size(109, 45);
            btnThemThuoc.TabIndex = 30;
            btnThemThuoc.TextAlignment = StringAlignment.Center;
            btnThemThuoc.TextOffset = new Point(0, 0);
            // 
            // cuiButton2
            // 
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Xoá";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(1005, 20);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.Red;
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(93, 45);
            cuiButton2.TabIndex = 31;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // btnCapNhat
            // 
            btnCapNhat.CheckButton = false;
            btnCapNhat.Checked = false;
            btnCapNhat.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCapNhat.CheckedForeColor = Color.White;
            btnCapNhat.CheckedImageTint = Color.White;
            btnCapNhat.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCapNhat.Content = "LƯU TOA THUỐC";
            btnCapNhat.DialogResult = DialogResult.None;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.HoverBackground = Color.White;
            btnCapNhat.HoveredImageTint = Color.White;
            btnCapNhat.HoverForeColor = Color.Black;
            btnCapNhat.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCapNhat.Image = null;
            btnCapNhat.ImageAutoCenter = true;
            btnCapNhat.ImageExpand = new Point(0, 0);
            btnCapNhat.ImageOffset = new Point(0, 0);
            btnCapNhat.Location = new Point(927, 454);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.NormalBackground = Color.MediumVioletRed;
            btnCapNhat.NormalForeColor = Color.White;
            btnCapNhat.NormalImageTint = Color.White;
            btnCapNhat.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCapNhat.OutlineThickness = 1F;
            btnCapNhat.PressedBackground = Color.WhiteSmoke;
            btnCapNhat.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCapNhat.PressedImageTint = Color.White;
            btnCapNhat.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCapNhat.Rounding = new Padding(8);
            btnCapNhat.Size = new Size(171, 79);
            btnCapNhat.TabIndex = 32;
            btnCapNhat.TextAlignment = StringAlignment.Center;
            btnCapNhat.TextOffset = new Point(0, 0);
            // 
            // ToaThuocMauControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnCapNhat);
            Controls.Add(cuiButton2);
            Controls.Add(btnThemThuoc);
            Controls.Add(btnThem);
            Controls.Add(dgvChiTiet);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(dgvDonThuocMau);
            Name = "ToaThuocMauControl";
            Size = new Size(1115, 550);
            ((System.ComponentModel.ISupportInitialize)dgvDonThuocMau).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox1;
        private DataGridView dgvDonThuocMau;
        private DataGridView dgvChiTiet;
        private CuoreUI.Controls.cuiButton btnThem;
        private CuoreUI.Controls.cuiButton btnThemThuoc;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton btnCapNhat;
    }
}
