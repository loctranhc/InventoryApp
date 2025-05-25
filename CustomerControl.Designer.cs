namespace InventoryApp.Controls
{
    partial class CustomerControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnThem = new CuoreUI.Controls.cuiButton();
            btnTimKiem = new CuoreUI.Controls.cuiButton();
            label1 = new Label();
            txtTimKiem = new CuoreUI.Controls.cuiTextBox();
            dgvKhachHang = new DataGridView();
            btnSua = new CuoreUI.Controls.cuiButton();
            btnXoa = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.CheckButton = false;
            btnThem.Checked = false;
            btnThem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThem.CheckedForeColor = Color.White;
            btnThem.CheckedImageTint = Color.White;
            btnThem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThem.Content = "+ Khách Hàng Mới";
            btnThem.DialogResult = DialogResult.None;
            btnThem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThem.ForeColor = Color.White;
            btnThem.HoverBackground = SystemColors.Window;
            btnThem.HoveredImageTint = Color.White;
            btnThem.HoverForeColor = Color.Black;
            btnThem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThem.Image = null;
            btnThem.ImageAutoCenter = true;
            btnThem.ImageExpand = new Point(0, 0);
            btnThem.ImageOffset = new Point(0, 0);
            btnThem.Location = new Point(23, 115);
            btnThem.Name = "btnThem";
            btnThem.NormalBackground = Color.OrangeRed;
            btnThem.NormalForeColor = Color.White;
            btnThem.NormalImageTint = Color.White;
            btnThem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.OutlineThickness = 1F;
            btnThem.PressedBackground = Color.WhiteSmoke;
            btnThem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThem.PressedImageTint = Color.White;
            btnThem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.Rounding = new Padding(8);
            btnThem.Size = new Size(169, 34);
            btnThem.TabIndex = 19;
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.TextOffset = new Point(0, 0);
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.CheckButton = false;
            btnTimKiem.Checked = false;
            btnTimKiem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnTimKiem.CheckedForeColor = Color.White;
            btnTimKiem.CheckedImageTint = Color.White;
            btnTimKiem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnTimKiem.Content = "Tìm";
            btnTimKiem.DialogResult = DialogResult.None;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.HoverBackground = Color.White;
            btnTimKiem.HoveredImageTint = Color.White;
            btnTimKiem.HoverForeColor = Color.Black;
            btnTimKiem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnTimKiem.Image = null;
            btnTimKiem.ImageAutoCenter = true;
            btnTimKiem.ImageExpand = new Point(0, 0);
            btnTimKiem.ImageOffset = new Point(0, 0);
            btnTimKiem.Location = new Point(417, 46);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NormalBackground = Color.OrangeRed;
            btnTimKiem.NormalForeColor = Color.White;
            btnTimKiem.NormalImageTint = Color.White;
            btnTimKiem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKiem.OutlineThickness = 1F;
            btnTimKiem.PressedBackground = Color.WhiteSmoke;
            btnTimKiem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTimKiem.PressedImageTint = Color.White;
            btnTimKiem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKiem.Rounding = new Padding(8);
            btnTimKiem.Size = new Size(81, 45);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.TextAlignment = StringAlignment.Center;
            btnTimKiem.TextOffset = new Point(0, 0);
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 17;
            label1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackgroundColor = Color.White;
            txtTimKiem.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtTimKiem.Content = "";
            txtTimKiem.FocusBackgroundColor = Color.White;
            txtTimKiem.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtTimKiem.FocusImageTint = Color.White;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Image = null;
            txtTimKiem.ImageExpand = new Point(0, 0);
            txtTimKiem.ImageOffset = new Point(0, 0);
            txtTimKiem.Location = new Point(23, 46);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.NormalImageTint = Color.White;
            txtTimKiem.Padding = new Padding(15, 15, 15, 0);
            txtTimKiem.PasswordChar = false;
            txtTimKiem.PlaceholderColor = SystemColors.WindowText;
            txtTimKiem.PlaceholderText = "Nhập Số Điện Thoại hoặc Họ Tên";
            txtTimKiem.Rounding = new Padding(8);
            txtTimKiem.Size = new Size(387, 45);
            txtTimKiem.TabIndex = 16;
            txtTimKiem.TextOffset = new Size(0, 0);
            txtTimKiem.UnderlinedStyle = true;
            txtTimKiem.ContentChanged += txtTimKiem_ContentChanged;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(23, 155);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(964, 511);
            dgvKhachHang.TabIndex = 15;
            // 
            // btnSua
            // 
            btnSua.CheckButton = false;
            btnSua.Checked = false;
            btnSua.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSua.CheckedForeColor = Color.White;
            btnSua.CheckedImageTint = Color.White;
            btnSua.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSua.Content = "Sửa";
            btnSua.DialogResult = DialogResult.None;
            btnSua.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSua.ForeColor = Color.White;
            btnSua.HoverBackground = SystemColors.Window;
            btnSua.HoveredImageTint = Color.White;
            btnSua.HoverForeColor = Color.Black;
            btnSua.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSua.Image = null;
            btnSua.ImageAutoCenter = true;
            btnSua.ImageExpand = new Point(0, 0);
            btnSua.ImageOffset = new Point(0, 0);
            btnSua.Location = new Point(198, 115);
            btnSua.Name = "btnSua";
            btnSua.NormalBackground = Color.Navy;
            btnSua.NormalForeColor = Color.White;
            btnSua.NormalImageTint = Color.White;
            btnSua.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSua.OutlineThickness = 1F;
            btnSua.PressedBackground = Color.WhiteSmoke;
            btnSua.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSua.PressedImageTint = Color.White;
            btnSua.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSua.Rounding = new Padding(8);
            btnSua.Size = new Size(86, 34);
            btnSua.TabIndex = 20;
            btnSua.TextAlignment = StringAlignment.Center;
            btnSua.TextOffset = new Point(0, 0);
            btnSua.Click += btnSua_Click;
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
            btnXoa.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnXoa.ForeColor = Color.White;
            btnXoa.HoverBackground = SystemColors.Window;
            btnXoa.HoveredImageTint = Color.White;
            btnXoa.HoverForeColor = Color.Black;
            btnXoa.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnXoa.Image = null;
            btnXoa.ImageAutoCenter = true;
            btnXoa.ImageExpand = new Point(0, 0);
            btnXoa.ImageOffset = new Point(0, 0);
            btnXoa.Location = new Point(290, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.NormalBackground = Color.Red;
            btnXoa.NormalForeColor = Color.White;
            btnXoa.NormalImageTint = Color.White;
            btnXoa.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.OutlineThickness = 1F;
            btnXoa.PressedBackground = Color.WhiteSmoke;
            btnXoa.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnXoa.PressedImageTint = Color.White;
            btnXoa.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.Rounding = new Padding(8);
            btnXoa.Size = new Size(86, 34);
            btnXoa.TabIndex = 21;
            btnXoa.TextAlignment = StringAlignment.Center;
            btnXoa.TextOffset = new Point(0, 0);
            btnXoa.Click += btnXoa_Click;
            // 
            // CustomerControl
            // 
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(label1);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvKhachHang);
            Name = "CustomerControl";
            Size = new Size(1013, 692);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private CuoreUI.Controls.cuiButton btnThem;
        private CuoreUI.Controls.cuiButton btnTimKiem;
        private Label label1;
        private CuoreUI.Controls.cuiTextBox txtTimKiem;
        private DataGridView dgvKhachHang;
        private CuoreUI.Controls.cuiButton btnSua;
        private CuoreUI.Controls.cuiButton btnXoa;
    }
}