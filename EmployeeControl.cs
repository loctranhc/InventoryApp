using System;
using System.Linq;
using System.Windows.Forms;
using InventoryApp.Data;

namespace InventoryApp
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
            //LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var db = new InventoryDbContext())
            {
                var employees = db.Users
                                  .Select(u => new
                                  {
                                      u.UserId,
                                      u.Username,
                                      u.FullName,
                                      u.Role
                                  })
                                  .ToList();

                dgvEmployees.DataSource = employees;
            }

            dgvEmployees.Columns["Id"].Visible = false;
            dgvEmployees.Columns["Username"].HeaderText = "Tên đăng nhập";
            dgvEmployees.Columns["FullName"].HeaderText = "Họ tên";
            dgvEmployees.Columns["Role"].HeaderText = "Vai trò";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                MessageBox.Show("Chức năng Sửa đang được phát triển.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int userId = (int)dgvEmployees.CurrentRow.Cells["Id"].Value;
                    using (var db = new InventoryDbContext())
                    {
                        var user = db.Users.Find(userId);
                        if (user != null)
                        {
                            db.Users.Remove(user);
                            db.SaveChanges();
                            LoadEmployees();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            }
        }
    }
}
