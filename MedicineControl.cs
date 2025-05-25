using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class MedicineControl : UserControl
    {
        private InventoryAppDbContext dbContext;

        public MedicineControl(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;

            LoadSanPham(context.Medicines.ToList());
        }

        private void LoadSanPham(List<Medicine> inventoryList)
        {
            gridViewMedicine.DataSource = inventoryList;
            gridViewMedicine.Columns["Id"].Visible = false;
            gridViewMedicine.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            gridViewMedicine.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            gridViewMedicine.Columns["SoDangKy"].HeaderText = "Số Đăng Ký";
            gridViewMedicine.Columns["HoatChatChinh"].HeaderText = "Hoạt Chất";
            gridViewMedicine.Columns["HamLuong"].HeaderText = "Hàm Lượng";
            gridViewMedicine.Columns["HangSanXuat"].HeaderText = "Hãng Sản Xuất";
            gridViewMedicine.Columns["NuocSanXuat"].HeaderText = "Nước Sản Xuất";
            gridViewMedicine.Columns["QuyCachDongGoi"].HeaderText = "Đóng Gói";
            gridViewMedicine.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";


            gridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewMedicine.AllowUserToAddRows = false;
            gridViewMedicine.AutoGenerateColumns = true;
            gridViewMedicine.ReadOnly = true;
            gridViewMedicine.EnableHeadersVisualStyles = false;
            gridViewMedicine.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            gridViewMedicine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewMedicine.EnableHeadersVisualStyles = false;
            gridViewMedicine.RowHeadersVisible = false;
            gridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewMedicine.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, gridViewMedicine, new object[] { true });

            gridViewMedicine.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridViewMedicine.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridViewMedicine.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridViewMedicine.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            gridViewMedicine.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridViewMedicine.GridColor = Color.LightGray;
            gridViewMedicine.BackgroundColor = Color.White;
        }
    }
}
