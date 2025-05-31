using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Session;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class ThongTinDonThuocMau : Form
    {
        private readonly InventoryAppDbContext dbContext;
        private BindingList<OrderDetail> details = new BindingList<OrderDetail>();
        private List<Product> products = new List<Product>();
        private Order editableOrder;
        private readonly string _frmStyle = "";

        public ThongTinDonThuocMau(InventoryAppDbContext Context)
        {
            InitializeComponent();
            dbContext = Context;
            LoadChITiet(details);
            richTextBox1.ReadOnly = true;
            txtLieuDung.Text = "1";
            txtSoLuong.Text = "1";

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(dbContext.Products.Where(x => x.IsHidden == false).Select(x => x.MaHang).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Products.Where(x => x.IsHidden == false).Select(x => x.TenHang).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        public ThongTinDonThuocMau(InventoryAppDbContext Context, Order order, string FormStyle = "Edit")
        {
            InitializeComponent();
            dbContext = Context;
            LoadChITiet(details);
            richTextBox1.ReadOnly = true;
            txtLieuDung.Text = "1";
            txtSoLuong.Text = "1";
            _frmStyle = FormStyle;

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(dbContext.Products.Where(x => x.IsHidden == false).Select(x => x.MaHang).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Products.Where(x => x.IsHidden == false).Select(x => x.TenHang).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;

            var chiTiet = dbContext.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();
            foreach (var item in chiTiet)
            {
                details.Add(item);
                var product = dbContext.Products.FirstOrDefault(X => X.MaHang.Trim().ToLower() == item.MaHang.Trim().ToLower());
                if (product != null)
                    products.Add(product);
            }

            editableOrder = order;
            txtTenDonThuoc.Text = order.TenHoaDon;
            LoadChITiet(details);
        }

        private void LoadChITiet(BindingList<OrderDetail> details)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = details;
            dgvDonThuoc.DataSource = bindingSource;

            dgvDonThuoc.Columns["Id"].Visible = false;
            dgvDonThuoc.Columns["OrderId"].Visible = false;
            dgvDonThuoc.Columns["GiaBan"].Visible = false;
            dgvDonThuoc.Columns["CreatedTime"].Visible = false;
            dgvDonThuoc.Columns["MaHang"].HeaderText = "Mã Sản Phẩm";
            dgvDonThuoc.Columns["TenHang"].HeaderText = "Tên Sản Phẩm";
            dgvDonThuoc.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvDonThuoc.Columns["LieuDung"].HeaderText = "Liều Dùng";

            dgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuoc.AllowUserToAddRows = false;
            dgvDonThuoc.AutoGenerateColumns = true;
            dgvDonThuoc.ReadOnly = true;
            dgvDonThuoc.EnableHeadersVisualStyles = false;
            dgvDonThuoc.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvDonThuoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDonThuoc.EnableHeadersVisualStyles = false;
            dgvDonThuoc.RowHeadersVisible = false;
            dgvDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonThuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvDonThuoc, new object[] { true });

            dgvDonThuoc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonThuoc.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDonThuoc.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvDonThuoc.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDonThuoc.GridColor = Color.LightGray;
            dgvDonThuoc.BackgroundColor = Color.White;

            // Tạo mới cột button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Thao Tác";
            btnColumn.Text = "Xoá";
            btnColumn.Name = "btnXoa";
            btnColumn.UseColumnTextForButtonValue = true;

            if (!dgvDonThuoc.Columns.Contains("btnXoa"))
            {
                dgvDonThuoc.Columns.Add(btnColumn);
            }
        }

        private void dgvDonThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemThuoc.Text.Trim().ToLower();
            var thuoc = dbContext.Products.FirstOrDefault(x => x.TenHang.ToLower().Contains(keyword) || x.MaHang.ToLower().Contains(keyword) && x.IsHidden == false);

            if (thuoc is not null)
            {
                richTextBox1.Text = $"Tên hàng: {thuoc.TenHang}\n\nĐơn vị tính: {thuoc.DonViTinh}\nSố lượng tồn kho: {thuoc.SoLuongTonKho}\nGiá nhập: {thuoc.GiaNhap}\nGiá bán: {thuoc.GiaBan}";
                btnThemThuoc.Tag = thuoc;
            }
            else
            {
                MessageBox.Show("Không có loại sản phẩm này.", "Thông báo");
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số lượng!", "Thông báo");
                return;
            }

            try
            {
                int.Parse(txtLieuDung.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng liều dùng!", "Thông báo");
                return;
            }

            var currentSelected = btnThemThuoc.Tag as Product;
            var exist = products.FirstOrDefault(x => x.MaHang.Trim() == currentSelected.MaHang.Trim());

            if (currentSelected != null)
            {
                if(exist is not null)
                {
                    products.Remove(exist);
                    var exists = details.FirstOrDefault(x => x.MaHang.Trim() == currentSelected.MaHang.Trim());
                    details.Remove(exists);
                }

                products.Add(currentSelected);
                details.Add(new OrderDetail
                {
                    LieuDung = int.Parse(txtLieuDung.Text),
                    MaHang = currentSelected.MaHang,
                    TenHang = currentSelected.TenHang,
                    SoLuong = int.Parse(txtSoLuong.Text),
                });
            }

            LoadChITiet(details);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDonThuoc.Columns["btnXoa"].Index)
            {
                string maHang = dgvDonThuoc.Rows[e.RowIndex].Cells["MaHang"].Value?.ToString();

                var thuoc = details.FirstOrDefault(x => x.MaHang.Trim() == maHang.Trim());
                if (thuoc != null)
                    details.Remove(thuoc);

                LoadChITiet(details);
                return;
            }

            if (dgvDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuoc.SelectedRows[0];
                string maHang = selectedRow.Cells["MaHang"].Value?.ToString();
                string lieuDung = selectedRow.Cells["LieuDung"].Value?.ToString().Split('/').First();
                string soLuong = selectedRow.Cells["SoLuong"].Value?.ToString();
                var thuoc = products.FirstOrDefault(x => x.MaHang == maHang);

                if (thuoc != null)
                {
                    richTextBox1.Text = $"Tên hàng: {thuoc.TenHang}\n\nĐơn vị tính: {thuoc.DonViTinh}\nSố lượng tồn kho: {thuoc.SoLuongTonKho}\nGiá nhập: {thuoc.GiaNhap}\nGiá bán: {thuoc.GiaBan}";
                    txtSoLuong.Text = soLuong;
                    txtLieuDung.Text = lieuDung;
                    btnThemThuoc.Tag = thuoc;
                }
            }
        }

        private void dgvDonThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDonThuoc.Columns[e.ColumnIndex].Name == "LieuDung" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = $"{value}/lần/ngày";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDonThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đơn thuốc.", "Thông báo");
                return;
            }

            var toaThuoc = dbContext.Orders.FirstOrDefault(x => x.TenHoaDon.ToLower().Trim() == txtTenDonThuoc.Text.ToLower().Trim());
            if (toaThuoc is not null)
            {
                if (_frmStyle.Equals("Edit"))
                {
                    var chiTietToaThuoc = dbContext.OrderDetails.Where(x => x.OrderId == toaThuoc.OrderId).ToList();
                    dbContext.RemoveRange(chiTietToaThuoc);

                    dbContext.OrderDetails.AddRange(details.Select(x => new OrderDetail
                    {
                        LieuDung = x.LieuDung,
                        SoLuong = x.SoLuong,
                        TenHang = x.TenHang,
                        MaHang = x.MaHang,
                        OrderId = editableOrder.OrderId,
                    }));
                    dbContext.SaveChanges();
                    MessageBox.Show("Lưu thành công!", "Thông báo");
                    this.Tag = toaThuoc;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }

                MessageBox.Show("Tên toa thuốc đã được sử dụng.", "Thông báo");
                return;
            }

            toaThuoc = new Order
            {
                IsHoaDonMau = true,
                MaNhanVien = UserSession.CurrentUser.UserNo,
                TenHoaDon = txtTenDonThuoc.Text
            };
            dbContext.Orders.Add(toaThuoc);
            dbContext.SaveChanges();

            foreach (var item in details)
            {
                item.OrderId = toaThuoc.OrderId;
                dbContext.OrderDetails.Add(item);
            }
            var newToaThuoc = dbContext.Orders.FirstOrDefault(x => x.OrderId == toaThuoc.OrderId);
            newToaThuoc.OrderNo = $"TT-{newToaThuoc.OrderId}";
            dbContext.SaveChanges();
            MessageBox.Show("Lưu thành công!", "Thông báo");
            this.Tag = newToaThuoc;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ThongTinDonThuocMau_Load(object sender, EventArgs e)
        {
            this.Text = "Tạo toa thuốc mẫu";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtLieuDung_TextChanged(object sender, EventArgs e)
        {
            var lieuDung = 0;
            if (int.TryParse(txtLieuDung.Text, out lieuDung))
            {
                return;
            }
            else
            {
                txtLieuDung.Text = "1";
            }
        }
    }
}
