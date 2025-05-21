using System;
using System.Windows.Forms;
using InventoryApp.Controls;

namespace InventoryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitMenuButtons();

            // Gán sự kiện Click cho các nút
            btnProducts.Click += (s, e) => LoadControl(new ProductControl());
            btnInventory.Click += (s, e) => LoadControl(new InventoryControl());
            btnPOS.Click += (s, e) => LoadControl(new POSControl());
            btnPrescription.Click += (s, e) => LoadControl(new PrescriptionControl());
            //btnInvoices.Click += (s, e) => LoadControl(new InvoiceControl());
            btnCustomers.Click += (s, e) => LoadControl(new CustomerControl());
            btnUsers.Click += (s, e) => LoadControl(new EmployeeControl());
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
                btnProducts, btnInventory, btnPOS, btnPrescription, btnInvoices,
                btnCustomers, btnUsers, btnReports, btnBackup
            };

            string[] texts = {
                "Sản phẩm", "Tồn kho", "Bán hàng (POS)", "Toa thuốc", "Hóa đơn",
                "Khách hàng", "Nhân viên", "Báo cáo", "Sao lưu & Khôi phục"
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                if(buttons[i] == btnBackup)
                    buttons[i].Visible = false;

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
