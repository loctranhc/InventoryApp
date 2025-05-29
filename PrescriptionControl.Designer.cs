namespace InventoryApp
{
    partial class PrescriptionControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDonViTinh = new Label();
            txtMoTa = new RichTextBox();
            lblTenHang = new Label();
            lblValueMaKhach = new Label();
            panelRight = new Panel();
            lblValueTenKhachHang = new Label();
            lbnHienThiMaKhach = new Label();
            lblHienThiTenKhach = new Label();
            btnThemKhachHang = new CuoreUI.Controls.cuiButton();
            txtSearch = new TextBox();
            btnThanhToan = new CuoreUI.Controls.cuiButton();
            btnAddCart = new CuoreUI.Controls.cuiButton();
            btnSearch = new CuoreUI.Controls.cuiButton();
            pnlSanPhamChiTiet = new Panel();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label1 = new Label();
            txtLieuDung = new TextBox();
            panelLeft = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            txtTimKhachHang = new TextBox();
            gridViewKhachHang = new DataGridView();
            rbtnTimTheoSoDienThoai = new RadioButton();
            rbtnTimTheoTen = new RadioButton();
            btnTimKhachHang = new CuoreUI.Controls.cuiButton();
            label6 = new Label();
            button1 = new Button();
            lblOrderTitle = new Label();
            dgvPrescriptionList = new DataGridView();
            panelRight.SuspendLayout();
            pnlSanPhamChiTiet.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionList).BeginInit();
            SuspendLayout();
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonViTinh.Location = new Point(229, 219);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(0, 21);
            lblDonViTinh.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMoTa.Location = new Point(13, 37);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = true;
            txtMoTa.Size = new Size(348, 133);
            txtMoTa.TabIndex = 2;
            txtMoTa.Text = "";
            // 
            // lblTenHang
            // 
            lblTenHang.AutoSize = true;
            lblTenHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenHang.Location = new Point(13, 13);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(84, 21);
            lblTenHang.TabIndex = 0;
            lblTenHang.Text = "Tên Thuốc";
            // 
            // lblValueMaKhach
            // 
            lblValueMaKhach.AutoSize = true;
            lblValueMaKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueMaKhach.Location = new Point(99, 444);
            lblValueMaKhach.Name = "lblValueMaKhach";
            lblValueMaKhach.Size = new Size(28, 30);
            lblValueMaKhach.TabIndex = 20;
            lblValueMaKhach.Text = "A";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.BackgroundImage = Properties.Resources.bg;
            panelRight.Controls.Add(lblValueTenKhachHang);
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
            panelRight.Size = new Size(1231, 843);
            panelRight.TabIndex = 2;
            // 
            // lblValueTenKhachHang
            // 
            lblValueTenKhachHang.AutoSize = true;
            lblValueTenKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueTenKhachHang.Location = new Point(99, 480);
            lblValueTenKhachHang.Name = "lblValueTenKhachHang";
            lblValueTenKhachHang.Size = new Size(28, 30);
            lblValueTenKhachHang.TabIndex = 21;
            lblValueTenKhachHang.Text = "A";
            // 
            // lbnHienThiMaKhach
            // 
            lbnHienThiMaKhach.AutoSize = true;
            lbnHienThiMaKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnHienThiMaKhach.Location = new Point(16, 444);
            lbnHienThiMaKhach.Name = "lbnHienThiMaKhach";
            lbnHienThiMaKhach.Size = new Size(86, 30);
            lbnHienThiMaKhach.TabIndex = 19;
            lbnHienThiMaKhach.Text = "Mã KH:";
            // 
            // lblHienThiTenKhach
            // 
            lblHienThiTenKhach.AutoSize = true;
            lblHienThiTenKhach.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHienThiTenKhach.Location = new Point(21, 480);
            lblHienThiTenKhach.Name = "lblHienThiTenKhach";
            lblHienThiTenKhach.Size = new Size(80, 30);
            lblHienThiTenKhach.TabIndex = 18;
            lblHienThiTenKhach.Text = "Khách:";
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
            btnThemKhachHang.Location = new Point(16, 532);
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
            // 
            // btnThanhToan
            // 
            btnThanhToan.CheckButton = false;
            btnThanhToan.Checked = false;
            btnThanhToan.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThanhToan.CheckedForeColor = Color.White;
            btnThanhToan.CheckedImageTint = Color.White;
            btnThanhToan.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThanhToan.Content = "LẬP ĐƠN THUỐC";
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
            btnThanhToan.Location = new Point(176, 532);
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
            btnAddCart.Content = "Kê Đơn";
            btnAddCart.DialogResult = DialogResult.None;
            btnAddCart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.HoverBackground = Color.WhiteSmoke;
            btnAddCart.HoveredImageTint = Color.White;
            btnAddCart.HoverForeColor = Color.Black;
            btnAddCart.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAddCart.Image = null;
            btnAddCart.ImageAutoCenter = true;
            btnAddCart.ImageExpand = new Point(0, 0);
            btnAddCart.ImageOffset = new Point(0, 0);
            btnAddCart.Location = new Point(13, 366);
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
            btnAddCart.Size = new Size(375, 50);
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
            pnlSanPhamChiTiet.Controls.Add(label3);
            pnlSanPhamChiTiet.Controls.Add(txtSoLuong);
            pnlSanPhamChiTiet.Controls.Add(label1);
            pnlSanPhamChiTiet.Controls.Add(txtLieuDung);
            pnlSanPhamChiTiet.Controls.Add(lblDonViTinh);
            pnlSanPhamChiTiet.Controls.Add(txtMoTa);
            pnlSanPhamChiTiet.Controls.Add(lblTenHang);
            pnlSanPhamChiTiet.Location = new Point(13, 65);
            pnlSanPhamChiTiet.Name = "pnlSanPhamChiTiet";
            pnlSanPhamChiTiet.Size = new Size(375, 273);
            pnlSanPhamChiTiet.TabIndex = 9;
            pnlSanPhamChiTiet.Paint += pnlSanPhamChiTiet_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 229);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(80, 226);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(281, 23);
            txtSoLuong.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 191);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 7;
            label1.Text = "Liều Dùng";
            // 
            // txtLieuDung
            // 
            txtLieuDung.Location = new Point(80, 187);
            txtLieuDung.Name = "txtLieuDung";
            txtLieuDung.Size = new Size(281, 23);
            txtLieuDung.TabIndex = 6;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Transparent;
            panelLeft.BackgroundImage = Properties.Resources.bg;
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(comboBox1);
            panelLeft.Controls.Add(txtTimKhachHang);
            panelLeft.Controls.Add(gridViewKhachHang);
            panelLeft.Controls.Add(rbtnTimTheoSoDienThoai);
            panelLeft.Controls.Add(rbtnTimTheoTen);
            panelLeft.Controls.Add(btnTimKhachHang);
            panelLeft.Controls.Add(label6);
            panelLeft.Controls.Add(button1);
            panelLeft.Controls.Add(lblOrderTitle);
            panelLeft.Controls.Add(dgvPrescriptionList);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(600, 843);
            panelLeft.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(248, 21);
            label2.TabIndex = 22;
            label2.Text = "Lựa chọn toa thuốc mẫu (nếu có)";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(264, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 28);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTimKhachHang
            // 
            txtTimKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKhachHang.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKhachHang.Location = new Point(10, 433);
            txtTimKhachHang.Name = "txtTimKhachHang";
            txtTimKhachHang.Size = new Size(309, 35);
            txtTimKhachHang.TabIndex = 20;
            txtTimKhachHang.TextChanged += txtTimKhachHang_TextChanged;
            // 
            // gridViewKhachHang
            // 
            gridViewKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewKhachHang.Location = new Point(10, 500);
            gridViewKhachHang.Name = "gridViewKhachHang";
            gridViewKhachHang.Size = new Size(580, 221);
            gridViewKhachHang.TabIndex = 17;
            gridViewKhachHang.CellClick += gridViewKhachHang_CellClick;
            // 
            // rbtnTimTheoSoDienThoai
            // 
            rbtnTimTheoSoDienThoai.AutoSize = true;
            rbtnTimTheoSoDienThoai.Location = new Point(133, 474);
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
            rbtnTimTheoTen.Location = new Point(10, 474);
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
            btnTimKhachHang.Location = new Point(322, 428);
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
            label6.Location = new Point(10, 393);
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
            lblOrderTitle.Size = new Size(315, 37);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "ĐƠN THUỐC HIỆN TẠI";
            // 
            // dgvPrescriptionList
            // 
            dgvPrescriptionList.AllowUserToAddRows = false;
            dgvPrescriptionList.Location = new Point(10, 102);
            dgvPrescriptionList.Name = "dgvPrescriptionList";
            dgvPrescriptionList.ReadOnly = true;
            dgvPrescriptionList.Size = new Size(580, 271);
            dgvPrescriptionList.TabIndex = 1;
            dgvPrescriptionList.CellClick += dgvPrescriptionList_CellClick_1;
            dgvPrescriptionList.CellContentClick += dgvPrescriptionList_CellContentClick;
            dgvPrescriptionList.CellFormatting += dgvPrescriptionList_CellFormatting;
            // 
            // PrescriptionControl
            // 
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "PrescriptionControl";
            Size = new Size(1831, 843);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            pnlSanPhamChiTiet.ResumeLayout(false);
            pnlSanPhamChiTiet.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionList).EndInit();
            ResumeLayout(false);
        }
        private Label lblDonViTinh;
        private RichTextBox txtMoTa;
        private Label lblTenHang;
        private Label lblValueMaKhach;
        private Panel panelRight;
        private Label lbnHienThiMaKhach;
        private Label lblHienThiTenKhach;
        private CuoreUI.Controls.cuiButton btnThemKhachHang;
        private TextBox txtSearch;
        private CuoreUI.Controls.cuiButton btnThanhToan;
        private CuoreUI.Controls.cuiButton btnAddCart;
        private CuoreUI.Controls.cuiButton btnSearch;
        private Panel pnlSanPhamChiTiet;
        private Panel panelLeft;
        private TextBox txtTimKhachHang;
        private DataGridView gridViewKhachHang;
        private RadioButton rbtnTimTheoSoDienThoai;
        private RadioButton rbtnTimTheoTen;
        private CuoreUI.Controls.cuiButton btnTimKhachHang;
        private Label label6;
        private Button button1;
        private Label lblOrderTitle;
        private DataGridView dgvPrescriptionList;
        private Label label1;
        private TextBox txtLieuDung;
        private Label lblValueTenKhachHang;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox txtSoLuong;
    }
}
