using System;
using System.Windows.Forms;
using InventoryApp.Session;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class LoginForm : BaseForm
    {
        private InventoryAppDbContext dbContext;
        private LaunchForm launchForm;

        public LoginForm(InventoryAppDbContext context, LaunchForm form)
        {
            InitializeComponent();
            dbContext = context;
            launchForm = form;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = dbContext.Users.FirstOrDefault(x => x.UserName.Equals(txtUsername.Content));
            if (user is null || PasswordHasher.VerifyPassword(txtPassword.Content, user.Password) == false)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user is not null)
            {
                this.Hide();
                var mainForm = new MainForm(dbContext);
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
                launchForm.Hide();

                // After successful login:
                UserSession.CurrentUser = user;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
