using System.Data;
using System.Reflection;
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

            LoadAllDsToa();
        }

        private void LoadAllDsToa()
        {
            var orders = dbContext.Orders.Where(x => x.IsHoaDonMau == true);
            LoadDanhSachToa(orders.ToList());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var queryText = textBox1.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var orders = dbContext.Orders.Where(x => x.TenHoaDon.Contains(queryText) || x.OrderNo.Contains(queryText) && x.IsHoaDonMau == true);
            LoadDanhSachToa(orders.ToList());
        }

        private void LoadDanhSachToa(List<Order> orders)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = orders;
            dgvDonThuocMau.DataSource = bindingSource;

            dgvDonThuocMau.Columns["OrderId"].Visible = false;
            dgvDonThuocMau.Columns["UserNo"].Visible = false;
            dgvDonThuocMau.Columns["IsHoaDonMau"].Visible = false;
            dgvDonThuocMau.Columns["PhanTramGiamGia"].Visible = false;
            dgvDonThuocMau.Columns["MaNhanVien"].Visible = false;
            dgvDonThuocMau.Columns["OrderNo"].HeaderText = "Mã Toa Thuốc";
            dgvDonThuocMau.Columns["TenHoaDon"].HeaderText = "DS Mẫu Toa Thuốc";
            dgvDonThuocMau.Columns["OrderDate"].HeaderText = "Ngày tạo";

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

        private void LoadChiTiet(List<OrderDetail> details)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = details;
            dgvChiTiet.DataSource = bindingSource;

            dgvChiTiet.Columns["Id"].Visible = false;
            dgvChiTiet.Columns["OrderId"].Visible = false;
            dgvChiTiet.Columns["GiaBan"].Visible = false;
            dgvChiTiet.Columns["CreatedTime"].Visible = false;
            dgvChiTiet.Columns["MaHang"].HeaderText = "Mã Sản Phẩm";
            dgvChiTiet.Columns["TenHang"].HeaderText = "Tên Sản Phẩm";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTiet.Columns["LieuDung"].HeaderText = "Liều Dùng";

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoGenerateColumns = true;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgvChiTiet, new object[] { true });

            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvChiTiet.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvChiTiet.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvChiTiet.GridColor = Color.LightGray;
            dgvChiTiet.BackgroundColor = Color.White;
        }

        private void dgvDonThuocMau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonThuocMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                var id = selectedRow.Cells["OrderId"].Value?.ToString();
                int.TryParse(id, out int orderId);
                var details = dbContext.OrderDetails.Where(x => x.OrderId == orderId);
                LoadChiTiet(details.ToList());
            }
        }

        private void dgvChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiTiet_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "LieuDung" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = $"{value}/lần/ngày";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinDonThuocMau thongTinDonThuocMau = new ThongTinDonThuocMau(dbContext);
            if (thongTinDonThuocMau.ShowDialog() == DialogResult.OK)
            {
                var toaThuoc = thongTinDonThuocMau.Tag as Order;
                LoadDanhSachToa(new List<Order> { toaThuoc });
                LoadChiTiet(dbContext.OrderDetails.Where(x => x.OrderId == toaThuoc.OrderId).ToList());
            }
        }

        private void btnSuaToaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                var id = selectedRow.Cells["OrderId"].Value?.ToString();
                int.TryParse(id, out int orderId);
                var details = dbContext.OrderDetails.Where(x => x.OrderId == orderId);
                LoadChiTiet(details.ToList());
            }
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                var id = selectedRow.Cells["OrderId"].Value?.ToString();
                int.TryParse(id, out int orderId);
                var order = dbContext.Orders.FirstOrDefault(x => x.OrderId == orderId);
                ThongTinDonThuocMau thongTinDonThuocMau = new ThongTinDonThuocMau(dbContext, order);
                if (thongTinDonThuocMau.ShowDialog() == DialogResult.OK)
                {
                    var toaThuoc = thongTinDonThuocMau.Tag as Order;
                    LoadDanhSachToa(new List<Order> { toaThuoc });
                    LoadChiTiet(dbContext.OrderDetails.Where(x => x.OrderId == toaThuoc.OrderId).ToList());
                }
            }
            else{
                MessageBox.Show("Vui lòng chọn toa thuốc cần sửa.", "Thông báo");
            }
        }
    }
}
