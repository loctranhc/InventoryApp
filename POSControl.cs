namespace InventoryApp
{
    partial class POSControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();

            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();

            // panelLeft
            this.panelLeft.Controls.Add(this.lblOrderTitle);
            this.panelLeft.Controls.Add(this.dgvOrderList);
            this.panelLeft.Controls.Add(this.lblTotal);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 600;

            // lblOrderTitle
            this.lblOrderTitle.Text = "ĐƠN HÀNG HIỆN TẠI";
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Location = new System.Drawing.Point(10, 10);

            // dgvOrderList
            this.dgvOrderList.Location = new System.Drawing.Point(10, 50);
            this.dgvOrderList.Size = new System.Drawing.Size(580, 300);
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.AllowUserToAddRows = false;

            // lblTotal
            this.lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            this.lblTotal.Location = new System.Drawing.Point(10, 360);
            this.lblTotal.AutoSize = true;

            // panelRight
            this.panelRight.Controls.Add(this.lblSearchTitle);
            this.panelRight.Controls.Add(this.txtSearch);
            this.panelRight.Controls.Add(this.btnSearch);
            this.panelRight.Controls.Add(this.lblName);
            this.panelRight.Controls.Add(this.lblStock);
            this.panelRight.Controls.Add(this.txtDescription);
            this.panelRight.Controls.Add(this.btnBuy);
            this.panelRight.Controls.Add(this.btnCheckout);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;

            // lblSearchTitle
            this.lblSearchTitle.Text = "TÌM KIẾM THUỐC";
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(10, 10);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(10, 50);
            this.txtSearch.Width = 200;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(220, 48);
            this.btnSearch.Text = "🔍";
            this.btnSearch.Width = 40;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // lblName
            this.lblName.Text = "Tên Thuốc";
            this.lblName.Location = new System.Drawing.Point(10, 100);
            this.lblName.AutoSize = true;

            // lblStock
            this.lblStock.Text = "Số lượng tồn kho: 0";
            this.lblStock.Location = new System.Drawing.Point(10, 130);
            this.lblStock.AutoSize = true;

            // txtDescription
            this.txtDescription.Multiline = true;
            this.txtDescription.Location = new System.Drawing.Point(10, 160);
            this.txtDescription.Size = new System.Drawing.Size(300, 100);
            this.txtDescription.ReadOnly = true;

            // btnBuy
            this.btnBuy.Text = "Mua";
            this.btnBuy.Location = new System.Drawing.Point(230, 270);
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);

            // btnCheckout
            this.btnCheckout.Text = "Thanh Toán";
            this.btnCheckout.BackColor = System.Drawing.Color.DeepPink;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(200, 350);
            this.btnCheckout.Size = new System.Drawing.Size(120, 40);
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            // POSControl
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Size = new System.Drawing.Size(1000, 450);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
