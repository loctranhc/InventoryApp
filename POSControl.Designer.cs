using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office.CustomUI;
using InventoryApp.Session;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Visitors;
using MigraDoc.Rendering;
using MigrateDatabase;
using MigrateDatabase.Models;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ComboBox = System.Windows.Forms.ComboBox;

namespace InventoryApp
{
    public partial class POSControl : UserControl
    {
        private List<Product> currentProduct = new List<Product>();
        private Order order = new Order();
        private List<OrderDetail> details = new List<OrderDetail>();
        private BindingList<OrderDetail> _orderDetails = new BindingList<OrderDetail>();
        private decimal total = 0;
        private InventoryAppDbContext context;
        private Customer curentCustomer = new Customer();

        public POSControl(InventoryAppDbContext dbContext)
        {
            context = dbContext;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            InitOrderTable(new List<OrderDetail>());
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(context.Products.Where(x => x.IsHidden == false).Select(x => x.TenHang).ToArray());
            txtSearch.AutoCompleteCustomSource = autoCompleteData;

            var khachHang = dbContext.Customers.FirstOrDefault(x => x.CustomerNo == "KH-1");
            lblHienThiTenKhach.Text = "Khách mua: " + khachHang.HoTen;
            lblValueMaKhach.Text = khachHang.CustomerNo;

            InitCustomerTable(new List<Customer> { khachHang });
            rbtnTimTheoTen.Checked = true;
            txtTimKhachHang.Text = khachHang.HoTen;
            txtGiamGia.Value = 0;

            cbxToaThuocMau.Items.AddRange(dbContext.Orders.Where(x => x.IsHoaDonMau == true)
                                                          .Select(x => x.TenHoaDon)
                                                          .ToArray());
        }

        private void InitOrderTable(List<OrderDetail> details)
        {
            _orderDetails = new BindingList<OrderDetail>(details);
            dgvOrderList.DataSource = _orderDetails;

            dgvOrderList.DataSource = details;
            dgvOrderList.Columns["Id"].Visible = false;
            dgvOrderList.Columns["MaHang"].Visible = false;
            dgvOrderList.Columns["OrderId"].Visible = false;
            dgvOrderList.Columns["CreatedTime"].Visible = false;
            dgvOrderList.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvOrderList.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvOrderList.Columns["LieuDung"].HeaderText = "Liều Dùng";
            dgvOrderList.Columns["GiaBan"].HeaderText = "Tạm Tính (VNĐ)";

            // Tạo mới cột button
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Thao Tác";
            btnColumn.Text = "Xoá";
            btnColumn.Name = "btnXoa";
            btnColumn.UseColumnTextForButtonValue = true;
            if (!dgvOrderList.Columns.Contains("btnXoa"))
            {
                dgvOrderList.Columns.Add(btnColumn);
            }

            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.ReadOnly = true;
            dgvOrderList.AutoGenerateColumns = true;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (currentProduct.Count() <= 0)
                return;

            order.Details = details;
            order.OrderDate = DateTime.Now;
            order.PhanTramGiamGia = int.Parse(txtGiamGia.Value.ToString());
            try
            {
                order.UserNo = UserSession.CurrentUser.UserNo;
                order.MaNhanVien = lblValueMaKhach.Text.Trim();
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
            foreach (var detail in details)
            {
                var product = context.Products.FirstOrDefault(x => x.MaHang == detail.MaHang);
                if (product is not null)
                {
                    NhapXuatHangHoa nhapXuatHangHoa = new NhapXuatHangHoa();
                    nhapXuatHangHoa.SoLuongTonTruoc = product.SoLuongTonKho;
                    nhapXuatHangHoa.SoLuongXuat = detail.SoLuong;
                    nhapXuatHangHoa.SoLuongNhap = 0;
                    nhapXuatHangHoa.MaHang = product.MaHang;
                    nhapXuatHangHoa.TenHang = product.TenHang;
                    nhapXuatHangHoa.CreatedTime = DateTime.Now;
                    nhapXuatHangHoa.ProductId = product.Id;
                    context.NhapXuatHangHoas.Add(nhapXuatHangHoa);

                    product.SoLuongTonKho = product.SoLuongTonKho - detail.SoLuong;
                }
            }

            context.SaveChanges();

            ExportNewInvoiceToPDF();
            CreatePrescriptionPdf();
            currentProduct.Clear();
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            total = 0;
            txtGiamGia.Value = 0;
            InitOrderTable(new List<OrderDetail>());
            details = new List<OrderDetail>();
            total = 0;
            currentProduct = new List<Product>();
            order = new Order();
            txtLieuDung.Clear();
            txtSoLuong.Clear();
            lblSoLuongTon.Text = "0";
            lblTenHang.Text = "";
            lblGiaBan.Text = "0:";
            txtMoTa.Clear();
            txtSearch.Clear();
            txtTimKhachHang.Clear();
            MessageBox.Show("Thanh toán thành công!", "Thông báo");
        }

        private void txtGiamGia_ValueChanged(object sender, EventArgs e)
        {
            total = TongTien();
            lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
        }

        private void dgvOrderList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            InitOrderTable(details);
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderList.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvOrderList.SelectedRows[0];
                    string maHang = selectedRow.Cells["MaHang"].Value?.ToString();
                    string tenHang = selectedRow.Cells["TenHang"].Value?.ToString();
                    string soLuong = selectedRow.Cells["SoLuong"].Value?.ToString();
                    string lieuDung = selectedRow.Cells["LieuDung"].Value?.ToString();
                    var hang = _orderDetails.FirstOrDefault(x => x.MaHang.Trim().ToLower().Equals(maHang.Trim().ToLower()));
                    var thongtinHang = currentProduct.FirstOrDefault(x => x.MaHang.Trim().ToLower().Equals(maHang.Trim().ToLower()));

                    if (hang != null)
                    {
                        lblGiaBan.Text = hang.GiaBan.ToString("N0") + " VNĐ";
                        lblTenHang.Text = hang.TenHang;
                        lblSoLuongTon.Text = thongtinHang.SoLuongTonKho.ToString();
                        //lbDVT.Text = string.IsNullOrEmpty(product.DonViTinh) ? "Cái" : product.DonViTinh;
                        txtLieuDung.Text = lieuDung.Trim();
                        txtSoLuong.Text = soLuong.Trim();
                        btnAddCart.Tag = thongtinHang;
                    }
                }


                if (e.RowIndex >= 0 && dgvOrderList.Columns[e.ColumnIndex].Name == "btnXoa")
                {
                    var row = dgvOrderList.Rows[e.RowIndex];
                    var maHang = row.Cells["MaHang"].Value?.ToString();

                    var detail = details.FirstOrDefault(x => x.MaHang == maHang);
                    if (detail is not null)
                    {
                        details.Remove(detail);
                        var product = currentProduct.FirstOrDefault(x => x.MaHang == detail.MaHang);
                        if (product is not null)
                            currentProduct.Remove(product);
                        currentProduct.Remove(product);
                    }

                    total = TongTien();
                    lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
                    InitOrderTable(details);
                }
            }
            catch
            {
                return;
            }
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

                detail.GiaBan = (decimal)(soLuong * currentProduct.FirstOrDefault(x => x.MaHang == maHang)?.GiaBan);
                total = TongTien();
                lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
            }
        }

        private decimal TongTien()
        {
            var tongTien = details.Sum(x => x.GiaBan);

            if (int.Parse(txtGiamGia.Value.ToString()) == 0)
                return tongTien;

            var tiLe = (double)(double.Parse(txtGiamGia.Value.ToString()) / (double)100);
            var result = tongTien - (decimal)((double)tongTien * (double)tiLe);
            return result;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var product = btnAddCart.Tag as Product;

            if(product == null) return;

            var soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == product.MaHang).SoLuongTonKho;
            if (soLuongTon <= 0)
            {
                MessageBox.Show($"Sản phầm mã {product.MaHang}: {product.TenHang} này đã hết hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show($"Chưa nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int.Parse(txtSoLuong.Text);
            }
            catch
            {
                txtSoLuong.Text = "1";
            }

            try
            {
                int.Parse(txtLieuDung.Text);
            }
            catch
            {
                txtLieuDung.Text = "0";
            }

            var orderDetail = new OrderDetail();
            if (product != null)
            {
                decimal subtotal = 0;
                var exist = currentProduct.FirstOrDefault(x => x.Id == product.Id);
                if (exist is null)
                {
                    int slthucte = int.Parse(txtSoLuong.Text);
                    soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == product.MaHang).SoLuongTonKho;

                    if (slthucte > soLuongTon)
                    {
                        slthucte = soLuongTon;
                        MessageBox.Show($"Sản phầm mã {product.MaHang}: {product.TenHang} này chỉ còn {soLuongTon}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    subtotal = product.GiaBan * slthucte;
                    currentProduct.Add(product);
                    orderDetail.GiaBan = product.GiaBan * slthucte;
                    orderDetail.MaHang = product.MaHang;
                    orderDetail.SoLuong = slthucte;
                    orderDetail.TenHang = product.TenHang;
                    orderDetail.LieuDung = int.Parse(txtLieuDung.Text);
                    details.Add(orderDetail);
                    InitOrderTable(details);
                }
                else
                {
                    var detail = details.FirstOrDefault(x => x.MaHang.Equals(product.MaHang));

                    if (string.IsNullOrEmpty(txtSoLuong.Text))
                    {
                        MessageBox.Show($"Chưa nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    try
                    {
                        int.Parse(txtSoLuong.Text);
                    }
                    catch
                    {
                        txtSoLuong.Text = "1";
                    }

                    detail.SoLuong = int.Parse(txtSoLuong.Text);
                    soLuongTon = context.Products.FirstOrDefault(x => x.MaHang == product.MaHang).SoLuongTonKho;

                    if (detail.SoLuong > soLuongTon)
                    {
                        detail.SoLuong = soLuongTon;
                        MessageBox.Show($"Sản phầm mã {product.MaHang}: {product.TenHang} này chỉ còn {soLuongTon}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    detail.GiaBan = detail.SoLuong * product.GiaBan;

                    if (!string.IsNullOrEmpty(txtLieuDung.Text))
                    {
                        try
                        {
                            int.Parse(txtLieuDung.Text);
                        }
                        catch
                        {
                            txtLieuDung.Text = "1";
                        }
                    }
                    detail.LieuDung = int.Parse(txtLieuDung.Text);
                    InitOrderTable(details);
                }

                total = TongTien();
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
                    curentCustomer = khachHang;
                }
            }
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var product = context.Products.FirstOrDefault(x => x.IsHidden == false && x.MaHang.ToLower().Contains(txtSearch.Text.Trim()) || x.TenHang.ToLower().Contains(txtSearch.Text.Trim()));
            if (product != null)
            {
                lblGiaBan.Text = product.GiaBan.ToString("N0") + " VNĐ";
                lblTenHang.Text = product.TenHang;
                lblSoLuongTon.Text = product.SoLuongTonKho.ToString();
                txtMoTa.Text = "N/A";
                //lbDVT.Text = string.IsNullOrEmpty(product.DonViTinh) ? "Cái" : product.DonViTinh;
                btnAddCart.Tag = product;
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var product = context.Products.FirstOrDefault(x => x.IsHidden == false && x.MaHang.ToLower().Contains(txtSearch.Text.Trim()) || x.TenHang.ToLower().Contains(txtSearch.Text.Trim()));
            if (product != null)
            {
                lblGiaBan.Text = product.GiaBan.ToString("N0") + " VNĐ";
                lblTenHang.Text = product.TenHang;
                lblSoLuongTon.Text = product.SoLuongTonKho.ToString();
                txtMoTa.Text = "N/A";
                //lbDVT.Text = string.IsNullOrEmpty(product.DonViTinh) ? "Cái" : product.DonViTinh;
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

        private void cbxToaThuocMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxToaThuocMau.Text))
            {
                var hoaDonMau = context.Orders.FirstOrDefault(x => x.TenHoaDon.Trim() == cbxToaThuocMau.Text.Trim() && x.IsHoaDonMau == true);
                if (hoaDonMau != null)
                {
                    currentProduct = new List<Product>();
                    details = new List<OrderDetail>();

                    var dsHetHang = new List<OrderDetail>();
                    var dsSapHetHang = new List<OrderDetail>();
                    var newListDetails = context.OrderDetails.Where(x => x.OrderId == hoaDonMau.OrderId).ToList();
                    details.AddRange(newListDetails.Select(x => new OrderDetail
                    {
                        GiaBan = context.Products.First(p => p.MaHang.Trim().Equals(x.MaHang)).GiaBan,
                        LieuDung = x.LieuDung,
                        MaHang = x.MaHang,
                        SoLuong = x.SoLuong,
                        TenHang = x.TenHang
                    }));

                    var dsLoadChiTiet = new List<OrderDetail>();
                    dsLoadChiTiet.AddRange(details);
                    foreach (var item in dsLoadChiTiet) {
                        var product = context.Products.FirstOrDefault(x => x.MaHang == item.MaHang);
                        if (product.SoLuongTonKho <= 0)
                        {
                            dsHetHang.Add(item);
                            details.Remove(item);
                            continue;
                        }
                        if(item.SoLuong > product.SoLuongTonKho)
                        {
                            dsSapHetHang.Add(item);
                            item.SoLuong = product.SoLuongTonKho;
                            continue;
                        }

                        currentProduct.Add(product);
                    }

                    if (dsSapHetHang != null && dsSapHetHang.Count > 0)
                        MessageBox.Show($"Những sản phẩm dưới đây sắp hết hàng: {string.Join(",", dsSapHetHang.Select(x => x.TenHang).ToArray())}", "THÔNG BÁO HẾT HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dsHetHang != null && dsHetHang.Count > 0)
                        MessageBox.Show($"Những sản phẩm dưới đây đã hết hàng: {string.Join(",", dsHetHang.Select(x => x.TenHang).ToArray())}", "THÔNG BÁO HẾT HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InitOrderTable(details);
                    total = TongTien();
                    lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";
                }
            }
        }

        private void ExportNewInvoiceToPDF()
        {
            // Tạo tài liệu
            Document doc = new Document();
            Section section = doc.AddSection();

            // Cấu hình khổ giấy 80mm x 210mm
            section.PageSetup.PageWidth = Unit.FromMillimeter(80);   // hoặc Unit.FromInch(2.835)
            section.PageSetup.PageHeight = Unit.FromMillimeter(210); // hoặc Unit.FromInch(8.264)

            // Cấu hình lề nhỏ như hình (0.02 inch ≈ 0.5 mm)
            section.PageSetup.LeftMargin = Unit.FromInch(0.02);
            section.PageSetup.RightMargin = Unit.FromInch(0.02);
            section.PageSetup.TopMargin = Unit.FromInch(0.02);
            section.PageSetup.BottomMargin = Unit.FromInch(0.02);

            // Thiết lập font mặc định
            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 8;

            // Header cửa hàng
            var header = section.AddParagraph("\n\nQuầy Thuốc Bác Sĩ Chín\n");
            header.Format.Alignment = ParagraphAlignment.Center;
            header.Format.Font.Bold = true;
            header.Format.Font.Size = 14;

            section.AddParagraph("CFVP+Q7W, ĐT749B, Minh Hoà, Dầu Tiếng, Bình Dương, Việt Nam", "Normal").Format.Alignment = ParagraphAlignment.Center;

            // Tiêu đề phiếu
            var title = section.AddParagraph("\nPHIẾU THANH TOÁN");
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font.Bold = true;
            title.Format.Font.Size = 16;

            // Thông tin hóa đơn
            section.AddParagraph("\n  Hoá đơn số: " + order.OrderNo);
            section.AddParagraph("  Ngày lập hoá đơn: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            section.AddParagraph("  Mã nhân viên: " + order.UserNo);
            section.AddParagraph("  Tên nhân viên: " + UserSession.CurrentUser.HoTen);
            section.AddParagraph("  Mã khách hàng: " + lblValueMaKhach.Text);
            section.AddParagraph("  Tên khách hàng: " + lblHienThiTenKhach.Text.Replace("Khách mua: ", ""));

            section.AddParagraph("\n");

            // Bảng sản phẩm
            var table = section.AddTable();
            table.Format.Alignment = ParagraphAlignment.Center;
            table.Borders.Width = 0.75;

            // Định nghĩa cột (cộng lại < 8.0cm để vừa khổ giấy 80mm)
            table.AddColumn("3.5cm"); // Tên SP
            table.AddColumn("1.2cm"); // SL
            table.AddColumn("1.5cm"); // Đơn giá
            table.AddColumn("1.8cm"); // Thành tiền

            // Dòng tiêu đề bảng
            var headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Tên Sản Phẩm");
            headerRow.Cells[1].AddParagraph("SL");
            headerRow.Cells[2].AddParagraph("Đơn Giá");
            headerRow.Cells[3].AddParagraph("T.Tiền");

            // Dữ liệu sản phẩm
            foreach (var item in details)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(item.TenHang);
                row.Cells[1].AddParagraph(item.SoLuong.ToString("0.##"));
                row.Cells[2].AddParagraph((item.GiaBan / item.SoLuong).ToString("N0"));
                row.Cells[3].AddParagraph(item.GiaBan.ToString("N0"));
            }

            // Tổng kết
            section.AddParagraph("\n  Giảm giá: " + txtGiamGia.Value + "%");
            section.AddParagraph("  Tổng tiền: " + total.ToString("N0") + " VNĐ");
            var pThanhToan = section.AddParagraph("  Thanh toán: " + total.ToString("N0") + " VNĐ");
            pThanhToan.Format.Font.Bold = true;

            section.AddParagraph("\n  (Giá trên đã bao gồm thuế GTGT)").Format.Font.Italic = true;
            section.AddParagraph("\n  Lưu ý: Hóa đơn chỉ xuất trong ngày. Quý khách vui lòng liên hệ thu ngân để được hỗ trợ.");

            // Xuất PDF
            string filename = $"{order.OrderNo.ToLower()}_{DateTimeOffset.Now.ToUnixTimeSeconds()}.pdf";
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();

            // Tạo thư mục lưu file
            string folderName = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string baseFolder = @"D:\hoadonbanhang";
            string fullPath = Path.Combine(baseFolder, folderName);
            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);

            string filePath = Path.Combine(fullPath, filename);
            renderer.PdfDocument.Save(filePath);

            // Mở file PDF
            Process.Start(new ProcessStartInfo { FileName = filePath, UseShellExecute = true });
        }


        private void CreatePrescriptionPdf()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            // Cấu hình khổ giấy 80mm x 210mm
            section.PageSetup.PageWidth = Unit.FromMillimeter(80);   // hoặc Unit.FromInch(2.835)
            section.PageSetup.PageHeight = Unit.FromMillimeter(210); // hoặc Unit.FromInch(8.264)

            // Cấu hình lề nhỏ như hình (0.02 inch ≈ 0.5 mm)
            section.PageSetup.LeftMargin = Unit.FromInch(0.02);
            section.PageSetup.RightMargin = Unit.FromInch(0.02);
            section.PageSetup.TopMargin = Unit.FromInch(0.02);
            section.PageSetup.BottomMargin = Unit.FromInch(0.02);

            // Set default font style
            var normal = doc.Styles["Normal"];
            normal.Font.Name = "Times New Roman";
            normal.Font.Size = 8;

            // Header
            Paragraph header = section.AddParagraph();
            header.AddFormattedText("\n\nTên đơn vị: Quầy Thuốc Bác Sĩ Chín", TextFormat.Bold);
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
            section.AddParagraph($"  Mã đơn thuốc: {order.OrderNo}");
            section.AddParagraph($"  Ngày lập đơn thuốc: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}");
            section.AddParagraph($"  Họ tên: {lblHienThiTenKhach.Text.Replace("Khách mua: ", "")}");
            section.AddParagraph($"  Địa chỉ liên hệ: {curentCustomer.DiaChi}");
            section.AddParagraph($"  Số điện thoại liên hệ: {curentCustomer.Phone}");

            // Treatment
            var table = section.AddTable();
            table.Borders.Width = 0.5;
            table.AddColumn("3.5cm");
            table.AddColumn("1.2cm");
            table.AddColumn("1.5cm");
            table.AddColumn("1.8cm");

            var headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Cells[0].AddParagraph("Tên SP");
            headerRow.Cells[1].AddParagraph("SL");
            headerRow.Cells[2].AddParagraph("Liều dùng");
            headerRow.Cells[3].AddParagraph("Ghi chú");

            foreach (var medicine in details)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(medicine.TenHang);
                row.Cells[1].AddParagraph(medicine.SoLuong.ToString());
                row.Cells[2].AddParagraph($"{medicine.LieuDung}/lần/ngày");
            }

            section.AddParagraph("\n\n *Khám lại xin mang theo đơn này*");
            section.AddParagraph($"\n\nNgày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year} ").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("Bác sỹ/Y sỹ khám bệnh ").Format.Alignment = ParagraphAlignment.Right;
            section.AddParagraph("(Ký, ghi rõ họ tên) ").Format.Alignment = ParagraphAlignment.Right;

            // Render PDF
            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();

            string filename = $"{order.OrderNo}_TT_{DateTimeOffset.Now.ToUnixTimeSeconds()}.pdf";
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
        private Panel panelRight;
        private Panel pnlSanPhamChiTiet;
        private RichTextBox txtMoTa;
        private Label lblGiaBan;
        private Label lblTenHang;
        private Label lblSoLuongTon;
        private Label label3;
        private System.Windows.Forms.Button button1;
        private CuoreUI.Controls.cuiButton btnAddCart;
        private CuoreUI.Controls.cuiButton btnSearch;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnThanhToan;
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
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private NumericUpDown txtGiamGia;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private Label label8;
        private TextBox txtSoLuong;
        private Label label7;
        private TextBox txtLieuDung;
        private Label label2;
        private ComboBox cbxToaThuocMau;
    }
}
