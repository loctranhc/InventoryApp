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
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace InventoryApp
{
    public partial class PrescriptionControl : UserControl
    {
        private InventoryAppDbContext appDbContext;
        private BindingList<PrescriptionDetail> currentPrescription = new BindingList<PrescriptionDetail>();
        private List<Medicine> currentMedicine = new List<Medicine>();

        public PrescriptionControl(InventoryAppDbContext dbContext)
        {
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
        }

        private void InitPrescriptionTable(BindingList<PrescriptionDetail> medicines)
        {
            dgvPrescriptionList.DataSource = medicines;
            dgvPrescriptionList.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvPrescriptionList.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgvPrescriptionList.Columns["LieuDung"].HeaderText = "Liều Dùng";
            dgvPrescriptionList.Columns["Id"].Visible = false;
            dgvPrescriptionList.Columns["PrescriptionId"].Visible = false;
            dgvPrescriptionList.Columns["MaKH"].Visible = false;
            dgvPrescriptionList.Columns["MaNhanVien"].Visible = false;
            dgvPrescriptionList.AllowUserToAddRows = false;
            dgvPrescriptionList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptionList.ReadOnly = true;
            dgvPrescriptionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptionList.AutoGenerateColumns = true;
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
            header.AddFormattedText("Tên đơn vị: TRUNG TÂM Y TẾ HUYỆN BÀU BÀNG", TextFormat.Bold);
            header.Format.Alignment = ParagraphAlignment.Left;

            Paragraph rightHeader = section.AddParagraph();
            rightHeader.AddText("Số phiếu: 17402/2025\nMã y tế: 48012821");
            rightHeader.Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n");

            // Title
            Paragraph title = section.AddParagraph("ĐƠN THUỐC");
            title.Format.Font.Size = 14;
            title.Format.Font.Bold = true;
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.SpaceAfter = 10;

            // Patient Info
            section.AddParagraph("Họ tên: LÊ QUANG BÌNH        Tuổi: 50       Cân nặng: 80 Kg     Nam/Nữ: Nam");
            section.AddParagraph("Mã số thẻ bảo hiểm y tế (nếu có): GD4757424653046");
            section.AddParagraph("Địa chỉ liên hệ: ..., Xã Lai Hưng, Huyện Bàu Bàng, Tỉnh Bình Dương");
            section.AddParagraph("Chẩn đoán: 120 - Cơn đau thắt ngực ổn định không kiểm soát đầy đủ");

            // Treatment
            section.AddParagraph("\n**Thuốc điều trị:**");

            var table = section.AddTable();
            table.Borders.Width = 0.5;
            table.AddColumn("5cm");
            table.AddColumn("2cm");
            table.AddColumn("4cm");

            var headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Cells[0].AddParagraph("Tên thuốc");
            headerRow.Cells[1].AddParagraph("Số lượng");
            headerRow.Cells[2].AddParagraph("Đơn giá (VNĐ)");

            foreach (var medicine in currentPrescription)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(medicine.TenThuoc);
                row.Cells[1].AddParagraph($"{medicine.LieuDung}/lần/ngày");
            }

            // Notes
            section.AddParagraph("\nLời dặn:  Tái khám nhịn ăn sáng XN TQ");

            section.AddParagraph("\n\nNgày 23 tháng 05 năm 2025").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("Bác sỹ/Y sỹ khám bệnh").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("(Ký, ghi rõ họ tên)").Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n\nBS. Nguyễn Thị Hương Giang").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("Thứ hai, 02/06/2025").Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n\n*Khám lại xin mang theo đơn này*");

            // Render PDF
            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();

            string filename = "don_thuoc.pdf";
            renderer.PdfDocument.Save(filename);
            Process.Start("explorer", filename);
        }

        private void pnlSanPhamChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLieuDung.Text))
            {
                MessageBox.Show("Phải chỉ định liều dùng!", "Thông báo");
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
                    TenThuoc = thuoc.TenThuoc
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
            prescription.MaDonThuoc =  $"TT-{prescription.Id}";

            appDbContext.PrescriptionDetails.AddRange(currentPrescription.Select(x => new PrescriptionDetail
            {
                PrescriptionId = prescription.Id,
                LieuDung = x.LieuDung,
                MaKH = x.MaKH,
                MaNhanVien = x.MaNhanVien,
                MaThuoc = x.MaThuoc,
                TenThuoc = x.TenThuoc
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
                var thuoc = currentMedicine.FirstOrDefault(x => x.MaThuoc == maThuoc);

                if (thuoc != null)
                {
                    lblTenHang.Text = thuoc.TenThuoc.ToString();
                    txtMoTa.Text = $"Hãng sản xuất: {thuoc.HangSanXuat}\nXuất xứ: {thuoc.NuocSanXuat}\nĐơn Vị Tính: {thuoc.DonViTinh}\nHàm lượng: {thuoc.HamLuong}";
                    txtLieuDung.Text = lieuDung;
                    btnAddCart.Tag = thuoc;
                }
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm(appDbContext);
            form.ShowDialog();
        }
    }
}
