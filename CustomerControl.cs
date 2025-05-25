using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp.Controls
{
    public partial class CustomerControl : UserControl
    {
        private InventoryAppDbContext _context;
        private BindingNavigator bindingNavigator;

        public CustomerControl(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            _context = dbContext;
            var customer = dbContext.Customers;
            bindingNavigator = new BindingNavigator(true);
            LoadKhachHang(customer.ToList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var form = new CustomerForm(_context);
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    LoadCustomers();
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgvCustomers.CurrentRow == null) return;
            //int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
            //var customer = _context.Customers.Find(id);
            //if (customer == null) return;

            //var form = new CustomerForm(_context, customer);
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    LoadCustomers();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadAllKhachHang()
        {
            var customer = _context.Customers;
            LoadKhachHang(customer.ToList());
        }

        private void LoadKhachHang(List<Customer> customers)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = customers;
            dgvKhachHang.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
            bindingNavigator.Dock = DockStyle.Bottom;
            bindingNavigator.DeleteItem.Visible = false;
            bindingNavigator.AddNewItem.Visible = false;
            bindingNavigator.ImageScalingSize = new Size(24, 24);
            var controls = this.Controls;
            if (!this.Controls.Contains(bindingNavigator))
            {
                this.Controls.Add(bindingNavigator);
            }

            dgvKhachHang.Columns["Id"].Visible = false;
            dgvKhachHang.Columns["CustomerNo"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvKhachHang.Columns["Phone"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns["DiemTichLuy"].HeaderText = "Điểm Tích Luỹ";
            dgvKhachHang.Columns["DiemTichLuy"].Visible = false;

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoGenerateColumns = true;
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvKhachHang, new object[] { true });

            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKhachHang.GridColor = Color.LightGray;
            dgvKhachHang.BackgroundColor = Color.White;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(_context);
            form.ShowDialog();
            LoadAllKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                string maKH = dgvKhachHang.SelectedRows[0].Cells["CustomerNo"].Value?.ToString();
                if (maKH == "KH-1")
                {
                    MessageBox.Show("Dữ liệu mặc định, không được phép sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var khachHang = _context.Customers.FirstOrDefault(x => x.CustomerNo == maKH);

                var form = new CustomerForm(_context, khachHang);
                form.ShowDialog();
                LoadAllKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                string maKH = dgvKhachHang.SelectedRows[0].Cells["CustomerNo"].Value?.ToString();
                if (maKH == "KH-1")
                {
                    MessageBox.Show("Dữ liệu mặc định, không được phép xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var khachHang = _context.Customers.FirstOrDefault(x => x.CustomerNo == maKH);

                if (khachHang is null)
                    return;

                if (MessageBox.Show("Xác nhận xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _context.Customers.Remove(khachHang);
                    _context.SaveChanges();
                    LoadAllKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var customer = _context.Customers.Where(x => x.HoTen.ToLower().Contains(txtTimKiem.Text.Trim()) || x.CustomerNo.ToLower().Contains(txtTimKiem.Text.Trim()) || x.Phone.ToLower().Contains(txtTimKiem.Text.Trim()));
            if (customer != null)
            {
                LoadKhachHang(customer.ToList());
            }
        }

        private void txtTimKiem_ContentChanged(object sender, EventArgs e)
        {
            var customer = _context.Customers.Where(x => x.HoTen.ToLower().Contains(txtTimKiem.Text.Trim()) || x.CustomerNo.ToLower().Contains(txtTimKiem.Text.Trim()) || x.Phone.ToLower().Contains(txtTimKiem.Text.Trim()));
            if (customer != null)
            {
                LoadKhachHang(customer.ToList());
            }
        }
    }
}