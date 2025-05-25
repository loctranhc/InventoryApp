using MigrateDatabase;
using MigrateDatabase.Models;

namespace InventoryApp
{
    partial class POSControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            txtTimKhachHang = new TextBox();
            gridViewKhachHang = new DataGridView();
            rbtnTimTheoSoDienThoai = new RadioButton();
            rbtnTimTheoTen = new RadioButton();
            btnTimKhachHang = new CuoreUI.Controls.cuiButton();
            label6 = new Label();
            button1 = new Button();
            lblOrderTitle = new Label();
            dgvOrderList = new DataGridView();
            lblTotal = new Label();
            panelRight = new Panel();
            lblValueMaKhach = new Label();
            lbnHienThiMaKhach = new Label();
            lblHienThiTenKhach = new Label();
            btnThemKhachHang = new CuoreUI.Controls.cuiButton();
            txtSearch = new TextBox();
            btnThanhToan = new CuoreUI.Controls.cuiButton();
            btnAddCart = new CuoreUI.Controls.cuiButton();
            btnSearch = new CuoreUI.Controls.cuiButton();
            pnlSanPhamChiTiet = new Panel();
            lbDVT = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDonViTinh = new Label();
            lblSoLuongTon = new Label();
            label3 = new Label();
            txtMoTa = new RichTextBox();
            lblGiaBan = new Label();
            lblTenHang = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            panelRight.SuspendLayout();
            pnlSanPhamChiTiet.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Transparent;
            panelLeft.BackgroundImage = Properties.Resources.bg;
            panelLeft.Controls.Add(txtTimKhachHang);
            panelLeft.Controls.Add(gridViewKhachHang);
            panelLeft.Controls.Add(rbtnTimTheoSoDienThoai);
            panelLeft.Controls.Add(rbtnTimTheoTen);
            panelLeft.Controls.Add(btnTimKhachHang);
            panelLeft.Controls.Add(label6);
            panelLeft.Controls.Add(button1);
            panelLeft.Controls.Add(lblOrderTitle);
            panelLeft.Controls.Add(dgvOrderList);
            panelLeft.Controls.Add(lblTotal);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(600, 687);
            panelLeft.TabIndex = 1;
            // 
            // txtTimKhachHang
            // 
            txtTimKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKhachHang.Location = new Point(166, 438);
            txtTimKhachHang.Name = "txtTimKhachHang";
            txtTimKhachHang.Size = new Size(263, 35);
            txtTimKhachHang.TabIndex = 20;
            txtTimKhachHang.TextChanged += txtTimKhachHang_TextChanged;
            // 
            // gridViewKhachHang
            // 
            gridViewKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewKhachHang.Location = new Point(10, 510);
            gridViewKhachHang.Name = "gridViewKhachHang";
            gridViewKhachHang.Size = new Size(580, 155);
            gridViewKhachHang.TabIndex = 17;
            gridViewKhachHang.CellClick += gridViewKhachHang_CellClick;
            // 
            // rbtnTimTheoSoDienThoai
            // 
            rbtnTimTheoSoDienThoai.AutoSize = true;
            rbtnTimTheoSoDienThoai.Location = new Point(292, 485);
            rbtnTimTheoSoDienThoai.Name = "rbtnTimTheoSoDienThoai";
            rbtnTimTheoSoDienThoai.Size = new Size(152, 19);
            rbtnTimTheoSoDienThoai.TabIndex = 16;
            rbtnTimTheoSoDienThoai.TabStop = true;
            rbtnTimTheoSoDienThoai.Text = "Tìm Theo Số Điện Thoại";
            rbtnTimTheoSoDienThoai.UseVisualStyleBackColor = true;
            rbtnTimTheoSoDienThoai.CheckedChanged += rbtnTimTheoSoDienThoai_CheckedChanged;
            // 
            // rbtnTimTheoTen
            // 
            rbtnTimTheoTen.AutoSize = true;
            rbtnTimTheoTen.Location = new Point(166, 485);
            rbtnTimTheoTen.Name = "rbtnTimTheoTen";
            rbtnTimTheoTen.Size = new Size(117, 19);
            rbtnTimTheoTen.TabIndex = 15;
            rbtnTimTheoTen.TabStop = true;
            rbtnTimTheoTen.Text = "Tìm Theo Họ Tên";
            rbtnTimTheoTen.UseVisualStyleBackColor = true;
            rbtnTimTheoTen.CheckedChanged += rbtnTimTheoTen_CheckedChanged;
            // 
            // btnTimKhachHang
            // 
            btnTimKhachHang.CheckButton = false;
            btnTimKhachHang.Checked = false;
            btnTimKhachHang.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnTimKhachHang.CheckedForeColor = Color.White;
            btnTimKhachHang.CheckedImageTint = Color.White;
            btnTimKhachHang.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnTimKhachHang.Content = "TÌM";
            btnTimKhachHang.DialogResult = DialogResult.None;
            btnTimKhachHang.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnTimKhachHang.ForeColor = Color.White;
            btnTimKhachHang.HoverBackground = Color.WhiteSmoke;
            btnTimKhachHang.HoveredImageTint = Color.White;
            btnTimKhachHang.HoverForeColor = Color.Black;
            btnTimKhachHang.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnTimKhachHang.Image = null;
            btnTimKhachHang.ImageAutoCenter = true;
            btnTimKhachHang.ImageExpand = new Point(0, 0);
            btnTimKhachHang.ImageOffset = new Point(0, 0);
            btnTimKhachHang.Location = new Point(435, 433);
            btnTimKhachHang.Name = "btnTimKhachHang";
            btnTimKhachHang.NormalBackground = Color.OrangeRed;
            btnTimKhachHang.NormalForeColor = Color.White;
            btnTimKhachHang.NormalImageTint = Color.White;
            btnTimKhachHang.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKhachHang.OutlineThickness = 1F;
            btnTimKhachHang.PressedBackground = Color.WhiteSmoke;
            btnTimKhachHang.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTimKhachHang.PressedImageTint = Color.White;
            btnTimKhachHang.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKhachHang.Rounding = new Padding(8);
            btnTimKhachHang.Size = new Size(70, 45);
            btnTimKhachHang.TabIndex = 14;
            btnTimKhachHang.TextAlignment = StringAlignment.Center;
            btnTimKhachHang.TextOffset = new Point(0, 0);
            btnTimKhachHang.Click += btnTimKhachHang_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 437);
            label6.Name = "label6";
            label6.Size = new Size(157, 37);
            label6.TabIndex = 5;
            label6.Text = "Tìm Khách";
            // 
            // button1
            // 
            button1.Location = new Point(438, 412);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTitle.Location = new Point(149, 9);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(302, 37);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "ĐƠN HÀNG HIỆN TẠI";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.Location = new Point(10, 56);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.Size = new Size(580, 300);
            dgvOrderList.TabIndex = 1;
            dgvOrderList.CellEndEdit += dgvOrderList_CellEndEdit;
            dgvOrderList.CellFormatting += dgvOrderList_CellFormatting;
            dgvOrderList.CellValueChanged += dgvOrderList_CellValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(10, 370);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(257, 30);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.BackgroundImage = Properties.Resources.bg;
            panelRight.Controls.Add(lblValueMaKhach);
            panelRight.Controls.Add(lbnHienThiMaKhach);
            panelRight.Controls.Add(lblHienThiTenKhach);
            panelRight.Controls.Add(btnThemKhachHang);
            panelRight.Controls.Add(txtSearch);
            panelRight.Controls.Add(btnThanhToan);
            panelRight.Controls.Add(btnAddCart);
            panelRight.Controls.Add(btnSearch);
            panelRight.Controls.Add(pnlSanPhamChiTiet);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(600, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(400, 687);
            panelRight.TabIndex = 0;
            panelRight.Paint += panelRight_Paint;
            // 
            // lblValueMaKhach
            // 
            lblValueMaKhach.AutoSize = true;
            lblValueMaKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueMaKhach.Location = new Point(99, 397);
            lblValueMaKhach.Name = "lblValueMaKhach";
            lblValueMaKhach.Size = new Size(28, 30);
            lblValueMaKhach.TabIndex = 20;
            lblValueMaKhach.Text = "A";
            // 
            // lbnHienThiMaKhach
            // 
            lbnHienThiMaKhach.AutoSize = true;
            lbnHienThiMaKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnHienThiMaKhach.Location = new Point(16, 397);
            lbnHienThiMaKhach.Name = "lbnHienThiMaKhach";
            lbnHienThiMaKhach.Size = new Size(86, 30);
            lbnHienThiMaKhach.TabIndex = 19;
            lbnHienThiMaKhach.Text = "Mã KH:";
            // 
            // lblHienThiTenKhach
            // 
            lblHienThiTenKhach.AutoSize = true;
            lblHienThiTenKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHienThiTenKhach.Location = new Point(16, 433);
            lblHienThiTenKhach.Name = "lblHienThiTenKhach";
            lblHienThiTenKhach.Size = new Size(277, 30);
            lblHienThiTenKhach.TabIndex = 18;
            lblHienThiTenKhach.Text = "Khách mua: Nguyễn Văn A";
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.CheckButton = false;
            btnThemKhachHang.Checked = false;
            btnThemKhachHang.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThemKhachHang.CheckedForeColor = Color.White;
            btnThemKhachHang.CheckedImageTint = Color.White;
            btnThemKhachHang.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThemKhachHang.Content = "TẠO KHÁCH HÀNG";
            btnThemKhachHang.DialogResult = DialogResult.None;
            btnThemKhachHang.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThemKhachHang.ForeColor = Color.White;
            btnThemKhachHang.HoverBackground = Color.WhiteSmoke;
            btnThemKhachHang.HoveredImageTint = Color.White;
            btnThemKhachHang.HoverForeColor = Color.Black;
            btnThemKhachHang.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThemKhachHang.Image = null;
            btnThemKhachHang.ImageAutoCenter = true;
            btnThemKhachHang.ImageExpand = new Point(0, 0);
            btnThemKhachHang.ImageOffset = new Point(0, 0);
            btnThemKhachHang.Location = new Point(16, 485);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.NormalBackground = Color.OrangeRed;
            btnThemKhachHang.NormalForeColor = Color.White;
            btnThemKhachHang.NormalImageTint = Color.White;
            btnThemKhachHang.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemKhachHang.OutlineThickness = 1F;
            btnThemKhachHang.PressedBackground = Color.WhiteSmoke;
            btnThemKhachHang.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThemKhachHang.PressedImageTint = Color.White;
            btnThemKhachHang.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemKhachHang.Rounding = new Padding(8);
            btnThemKhachHang.Size = new Size(154, 112);
            btnThemKhachHang.TabIndex = 14;
            btnThemKhachHang.TextAlignment = StringAlignment.Center;
            btnThemKhachHang.TextOffset = new Point(0, 0);
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(13, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(303, 35);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.MouseEnter += txtSearch_MouseEnter;
            // 
            // btnThanhToan
            // 
            btnThanhToan.CheckButton = false;
            btnThanhToan.Checked = false;
            btnThanhToan.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThanhToan.CheckedForeColor = Color.White;
            btnThanhToan.CheckedImageTint = Color.White;
            btnThanhToan.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThanhToan.Content = "THANH TOÁN";
            btnThanhToan.DialogResult = DialogResult.None;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.HoverBackground = Color.WhiteSmoke;
            btnThanhToan.HoveredImageTint = Color.White;
            btnThanhToan.HoverForeColor = Color.Black;
            btnThanhToan.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThanhToan.Image = null;
            btnThanhToan.ImageAutoCenter = true;
            btnThanhToan.ImageExpand = new Point(0, 0);
            btnThanhToan.ImageOffset = new Point(0, 0);
            btnThanhToan.Location = new Point(176, 485);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.NormalBackground = Color.DarkGreen;
            btnThanhToan.NormalForeColor = Color.White;
            btnThanhToan.NormalImageTint = Color.White;
            btnThanhToan.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThanhToan.OutlineThickness = 1F;
            btnThanhToan.PressedBackground = Color.WhiteSmoke;
            btnThanhToan.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThanhToan.PressedImageTint = Color.White;
            btnThanhToan.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThanhToan.Rounding = new Padding(8);
            btnThanhToan.Size = new Size(212, 112);
            btnThanhToan.TabIndex = 12;
            btnThanhToan.TextAlignment = StringAlignment.Center;
            btnThanhToan.TextOffset = new Point(0, 0);
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnAddCart
            // 
            btnAddCart.CheckButton = false;
            btnAddCart.Checked = false;
            btnAddCart.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAddCart.CheckedForeColor = Color.White;
            btnAddCart.CheckedImageTint = Color.White;
            btnAddCart.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAddCart.Content = "MUA";
            btnAddCart.DialogResult = DialogResult.None;
            btnAddCart.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.HoverBackground = Color.WhiteSmoke;
            btnAddCart.HoveredImageTint = Color.White;
            btnAddCart.HoverForeColor = Color.Black;
            btnAddCart.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAddCart.Image = null;
            btnAddCart.ImageAutoCenter = true;
            btnAddCart.ImageExpand = new Point(0, 0);
            btnAddCart.ImageOffset = new Point(0, 0);
            btnAddCart.Location = new Point(273, 332);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.NormalBackground = Color.OrangeRed;
            btnAddCart.NormalForeColor = Color.White;
            btnAddCart.NormalImageTint = Color.White;
            btnAddCart.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnAddCart.OutlineThickness = 1F;
            btnAddCart.PressedBackground = Color.WhiteSmoke;
            btnAddCart.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAddCart.PressedImageTint = Color.White;
            btnAddCart.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAddCart.Rounding = new Padding(8);
            btnAddCart.Size = new Size(115, 50);
            btnAddCart.TabIndex = 11;
            btnAddCart.TextAlignment = StringAlignment.Center;
            btnAddCart.TextOffset = new Point(0, 0);
            btnAddCart.Click += btnAddCart_Click;
            // 
            // btnSearch
            // 
            btnSearch.CheckButton = false;
            btnSearch.Checked = false;
            btnSearch.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSearch.CheckedForeColor = Color.White;
            btnSearch.CheckedImageTint = Color.White;
            btnSearch.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSearch.Content = "TÌM";
            btnSearch.DialogResult = DialogResult.None;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSearch.ForeColor = Color.White;
            btnSearch.HoverBackground = Color.WhiteSmoke;
            btnSearch.HoveredImageTint = Color.White;
            btnSearch.HoverForeColor = Color.Black;
            btnSearch.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSearch.Image = null;
            btnSearch.ImageAutoCenter = true;
            btnSearch.ImageExpand = new Point(0, 0);
            btnSearch.ImageOffset = new Point(0, 0);
            btnSearch.Location = new Point(322, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.NormalBackground = Color.OrangeRed;
            btnSearch.NormalForeColor = Color.White;
            btnSearch.NormalImageTint = Color.White;
            btnSearch.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSearch.OutlineThickness = 1F;
            btnSearch.PressedBackground = Color.WhiteSmoke;
            btnSearch.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSearch.PressedImageTint = Color.White;
            btnSearch.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSearch.Rounding = new Padding(8);
            btnSearch.Size = new Size(70, 45);
            btnSearch.TabIndex = 10;
            btnSearch.TextAlignment = StringAlignment.Center;
            btnSearch.TextOffset = new Point(0, 0);
            btnSearch.Click += btnSearch_Click_1;
            // 
            // pnlSanPhamChiTiet
            // 
            pnlSanPhamChiTiet.BackColor = Color.Gainsboro;
            pnlSanPhamChiTiet.Controls.Add(lbDVT);
            pnlSanPhamChiTiet.Controls.Add(label2);
            pnlSanPhamChiTiet.Controls.Add(label1);
            pnlSanPhamChiTiet.Controls.Add(lblDonViTinh);
            pnlSanPhamChiTiet.Controls.Add(lblSoLuongTon);
            pnlSanPhamChiTiet.Controls.Add(label3);
            pnlSanPhamChiTiet.Controls.Add(txtMoTa);
            pnlSanPhamChiTiet.Controls.Add(lblGiaBan);
            pnlSanPhamChiTiet.Controls.Add(lblTenHang);
            pnlSanPhamChiTiet.Location = new Point(13, 65);
            pnlSanPhamChiTiet.Name = "pnlSanPhamChiTiet";
            pnlSanPhamChiTiet.Size = new Size(375, 261);
            pnlSanPhamChiTiet.TabIndex = 9;
            // 
            // lbDVT
            // 
            lbDVT.AutoSize = true;
            lbDVT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDVT.Location = new Point(228, 219);
            lbDVT.Name = "lbDVT";
            lbDVT.Size = new Size(32, 21);
            lbDVT.TabIndex = 8;
            lbDVT.Text = "Cái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 219);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 7;
            label2.Text = "Đơn Vị Tính:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 197);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 6;
            label1.Text = "Giá Bán:";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonViTinh.Location = new Point(229, 219);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(0, 21);
            lblDonViTinh.TabIndex = 5;
            lblDonViTinh.Click += lblDonViTinh_Click;
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Location = new Point(113, 44);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(13, 15);
            lblSoLuongTon.TabIndex = 4;
            lblSoLuongTon.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 43);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Số Lượng Còn Lại: ";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMoTa.Location = new Point(13, 72);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = true;
            txtMoTa.Size = new Size(348, 109);
            txtMoTa.TabIndex = 2;
            txtMoTa.Text = "";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaBan.Location = new Point(228, 197);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(19, 21);
            lblGiaBan.TabIndex = 1;
            lblGiaBan.Text = "0";
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenHang.Location = new Point(13, 13);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(112, 21);
            lblTenHang.TabIndex = 0;
            lblTenHang.Text = "Tên Hàng Hoá";
            // 
            // POSControl
            // 
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "POSControl";
            Size = new Size(1000, 687);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            pnlSanPhamChiTiet.ResumeLayout(false);
            pnlSanPhamChiTiet.PerformLayout();
            ResumeLayout(false);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {


        }

        private void txtTmKhachHang_ContentChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrderList_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
