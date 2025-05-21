using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using InventoryApp.Data; // Giả định DbContext nằm trong thư mục này
using InventoryApp.Models; // Giả định model Customer nằm ở đây

namespace InventoryApp.Controls
{
    public partial class CustomerControl : UserControl
    {
        private InventoryDbContext _context;

        public CustomerControl()
        {
            InitializeComponent();
            _context = new InventoryDbContext();
            //LoadCustomers();
        }

        private void LoadCustomers(string search = "")
        {
            var query = _context.Customers.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(c => c.CustomerName.Contains(search));
            }

            var data = query.Select(c => new
            {
                c.CustomerId,
                c.CustomerName,
                c.Phone,
                c.Address
            }).ToList();

            dgvCustomers.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(_context);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
            var customer = _context.Customers.Find(id);
            if (customer == null) return;

            var form = new CustomerForm(_context, customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;
            var customer = _context.Customers.Find(id);
            if (customer == null) return;

            if (MessageBox.Show("Xác nhận xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                LoadCustomers();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text);
        }
    }
}