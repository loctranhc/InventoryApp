namespace InventoryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMenu;
        private Panel panelMain;
        private Button btnProducts;
        private Button btnInventory;
        private Button btnPOS;
        private Button btnInvoices;
        private Button btnCustomers;
        private Button btnUsers;
        private Button btnReports;
        private Button btnBackup;
        private Button btnPrescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new Panel();
            this.btnProducts = new Button();
            this.btnInventory = new Button();
            this.btnPOS = new Button();
            this.btnPrescription = new Button();
            this.btnInvoices = new Button();
            this.btnCustomers = new Button();
            this.btnUsers = new Button();
            this.btnReports = new Button();
            this.btnBackup = new Button();
            this.panelMain = new Panel();

            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = Color.FromArgb(30, 30, 30);
            this.panelMenu.Dock = DockStyle.Left;
            this.panelMenu.Width = 200;
            this.panelMenu.Controls.AddRange(new Control[] {
                this.btnBackup, this.btnReports, this.btnUsers,
                this.btnCustomers, this.btnInvoices, this.btnPOS,
                this.btnPrescription,
                this.btnInventory, this.btnProducts });

            // 
            // panelMain
            // 
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = Color.White;

            // 
            // MainForm
            // 
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý Bán Hàng";

            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}