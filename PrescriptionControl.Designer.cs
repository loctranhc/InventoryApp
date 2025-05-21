namespace InventoryApp
{
    partial class PrescriptionControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgvPrescriptionList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;

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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblName = new Label();
            lblStock = new Label();
            txtDescription = new TextBox();
            btnBuy = new Button();
            dgvPrescriptionList = new DataGridView();
            lblTotal = new Label();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionList).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm thuốc:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(310, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Tên thuốc:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 90);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(101, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Số lượng tồn kho:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 120);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 60);
            txtDescription.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.Enabled = false;
            btnBuy.Location = new Point(20, 190);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(75, 23);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Kê thuốc";
            btnBuy.Click += btnBuy_Click;
            // 
            // dgvPrescriptionList
            // 
            dgvPrescriptionList.Location = new Point(400, 20);
            dgvPrescriptionList.Name = "dgvPrescriptionList";
            dgvPrescriptionList.Size = new Size(400, 200);
            dgvPrescriptionList.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(400, 230);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(136, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(400, 260);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(136, 23);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = "Lập đơn thuốc";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // PrescriptionControl
            // 
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblName);
            Controls.Add(lblStock);
            Controls.Add(txtDescription);
            Controls.Add(btnBuy);
            Controls.Add(dgvPrescriptionList);
            Controls.Add(lblTotal);
            Controls.Add(btnCheckout);
            Name = "PrescriptionControl";
            Size = new Size(820, 320);
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptionList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
