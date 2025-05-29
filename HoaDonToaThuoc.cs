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
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class HoaDonToaThuoc : UserControl
    {
        private readonly InventoryAppDbContext appDbContext;

        public HoaDonToaThuoc(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            appDbContext = dbContext;
            comboBox1.Items.Add("Hoá Đơn");
            comboBox1.Items.Add("Toa Thuốc");
            comboBox1.SelectedIndex = 0;
        }

        private void LoadTong(List<Prescription> prescriptions)
        {
            BindingList<Prescription> sources = new BindingList<Prescription>();
            foreach (Prescription prescription in prescriptions)
            {
                sources.Add(prescription);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = prescriptions;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TenDonThuoc"].Visible = false;


            dataGridView1.Columns["IsToaThuocMau"].Visible = false;
            dataGridView1.Columns["MaDonThuoc"].HeaderText = "Mã Đơn Thuốc";
            dataGridView1.Columns["CreatedTime"].HeaderText = "Ngày Tạo";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridView1, new object[] { true });

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.BackgroundColor = Color.White;
        }

        private void LoadTong(List<MigrateDatabase.Models.Order> orders)
        {
            BindingList<MigrateDatabase.Models.Order> sources = new BindingList<MigrateDatabase.Models.Order>();
            foreach (MigrateDatabase.Models.Order order in orders)
            {
                sources.Add(order);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sources;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns["OrderId"].Visible = false;
            dataGridView1.Columns["UserNo"].Visible = false;
            dataGridView1.Columns["MaNhanVien"].Visible = false;
            dataGridView1.Columns["OrderNo"].HeaderText = "Mã Hoá Đơn";
            dataGridView1.Columns["OrderDate"].HeaderText = "Ngày Tạo";
            dataGridView1.Columns["PhanTramGiamGia"].HeaderText = "Giảm Giá Theo Phần Trăm";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridView1, new object[] { true });

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.BackgroundColor = Color.White;
        }

        private void LoadChiTiet(List<object> list)
        {
            BindingList<object> sources = new BindingList<object>();
            foreach (var order in list)
            {
                sources.Add(order);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sources;
            dataGridView2.DataSource = bindingSource;
                        
            dataGridView2.Columns["MaHang"].HeaderText = "Mã Hàng";
            dataGridView2.Columns["TenHang"].HeaderText = "Tên Hàng";
            dataGridView2.Columns["SoLuong"].HeaderText = "Số Lượng";
            dataGridView2.Columns["GiaBan"].HeaderText = "Thành Tiền";
                        
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridView2, new object[] { true });

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.BackgroundColor = Color.White;
        }

        private void LoadChiTiet(List<PrescriptionDetail> list)
        {
            BindingList<PrescriptionDetail> sources = new BindingList<PrescriptionDetail>();
            foreach (var order in list)
            {
                sources.Add(order);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sources;
            dataGridView2.DataSource = bindingSource;

            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["PrescriptionId"].Visible = false;
            dataGridView2.Columns["MaKH"].Visible = false;
            dataGridView2.Columns["MaNhanVien"].Visible = false;
            dataGridView2.Columns["MaThuoc"].HeaderText = "Mã Hàng";
            dataGridView2.Columns["TenThuoc"].HeaderText = "Tên Hàng";
            dataGridView2.Columns["SoLuong"].HeaderText = "Tên Hàng";
            dataGridView2.Columns["LieuDung"].HeaderText = "Số Lượng";

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dataGridView2, new object[] { true });

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.BackgroundColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hoá Đơn")
            {
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                var hoaDon = appDbContext.Orders.Select(x => x.OrderNo ?? string.Empty).ToArray();
                autoCompleteStringCollection.AddRange(hoaDon);
            }

            if (comboBox1.Text == "Toa Thuốc")
            {
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                var toaThuoc = appDbContext.Prescriptions.Where(p => p.IsToaThuocMau == false).Select(x => x.MaDonThuoc ?? string.Empty).ToArray();
                autoCompleteStringCollection.AddRange(toaThuoc);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var query = txtTimKiem.Text;
            if (comboBox1.Text == "Hoá Đơn")
            {
                var hoaDons = appDbContext.Orders.Where(x => x.OrderNo.ToLower().Contains(query.ToLower())).ToList();
                if (hoaDons is not null)
                    LoadTong(hoaDons);
            }

            if (comboBox1.Text == "Toa Thuốc")
            {
                var toaThuoc = appDbContext.Prescriptions.Where(x => x.MaDonThuoc.ToLower().Contains(query.ToLower())).ToList();
                if (toaThuoc is not null)
                    LoadTong(toaThuoc);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.Text == "Hoá Đơn")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    var ma = selectedRow.Cells["OrderNo"].Value?.ToString();

                    if (string.IsNullOrEmpty(ma)) return;

                    var order = appDbContext.Orders.FirstOrDefault(x => x.OrderNo == ma);
                    if(order == null) return;

                    var details = appDbContext.OrderDetails.Where(x => x.OrderId == order.OrderId);
                    if(details is not null)
                    {
                        lblTenNhanVien.Text = appDbContext.Users.FirstOrDefault(x => x.UserNo == order.UserNo)?.UserName;
                        lblTenKhachHang.Text = appDbContext.Customers.FirstOrDefault(x => x.CustomerNo == order.MaNhanVien)?.HoTen;
                        
                        LoadChiTiet(details.Select(x => new
                        {
                            MaHang = x.MaHang,
                            TenHang = x.TenHang,
                            SoLuong = x.SoLuong,
                            GiaBan = x.GiaBan,
                        }).ToList<object>());
                    }
                }
            }

            if (comboBox1.Text == "Toa Thuốc")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    var ma = selectedRow.Cells["Id"].Value?.ToString();

                    if (string.IsNullOrEmpty(ma)) return;

                    var details = appDbContext.PrescriptionDetails.Where(x => x.PrescriptionId == int.Parse(ma));
                    if (details is not null)
                    {
                        lblTenNhanVien.Text = appDbContext.Users.FirstOrDefault(x => x.UserNo == details.First().MaNhanVien)?.UserName;
                        lblTenKhachHang.Text = appDbContext.Customers.FirstOrDefault(x => x.CustomerNo == details.First().MaKH)?.HoTen;
                        LoadChiTiet(details.ToList<PrescriptionDetail>());
                    }
                }
            }
        }
    }
}
