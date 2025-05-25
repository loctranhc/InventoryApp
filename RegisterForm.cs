using InventoryApp.Session;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class RegisterForm : BaseForm
    {
        private readonly InventoryAppDbContext _dbContext;

        public RegisterForm(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void txtTenDangNhap_ContentChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Content.Trim();
            string password = txtMatKhau.Content.Trim();
            string diaChi = txtDiaChi.Content.Trim();
            string sodienthoai = txtSoDienThoai.Content.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sodienthoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var exist = _dbContext.Users.FirstOrDefault(x => x.UserName == txtTenDangNhap.Content.Trim());

            if(exist is not null)
            {
                MessageBox.Show("Vui lòng sử dụng tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Lưu thông tin người dùng vào database
            // Bạn có thể dùng EF: db.Users.Add(new User { Username = ..., Password = ... }); db.SaveChanges();
            var user = new User
            {
                UserName = txtTenDangNhap.Content.Trim(),
                HoTen = txtTenDangNhap.Content.Trim(),
                DiaChi = txtDiaChi.Content.Trim(),
                Phone = txtSoDienThoai.Content.Trim(),
                Password = PasswordHasher.HashPassword(txtMatKhau.Content.Trim())
            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            var newUser = _dbContext.Users.FirstOrDefault(x => x.Id == user.Id);
            newUser.UserNo = $"IA-{newUser.Id}";
            var lockRole = _dbContext.Roles.First(x => x.Code == "LK");
            newUser.RoleId = lockRole.Id;   
            _dbContext.SaveChanges();

            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
