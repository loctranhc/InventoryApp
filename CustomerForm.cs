using System;
using System.Windows.Forms;
using InventoryApp.Data;
using InventoryApp.Models; // Đảm bảo namespace đúng với project của bạn

namespace InventoryApp
{
    public partial class CustomerForm : Form
    {
        private readonly InventoryDbContext _context;
        private readonly Customer _editingCustomer;

        public CustomerForm(InventoryDbContext context, Customer customer = null)
        {
            InitializeComponent();
            _context = context;
            _editingCustomer = customer;

            if (_editingCustomer != null)
            {
                this.Text = "Cập nhật khách hàng";
                txtName.Text = _editingCustomer.CustomerName;
                txtPhone.Text = _editingCustomer.Phone;
                txtAddress.Text = _editingCustomer.Address;
            }
            else
            {
                this.Text = "Thêm khách hàng";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingCustomer == null)
            {
                var customer = new Customer
                {
                    CustomerName = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _context.Customers.Add(customer);
            }
            else
            {
                _editingCustomer.CustomerName = txtName.Text.Trim();
                _editingCustomer.Phone = txtPhone.Text.Trim();
                _editingCustomer.Address = txtAddress.Text.Trim();
            }

            _context.SaveChanges();
            MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
