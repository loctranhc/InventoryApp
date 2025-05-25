using System.Reflection;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class InventoryControl : UserControl
    {
        private InventoryAppDbContext _dbContext;

        public InventoryControl(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            var gioiHanTonKho = _dbContext.Settings.Where(x => x.Key == "SoLuongTonGioiHan").OrderByDescending(x => x.Id).FirstOrDefault();
            var soLuongTon = 0;
            if (gioiHanTonKho is null)
                soLuongTon = 0;
            else
                soLuongTon = int.Parse(gioiHanTonKho.Value);

            LoadSanPham(_dbContext.Products.Where(x => x.SoLuongTonKho < soLuongTon).OrderByDescending(x => x.SoLuongTonKho).ToList());
        }

        private void LoadSanPham(List<Product> inventoryList)
        {
            dataGridViewInventory.DataSource = inventoryList;
            dataGridViewInventory.Columns["Id"].Visible = false;
            dataGridViewInventory.Columns["MaHang"].HeaderText = "Mã Hàng";
            dataGridViewInventory.Columns["TenHang"].HeaderText = "Tên Hàng";
            dataGridViewInventory.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dataGridViewInventory.Columns["SoLuongTonKho"].HeaderText = "Số Lượng Tồn";

            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AutoGenerateColumns = true;
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.EnableHeadersVisualStyles = false;
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewInventory.EnableHeadersVisualStyles = false;
            dataGridViewInventory.RowHeadersVisible = false;
            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridViewInventory, new object[] { true });

            dataGridViewInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewInventory.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewInventory.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewInventory.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewInventory.GridColor = Color.LightGray;
            dataGridViewInventory.BackgroundColor = Color.White;
        }
    }
}
