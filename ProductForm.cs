using System;
using System.Windows.Forms;
using InventoryApp.Models;
using System.Xml.Linq;

namespace InventoryApp
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            InitFormLayout();
        }

        private void AddLabel(string text, int x, int y)
        {
            var lbl = new Label
            {
                Text = text,
                Location = new Point(x, y + 4),
                AutoSize = true
            };
            this.Controls.Add(lbl);
        }

        private void InitFormLayout()
        {
            this.Text = "Thêm / Sửa sản phẩm";
            this.ClientSize = new Size(700, 450);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            int labelX = 20, inputX = 150, rowY = 20, gap = 35;

            AddLabel("Mã sản phẩm (SKU):", labelX, rowY);
            txtSKU.Location = new Point(inputX, rowY);
            txtSKU.Width = 200;

            rowY += gap;
            AddLabel("Tên sản phẩm:", labelX, rowY);
            txtName.Location = new Point(inputX, rowY);
            txtName.Width = 300;

            rowY += gap;
            AddLabel("Mô tả:", labelX, rowY);
            txtDescription.Location = new Point(inputX, rowY);
            txtDescription.Width = 300;

            rowY += gap;
            AddLabel("Đơn vị tính:", labelX, rowY);
            txtUnit.Location = new Point(inputX, rowY);
            txtUnit.Width = 100;

            rowY += gap;
            AddLabel("Giá nhập:", labelX, rowY);
            nudPurchase.Location = new Point(inputX, rowY);
            nudPurchase.Maximum = 1000000;

            rowY += gap;
            AddLabel("Giá bán:", labelX, rowY);
            nudSale.Location = new Point(inputX, rowY);
            nudSale.Maximum = 1000000;

            rowY += gap;
            AddLabel("Số lượng tồn kho:", labelX, rowY);
            nudQuantity.Location = new Point(inputX, rowY);
            nudQuantity.Maximum = 10000;

            rowY += gap;
            AddLabel("Danh mục:", labelX, rowY);
            cbCategory.Location = new Point(inputX, rowY);
            cbCategory.Width = 200;
            cbCategory.Items.AddRange(new object[] { "Đồ uống", "Thực phẩm", "Thiết bị", "Khác" });

            rowY += gap;
            AddLabel("Hình ảnh:", labelX, rowY);
            txtImagePath.Location = new Point(inputX, rowY);
            txtImagePath.Width = 200;

            btnChooseImage.Text = "...";
            btnChooseImage.Location = new Point(inputX + 210, rowY);
            btnChooseImage.Click += btnChooseImage_Click;

            pictureBox.Location = new Point(470, 20);
            pictureBox.Size = new Size(150, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            btnSave.Text = "Lưu";
            btnSave.Location = new Point(250, rowY + 50);
            btnSave.Click += btnSave_Click;

            btnCancel.Text = "Hủy";
            btnCancel.Location = new Point(330, rowY + 50);
            btnCancel.Click += btnCancel_Click;

            this.Controls.AddRange(new Control[]
            {
                txtSKU, txtName, txtDescription, txtUnit,
                nudPurchase, nudSale, nudQuantity, cbCategory,
                txtImagePath, btnChooseImage, pictureBox,
                btnSave, btnCancel
            });
        }

        public string ProductName => txtName.Text;
        public string SKU => txtSKU.Text;
        public string Description => txtDescription.Text;
        public string Unit => txtUnit.Text;
        public decimal PurchasePrice => nudPurchase.Value;
        public decimal SalePrice => nudSale.Value;
        public int Quantity => (int)nudQuantity.Value;
        public string Category => cbCategory.Text;
        public string ImagePath => txtImagePath.Text;

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofd.FileName;
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // (Bạn có thể thêm validate ở đây)
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
