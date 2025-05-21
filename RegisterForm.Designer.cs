namespace InventoryApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.lblUsername.AutoSize = true;

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 27);
            this.txtUsername.Width = 180;

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.lblPassword.AutoSize = true;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 67);
            this.txtPassword.Width = 180;
            this.txtPassword.PasswordChar = '*';

            // 
            // lblConfirm
            // 
            this.lblConfirm.Text = "Xác nhận mật khẩu:";
            this.lblConfirm.Location = new System.Drawing.Point(30, 110);
            this.lblConfirm.AutoSize = true;

            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(150, 107);
            this.txtConfirm.Width = 180;
            this.txtConfirm.PasswordChar = '*';

            // 
            // btnRegister
            // 
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.Location = new System.Drawing.Point(80, 160);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Location = new System.Drawing.Point(180, 160);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblUsername, txtUsername,
                lblPassword, txtPassword,
                lblConfirm, txtConfirm,
                btnRegister, btnCancel
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
