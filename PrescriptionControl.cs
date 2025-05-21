using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class PrescriptionControl : UserControl
    {
        private List<Product> currentPrescription = new List<Product>();
        private decimal total = 0;

        public PrescriptionControl()
        {
            InitializeComponent();
            InitPrescriptionTable();
        }

        private void InitPrescriptionTable()
        {
            dgvPrescriptionList.ColumnCount = 3;
            dgvPrescriptionList.Columns[0].Name = "Tên Thuốc";
            dgvPrescriptionList.Columns[1].Name = "Số Lượng";
            dgvPrescriptionList.Columns[2].Name = "Tạm Tính (VNĐ)";
            dgvPrescriptionList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptionList.AllowUserToAddRows = false;
            dgvPrescriptionList.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var product = new Product
            {
                ProductName = "Paracetamol",
                StockQuantity = 20,
                Description = "Thuốc giảm đau hạ sốt.",
                SalePrice = 2000
            };

            if (product.ProductName.ToLower().Contains(keyword))
            {
                lblName.Text = product.ProductName;
                lblStock.Text = "Số lượng tồn kho: " + product.StockQuantity;
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
                currentPrescription.Add(product);
                total += product.SalePrice;
                lblTotal.Text = $"Tạm tính hiện tại: {total:N0} VNĐ";

                dgvPrescriptionList.Rows.Add(product.ProductName, 1, product.SalePrice.ToString("N0"));
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lập toa thuốc thành công!", "Thông báo");

            CreatePrescriptionPdf();

            currentPrescription.Clear();
            dgvPrescriptionList.Rows.Clear();
            lblTotal.Text = "Tạm tính hiện tại: 0 VNĐ";
            total = 0;
        }

        private void CreatePrescriptionPdf()
        {
            Document doc = new Document();
            Section section = doc.AddSection();

            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";

            Paragraph title = section.AddParagraph("ĐƠN THUỐC");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = 10;
            title.Format.Alignment = ParagraphAlignment.Center;

            section.AddParagraph("Ngày lập: " + DateTime.Now.ToShortDateString());
            section.AddParagraph("Danh sách thuốc:");

            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.AddColumn("4cm");
            table.AddColumn("3cm");
            table.AddColumn("5cm");

            var header = table.AddRow();
            header.Cells[0].AddParagraph("Tên thuốc");
            header.Cells[1].AddParagraph("Số lượng");
            header.Cells[2].AddParagraph("Đơn giá (VNĐ)");

            foreach (var product in currentPrescription)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(product.ProductName);
                row.Cells[1].AddParagraph("1");
                row.Cells[2].AddParagraph(product.SalePrice.ToString("N0"));
            }

            Paragraph totalParagraph = section.AddParagraph("\nTổng cộng: " + total.ToString("N0") + " VNĐ");
            totalParagraph.Format.Alignment = ParagraphAlignment.Right;

            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            string filename = "don_thuoc.pdf";
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filename);

            Process.Start("explorer", filename);
        }
    }
}
