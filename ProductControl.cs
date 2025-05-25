using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;
using MigrateDatabase.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryApp
{
    public partial class ProductControl : UserControl
    {
        private InventoryAppDbContext _dbContext;

        public ProductControl(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadSanPham(_dbContext.Products.ToList());
        }

        private void LoadSanPham(List<Product> inventoryList)
        {
            BindingSource bindingSource = new BindingSource();
            BindingNavigator bindingNavigator = new BindingNavigator(true);
            bindingSource.DataSource = inventoryList;
            dgvProducts.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
            bindingNavigator.Dock = DockStyle.Bottom;
            bindingNavigator.DeleteItem.Visible = false;
            bindingNavigator.AddNewItem.Visible = false;
            bindingNavigator.ImageScalingSize = new Size(24, 24);
            this.Controls.Add(bindingNavigator);

            dgvProducts.Columns["Id"].Visible = false;
            dgvProducts.Columns["MaHang"].HeaderText = "Mã Hàng";
            dgvProducts.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvProducts.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvProducts.Columns["SoLuongTonKho"].HeaderText = "Số Lượng Tồn";
            dgvProducts.Columns["GiaVon"].HeaderText = "Giá Vốn";
            dgvProducts.Columns["GiaVon"].DefaultCellStyle.Format = "N0";
            dgvProducts.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgvProducts.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
            dgvProducts.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvProducts.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.ReadOnly = true;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvProducts, new object[] { true });

            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProducts.GridColor = Color.LightGray;
            dgvProducts.BackgroundColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa sản phẩm!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa sản phẩm!");
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Content.Trim().ToLower();

            var filtered = _dbContext.Products
                .Where(p => p.MaHang.ToLower().Contains(keyword) || p.TenHang.ToLower().Contains(keyword))
                .ToList();

            LoadSanPham(filtered);
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            var items = _dbContext.Categories.Select(x => x.TenNhomHang).ToArray();
            cbxCategory.Items.Add("All");
            cbxCategory.SelectedIndex = 0;

            foreach (var item in items)
            {
                cbxCategory.Items.Add($"{item}");
            }
        }

        private void cbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var txt = cbxCategory.Text;
            if (!txt.Equals("All"))
            {
                var category = _dbContext.Categories.FirstOrDefault(x => x.TenNhomHang.Equals(txt));
                if (category != null)
                {
                    var products = _dbContext.Products.Where(x => x.CategoryId == category.Id);
                    LoadSanPham(products.ToList());
                }
            }
            else
            {
                LoadSanPham(_dbContext.Products.ToList());
            }
        }

        private async void btnNhapHang_Click_1(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var progressForm = new ProgressForm();
                progressForm.Show();

                try
                {
                    await Task.Run(() =>
                    {
                        ExcelSync.SyncBangGiaWithProgress(ofd.FileName, _dbContext, progressForm.UpdateProgress);
                    });

                    MessageBox.Show("Nhập hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    progressForm.Close();
                }
            }
        }
    }
}
