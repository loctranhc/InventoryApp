using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.VisualBasic.ApplicationServices;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class EmployeeForm : Form
    {
        private InventoryAppDbContext dbContext;
        private MigrateDatabase.Models.User modifyUser;

        public EmployeeForm(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;
            cbxGioiTinh.Items.Clear();
            cbxGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbxGioiTinh.SelectedIndex = 0;
        }

        public EmployeeForm(InventoryAppDbContext context, MigrateDatabase.Models.User user)
        {
            InitializeComponent();
            dbContext = context;
            cbxGioiTinh.Items.Clear();
            cbxGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbxGioiTinh.Text = user.GioiTinh;

            txtFullName.Text = user.HoTen;
            txtDiaChi.Text = user.DiaChi;
            txtEmail.Text = user.Email;
            txtMatKhau.Text = user.Password;
            txtPhone.Text = user.Phone;
            txtUsername.Text = user.UserName;
            modifyUser = user;
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                return false;
            if (string.IsNullOrWhiteSpace(cbxGioiTinh.Text))
                return false;

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (modifyUser != null)
            {
                if (modifyUser.UserNo == "IA-1")
                {
                    MessageBox.Show("Không được phép chỉnh sửa nhân viên mặc định.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var userEdit = dbContext.Users.FirstOrDefault(x => x.UserNo == modifyUser.UserNo);
                userEdit.UserName = txtUsername.Text;
                userEdit.HoTen = txtFullName.Text;
                userEdit.Email = txtEmail.Text;
                userEdit.Phone = txtPhone.Text;
                userEdit.DiaChi = txtDiaChi.Text;
                userEdit.Password = PasswordHasher.HashPassword(txtMatKhau.Text);
                userEdit.GioiTinh = cbxGioiTinh.Text;
                dbContext.SaveChanges();
                MessageBox.Show("Đã lưu thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            MigrateDatabase.Models.User user = new MigrateDatabase.Models.User();
            user.UserName = txtUsername.Text;
            user.HoTen = txtFullName.Text;
            user.Email = txtEmail.Text;
            user.DiaChi = txtDiaChi.Text;
            user.Phone = txtPhone.Text;
            user.Password = PasswordHasher.HashPassword(txtMatKhau.Text);
            user.GioiTinh = cbxGioiTinh.Text;
            user.NgaySinh = DateTime.Now;
            user.RoleId = 1;

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            var newUser = dbContext.Users.FirstOrDefault(x => x.Id == user.Id);
            user.UserNo = $"IA-{newUser.Id}";
            dbContext.SaveChanges();

            // TODO: Thêm logic lưu dữ liệu vào database tại đây
            MessageBox.Show("Đã lưu thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
