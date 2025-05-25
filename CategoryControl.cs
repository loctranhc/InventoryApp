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
    public partial class CategoryControl : UserControl
    {
        private InventoryAppDbContext dbContext;

        public CategoryControl(InventoryAppDbContext inventoryAppDbContext)
        {
            InitializeComponent();
            dbContext = inventoryAppDbContext;
            LoadDanhMuc(dbContext.Categories.ToList());
        }

        private void LoadDanhMuc(List<Category> categories)
        {
            gridViewCategory.DataSource = categories;
            gridViewCategory.Columns["Id"].Visible = false;
            gridViewCategory.Columns["TenNhomHang"].HeaderText = "Tên Nhóm Hàng";
            gridViewCategory.Columns["MoTa"].HeaderText = "Mô Tả";
            gridViewCategory.Columns["TenNhapHang"].HeaderText = "Tên Nhập Hàng";
            gridViewCategory.Columns["TenNhapHang"].Visible = false;

            gridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gridViewCategory.AllowUserToAddRows = false;
            gridViewCategory.AutoGenerateColumns = true;
            gridViewCategory.ReadOnly = true;
            gridViewCategory.EnableHeadersVisualStyles = false;
            gridViewCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            gridViewCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewCategory.EnableHeadersVisualStyles = false;
            gridViewCategory.RowHeadersVisible = false;
            gridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewCategory.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, gridViewCategory, new object[] { true });

            gridViewCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridViewCategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridViewCategory.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridViewCategory.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            gridViewCategory.DefaultCellStyle.SelectionForeColor = Color.Black;
            gridViewCategory.GridColor = Color.LightGray;
            gridViewCategory.BackgroundColor = Color.White;
        }
    }
}
