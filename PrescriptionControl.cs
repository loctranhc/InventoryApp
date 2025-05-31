using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Vml;
using InventoryApp.Session;
using Microsoft.VisualBasic.Devices;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigrateDatabase;
using MigrateDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace InventoryApp
{
    public partial class PrescriptionControl : UserControl
    {
        private InventoryAppDbContext appDbContext;
        private BindingList<PrescriptionDetail> currentPrescription = new BindingList<PrescriptionDetail>();
        private List<Medicine> currentMedicine = new List<Medicine>();
        private Customer curentCustomer = new Customer();
        private string PrescriptionNo = "";

        public PrescriptionControl(InventoryAppDbContext dbContext)
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            appDbContext = dbContext;

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            var medicines = appDbContext.Medicines;
            autoCompleteStringCollection.AddRange(medicines.Select(x => x.TenThuoc).ToArray());
            autoCompleteStringCollection.AddRange(medicines.Select(x => x.MaThuoc).ToArray());
            txtSearch.AutoCompleteCustomSource = autoCompleteStringCollection;

            var defaultKhachHang = appDbContext.Customers.FirstOrDefault(x => x.CustomerNo == "KH-1");
            InitCustomerTable(new List<Customer> { defaultKhachHang });
            lblValueMaKhach.Text = defaultKhachHang.CustomerNo;
            lblValueTenKhachHang.Text = defaultKhachHang.HoTen;

            comboBox1.Items.Add("Chưa chọn");
            comboBox1.Items.AddRange(dbContext.Prescriptions.Where(x => x.IsToaThuocMau == true).Select(x => x.TenDonThuoc).ToArray());
        }

        private void InitPrescriptionTable(BindingList<PrescriptionDetail> medicines)
        {
            dgvPrescriptionList.DataSource = medicines;
            dgvPrescriptionList.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvPrescriptionList.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgvPrescriptionList.Columns["LieuDung"].HeaderText = "Liều Dùng";
            dgvPrescriptionList.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvPrescriptionList.Columns["Id"].Visible = false;
            dgvPrescriptionList.Columns["PrescriptionId"].Visible = false;
            dgvPrescriptionList.Columns["MaKH"].Visible = false;
            dgvPrescriptionList.Columns["MaNhanVien"].Visible = false;
            dgvPrescriptionList.AllowUserToAddRows = false;
            dgvPrescriptionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptionList.ReadOnly = true;
            dgvPrescriptionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptionList.AutoGenerateColumns = true;
            // Tạo mới cột button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Thao Tác";
            btnColumn.Text = "Xoá";
            btnColumn.Name = "btnXoa";
            btnColumn.UseColumnTextForButtonValue = true;
            if (!dgvPrescriptionList.Columns.Contains("btnXoa"))
            {
                dgvPrescriptionList.Columns.Add(btnColumn);
            }
            dgvPrescriptionList.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var thuoc = appDbContext.Medicines.FirstOrDefault(x => x.TenThuoc.ToLower().Contains(keyword) || x.MaThuoc.ToLower().Contains(keyword));

            if (thuoc is not null)
            {
                lblTenHang.Text = thuoc.TenThuoc.ToString();
                txtMoTa.Text = $"Hãng sản xuất: {thuoc.HangSanXuat}\nXuất xứ: {thuoc.NuocSanXuat}\nĐơn Vị Tính: {thuoc.DonViTinh}\nHàm lượng: {thuoc.HamLuong}";
                btnAddCart.Tag = thuoc;
            }
            else
            {
                MessageBox.Show("Không có loại thuốc này.", "Thông báo");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrescriptionPdf()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            // Set margins for this section
            section.PageSetup.TopMargin = Unit.FromCentimeter(1);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);

            // Set default font style
            var normal = doc.Styles["Normal"];
            normal.Font.Name = "Times New Roman";
            normal.Font.Size = 12;

            // Header
            Paragraph header = section.AddParagraph();
            header.AddFormattedText("Tên đơn vị: Quầy Thuốc Bác Sĩ Chín", TextFormat.Bold);
            header.AddFormattedText("\nĐịa chỉ: CFVP+Q7W, ĐT749B, Minh Hoà, Dầu Tiếng, Bình Dương, Việt Nam", TextFormat.Bold);
            header.Format.Alignment = ParagraphAlignment.Left;

            Paragraph rightHeader = section.AddParagraph();
            rightHeader.Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n");

            // Title
            Paragraph title = section.AddParagraph("ĐƠN THUỐC");
            title.Format.Font.Size = 14;
            title.Format.Font.Bold = true;
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.SpaceAfter = 10;

            // Patient Info
            section.AddParagraph($"Mã đơn thuốc: {PrescriptionNo}");
            section.AddParagraph($"Họ tên: {lblValueTenKhachHang.Text}");
            section.AddParagraph($"Địa chỉ liên hệ: {curentCustomer.DiaChi}");
            section.AddParagraph($"Số điện thoại liên hệ: {curentCustomer.Phone}");

            // Treatment
            section.AddParagraph("\n**Thuốc điều trị:**");

            var table = section.AddTable();
            table.Borders.Width = 0.5;
            table.AddColumn("6cm");
            table.AddColumn("3cm");
            table.AddColumn("3cm");
            table.AddColumn("5cm");

            var headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Cells[0].AddParagraph("Tên thuốc");
            headerRow.Cells[1].AddParagraph("Số Lượng");
            headerRow.Cells[2].AddParagraph("Liều dùng");
            headerRow.Cells[3].AddParagraph("Ghi chú");

            foreach (var medicine in currentPrescription)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(medicine.TenThuoc);
                row.Cells[1].AddParagraph(medicine.SoLuong.ToString());
                row.Cells[2].AddParagraph($"{medicine.LieuDung}/lần/ngày");
            }

            section.AddParagraph("\nLời dặn:  ..........................................");

            section.AddParagraph($"\n\nNgày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("Bác sỹ/Y sỹ khám bệnh").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("(Ký, ghi rõ họ tên)").Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n\n*Khám lại xin mang theo đơn này*");

            // Render PDF
            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();

            string filename = $"{PrescriptionNo}_{DateTimeOffset.Now.ToUnixTimeSeconds()}.pdf";
            // 1. Tạo thư mục lưu trữ theo thời gian hiện tại
            string folderName = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string baseFolder = @"D:\toathuoc";
            string fullPath = System.IO.Path.Combine(baseFolder, folderName);
            // 2. Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);
            // 3. Đường dẫn file đầy đủ
            string filePath = System.IO.Path.Combine(fullPath, filename);
            renderer.PdfDocument.Save(filename);
            Process.Start("explorer", filename);
        }

        private void pnlSanPhamChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
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
                MessageBox.Show("Phải chỉ định liều dùng!", "Thông báo");
                return;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo");
                return;
            }
            var thuoc = btnAddCart.Tag as Medicine;
            if (thuoc is not null)
            {
                var exitst = currentPrescription.FirstOrDefault(x => x.MaThuoc == thuoc.MaThuoc);
                if (exitst is not null)
                {
                    currentPrescription.Remove(exitst);
                }

                currentPrescription.Add(new PrescriptionDetail
                {
                    LieuDung = txtLieuDung.Text,
                    MaKH = lblValueMaKhach.Text,
                    MaNhanVien = UserSession.CurrentUser.UserNo,
                    MaThuoc = thuoc.MaThuoc,
                    TenThuoc = thuoc.TenThuoc,
                    SoLuong = int.Parse(txtSoLuong.Text),
                });
                currentMedicine.Add(thuoc);

                InitPrescriptionTable(currentPrescription);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void gridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridViewKhachHang.Columns["btnThem"].Index)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                string maKH = gridViewKhachHang.Rows[e.RowIndex].Cells["CustomerNo"].Value?.ToString();

                var khachHang = appDbContext.Customers.FirstOrDefault(x => x.CustomerNo == maKH);
                if (khachHang is not null)
                {
                    lblValueTenKhachHang.Text = khachHang.HoTen;
                    lblValueMaKhach.Text = khachHang.CustomerNo;
                    curentCustomer = khachHang;
                }
            }
        }

        private void InitCustomerTable(List<Customer> customers)
        {
            gridViewKhachHang.DataSource = new BindingList<Customer>(customers);

            gridViewKhachHang.DataSource = customers;
            gridViewKhachHang.Columns["Id"].Visible = false;
            gridViewKhachHang.Columns["CustomerNo"].HeaderText = "Mã Khách Hàng";
            gridViewKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
            gridViewKhachHang.Columns["Phone"].HeaderText = "Số Điện Thoại";
            gridViewKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            gridViewKhachHang.Columns["DiemTichLuy"].HeaderText = "Điểm Tích Luỹ";
            gridViewKhachHang.Columns["DiemTichLuy"].Visible = false;
            gridViewKhachHang.Columns["GioiTinh"].Visible = false;

            // Tạo mới cột button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Thao Tác";
            btnColumn.Text = "Thêm Bệnh Nhân";
            btnColumn.Name = "btnThem";
            btnColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView (ví dụ tên là dgvKhachHang)
            if (!gridViewKhachHang.Columns.Contains("btnThem"))
            {
                gridViewKhachHang.Columns.Add(btnColumn);
            }

            gridViewKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewKhachHang.AllowUserToAddRows = false;
            gridViewKhachHang.ReadOnly = true;
            gridViewKhachHang.AutoGenerateColumns = true;
            gridViewKhachHang.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var medicine = appDbContext.Medicines.FirstOrDefault(x => x.MaThuoc.ToLower().Contains(txtSearch.Text.Trim()) || x.TenThuoc.ToLower().Contains(txtSearch.Text.Trim()));
            if (medicine != null)
            {
                lblTenHang.Text = medicine.TenThuoc.ToString();
                txtMoTa.Text = $"Hãng sản xuất: {medicine.HangSanXuat}\nXuất xứ: {medicine.NuocSanXuat}\nĐơn Vị Tính: {medicine.DonViTinh}\nHàm lượng: {medicine.HamLuong}";
                btnAddCart.Tag = medicine;
            }
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            var queryText = txtTimKhachHang.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var cutomers = appDbContext.Customers.Where(x => x.HoTen.Contains(queryText) || x.Phone.Contains(queryText) || x.CustomerNo.ToLower().Contains(queryText.ToLower()));
            InitCustomerTable(cutomers.ToList());
        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            var queryText = txtTimKhachHang.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var cutomers = appDbContext.Customers.Where(x => x.HoTen.Contains(queryText) || x.Phone.Contains(queryText) || x.CustomerNo.ToLower().Contains(queryText.ToLower()));
            InitCustomerTable(cutomers.ToList());
        }

        private void rbtnTimTheoSoDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTimTheoSoDienThoai.Checked)
            {
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(appDbContext.Customers.Select(x => x.Phone).ToArray());
                txtTimKhachHang.AutoCompleteCustomSource = autoCompleteData;
            }
        }

        private void rbtnTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTimTheoTen.Checked)
            {
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(appDbContext.Customers.Select(x => x.HoTen).ToArray());
                txtTimKhachHang.AutoCompleteCustomSource = autoCompleteData;
            }
        }

        private void dgvPrescriptionList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPrescriptionList.Columns[e.ColumnIndex].Name == "LieuDung" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = $"{value}/lần/ngày";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var maThuoc = Guid.NewGuid().ToString();
            appDbContext.Prescriptions.Add(new Prescription
            {
                MaDonThuoc = maThuoc
            });
            appDbContext.SaveChanges();

            var prescription = appDbContext.Prescriptions.FirstOrDefault(x => x.MaDonThuoc == maThuoc);
            prescription.MaDonThuoc = $"TT-{prescription.Id}";
            PrescriptionNo = prescription.MaDonThuoc;

            appDbContext.PrescriptionDetails.AddRange(currentPrescription.Select(x => new PrescriptionDetail
            {
                PrescriptionId = prescription.Id,
                LieuDung = x.LieuDung,
                MaKH = x.MaKH,
                MaNhanVien = x.MaNhanVien,
                MaThuoc = x.MaThuoc,
                TenThuoc = x.TenThuoc,
                SoLuong = x.SoLuong
            }));

            appDbContext.SaveChanges();

            CreatePrescriptionPdf();
            currentPrescription = new BindingList<PrescriptionDetail>();
            currentMedicine = new List<Medicine>();
        }

        private void dgvPrescriptionList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPrescriptionList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPrescriptionList.SelectedRows[0];
                string maThuoc = selectedRow.Cells["MaThuoc"].Value?.ToString();
                string lieuDung = selectedRow.Cells["LieuDung"].Value?.ToString().Split('/').First();
                string soLuong = selectedRow.Cells["SoLuong"].Value?.ToString();
                var thuoc = currentMedicine.FirstOrDefault(x => x.MaThuoc == maThuoc);

                if (thuoc != null)
                {
                    lblTenHang.Text = thuoc.TenThuoc.ToString();
                    txtMoTa.Text = $"Hãng sản xuất: {thuoc.HangSanXuat}\nXuất xứ: {thuoc.NuocSanXuat}\nĐơn Vị Tính: {thuoc.DonViTinh}\nHàm lượng: {thuoc.HamLuong}";
                    txtLieuDung.Text = lieuDung;
                    txtSoLuong.Text = soLuong;
                    btnAddCart.Tag = thuoc;
                }
            }

            if (e.RowIndex >= 0 && dgvPrescriptionList.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                var row = dgvPrescriptionList.Rows[e.RowIndex];
                var maThuoc = row.Cells["MaThuoc"].Value?.ToString();

                var medicine = currentMedicine.FirstOrDefault(x => x.MaThuoc == maThuoc);
                if (medicine is not null)
                {
                    currentMedicine.Remove(medicine);
                    var prescription = currentPrescription.FirstOrDefault(x => x.MaThuoc == medicine.MaThuoc);
                    if (prescription is not null)
                        currentPrescription.Remove(prescription);
                }

                InitPrescriptionTable(currentPrescription);
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(appDbContext);
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var toaThuoc = appDbContext.Prescriptions.FirstOrDefault(x => x.TenDonThuoc.ToLower() == comboBox1.Text.ToLower());
            if (toaThuoc is not null)
            {
                currentPrescription.Clear();
                currentMedicine.Clear();
                var chiTiet = appDbContext.PrescriptionDetails.Where(x => x.PrescriptionId == toaThuoc.Id).ToList();
                foreach (var item in chiTiet)
                {
                    currentPrescription.Add(item);
                    var thuoc = appDbContext.Medicines.FirstOrDefault(x => x.MaThuoc == item.MaThuoc);
                    currentMedicine.Add(thuoc);
                }

                InitPrescriptionTable(currentPrescription);
            }
        }

        private void dgvPrescriptionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
