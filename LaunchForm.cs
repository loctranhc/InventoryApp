using MigrateDatabase;

namespace InventoryApp
{
    public partial class LaunchForm : BaseForm
    {
        private readonly InventoryAppDbContext _dbContext;
        public LaunchForm(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(_dbContext, this);
            loginForm.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_dbContext);
            registerForm.Show();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
