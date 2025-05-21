using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using InventoryApp.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

namespace InventoryApp
{
    public partial class POSControl : UserControl
    {
        private List<Product> currentOrder = new List<Product>();
        private decimal total = 0;

        public POSControl()
        {
            InitializeComponent();
            InitOrderTable();
        }

        private void InitOrderTable()
        {
            dgvOrderList.ColumnCount = 3;
            dgvOrderList.Columns[0].Name = "Tên Thuốc";
            dgvOrderList.Columns[1].Name = "Số Lượng";
            dgvOrderList.Columns[2].Name = "Tạm Tính (VNĐ)";
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            // Giả lập dữ liệu tìm kiếm (sau này thay bằng truy vấn database)
            var product = new Product
            {
                ProductName = "Thuốc Đau Bụng",
                StockQuantity = 15,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry...",
                SalePrice = 3000
            };

            if (product.ProductName.ToLower().Contains(keyword))
            {
                lblName.Text = product.ProductName;
                lblStock.Text = $"Số lượng tồn kho: {product.StockQuantity}";
                txtDescription.Text = product.Description;
                btnBuy.Tag = product;
                btnBuy.Enabled = true;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var product = btnBuy.Tag as Product;
            if (product != null)
            {
                decimal subtotal = product.SalePrice * 1;

                currentOrder.Add(product);
                total += subtotal;
                lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";

                dgvOrderList.Rows.Add(product.ProductName, 1, subtotal.ToString("N0"));
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ExportInvoiceToPDF();
            MessageBox.Show("Thanh toán thành công!", "Thông báo");
            currentOrder.Clear();
            dgvOrderList.Rows.Clear();
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            total = 0;
        }

        private void ExportInvoiceToPDF()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 12;

            section.AddParagraph("HÓA ĐƠN BÁN HÀNG").Format.Font.Size = 16;
            section.AddParagraph("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"));

            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.AddColumn("5cm");
            table.AddColumn("3cm");
            table.AddColumn("4cm");

            var headerRow = table.AddRow();
            headerRow.Cells[0].AddParagraph("Tên Sản Phẩm");
            headerRow.Cells[1].AddParagraph("Số Lượng");
            headerRow.Cells[2].AddParagraph("Thành Tiền");

            foreach (var item in currentOrder)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(item.ProductName);
                row.Cells[1].AddParagraph("1");
                row.Cells[2].AddParagraph(item.SalePrice.ToString("N0") + " VNĐ");
            }

            section.AddParagraph("\nTổng cộng: " + total.ToString("N0") + " VNĐ");

            string filename = "hoa_don_ban_hang.pdf";
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filename);

            Process.Start(new ProcessStartInfo { FileName = filename, UseShellExecute = true });
        }
    }
}
