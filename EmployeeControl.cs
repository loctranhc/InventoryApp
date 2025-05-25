using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MigrateDatabase;
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
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.CellSelect;

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
            //if (dgvEmployees.CurrentRow != null)
            //{
            //    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            //    if (confirm == DialogResult.Yes)
            //    {
            //        int userId = (int)dgvEmployees.CurrentRow.Cells["Id"].Value;
            //        using (var db = new InventoryDbContext())
            //        {
            //            var user = db.Users.Find(userId);
            //            if (user != null)
            //            {
            //                db.Users.Remove(user);
            //                db.SaveChanges();
            //                LoadEmployees();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
            //}
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
    }
}
