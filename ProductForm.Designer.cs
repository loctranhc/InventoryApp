namespace InventoryApp
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtSKU, txtName, txtDescription, txtUnit, txtImagePath;
        private System.Windows.Forms.NumericUpDown nudPurchase, nudSale, nudQuantity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnChooseImage, btnSave, btnCancel;
        private System.Windows.Forms.PictureBox pictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            txtSKU = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtUnit = new System.Windows.Forms.TextBox();
            txtImagePath = new System.Windows.Forms.TextBox();
            nudPurchase = new System.Windows.Forms.NumericUpDown();
            nudSale = new System.Windows.Forms.NumericUpDown();
            nudQuantity = new System.Windows.Forms.NumericUpDown();
            cbCategory = new System.Windows.Forms.ComboBox();
            btnChooseImage = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pictureBox = new System.Windows.Forms.PictureBox();
        }
    }
}