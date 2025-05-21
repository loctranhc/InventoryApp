using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Ví dụ: lấy dữ liệu
                string name = form.ProductName;
                decimal salePrice = form.SalePrice;

                MessageBox.Show($"Thêm sản phẩm: {name} - Giá bán: {salePrice}");
                // TODO: Gọi DB.Save hoặc thêm vào DataGridView
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa sản phẩm!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa sản phẩm!");
        }
    }
}
