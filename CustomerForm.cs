using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class CustomerForm : Form
    {
        private readonly InventoryAppDbContext _context;
        private readonly Customer _editingCustomer;

        public CustomerForm(InventoryAppDbContext appDbContext, Customer customer = null)
        {
            InitializeComponent();
            _context = appDbContext;
            _editingCustomer = customer;

            cbxGioiTinh.Items.Add("Nam");
            cbxGioiTinh.Items.Add("Nữ");
            cbxGioiTinh.SelectedIndex = 0;

            if(customer is not null)
            {
                txtName.Text = customer.HoTen;
                txtAddress.Text = customer.DiaChi;
                txtPhone.Text = customer.Phone;
                cbxGioiTinh.Text = customer.GioiTinh;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingCustomer == null)
            {
                var exits = _context.Customers.FirstOrDefault(x => txtPhone.Text == x.Phone);
                if(exits != null)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }       

                var customer = new Customer
                {
                    CustomerNo = string.Empty,
                    HoTen = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    DiaChi = txtAddress.Text.Trim(),
                    GioiTinh = cbxGioiTinh.Text
                };

                _context.Customers.Add(customer);
                _context.SaveChanges();

                var newCustomer = _context.Customers.FirstOrDefault(x => customer.Id == x.Id);
                newCustomer.CustomerNo = $"KH-{newCustomer.Id.ToString()}";
            }
            else
            {
                var editCustomer = _context.Customers.FirstOrDefault(x => _editingCustomer.Id == x.Id);
                editCustomer.HoTen = txtName.Text.Trim();
                editCustomer.Phone = txtPhone.Text.Trim();
                editCustomer.DiaChi = txtAddress.Text.Trim();
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
