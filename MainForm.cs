using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using InventoryApp.Controls;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class MainForm : BaseForm
    {
        private InventoryAppDbContext context;

        public MainForm(InventoryAppDbContext dbContext)
        {
            InitializeComponent();
            InitMenuButtons();
            context = dbContext;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            LoadControl(new HomePage());

            // Gán sự kiện Click cho các nút
            btnDashboard.Click += (s, e) => LoadControl(new HomePage());
            btnCategory.Click += (s, e) => LoadControl(new CategoryControl(context));
            btnProducts.Click += (s, e) => LoadControl(new ProductControl(context));
            btnInventory.Click += (s, e) => LoadControl(new InventoryControl(dbContext));
            btnPOS.Click += (s, e) => LoadControl(new POSControl(dbContext));
            btnPrescription.Click += (s, e) => LoadControl(new PrescriptionControl(dbContext));
            btnMedicine.Click += (s, e) => LoadControl(new MedicineControl(dbContext));
            //btnInvoices.Click += (s, e) => LoadControl(new InvoiceControl());
            btnCustomers.Click += (s, e) => LoadControl(new CustomerControl(dbContext));
            btnUsers.Click += (s, e) => LoadControl(new EmployeeControl(dbContext));
            //btnReports.Click += (s, e) => LoadControl(new ReportControl());
            //btnBackup.Click += (s, e) => LoadControl(new BackupControl());
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void InitMenuButtons()
        {
            Button[] buttons = {
                btnDashboard, btnPOS, btnPrescription, btnCategory, btnProducts, btnMedicine, btnInventory, btnInvoices,
                btnCustomers, btnUsers, btnReports
            };

            string[] texts = {
                "DASHBOARD", "BÁN HÀNG", "TOA THUỐC", "DANH MỤC", "SẢN PHẨM", "THUỐC", "TỒN KHO", "HOÁ ĐƠN",
                "KHÁCH HÀNG", "NHÂN VIÊN", "BÁO CÁO"
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = texts[i];
                buttons[i].Dock = DockStyle.Top;
                buttons[i].Height = 40;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].ForeColor = Color.White;
                buttons[i].BackColor = Color.FromArgb(45, 45, 45);
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].TextAlign = ContentAlignment.MiddleLeft;
                buttons[i].Padding = new Padding(10, 0, 0, 0);
            }
        }
    }
}
