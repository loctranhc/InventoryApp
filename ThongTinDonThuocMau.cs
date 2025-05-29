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
        private BindingList<PrescriptionDetail> details = new BindingList<PrescriptionDetail>();
        private List<Medicine> medicines = new List<Medicine>();
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
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.TenThuoc).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.MaThuoc).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        public ThongTinDonThuocMau(InventoryAppDbContext Context, Prescription prescription, string FormStyle = "Edit")
        {
            InitializeComponent();
            dbContext = Context;
            LoadChITiet(details);
            richTextBox1.ReadOnly = true;
            txtLieuDung.Text = "1";
            txtSoLuong.Text = "1";
            _frmStyle = FormStyle;

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.TenThuoc).ToArray());
            autoCompleteStringCollection.AddRange(dbContext.Medicines.Select(x => x.MaThuoc).ToArray());
            txtTimKiemThuoc.AutoCompleteCustomSource = autoCompleteStringCollection;

            var chiTiet = dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == prescription.Id).ToList();
            foreach (var item in chiTiet)
            {
                details.Add(item);
                var thuoc = dbContext.Medicines.FirstOrDefault(X => X.MaThuoc == item.MaThuoc);
                if (thuoc != null)
                    medicines.Add(thuoc);
            }
            
            txtTenDonThuoc.Text = prescription.TenDonThuoc;
            LoadChITiet(details);
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
            try
            {
                int.Parse(txtSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtLieuDung.Text))
            {
                MessageBox.Show("Phải chỉ định liều dùng.", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Thông báo");
                return;
            }

            var currentSelected = btnThemThuoc.Tag as Medicine;
            var exist = medicines.FirstOrDefault(x => x.MaThuoc == currentSelected.MaThuoc);

            if (currentSelected != null)
            {
                if(exist is not null)
                {
                    medicines.Remove(exist);
                    var exists = details.FirstOrDefault(x => x.MaThuoc == currentSelected.MaThuoc);
                    details.Remove(exists);
                }

                var maNhanVien = "";
                try
                {
                    maNhanVien = UserSession.CurrentUser.UserNo;
                }
                catch
                {
                    maNhanVien = "N/A";
                }

                medicines.Add(currentSelected);
                details.Add(new PrescriptionDetail
                {
                    LieuDung = txtLieuDung.Text,
                    MaNhanVien = maNhanVien,
                    MaKH = "KH-1",
                    MaThuoc = currentSelected.MaThuoc,
                    TenThuoc = currentSelected.TenThuoc,
                    SoLuong = int.Parse(txtSoLuong.Text)
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
                string maThuoc = dgvDonThuoc.Rows[e.RowIndex].Cells["MaThuoc"].Value?.ToString();

                var thuoc = details.FirstOrDefault(x => x.MaThuoc == maThuoc);
                if (thuoc != null)
                    details.Remove(thuoc);

                LoadChITiet(details);
                return;
            }

            if (dgvDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDonThuoc.SelectedRows[0];
                string maThuoc = selectedRow.Cells["MaThuoc"].Value?.ToString();
                string lieuDung = selectedRow.Cells["LieuDung"].Value?.ToString().Split('/').First();
                string soLuong = selectedRow.Cells["SoLuong"].Value?.ToString();
                var thuoc = medicines.FirstOrDefault(x => x.MaThuoc == maThuoc);

                if (thuoc != null)
                {
                    richTextBox1.Text = $"Tên thuốc: {thuoc.TenThuoc}\n\nHãng sản xuất: {thuoc.HangSanXuat}\nXuất xứ: {thuoc.NuocSanXuat}\nĐơn Vị Tính: {thuoc.DonViTinh}\nHàm lượng: {thuoc.HamLuong}";
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

            var toaThuoc = dbContext.Prescriptions.FirstOrDefault(x => x.TenDonThuoc.ToLower() == txtTenDonThuoc.Text.ToLower());
            if (toaThuoc is not null)
            {
                if (_frmStyle.Equals("Edit"))
                {
                    var chiTietToaThuoc = dbContext.PrescriptionDetails.Where(x => x.PrescriptionId == toaThuoc.Id).ToList();
                    dbContext.RemoveRange(chiTietToaThuoc);

                    dbContext.PrescriptionDetails.AddRange(details.Select(x => new PrescriptionDetail
                    {
                        LieuDung = x.LieuDung,
                        MaKH = x.MaKH,
                        MaNhanVien = x.MaNhanVien,
                        MaThuoc = x.MaThuoc,
                        PrescriptionId = toaThuoc.Id,
                        SoLuong = x.SoLuong,
                        TenThuoc = x.TenThuoc
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

            toaThuoc = new Prescription
            {
                IsToaThuocMau = true,
                MaDonThuoc = string.Empty,
                TenDonThuoc = txtTenDonThuoc.Text
            };
            dbContext.Prescriptions.Add(toaThuoc);
            dbContext.SaveChanges();

            foreach (var item in details)
            {
                item.PrescriptionId = toaThuoc.Id;
                dbContext.PrescriptionDetails.Add(item);
            }
            var newToaThuoc = dbContext.Prescriptions.FirstOrDefault(x => x.Id == toaThuoc.Id);
            newToaThuoc.MaDonThuoc = $"TT-{newToaThuoc.Id}";
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
