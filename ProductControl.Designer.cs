namespace InventoryApp
{
    partial class ProductControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            label1 = new Label();
            btnTimKiem = new CuoreUI.Controls.cuiButton();
            btnThem = new CuoreUI.Controls.cuiButton();
            btnNhapHang = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            cbxCategory = new ComboBox();
            txtTimKiem = new TextBox();
            btnDownFileMau = new CuoreUI.Controls.cuiButton();
            btnSua = new CuoreUI.Controls.cuiButton();
            btnXoa = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(20, 143);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(1019, 490);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(654, 21);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 6;
            label1.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.CheckButton = false;
            btnTimKiem.Checked = false;
            btnTimKiem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnTimKiem.CheckedForeColor = Color.White;
            btnTimKiem.CheckedImageTint = Color.White;
            btnTimKiem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnTimKiem.Content = "Tìm";
            btnTimKiem.DialogResult = DialogResult.None;
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.HoverBackground = Color.White;
            btnTimKiem.HoveredImageTint = Color.White;
            btnTimKiem.HoverForeColor = Color.Black;
            btnTimKiem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnTimKiem.Image = null;
            btnTimKiem.ImageAutoCenter = true;
            btnTimKiem.ImageExpand = new Point(0, 0);
            btnTimKiem.ImageOffset = new Point(0, 0);
            btnTimKiem.Location = new Point(958, 47);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NormalBackground = Color.OrangeRed;
            btnTimKiem.NormalForeColor = Color.White;
            btnTimKiem.NormalImageTint = Color.White;
            btnTimKiem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKiem.OutlineThickness = 1F;
            btnTimKiem.PressedBackground = Color.WhiteSmoke;
            btnTimKiem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnTimKiem.PressedImageTint = Color.White;
            btnTimKiem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnTimKiem.Rounding = new Padding(8);
            btnTimKiem.Size = new Size(81, 33);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.TextAlignment = StringAlignment.Center;
            btnTimKiem.TextOffset = new Point(0, 0);
            btnTimKiem.Click += cuiButton1_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.Transparent;
            btnThem.CheckButton = false;
            btnThem.Checked = false;
            btnThem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThem.CheckedForeColor = Color.White;
            btnThem.CheckedImageTint = Color.White;
            btnThem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThem.Content = "Thêm Hàng";
            btnThem.DialogResult = DialogResult.None;
            btnThem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThem.ForeColor = Color.White;
            btnThem.HoverBackground = SystemColors.Window;
            btnThem.HoveredImageTint = Color.White;
            btnThem.HoverForeColor = Color.Black;
            btnThem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThem.Image = null;
            btnThem.ImageAutoCenter = true;
            btnThem.ImageExpand = new Point(0, 0);
            btnThem.ImageOffset = new Point(0, 0);
            btnThem.Location = new Point(775, 103);
            btnThem.Name = "btnThem";
            btnThem.NormalBackground = Color.Green;
            btnThem.NormalForeColor = Color.White;
            btnThem.NormalImageTint = Color.White;
            btnThem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.OutlineThickness = 1F;
            btnThem.PressedBackground = Color.WhiteSmoke;
            btnThem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThem.PressedImageTint = Color.White;
            btnThem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.Rounding = new Padding(8);
            btnThem.Size = new Size(103, 34);
            btnThem.TabIndex = 9;
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.TextOffset = new Point(0, 0);
            btnThem.Click += btnThem_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhapHang.CheckButton = false;
            btnNhapHang.Checked = false;
            btnNhapHang.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnNhapHang.CheckedForeColor = Color.White;
            btnNhapHang.CheckedImageTint = Color.White;
            btnNhapHang.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnNhapHang.Content = "Nhập Hàng";
            btnNhapHang.DialogResult = DialogResult.None;
            btnNhapHang.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.HoverBackground = SystemColors.Window;
            btnNhapHang.HoveredImageTint = Color.White;
            btnNhapHang.HoverForeColor = Color.Black;
            btnNhapHang.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnNhapHang.Image = null;
            btnNhapHang.ImageAutoCenter = true;
            btnNhapHang.ImageExpand = new Point(0, 0);
            btnNhapHang.ImageOffset = new Point(0, 0);
            btnNhapHang.Location = new Point(591, 103);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.NormalBackground = Color.RoyalBlue;
            btnNhapHang.NormalForeColor = Color.White;
            btnNhapHang.NormalImageTint = Color.White;
            btnNhapHang.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnNhapHang.OutlineThickness = 1F;
            btnNhapHang.PressedBackground = Color.WhiteSmoke;
            btnNhapHang.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnNhapHang.PressedImageTint = Color.White;
            btnNhapHang.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnNhapHang.Rounding = new Padding(8);
            btnNhapHang.Size = new Size(165, 34);
            btnNhapHang.TabIndex = 10;
            btnNhapHang.TextAlignment = StringAlignment.Center;
            btnNhapHang.TextOffset = new Point(0, 0);
            btnNhapHang.Click += btnNhapHang_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 94);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 13;
            label2.Text = "Danh Mục";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(20, 114);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(233, 23);
            cbxCategory.TabIndex = 14;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(653, 47);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(299, 33);
            txtTimKiem.TabIndex = 15;
            // 
            // btnDownFileMau
            // 
            btnDownFileMau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownFileMau.CheckButton = false;
            btnDownFileMau.Checked = false;
            btnDownFileMau.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDownFileMau.CheckedForeColor = Color.White;
            btnDownFileMau.CheckedImageTint = Color.White;
            btnDownFileMau.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDownFileMau.Content = "Download File Mẫu Nhập Hàng";
            btnDownFileMau.DialogResult = DialogResult.None;
            btnDownFileMau.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnDownFileMau.ForeColor = Color.White;
            btnDownFileMau.HoverBackground = SystemColors.Window;
            btnDownFileMau.HoveredImageTint = Color.White;
            btnDownFileMau.HoverForeColor = Color.Black;
            btnDownFileMau.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDownFileMau.Image = null;
            btnDownFileMau.ImageAutoCenter = true;
            btnDownFileMau.ImageExpand = new Point(0, 0);
            btnDownFileMau.ImageOffset = new Point(0, 0);
            btnDownFileMau.Location = new Point(355, 103);
            btnDownFileMau.Name = "btnDownFileMau";
            btnDownFileMau.NormalBackground = Color.RoyalBlue;
            btnDownFileMau.NormalForeColor = Color.White;
            btnDownFileMau.NormalImageTint = Color.White;
            btnDownFileMau.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnDownFileMau.OutlineThickness = 1F;
            btnDownFileMau.PressedBackground = Color.WhiteSmoke;
            btnDownFileMau.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDownFileMau.PressedImageTint = Color.White;
            btnDownFileMau.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDownFileMau.Rounding = new Padding(8);
            btnDownFileMau.Size = new Size(230, 34);
            btnDownFileMau.TabIndex = 16;
            btnDownFileMau.TextAlignment = StringAlignment.Center;
            btnDownFileMau.TextOffset = new Point(0, 0);
            btnDownFileMau.Click += btnDownFileMau_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.Transparent;
            btnSua.CheckButton = false;
            btnSua.Checked = false;
            btnSua.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSua.CheckedForeColor = Color.White;
            btnSua.CheckedImageTint = Color.White;
            btnSua.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSua.Content = "Sửa";
            btnSua.DialogResult = DialogResult.None;
            btnSua.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnSua.ForeColor = Color.White;
            btnSua.HoverBackground = SystemColors.Window;
            btnSua.HoveredImageTint = Color.White;
            btnSua.HoverForeColor = Color.Black;
            btnSua.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSua.Image = null;
            btnSua.ImageAutoCenter = true;
            btnSua.ImageExpand = new Point(0, 0);
            btnSua.ImageOffset = new Point(0, 0);
            btnSua.Location = new Point(884, 103);
            btnSua.Name = "btnSua";
            btnSua.NormalBackground = Color.FromArgb(0, 0, 192);
            btnSua.NormalForeColor = Color.White;
            btnSua.NormalImageTint = Color.White;
            btnSua.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSua.OutlineThickness = 1F;
            btnSua.PressedBackground = Color.WhiteSmoke;
            btnSua.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSua.PressedImageTint = Color.White;
            btnSua.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSua.Rounding = new Padding(8);
            btnSua.Size = new Size(79, 34);
            btnSua.TabIndex = 17;
            btnSua.TextAlignment = StringAlignment.Center;
            btnSua.TextOffset = new Point(0, 0);
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Transparent;
            btnXoa.CheckButton = false;
            btnXoa.Checked = false;
            btnXoa.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnXoa.CheckedForeColor = Color.White;
            btnXoa.CheckedImageTint = Color.White;
            btnXoa.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnXoa.Content = "Xoá";
            btnXoa.DialogResult = DialogResult.None;
            btnXoa.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnXoa.ForeColor = Color.White;
            btnXoa.HoverBackground = SystemColors.Window;
            btnXoa.HoveredImageTint = Color.White;
            btnXoa.HoverForeColor = Color.Black;
            btnXoa.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnXoa.Image = null;
            btnXoa.ImageAutoCenter = true;
            btnXoa.ImageExpand = new Point(0, 0);
            btnXoa.ImageOffset = new Point(0, 0);
            btnXoa.Location = new Point(969, 103);
            btnXoa.Name = "btnXoa";
            btnXoa.NormalBackground = Color.Red;
            btnXoa.NormalForeColor = Color.White;
            btnXoa.NormalImageTint = Color.White;
            btnXoa.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.OutlineThickness = 1F;
            btnXoa.PressedBackground = Color.WhiteSmoke;
            btnXoa.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnXoa.PressedImageTint = Color.White;
            btnXoa.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnXoa.Rounding = new Padding(8);
            btnXoa.Size = new Size(70, 34);
            btnXoa.TabIndex = 18;
            btnXoa.TextAlignment = StringAlignment.Center;
            btnXoa.TextOffset = new Point(0, 0);
            btnXoa.Click += btnXoa_Click;
            // 
            // ProductControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnDownFileMau);
            Controls.Add(txtTimKiem);
            Controls.Add(cbxCategory);
            Controls.Add(label2);
            Controls.Add(btnNhapHang);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "ProductControl";
            Size = new Size(1056, 681);
            Load += ProductControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private CuoreUI.Controls.cuiButton btnTimKiem;
        private CuoreUI.Controls.cuiButton btnThem;
        private CuoreUI.Controls.cuiButton btnNhapHang;
        private Label label2;
        private ComboBox cbxCategory;
        private TextBox txtTimKiem;
        private CuoreUI.Controls.cuiButton btnDownFileMau;
        private CuoreUI.Controls.cuiButton btnSua;
        private CuoreUI.Controls.cuiButton btnXoa;
    }
}
