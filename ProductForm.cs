using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using MigrateDatabase;
using MigrateDatabase.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventoryApp
{
    public partial class ProductForm : Form
    {
        private InventoryAppDbContext AppDbContext;

        public ProductForm(InventoryAppDbContext inventoryAppDbContext)
        {
            InitializeComponent();
            AppDbContext = inventoryAppDbContext;

            if (AppDbContext.Categories.FirstOrDefault(x => x.TenNhapHang == "N/A") == null)
            {
                AppDbContext.Categories.Add(new MigrateDatabase.Models.Category
                {
                    MoTa = "Nhóm hàng mặc định",
                    TenNhapHang = "N/A",
                    TenNhomHang = "N/A"
                });
                AppDbContext.SaveChanges();
            }
            var categories = AppDbContext.Categories.Select(X => X.TenNhomHang).ToList<string>();
            foreach (var item in categories)
                comboBox1.Items.Add(item);
            comboBox1.Text = "None";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuongNhap.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtGiaVon.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSoLuongNhap.Text, out _) ||
                !decimal.TryParse(txtGiaVon.Text, out _) ||
                !decimal.TryParse(txtGiaNhap.Text, out _) ||
                !decimal.TryParse(txtGiaBan.Text, out _))
            {
                MessageBox.Show("Số lượng và giá trị phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string GenerateMaHang()
        {
            var count = AppDbContext.Products.Count() + 1;
            return $"SP{count:D5}"; // VD: SP00001
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var product = new Product();
                product.MaHang = GenerateMaHang(); // bạn có thể tạo mã sản phẩm theo kiểu SP00001...
                product.TenHang = txtTenHang.Text.Trim();
                product.DonViTinh = txtDonViTinh.Text.Trim();
                product.SoLuongTonKho = int.Parse(txtSoLuongNhap.Text.Trim());
                product.CategoryId = AppDbContext.Categories.FirstOrDefault(x => x.TenNhapHang.ToLower().Equals(comboBox1.Text.Trim().ToLower())).Id;
                product.GiaVon = decimal.Parse(txtGiaVon.Text.Trim());
                product.GiaNhap = decimal.Parse(txtGiaNhap.Text.Trim());
                product.GiaBan = decimal.Parse(txtGiaBan.Text.Trim());

                AppDbContext.Products.Add(product);
                AppDbContext.SaveChanges();

                NhapXuatHangHoa nhapXuatHangHoa = new NhapXuatHangHoa();
                nhapXuatHangHoa.SoLuongTonTruoc = 0;
                nhapXuatHangHoa.SoLuongXuat = 0;
                nhapXuatHangHoa.SoLuongNhap = product.SoLuongTonKho;
                nhapXuatHangHoa.MaHang = product.MaHang;
                nhapXuatHangHoa.TenHang = product.TenHang;
                nhapXuatHangHoa.CreatedTime = DateTime.Now;
                nhapXuatHangHoa.ProductId = product.Id;
                AppDbContext.NhapXuatHangHoas.Add(nhapXuatHangHoa);
                AppDbContext.SaveChanges();

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
