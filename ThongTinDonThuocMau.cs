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
using InventoryApp.Session;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class ThongTinDonThuocMau : Form
    {
        private readonly InventoryAppDbContext dbContext;
        private BindingList<PrescriptionDetail> details = new BindingList<PrescriptionDetail>();
        private List<Medicine> medicines = new List<Medicine>();

        public ThongTinDonThuocMau(InventoryAppDbContext Context)
        {
            InitializeComponent();
            dbContext = Context;
            LoadChITiet(details);
            richTextBox1.ReadOnly = true;

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.TenThuoc).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.MaThuoc).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void LoadChITiet(BindingList<PrescriptionDetail> details)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = details;
            dgvDonThuoc.DataSource = bindingSource;

            dgvDonThuoc.Columns["Id"].Visible = false;
            dgvDonThuoc.Columns["PrescriptionId"].Visible = false;
            dgvDonThuoc.Columns["MaKH"].Visible = false;
            dgvDonThuoc.Columns["MaNhanVien"].Visible = false;
            dgvDonThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvDonThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
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
            var thuoc = dbContext.Medicines.FirstOrDefault(x => x.TenThuoc.ToLower().Contains(keyword) || x.MaThuoc.ToLower().Contains(keyword));

            if (thuoc is not null)
            {
                richTextBox1.Text = $"Tên thuốc: {thuoc.TenThuoc}\n\nHãng sản xuất: {thuoc.HangSanXuat}\nXuất xứ: {thuoc.NuocSanXuat}\nĐơn Vị Tính: {thuoc.DonViTinh}\nHàm lượng: {thuoc.HamLuong}";
                btnThemThuoc.Tag = thuoc;
            }
            else
            {
                MessageBox.Show("Không có loại thuốc này.", "Thông báo");
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLieuDung.Text))
            {
                MessageBox.Show("Phải chỉ định liều dùng.", "Thông báo");
                return;
            }

            var currentSelected = btnThemThuoc.Tag as Medicine;
            var exist = medicines.FirstOrDefault(x => x.MaThuoc == currentSelected.MaThuoc);

            if (exist is null)
            {
                medicines.Add(currentSelected);
                details.Add(new PrescriptionDetail
                {
                    LieuDung = txtLieuDung.Text,
                    MaNhanVien = UserSession.CurrentUser.UserNo,
                    MaKH = "KH-1",
                    MaThuoc = currentSelected.MaThuoc,
                    TenThuoc = currentSelected.TenThuoc,
                });
            }

            LoadChITiet(details);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
