namespace InventoryApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new CuoreUI.Controls.cuiTextBox();
            txtPassword = new CuoreUI.Controls.cuiTextBox();
            btnDangNhap = new CuoreUI.Controls.cuiButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackgroundColor = Color.White;
            txtUsername.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtUsername.Content = "";
            txtUsername.FocusBackgroundColor = Color.White;
            txtUsername.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtUsername.FocusImageTint = Color.White;
            txtUsername.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Image = null;
            txtUsername.ImageExpand = new Point(0, 0);
            txtUsername.ImageOffset = new Point(0, 0);
            txtUsername.Location = new Point(13, 146);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.NormalImageTint = Color.White;
            txtUsername.Padding = new Padding(15, 18, 15, 0);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = SystemColors.WindowText;
            txtUsername.PlaceholderText = "Tên Đăng Nhập";
            txtUsername.Rounding = new Padding(8);
            txtUsername.Size = new Size(457, 50);
            txtUsername.TabIndex = 7;
            txtUsername.TextOffset = new Size(0, 0);
            txtUsername.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackgroundColor = Color.White;
            txtPassword.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtPassword.FocusImageTint = Color.White;
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.Location = new Point(13, 217);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.Padding = new Padding(15, 18, 15, 0);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = SystemColors.WindowText;
            txtPassword.PlaceholderText = "Mật Khẩu";
            txtPassword.Rounding = new Padding(8);
            txtPassword.Size = new Size(457, 50);
            txtPassword.TabIndex = 8;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.CheckButton = false;
            btnDangNhap.Checked = false;
            btnDangNhap.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDangNhap.CheckedForeColor = Color.White;
            btnDangNhap.CheckedImageTint = Color.White;
            btnDangNhap.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDangNhap.Content = "ĐĂNG NHẬP";
            btnDangNhap.DialogResult = DialogResult.OK;
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.HoverBackground = Color.White;
            btnDangNhap.HoveredImageTint = Color.White;
            btnDangNhap.HoverForeColor = Color.Black;
            btnDangNhap.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDangNhap.Image = null;
            btnDangNhap.ImageAutoCenter = true;
            btnDangNhap.ImageExpand = new Point(0, 0);
            btnDangNhap.ImageOffset = new Point(0, 0);
            btnDangNhap.Location = new Point(135, 304);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.NormalBackground = Color.OrangeRed;
            btnDangNhap.NormalForeColor = Color.White;
            btnDangNhap.NormalImageTint = Color.White;
            btnDangNhap.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangNhap.OutlineThickness = 1F;
            btnDangNhap.PressedBackground = Color.WhiteSmoke;
            btnDangNhap.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDangNhap.PressedImageTint = Color.White;
            btnDangNhap.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangNhap.Rounding = new Padding(8);
            btnDangNhap.Size = new Size(212, 45);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.TextAlignment = StringAlignment.Center;
            btnDangNhap.TextOffset = new Point(0, 0);
            btnDangNhap.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 77);
            label1.Name = "label1";
            label1.Size = new Size(351, 40);
            label1.TabIndex = 10;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // LoginForm
            // 
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(483, 432);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory App";
            ResumeLayout(false);
            PerformLayout();
        }
        private CuoreUI.Controls.cuiTextBox txtUsername;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private CuoreUI.Controls.cuiButton btnDangNhap;
        private Label label1;
    }
}
