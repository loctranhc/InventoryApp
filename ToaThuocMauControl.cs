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
            var prescriptions = dbContext.Prescriptions.Where(x => x.IsToaThuocMau == true);
            LoadDanhSachToa(prescriptions.ToList());
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
            dgvChiTiet.DataSource = bindingSource;

            dgvChiTiet.Columns["Id"].Visible = false;
            dgvChiTiet.Columns["PrescriptionId"].Visible = false;
            dgvChiTiet.Columns["MaKH"].Visible = false;
            dgvChiTiet.Columns["MaNhanVien"].Visible = false;
            dgvChiTiet.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvChiTiet.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
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

            // Tạo mới cột button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Thao Tác";
            btnColumn.Text = "Xoá";
            btnColumn.Name = "btnXoa";
            btnColumn.UseColumnTextForButtonValue = true;

            if (!dgvChiTiet.Columns.Contains("btnXoa"))
            {
                dgvChiTiet.Columns.Add(btnColumn);
            }
        }

        private void dgvDonThuocMau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonThuocMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                var maDonThuoc = selectedRow.Cells["MaDonThuoc"].Value?.ToString();
                var idDonThuoc = dbContext.Prescriptions.FirstOrDefault(x => x.MaDonThuoc == maDonThuoc.Trim())?.Id;
                var details = dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == idDonThuoc);
                LoadChITiet(details.ToList());
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
                var toaThuoc = thongTinDonThuocMau.Tag as Prescription;
                LoadDanhSachToa(new List<Prescription> { toaThuoc });
                LoadChITiet(dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == toaThuoc.Id).ToList());
            }
        }

        private void btnSuaToaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuocMau.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuocMau.SelectedRows[0];
                var maDonThuoc = selectedRow.Cells["MaDonThuoc"].Value?.ToString();
                var donThuoc = dbContext.Prescriptions.FirstOrDefault(x => x.MaDonThuoc == maDonThuoc.Trim());
                ThongTinDonThuocMau thongTinDonThuocMau = new ThongTinDonThuocMau(dbContext, prescription: donThuoc);
                if (thongTinDonThuocMau.ShowDialog() == DialogResult.OK)
                {
                    var toaThuoc = thongTinDonThuocMau.Tag as Prescription;
                    LoadDanhSachToa(new List<Prescription> { toaThuoc });
                    LoadChITiet(dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == toaThuoc.Id).ToList());
                }
            }
            else{
                MessageBox.Show("Vui lòng chọn toa thuốc cần sửa.", "Thông báo");
            }
        }
    }
}
