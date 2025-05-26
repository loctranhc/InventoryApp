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
    public partial class frmToaThuocMau : BaseForm
    {
        private InventoryAppDbContext dbContext;

        public frmToaThuocMau(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;    
            LoadDanhSachToa(dbContext.Prescriptions.Where(x => x.IsToaThuocMau == true).ToList());
        }

        private void LoadDanhSachToa(List<Prescription> prescriptions)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = prescriptions;
            dgvDonThuocMau.DataSource = bindingSource;

            dgvDonThuocMau.Columns["MaDonThuoc"].HeaderText = "Mã Đơn Thuốc";
            dgvDonThuocMau.Columns["TenDonThuoc"].HeaderText = "Tên Đơn Thuốc";

            dgvDonThuocMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuocMau.AllowUserToAddRows = false;
            dgvDonThuocMau.AutoGenerateColumns = true;
            dgvDonThuocMau.ReadOnly = true;
            dgvDonThuocMau.EnableHeadersVisualStyles = false;
            dgvDonThuocMau.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvDonThuocMau.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDonThuocMau.EnableHeadersVisualStyles = false;
            dgvDonThuocMau.RowHeadersVisible = false;
            dgvDonThuocMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuocMau.SelectionMode = DataGridViewSelectionMode.CellSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvDonThuocMau, new object[] { true });

            dgvDonThuocMau.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDonThuocMau.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonThuocMau.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDonThuocMau.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvDonThuocMau.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDonThuocMau.GridColor = Color.LightGray;
            dgvDonThuocMau.BackgroundColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLieuDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDonThuocMau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
