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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            InitMenuButtons();
            context = dbContext;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            ShowLoadingThenLoad(() => LoadControl(new POSControl(dbContext)));

            // Gán sự kiện Click cho các nút
            //btnDashboard.Click += (s, e) => LoadControl(new HomePage());
            btnCategory.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new CategoryControl(context)));
            btnProducts.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new ProductControl(context)));
            btnInventory.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new InventoryControl(dbContext)));
            btnPOS.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new POSControl(dbContext)));
            btnPrescription.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new PrescriptionControl(dbContext)));
            btnMedicine.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new MedicineControl(dbContext)));
            btnInvoices.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new HoaDonToaThuoc(dbContext)));
            btnCustomers.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new CustomerControl(dbContext)));
            btnUsers.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new EmployeeControl(dbContext)));
            btnToaThuocMau.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new ToaThuocMauControl(dbContext)));
            btnReports.Click += (s, e) => ShowLoadingThenLoad(() => LoadControl(new ThongKeBaoCaoControl(dbContext)));
            //btnBackup.Click += (s, e) => LoadControl(new BackupControl());
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private async void ShowLoadingThenLoad(Action loadAction)
        {
            LoadControl(new panelLoading());
            await Task.Delay(500);
            loadAction();
        }

        private void InitMenuButtons()
        {
            Button[] buttons = {
                btnPOS, btnPrescription, btnToaThuocMau, btnCategory, btnProducts, btnMedicine, btnInvoices,
                btnCustomers, btnUsers, btnReports
            };

            string[] texts = {
                "BÁN HÀNG", "BÁN THUỐC", "TOA THUỐC MẪU", "DANH MỤC", "QUẢN LÝ SẢN PHẨM", "QUẢN LÝ THUỐC", "HOÁ ĐƠN/TOA THUỐC",
                "DS KHÁCH HÀNG", "DS NHÂN VIÊN", "THỐNG KÊ/BÁO CÁO"
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
