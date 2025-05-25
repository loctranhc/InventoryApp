namespace InventoryApp
{
    partial class LaunchForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnDangNhap = new CuoreUI.Controls.cuiButton();
            btnDangKy = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.CheckButton = false;
            btnDangNhap.Checked = false;
            btnDangNhap.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDangNhap.CheckedForeColor = Color.White;
            btnDangNhap.CheckedImageTint = Color.White;
            btnDangNhap.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDangNhap.Content = "ĐĂNG NHẬP HỆ THỐNG";
            btnDangNhap.DialogResult = DialogResult.None;
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
            btnDangNhap.Location = new Point(143, 158);
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
            btnDangNhap.Size = new Size(266, 57);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.TextAlignment = StringAlignment.Center;
            btnDangNhap.TextOffset = new Point(0, 0);
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Transparent;
            btnDangKy.CheckButton = false;
            btnDangKy.Checked = false;
            btnDangKy.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDangKy.CheckedForeColor = Color.White;
            btnDangKy.CheckedImageTint = Color.White;
            btnDangKy.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDangKy.Content = "TẠO TÀI KHOẢN";
            btnDangKy.DialogResult = DialogResult.None;
            btnDangKy.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDangKy.ForeColor = Color.Black;
            btnDangKy.HoverBackground = Color.White;
            btnDangKy.HoveredImageTint = Color.White;
            btnDangKy.HoverForeColor = Color.Black;
            btnDangKy.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDangKy.Image = null;
            btnDangKy.ImageAutoCenter = true;
            btnDangKy.ImageExpand = new Point(0, 0);
            btnDangKy.ImageOffset = new Point(0, 0);
            btnDangKy.Location = new Point(186, 230);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.NormalBackground = Color.White;
            btnDangKy.NormalForeColor = Color.Black;
            btnDangKy.NormalImageTint = Color.White;
            btnDangKy.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangKy.OutlineThickness = 1F;
            btnDangKy.PressedBackground = Color.WhiteSmoke;
            btnDangKy.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDangKy.PressedImageTint = Color.White;
            btnDangKy.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDangKy.Rounding = new Padding(8);
            btnDangKy.Size = new Size(181, 45);
            btnDangKy.TabIndex = 3;
            btnDangKy.TextAlignment = StringAlignment.Center;
            btnDangKy.TextOffset = new Point(0, 0);
            btnDangKy.Click += btnDangKy_Click;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "X";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(509, 12);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Red;
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(32, 31);
            cuiButton1.TabIndex = 4;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // LaunchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 383);
            Controls.Add(cuiButton1);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LaunchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory App";
            ResumeLayout(false);
        }
        private CuoreUI.Controls.cuiButton btnDangNhap;
        private CuoreUI.Controls.cuiButton btnDangKy;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}
