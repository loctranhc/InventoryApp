namespace InventoryApp
{
    partial class MedicineControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridViewMedicine = new DataGridView();
            btnDownFileMau = new CuoreUI.Controls.cuiButton();
            btnThemThuoc = new CuoreUI.Controls.cuiButton();
            txtTimKiemThuoc = new TextBox();
            label1 = new Label();
            btnNhapThuoc = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)gridViewMedicine).BeginInit();
            SuspendLayout();
            // 
            // gridViewMedicine
            // 
            gridViewMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMedicine.Location = new Point(20, 71);
            gridViewMedicine.Name = "gridViewMedicine";
            gridViewMedicine.Size = new Size(1459, 612);
            gridViewMedicine.TabIndex = 0;
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
            btnDownFileMau.Location = new Point(964, 30);
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
            btnDownFileMau.TabIndex = 17;
            btnDownFileMau.TextAlignment = StringAlignment.Center;
            btnDownFileMau.TextOffset = new Point(0, 0);
            btnDownFileMau.Click += btnDownFileMau_Click;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemThuoc.BackColor = Color.Transparent;
            btnThemThuoc.CheckButton = false;
            btnThemThuoc.Checked = false;
            btnThemThuoc.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThemThuoc.CheckedForeColor = Color.White;
            btnThemThuoc.CheckedImageTint = Color.White;
            btnThemThuoc.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThemThuoc.Content = "Thêm Thuốc";
            btnThemThuoc.DialogResult = DialogResult.None;
            btnThemThuoc.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThemThuoc.ForeColor = Color.White;
            btnThemThuoc.HoverBackground = SystemColors.Window;
            btnThemThuoc.HoveredImageTint = Color.White;
            btnThemThuoc.HoverForeColor = Color.Black;
            btnThemThuoc.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThemThuoc.Image = null;
            btnThemThuoc.ImageAutoCenter = true;
            btnThemThuoc.ImageExpand = new Point(0, 0);
            btnThemThuoc.ImageOffset = new Point(0, 0);
            btnThemThuoc.Location = new Point(1339, 31);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.NormalBackground = Color.OrangeRed;
            btnThemThuoc.NormalForeColor = Color.White;
            btnThemThuoc.NormalImageTint = Color.White;
            btnThemThuoc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.OutlineThickness = 1F;
            btnThemThuoc.PressedBackground = Color.WhiteSmoke;
            btnThemThuoc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThemThuoc.PressedImageTint = Color.White;
            btnThemThuoc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThemThuoc.Rounding = new Padding(8);
            btnThemThuoc.Size = new Size(140, 34);
            btnThemThuoc.TabIndex = 18;
            btnThemThuoc.TextAlignment = StringAlignment.Center;
            btnThemThuoc.TextOffset = new Point(0, 0);
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // txtTimKiemThuoc
            // 
            txtTimKiemThuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiemThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiemThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemThuoc.Location = new Point(96, 35);
            txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            txtTimKiemThuoc.Size = new Size(408, 29);
            txtTimKiemThuoc.TabIndex = 19;
            txtTimKiemThuoc.TextChanged += txtTimKiemThuoc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 20;
            label1.Text = "Tìm Kiếm";
            // 
            // btnNhapThuoc
            // 
            btnNhapThuoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhapThuoc.BackColor = Color.Transparent;
            btnNhapThuoc.CheckButton = false;
            btnNhapThuoc.Checked = false;
            btnNhapThuoc.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnNhapThuoc.CheckedForeColor = Color.White;
            btnNhapThuoc.CheckedImageTint = Color.White;
            btnNhapThuoc.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnNhapThuoc.Content = "Nhập Thuốc";
            btnNhapThuoc.DialogResult = DialogResult.None;
            btnNhapThuoc.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnNhapThuoc.ForeColor = Color.White;
            btnNhapThuoc.HoverBackground = SystemColors.Window;
            btnNhapThuoc.HoveredImageTint = Color.White;
            btnNhapThuoc.HoverForeColor = Color.Black;
            btnNhapThuoc.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnNhapThuoc.Image = null;
            btnNhapThuoc.ImageAutoCenter = true;
            btnNhapThuoc.ImageExpand = new Point(0, 0);
            btnNhapThuoc.ImageOffset = new Point(0, 0);
            btnNhapThuoc.Location = new Point(1197, 31);
            btnNhapThuoc.Name = "btnNhapThuoc";
            btnNhapThuoc.NormalBackground = Color.ForestGreen;
            btnNhapThuoc.NormalForeColor = Color.White;
            btnNhapThuoc.NormalImageTint = Color.White;
            btnNhapThuoc.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnNhapThuoc.OutlineThickness = 1F;
            btnNhapThuoc.PressedBackground = Color.WhiteSmoke;
            btnNhapThuoc.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnNhapThuoc.PressedImageTint = Color.White;
            btnNhapThuoc.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnNhapThuoc.Rounding = new Padding(8);
            btnNhapThuoc.Size = new Size(140, 34);
            btnNhapThuoc.TabIndex = 21;
            btnNhapThuoc.TextAlignment = StringAlignment.Center;
            btnNhapThuoc.TextOffset = new Point(0, 0);
            btnNhapThuoc.Click += btnNhapThuoc_Click;
            // 
            // MedicineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnNhapThuoc);
            Controls.Add(label1);
            Controls.Add(txtTimKiemThuoc);
            Controls.Add(btnThemThuoc);
            Controls.Add(btnDownFileMau);
            Controls.Add(gridViewMedicine);
            Name = "MedicineControl";
            Size = new Size(1515, 719);
            ((System.ComponentModel.ISupportInitialize)gridViewMedicine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewMedicine;
        private CuoreUI.Controls.cuiButton btnDownFileMau;
        private CuoreUI.Controls.cuiButton btnThemThuoc;
        private TextBox txtTimKiemThuoc;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnNhapThuoc;
    }
}
