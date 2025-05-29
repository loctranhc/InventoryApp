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
            btnSuaToaThuoc = new CuoreUI.Controls.cuiButton();
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
            btnThem.Content = "Tạo Toa Thuốc";
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
            btnThem.Location = new Point(830, 20);
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
            btnThem.Size = new Size(137, 45);
            btnThem.TabIndex = 29;
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.TextOffset = new Point(0, 0);
            btnThem.Click += btnThem_Click;
            // 
            // btnSuaToaThuoc
            // 
            btnSuaToaThuoc.CheckButton = false;
            btnSuaToaThuoc.Checked = false;
            btnSuaToaThuoc.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSuaToaThuoc.CheckedForeColor = Color.White;
            btnSuaToaThuoc.CheckedImageTint = Color.White;
            btnSuaToaThuoc.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSuaToaThuoc.Content = "Sửa Toa Thuốc";
            btnSuaToaThuoc.DialogResult = DialogResult.None;
            btnSuaToaThuoc.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSuaToaThuoc.ForeColor = Color.White;
            btnSuaToaThuoc.HoverBackground = Color.White;
            btnSuaToaThuoc.HoveredImageTint = Color.White;
            btnSuaToaThuoc.HoverForeColor = Color.Black;
            btnSuaToaThuoc.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSuaToaThuoc.Image = null;
            btnSuaToaThuoc.ImageAutoCenter = true;
            btnSuaToaThuoc.ImageExpand = new Point(0, 0);
            btnSuaToaThuoc.ImageOffset = new Point(0, 0);
            btnSuaToaThuoc.Location = new Point(973, 19);
            btnSuaToaThuoc.Name = "btnSuaToaThuoc";
            btnSuaToaThuoc.NormalBackground = SystemColors.HotTrack;
            btnSuaToaThuoc.NormalForeColor = Color.White;
            btnSuaToaThuoc.NormalImageTint = Color.White;
            btnSuaToaThuoc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSuaToaThuoc.OutlineThickness = 1F;
            btnSuaToaThuoc.PressedBackground = Color.WhiteSmoke;
            btnSuaToaThuoc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSuaToaThuoc.PressedImageTint = Color.White;
            btnSuaToaThuoc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSuaToaThuoc.Rounding = new Padding(8);
            btnSuaToaThuoc.Size = new Size(125, 45);
            btnSuaToaThuoc.TabIndex = 30;
            btnSuaToaThuoc.TextAlignment = StringAlignment.Center;
            btnSuaToaThuoc.TextOffset = new Point(0, 0);
            btnSuaToaThuoc.Click += btnSuaToaThuoc_Click;
            // 
            // ToaThuocMauControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnSuaToaThuoc);
            Controls.Add(btnThem);
            Controls.Add(dgvChiTiet);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(dgvDonThuocMau);
            Name = "ToaThuocMauControl";
            Size = new Size(1115, 473);
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
        private CuoreUI.Controls.cuiButton btnSuaToaThuoc;
    }
}
