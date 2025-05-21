namespace InventoryApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // lblTitle
            this.lblTitle.Text = "Đăng nhập hệ thống";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Size = new System.Drawing.Size(250, 30);

            // lblUsername
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new System.Drawing.Point(40, 70);
            this.lblUsername.Size = new System.Drawing.Size(100, 23);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(150, 70);
            this.txtUsername.Size = new System.Drawing.Size(160, 23);

            // lblPassword
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new System.Drawing.Point(40, 110);
            this.lblPassword.Size = new System.Drawing.Size(100, 23);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 110);
            this.txtPassword.Size = new System.Drawing.Size(160, 23);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Location = new System.Drawing.Point(150, 160);
            this.btnLogin.Size = new System.Drawing.Size(80, 30);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnCancel
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Location = new System.Drawing.Point(230, 160);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Đăng nhập";
        }
    }
}
