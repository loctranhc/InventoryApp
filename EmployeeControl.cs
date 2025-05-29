using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MigrateDatabase;
using MigrateDatabase.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryApp
{
    public partial class EmployeeControl : UserControl
    {
        private InventoryAppDbContext dbContext;

        public EmployeeControl(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;
            var usersWithRoles = from u in dbContext.Users
                                 join r in dbContext.Roles on u.RoleId equals r.Id
                                 select new
                                 {
                                     u.Id,
                                     u.UserNo,
                                     u.UserName,
                                     HoTen = u.HoTen,
                                     RoleName = r.Name,
                                     Phone = u.Phone,
                                     DiaChi = u.DiaChi,
                                 };

            LoadEmployees(usersWithRoles.ToList());
        }

        private void LoadEmployees(object users)
        {
            dgvEmployees.DataSource = users;
            dgvEmployees.Columns["Id"].Visible = false;
            dgvEmployees.Columns["UserNo"].Visible = false;
            dgvEmployees.Columns["UserName"].HeaderText = "Tên đăng nhập";
            dgvEmployees.Columns["HoTen"].HeaderText = "Họ tên";
            dgvEmployees.Columns["Phone"].HeaderText = "Số Điện Thoại";
            dgvEmployees.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvEmployees.Columns["RoleName"].HeaderText = "Vai trò";

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AutoGenerateColumns = true;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvEmployees, new object[] { true });

            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvEmployees.GridColor = Color.LightGray;
            dgvEmployees.BackgroundColor = Color.White;
        }

        private void LoadAll()
        {
            var usersWithRoles = from u in dbContext.Users
                                 join r in dbContext.Roles on u.RoleId equals r.Id
                                 select new
                                 {
                                     u.Id,
                                     u.UserNo,
                                     u.UserName,
                                     HoTen = u.HoTen,
                                     RoleName = r.Name,
                                     Phone = u.Phone,
                                     DiaChi = u.DiaChi,
                                 };
            LoadEmployees(usersWithRoles.ToList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EmployeeForm(dbContext);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var employee = dbContext.Users.Where(x => x.HoTen.ToLower().Contains(txtTimKiem.Text.Trim()) || x.UserNo.ToLower().Contains(txtTimKiem.Text.Trim()) || x.UserName.ToLower().Contains(txtTimKiem.Text.Trim()));
            if (employee != null)
            {
                LoadEmployees(employee.ToList());
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var employee = dbContext.Users.Where(x => x.HoTen.ToLower().Contains(txtTimKiem.Text.Trim()) || x.UserNo.ToLower().Contains(txtTimKiem.Text.Trim()) || x.UserName.ToLower().Contains(txtTimKiem.Text.Trim()));
            if (employee != null)
            {
                LoadEmployees(employee.ToList());
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(dbContext);
            if (form.ShowDialog() == DialogResult.OK) LoadAll();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                var ma = selectedRow.Cells["UserNo"].Value?.ToString();

                if (string.IsNullOrEmpty(ma)) return;

                var user = dbContext.Users.FirstOrDefault(x => x.UserNo == ma);
                if (user is not null)
                {
                    EmployeeForm form = new EmployeeForm(dbContext, user);
                    if (form.ShowDialog() == DialogResult.OK) LoadAll();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                var ma = selectedRow.Cells["UserNo"].Value?.ToString();

                if (string.IsNullOrEmpty(ma)) return;

                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này?",
                                              "Xác nhận xoá",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.No) return;

                var user = dbContext.Users.FirstOrDefault(x => x.UserNo == ma);
                if (user is not null)
                {
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                    var usersWithRoles = from u in dbContext.Users
                                         join r in dbContext.Roles on u.RoleId equals r.Id
                                         select new
                                         {
                                             u.Id,
                                             u.UserNo,
                                             u.UserName,
                                             HoTen = u.HoTen,
                                             RoleName = r.Name,
                                             Phone = u.Phone,
                                             DiaChi = u.DiaChi,
                                         };
                    LoadEmployees(usersWithRoles.ToList());
                }
            }
        }
    }
}

