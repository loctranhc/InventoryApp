namespace InventoryApp
{
    partial class CategoryControl
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
            gridViewCategory = new DataGridView();
            btnThem = new CuoreUI.Controls.cuiButton();
            txtTenDanhMuc = new CuoreUI.Controls.cuiTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // gridViewCategory
            // 
            gridViewCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewCategory.Location = new Point(22, 25);
            gridViewCategory.Name = "gridViewCategory";
            gridViewCategory.Size = new Size(527, 648);
            gridViewCategory.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.CheckButton = false;
            btnThem.Checked = false;
            btnThem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnThem.CheckedForeColor = Color.White;
            btnThem.CheckedImageTint = Color.White;
            btnThem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnThem.Content = "Thêm";
            btnThem.DialogResult = DialogResult.None;
            btnThem.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnThem.ForeColor = Color.White;
            btnThem.HoverBackground = Color.White;
            btnThem.HoveredImageTint = Color.White;
            btnThem.HoverForeColor = Color.Black;
            btnThem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnThem.Image = null;
            btnThem.ImageAutoCenter = true;
            btnThem.ImageExpand = new Point(0, 0);
            btnThem.ImageOffset = new Point(0, 0);
            btnThem.Location = new Point(777, 423);
            btnThem.Name = "btnThem";
            btnThem.NormalBackground = Color.OrangeRed;
            btnThem.NormalForeColor = Color.White;
            btnThem.NormalImageTint = Color.White;
            btnThem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.OutlineThickness = 1F;
            btnThem.PressedBackground = Color.WhiteSmoke;
            btnThem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnThem.PressedImageTint = Color.White;
            btnThem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnThem.Rounding = new Padding(8);
            btnThem.Size = new Size(123, 45);
            btnThem.TabIndex = 1;
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.TextOffset = new Point(0, 0);
            btnThem.Click += btnThem_Click;
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.BackgroundColor = Color.White;
            txtTenDanhMuc.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txtTenDanhMuc.Content = "";
            txtTenDanhMuc.FocusBackgroundColor = Color.White;
            txtTenDanhMuc.FocusBorderColor = Color.FromArgb(255, 106, 0);
            txtTenDanhMuc.FocusImageTint = Color.White;
            txtTenDanhMuc.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDanhMuc.ForeColor = Color.Gray;
            txtTenDanhMuc.Image = null;
            txtTenDanhMuc.ImageExpand = new Point(0, 0);
            txtTenDanhMuc.ImageOffset = new Point(0, 0);
            txtTenDanhMuc.Location = new Point(573, 25);
            txtTenDanhMuc.Margin = new Padding(4);
            txtTenDanhMuc.Multiline = false;
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.NormalImageTint = Color.White;
            txtTenDanhMuc.Padding = new Padding(15, 15, 15, 0);
            txtTenDanhMuc.PasswordChar = false;
            txtTenDanhMuc.PlaceholderColor = SystemColors.WindowText;
            txtTenDanhMuc.PlaceholderText = "Nhập tên danh mục hàng hoá";
            txtTenDanhMuc.Rounding = new Padding(8);
            txtTenDanhMuc.Size = new Size(327, 45);
            txtTenDanhMuc.TabIndex = 2;
            txtTenDanhMuc.TextOffset = new Size(0, 0);
            txtTenDanhMuc.UnderlinedStyle = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(573, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 312);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 87);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Mô tả danh mục";
            // 
            // CategoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(txtTenDanhMuc);
            Controls.Add(btnThem);
            Controls.Add(gridViewCategory);
            Name = "CategoryControl";
            Size = new Size(914, 693);
            ((System.ComponentModel.ISupportInitialize)gridViewCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewCategory;
        private CuoreUI.Controls.cuiButton btnThem;
        private CuoreUI.Controls.cuiTextBox txtTenDanhMuc;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}
