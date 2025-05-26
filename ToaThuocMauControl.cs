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
using DocumentFormat.OpenXml.InkML;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class ToaThuocMauControl : UserControl
    {
        private InventoryAppDbContext dbContext;

        public ToaThuocMauControl(InventoryAppDbContext context)
        {
            InitializeComponent();
            dbContext = context;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var queryText = textBox1.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var prescriptions = dbContext.Prescriptions.Where(x => x.TenDonThuoc.Contains(queryText) || x.MaDonThuoc.Contains(queryText) && x.IsToaThuocMau == true);
            LoadDanhSachToa(prescriptions.ToList());
        }

        private void LoadDanhSachToa(List<Prescription> prescriptions)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = prescriptions;
            dgvDonThuocMau.DataSource = bindingSource;

            dgvDonThuocMau.Columns["Id"].Visible = false;
            dgvDonThuocMau.Columns["IsToaThuocMau"].Visible = false;
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
            dgvDonThuocMau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void LoadChITiet(List<PrescriptionDetail> details)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = details;
            dgvDonThuocMau.DataSource = bindingSource;

            dgvDonThuocMau.Columns["Id"].Visible = false;
            dgvDonThuocMau.Columns["PrescriptionId"].Visible = false;
            dgvDonThuocMau.Columns["IsToaThuocMau"].Visible = false;
            dgvDonThuocMau.Columns["MaKH"].Visible = false;
            dgvDonThuocMau.Columns["MaNhanVien"].Visible = false;
            dgvDonThuocMau.Columns["TenDonThuoc"].HeaderText = "Tên Thuốc";
            dgvDonThuocMau.Columns["LieuDung"].HeaderText = "Liều Dùng";

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
            dgvDonThuocMau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void dgvDonThuocMau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonThuocMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                int maDonThuoc = int.Parse(selectedRow.Cells["TenDonThuoc"].Value?.ToString());
                var details = dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == maDonThuoc);
                LoadChITiet(details.ToList());
            }
        }
    }
}
