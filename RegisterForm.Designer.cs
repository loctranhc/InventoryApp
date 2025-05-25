namespace InventoryApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnDangKy = new CuoreUI.Controls.cuiButton();
            txtTenDangNhap = new CuoreUI.Controls.cuiTextBox();
            txtMatKhau = new CuoreUI.Controls.cuiTextBox();
            txtDiaChi = new CuoreUI.Controls.cuiTextBox();
            txtSoDienThoai = new CuoreUI.Controls.cuiTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.CheckButton = false;
            btnDangKy.Checked = false;
            btnDangKy.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDangKy.CheckedForeColor = Color.White;
            btnDangKy.CheckedImageTint = Color.White;
            btnDangKy.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDangKy.Content = "ĐĂNG KÝ TÀI KHOẢN";
            btnDangKy.DialogResult = DialogResult.None;
            btnDangKy.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.HoverBackground = Color.White;
            btnDangKy.HoveredImageTint = Color.White;
            btnDangKy.HoverForeColor = Color.Black;
            btnDangKy.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDangKy.Image = null;
            btnDangKy.ImageAutoCenter = true;
            btnDangKy.ImageExpand = new Point(0, 0);
            btnDangKy.ImageOffset = new Point(0, 0);
            btnDangKy.Location = new Point(150, 390);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.NormalBackground = Color.OrangeRed;
            btnDangKy.NormalForeColor = Color.White;
            btnDangKy.NormalImageTint = Color.White;
            btnDangKy.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangKy.OutlineThickness = 1F;
            btnDangKy.PressedBackground = Color.WhiteSmoke;
            btnDangKy.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDangKy.PressedImageTint = Color.White;
            btnDangKy.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangKy.Rounding = new Padding(8);
            btnDangKy.Size = new Size(206, 45);
            btnDangKy.TabIndex = 8;
            btnDangKy.TextAlignment = StringAlignment.Center;
            btnDangKy.TextOffset = new Point(0, 0);
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackgroundColor = Color.White;
            txtTenDangNhap.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtTenDangNhap.Content = "";
            txtTenDangNhap.FocusBackgroundColor = Color.White;
            txtTenDangNhap.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtTenDangNhap.FocusImageTint = Color.White;
            txtTenDangNhap.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = Color.Gray;
            txtTenDangNhap.Image = null;
            txtTenDangNhap.ImageExpand = new Point(0, 0);
            txtTenDangNhap.ImageOffset = new Point(0, 0);
            txtTenDangNhap.Location = new Point(80, 142);
            txtTenDangNhap.Margin = new Padding(4);
            txtTenDangNhap.Multiline = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.NormalImageTint = Color.White;
            txtTenDangNhap.Padding = new Padding(15, 15, 15, 0);
            txtTenDangNhap.PasswordChar = false;
            txtTenDangNhap.PlaceholderColor = SystemColors.WindowText;
            txtTenDangNhap.PlaceholderText = "Tên Đăng Nhập";
            txtTenDangNhap.Rounding = new Padding(8);
            txtTenDangNhap.Size = new Size(350, 45);
            txtTenDangNhap.TabIndex = 9;
            txtTenDangNhap.TextOffset = new Size(0, 0);
            txtTenDangNhap.UnderlinedStyle = true;
            txtTenDangNhap.ContentChanged += txtTenDangNhap_ContentChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackgroundColor = Color.White;
            txtMatKhau.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtMatKhau.Content = "";
            txtMatKhau.FocusBackgroundColor = Color.White;
            txtMatKhau.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtMatKhau.FocusImageTint = Color.White;
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.Image = null;
            txtMatKhau.ImageExpand = new Point(0, 0);
            txtMatKhau.ImageOffset = new Point(0, 0);
            txtMatKhau.Location = new Point(80, 195);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.NormalImageTint = Color.White;
            txtMatKhau.Padding = new Padding(15, 15, 15, 0);
            txtMatKhau.PasswordChar = true;
            txtMatKhau.PlaceholderColor = SystemColors.WindowText;
            txtMatKhau.PlaceholderText = "Mật Khẩu";
            txtMatKhau.Rounding = new Padding(8);
            txtMatKhau.Size = new Size(350, 45);
            txtMatKhau.TabIndex = 10;
            txtMatKhau.TextOffset = new Size(0, 0);
            txtMatKhau.UnderlinedStyle = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackgroundColor = Color.White;
            txtDiaChi.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtDiaChi.Content = "";
            txtDiaChi.FocusBackgroundColor = Color.White;
            txtDiaChi.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtDiaChi.FocusImageTint = Color.White;
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = Color.Gray;
            txtDiaChi.Image = null;
            txtDiaChi.ImageExpand = new Point(0, 0);
            txtDiaChi.ImageOffset = new Point(0, 0);
            txtDiaChi.Location = new Point(80, 248);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Multiline = false;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.NormalImageTint = Color.White;
            txtDiaChi.Padding = new Padding(15, 15, 15, 0);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = SystemColors.WindowText;
            txtDiaChi.PlaceholderText = "Địa Chỉ";
            txtDiaChi.Rounding = new Padding(8);
            txtDiaChi.Size = new Size(350, 45);
            txtDiaChi.TabIndex = 11;
            txtDiaChi.TextOffset = new Size(0, 0);
            txtDiaChi.UnderlinedStyle = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackgroundColor = Color.White;
            txtSoDienThoai.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtSoDienThoai.Content = "";
            txtSoDienThoai.FocusBackgroundColor = Color.White;
            txtSoDienThoai.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtSoDienThoai.FocusImageTint = Color.White;
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.ForeColor = Color.Gray;
            txtSoDienThoai.Image = null;
            txtSoDienThoai.ImageExpand = new Point(0, 0);
            txtSoDienThoai.ImageOffset = new Point(0, 0);
            txtSoDienThoai.Location = new Point(80, 301);
            txtSoDienThoai.Margin = new Padding(4);
            txtSoDienThoai.Multiline = false;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.NormalImageTint = Color.White;
            txtSoDienThoai.Padding = new Padding(15, 15, 15, 0);
            txtSoDienThoai.PasswordChar = false;
            txtSoDienThoai.PlaceholderColor = SystemColors.WindowText;
            txtSoDienThoai.PlaceholderText = "Số Điện Thoại";
            txtSoDienThoai.Rounding = new Padding(8);
            txtSoDienThoai.Size = new Size(350, 45);
            txtSoDienThoai.TabIndex = 12;
            txtSoDienThoai.TextOffset = new Size(0, 0);
            txtSoDienThoai.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 66);
            label1.Name = "label1";
            label1.Size = new Size(305, 40);
            label1.TabIndex = 13;
            label1.Text = "ĐĂNG KÝ HỆ THỐNG";
            // 
            // RegisterForm
            // 
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(510, 501);
            Controls.Add(label1);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnDangKy);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }
        private CuoreUI.Controls.cuiButton btnDangKy;
        private CuoreUI.Controls.cuiTextBox txtTenDangNhap;
        private CuoreUI.Controls.cuiTextBox txtMatKhau;
        private CuoreUI.Controls.cuiTextBox txtDiaChi;
        private CuoreUI.Controls.cuiTextBox txtSoDienThoai;
        private Label label1;
    }
}
