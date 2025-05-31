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
        private Button btnPrescription;
        private Button btnCategory;
        private Button btnDashboard;
        private Button btnMedicine;
        private Button btnToaThuocMau;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnReports = new Button();
            btnUsers = new Button();
            btnCustomers = new Button();
            btnInvoices = new Button();
            btnPOS = new Button();
            btnPrescription = new Button();
            btnInventory = new Button();
            btnProducts = new Button();
            btnCategory = new Button();
            btnDashboard = new Button();
            btnMedicine = new Button();
            btnToaThuocMau = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 30);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnCategory);
            panelMenu.Controls.Add(btnMedicine);
            panelMenu.Controls.Add(btnProducts);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Controls.Add(btnInvoices);
            panelMenu.Controls.Add(btnToaThuocMau);
            panelMenu.Controls.Add(btnPrescription);
            panelMenu.Controls.Add(btnPOS);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 600);
            panelMenu.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.ForeColor = SystemColors.ControlLightLight;
            btnReports.Location = new Point(0, 29);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 23);
            btnReports.TabIndex = 1;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(0, 58);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(75, 23);
            btnUsers.TabIndex = 2;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(0, 87);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(75, 23);
            btnCustomers.TabIndex = 3;
            // 
            // btnInvoices
            // 
            btnInvoices.Location = new Point(0, 116);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(75, 23);
            btnInvoices.TabIndex = 4;
            // 
            // btnPOS
            // 
            btnPOS.Location = new Point(0, 145);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(75, 23);
            btnPOS.TabIndex = 5;
            // 
            // btnPrescription
            // 
            btnPrescription.Location = new Point(0, 174);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(75, 23);
            btnPrescription.TabIndex = 6;
            btnPrescription.Visible = false;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(0, 203);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 23);
            btnInventory.TabIndex = 7;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(3, 232);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(75, 23);
            btnProducts.TabIndex = 8;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(0, 0);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(75, 23);
            btnCategory.TabIndex = 9;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(75, 23);
            btnDashboard.TabIndex = 10;
            // 
            // btnMedicine
            // 
            btnMedicine.Location = new Point(0, 0);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(75, 23);
            btnMedicine.TabIndex = 10;
            btnMedicine.Visible = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 600);
            panelMain.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Bán Hàng";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}