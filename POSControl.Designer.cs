using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using InventoryApp.Session;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    public partial class POSControl : UserControl
    {
        private List<Product> currentOrder = new List<Product>();
        private Order order = new Order();
        private List<OrderDetail> details = new List<OrderDetail>();
        private BindingList<OrderDetail> _orderDetails = new BindingList<OrderDetail>();
        private decimal total = 0;
        private InventoryAppDbContext context;

        public POSControl(InventoryAppDbContext dbContext)
        {
            context = dbContext;

            InitializeComponent();
            InitOrderTable(new List<OrderDetail>());
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(context.Products.Select(x => x.TenHang).ToArray());
            txtSearch.AutoCompleteCustomSource = autoCompleteData;

            var khachHang = dbContext.Customers.FirstOrDefault(x => x.CustomerNo == "KH-1");
            lblHienThiTenKhach.Text = "Khách mua: " + khachHang.HoTen;
            lblValueMaKhach.Text = khachHang.CustomerNo;

            InitCustomerTable(new List<Customer> { khachHang });
            rbtnTimTheoTen.Checked = true;
            txtTimKhachHang.Text = khachHang.HoTen;
        }

        private void InitOrderTable(List<OrderDetail> details)
        {
            _orderDetails = new BindingList<OrderDetail>(details);
            dgvOrderList.DataSource = _orderDetails;

            dgvOrderList.DataSource = details;
            dgvOrderList.Columns["MaHang"].Visible = false;
            dgvOrderList.Columns["OrderId"].Visible = false;
            dgvOrderList.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvOrderList.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvOrderList.Columns["GiaBan"].HeaderText = "Tạm Tính (VNĐ)";
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.ReadOnly = false;
            dgvOrderList.AutoGenerateColumns = true;
            dgvOrderList.Refresh();
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
            btnColumn.Text = "+ Hoá Đơn";
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

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(context);
            customerForm.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            order.Details = details;
            order.OrderDate = DateTime.Now;
            try
            {
                order.UserNo = UserSession.CurrentUser.UserNo;
            }
            catch (Exception ex)
            {
                order.UserNo = "N/A";
            }

            context.Orders.Add(order);
            context.SaveChanges();

            var newOrder = context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
            newOrder.OrderNo = $"HDBH-{order.OrderId}";

            foreach (var item in details)
                item.OrderId = order.OrderId;

            context.OrderDetails.AddRange(details);
            foreach(var detail in details)
            {
                var product = context.Products.FirstOrDefault(x => x.MaHang == detail.MaHang);
                if (product is not null)
                    product.SoLuongTonKho = product.SoLuongTonKho - detail.SoLuong;
            }

            context.SaveChanges();

            ExportNewInvoiceToPDF();
            MessageBox.Show("Thanh toán thành công!", "Thông báo");
            currentOrder.Clear();
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            total = 0;
            InitOrderTable(new List<OrderDetail>());
            details = new List<OrderDetail>();
            total = 0;
            currentOrder = new List<Product>();
            order = new Order();
        }

        private void dgvOrderList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            InitOrderTable(details);
        }

        private void dgvOrderList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrderList.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                var row = dgvOrderList.Rows[e.RowIndex];
                var soluong = int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out int soLuong);
                var maHang = row.Cells["MaHang"].Value?.ToString();

                var detail = _orderDetails.FirstOrDefault(x => x.MaHang == maHang);
                detail.SoLuong = soLuong;

                var soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == maHang).SoLuongTonKho;
                if (detail.SoLuong > soLuongTon)
                {
                    detail.SoLuong = soLuongTon;
                    soLuong = soLuongTon;
                    MessageBox.Show($"Sản phầm mã {maHang}: {detail.TenHang} này chỉ còn {soLuongTon}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                detail.GiaBan = (decimal)(soLuong * currentOrder.FirstOrDefault(x => x.MaHang == maHang)?.GiaBan);
                total = TongTien();
                lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
            }
        }

        private decimal TongTien()
        {
            return details.Sum(x => x.GiaBan);
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var product = btnAddCart.Tag as Product;
            var soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == product.MaHang).SoLuongTonKho;
            if(soLuongTon <= 0)
            {
                MessageBox.Show($"Sản phầm mã {product.MaHang}: {product.TenHang} này đã hết hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var orderDetail = new OrderDetail();
            if (product != null)
            {
                decimal subtotal = 0;
                var exist = currentOrder.FirstOrDefault(x => x.Id == product.Id);
                if (exist is null)
                {
                    subtotal = product.GiaBan * 1;
                    currentOrder.Add(product);
                    orderDetail.GiaBan = product.GiaBan * 1;
                    orderDetail.MaHang = product.MaHang;
                    orderDetail.SoLuong = 1;
                    orderDetail.TenHang = product.TenHang;
                    details.Add(orderDetail);
                    InitOrderTable(details);
                }
                else
                {
                    var detail = details.FirstOrDefault(x => x.MaHang.Equals(product.MaHang));
                    detail.SoLuong++;

                    soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == product.MaHang).SoLuongTonKho;

                    if(detail.SoLuong > soLuongTon)
                    {
                        detail.SoLuong = soLuongTon;
                        MessageBox.Show($"Sản phầm mã {product.MaHang}: {product.TenHang} này chỉ còn {soLuongTon}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    detail.GiaBan = detail.SoLuong * product.GiaBan;
                    InitOrderTable(details);
                }

                total = details.Sum(x => x.GiaBan);
                lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
            }
        }

        private void rbtnTimTheoSoDienThoai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTimTheoSoDienThoai.Checked)
            {
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(context.Customers.Select(x => x.Phone).ToArray());
                txtTimKhachHang.AutoCompleteCustomSource = autoCompleteData;
            }
        }

        private void rbtnTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTimTheoTen.Checked)
            {
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(context.Customers.Select(x => x.HoTen).ToArray());
                txtTimKhachHang.AutoCompleteCustomSource = autoCompleteData;
            }
        }

        private void dgvOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang format cột "TamTinh"
            if (dgvOrderList.Columns[e.ColumnIndex].Name == "GiaBan" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }


        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            var queryText = txtTimKhachHang.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var cutomers = context.Customers.Where(x => x.HoTen.Contains(queryText) || x.Phone.Contains(queryText) || x.CustomerNo.ToLower().Contains(queryText.ToLower()));
            InitCustomerTable(cutomers.ToList());
        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            var queryText = txtTimKhachHang.Text;

            if (string.IsNullOrEmpty(queryText))
                return;

            var cutomers = context.Customers.Where(x => x.HoTen.Contains(queryText) || x.Phone.Contains(queryText) || x.CustomerNo.ToLower().Contains(queryText.ToLower()));
            InitCustomerTable(cutomers.ToList());
        }

        private void gridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridViewKhachHang.Columns["btnThem"].Index)
            {
                // Lấy thông tin khách hàng từ dòng được chọn
                string maKH = gridViewKhachHang.Rows[e.RowIndex].Cells["CustomerNo"].Value?.ToString();

                var khachHang = context.Customers.FirstOrDefault(x => x.CustomerNo == maKH);
                if (khachHang is not null)
                {
                    lblHienThiTenKhach.Text = "Khách mua: " + khachHang.HoTen;
                    lblValueMaKhach.Text = khachHang.CustomerNo;
                }
            }
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var product = context.Products.FirstOrDefault(x => x.MaHang.ToLower().Contains(txtSearch.Text.Trim()) || x.TenHang.ToLower().Contains(txtSearch.Text.Trim()));
            if (product != null)
            {
                lblGiaBan.Text = product.GiaBan.ToString("N0") + " VNĐ";
                lblTenHang.Text = product.TenHang;
                lblSoLuongTon.Text = product.SoLuongTonKho.ToString();
                txtMoTa.Text = "N/A";
                lbDVT.Text = string.IsNullOrEmpty(product.DonViTinh) ? "Cái" : product.DonViTinh;
                btnAddCart.Tag = product;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var product = context.Products.FirstOrDefault(x => x.MaHang.ToLower().Contains(txtSearch.Text.Trim()) || x.TenHang.ToLower().Contains(txtSearch.Text.Trim()));
            if (product != null)
            {
                lblGiaBan.Text = product.GiaBan.ToString("N0") + " VNĐ";
                lblTenHang.Text = product.TenHang;
                lblSoLuongTon.Text = product.SoLuongTonKho.ToString();
                txtMoTa.Text = "N/A";
                lbDVT.Text = string.IsNullOrEmpty(product.DonViTinh) ? "Cái" : product.DonViTinh;
                btnAddCart.Tag = product;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm này.", "InventoryApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblDonViTinh_Click(object sender, EventArgs e)
        {

        }

        private void ExportNewInvoiceToPDF()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 10;

            // Header cửa hàng
            var header = section.AddParagraph("Quầy Thuốc Bác Sĩ Chín");
            header.Format.Alignment = ParagraphAlignment.Center;
            header.Format.Font.Bold = true;
            header.Format.Font.Size = 14;

            //section.AddParagraph("www.bachhoaxanh.com", "Normal").Format.Alignment = ParagraphAlignment.Center;
            //section.AddParagraph("1212 - 1214 Huỳnh Tấn Phát, Khu phố 5, Phường Tân Phú, Quận 7, TP. HCM", "Normal").Format.Alignment = ParagraphAlignment.Center;

            section.AddParagraph("\nPHIẾU THANH TOÁN", "Normal").Format.Alignment = ParagraphAlignment.Center;
            section.AddParagraph("\nHoá đơn số: " + order.OrderNo);
            section.AddParagraph("Ngày lập hoá đơn: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            section.AddParagraph("Mã nhân viên: " + order.UserNo);
            section.AddParagraph("Tên nhân viên: " + UserSession.CurrentUser.HoTen);

            section.AddParagraph("\n");

            // Table Sản phẩm
            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.AddColumn("6cm"); // Tên SP
            table.AddColumn("2cm"); // Số lượng
            table.AddColumn("3cm"); // Đơn giá
            table.AddColumn("3cm"); // Thành tiền

            var headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Tên Sản Phẩm");
            headerRow.Cells[1].AddParagraph("SL");
            headerRow.Cells[2].AddParagraph("Đơn Giá");
            headerRow.Cells[3].AddParagraph("T.Tiền");

            foreach (var item in details)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(item.TenHang);
                row.Cells[1].AddParagraph(item.SoLuong.ToString("0.##"));
                row.Cells[2].AddParagraph(item.GiaBan.ToString("N0"));
                row.Cells[3].AddParagraph((item.SoLuong * item.GiaBan).ToString("N0"));
            }

            section.AddParagraph("\nTổng tiền: " + total.ToString("N0") + " VNĐ");
            var pThanhToan = section.AddParagraph("Thanh toán: " + total.ToString("N0") + " VNĐ");
            pThanhToan.Format.Font.Bold = true;
            section.AddParagraph("\n(Giá trên đã bao gồm thuế GTGT)").Format.Font.Italic = true;

            // Ghi chú
            section.AddParagraph("\nLưu ý: Hóa đơn chỉ xuất trong ngày. Quý khách vui lòng liên hệ thu ngân để được hỗ trợ.");

            // Tạo PDF
            string filename = "hoa_don_ban_hang.pdf";
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filename);

            Process.Start(new ProcessStartInfo { FileName = filename, UseShellExecute = true });
        }


        private void ExportInvoiceToPDF()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 12;

            section.AddParagraph("HÓA ĐƠN BÁN HÀNG").Format.Font.Size = 16;
            section.AddParagraph("Mã Hoá Đơn: " + order.OrderNo);
            section.AddParagraph("Mã Nhân Viên: " + order.UserNo);
            section.AddParagraph("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"));
            section.AddParagraph("");

            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.AddColumn("5cm");
            table.AddColumn("3cm");
            table.AddColumn("4cm");

            var headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Tên Sản Phẩm");
            headerRow.Cells[1].AddParagraph("Số Lượng");
            headerRow.Cells[2].AddParagraph("Thành Tiền");

            foreach (var item in details)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(item.TenHang);
                row.Cells[1].AddParagraph(item.SoLuong.ToString());
                row.Cells[2].AddParagraph(item.GiaBan.ToString("N0") + " VNĐ");
            }

            section.AddParagraph("\nTổng cộng: " + total.ToString("N0") + " VNĐ");

            string filename = "hoa_don_ban_hang.pdf";
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filename);

            Process.Start(new ProcessStartInfo { FileName = filename, UseShellExecute = true });
        }
        private Panel panelRight;
        private Panel pnlSanPhamChiTiet;
        private RichTextBox txtMoTa;
        private Label lblGiaBan;
        private Label lblTenHang;
        private Label lblSoLuongTon;
        private Label label3;
        private Button button1;
        private CuoreUI.Controls.cuiButton btnAddCart;
        private CuoreUI.Controls.cuiButton btnSearch;
        private Label label1;
        private Label lblDonViTinh;
        private Label label2;
        private CuoreUI.Controls.cuiButton btnThanhToan;
        private Label lbDVT;
        private TextBox txtSearch;
        private CuoreUI.Controls.cuiButton btnTimKhachHang;
        private Label label6;
        private DataGridView gridViewKhachHang;
        private RadioButton rbtnTimTheoSoDienThoai;
        private RadioButton rbtnTimTheoTen;
        private CuoreUI.Controls.cuiButton btnThemKhachHang;
        private Label lbnHienThiMaKhach;
        private Label lblHienThiTenKhach;
        private TextBox txtTimKhachHang;
        private Label lblValueMaKhach;
    }
}
