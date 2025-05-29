using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using InventoryApp;
using MigrateDatabase;
using InventoryApp.ViewModels;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.InkML;

namespace InventoryApp
{
    public partial class RevenueReportForm : Form
    {
        private readonly InventoryAppDbContext context;
        private readonly string FormStyle = "";

        public RevenueReportForm(InventoryAppDbContext appContext, string formStyle, string formName)
        {
            InitializeComponent();
            context = appContext;
            FormStyle = formStyle;
            this.Text = formName;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            if (FormStyle == "BaoCaoBanHang")
            {
                XuatBaoCaoBanHang();
            }
            if (FormStyle == "BaoCaoBanThuoc")
            {
                XuatBaoCaoBanThuoc();
            }
            if (FormStyle == "BaoCaoXuatNhapTon")
            {
                XuatBaoCaoXuatNhapTon();
            }
        }

        private void XuatBaoCaoBanThuoc()
        {
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            // Lấy tất cả đơn thuốc trong khoảng thời gian
            var prescriptions = context.Prescriptions
                .Where(p => p.CreatedTime >= fromDate && p.CreatedTime <= toDate && p.IsToaThuocMau == false)
                .ToList();

            // Lấy tất cả chi tiết đơn thuốc liên quan đến các đơn trên
            var prescriptionIds = prescriptions.Select(p => p.Id).ToList();
            var allDetails = context.PrescriptionDetails
                .Where(d => prescriptionIds.Contains(d.PrescriptionId))
                .ToList();

            // Nhóm lại dữ liệu theo ngày bán
            var reportData = prescriptions
                .GroupBy(p => p.CreatedTime.Date)
                .Select(g => new
                {
                    SaleDate = g.Key,
                    Medicines = g
                        .SelectMany(p => allDetails
                            .Where(d => d.PrescriptionId == p.Id))
                        .ToList()
                })
                .OrderBy(x => x.SaleDate)
                .ToList();

            ExcelPackage.License.SetNonCommercialPersonal("Jack Five Bulb");


            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("Báo cáo");

            int currentRow = 1;

            // Tiêu đề trung tâm
            ws.Cells[currentRow, 1, currentRow, 7].Merge = true;
            ws.Cells[currentRow, 1].Value = "BÁO CÁO BÁN THUỐC";
            ws.Cells[currentRow, 1].Style.Font.Bold = true;
            ws.Cells[currentRow, 1].Style.Font.Size = 16;
            ws.Cells[currentRow, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            currentRow += 2;

            // Thông tin thời gian
            int locationRowAtFromDayCell = currentRow;
            ws.Cells[currentRow, 6].Value = "Từ ngày:";
            ws.Cells[currentRow, 7].Value = $"{fromDate.ToString("dd/M/yyyy")}";
            ws.Cells[currentRow + 1, 6].Value = "Đến ngày:";
            ws.Cells[currentRow + 1, 7].Value = $"{toDate.ToString("dd/M/yyyy")}";
            currentRow += 3;

            // Nhóm dữ liệu theo ngày
            decimal totalAllReport = 0;
            foreach (var group in reportData)
            {
                // Ngày bán
                ws.Cells[currentRow, 1].Value = $"Ngày bán: {group.SaleDate:dd/M/yyyy}";
                ws.Cells[currentRow, 1].Style.Font.Bold = true;
                ws.Cells[currentRow, 1].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                currentRow++;

                // Header
                string[] headers = { "#", "Mã thuốc", "Tên thuốc", "Hoạt chất", "Hàm lượng", "Đơn vị tính", "Số lượng" };
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[currentRow, i + 1].Value = headers[i];
                    ws.Cells[currentRow, i + 1].Style.Font.Bold = true;
                    ws.Cells[currentRow, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    ws.Cells[currentRow, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[currentRow, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                }

                currentRow++;

                int stt = 1;
                var checkExists = group.Medicines.GroupBy(x => x.MaThuoc).Select(x => new
                {
                    Key = x.Key,
                    Details = x.Select(x => x)
                });
                foreach (var item in checkExists)
                {

                    var thuoc = context.Medicines.FirstOrDefault(x => x.MaThuoc == item.Key);
                    ws.Cells[currentRow, 1].Value = stt++;
                    ws.Cells[currentRow, 2].Value = thuoc.MaThuoc;
                    ws.Cells[currentRow, 3].Value = thuoc.TenThuoc;
                    ws.Cells[currentRow, 4].Value = thuoc.HoatChatChinh;
                    ws.Cells[currentRow, 5].Value = thuoc.HamLuong;
                    ws.Cells[currentRow, 6].Value = thuoc.DonViTinh;
                    var soLuong = item.Details.Sum(x => x.SoLuong);
                    ws.Cells[currentRow, 7].Value = soLuong;
                    totalAllReport += soLuong;
                    for (int i = 1; i <= 7; i++)
                    {
                        ws.Cells[currentRow, i].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    currentRow++;
                }

                // Tổng cộng
                ws.Cells[currentRow, 6].Value = "Tổng cộng:";
                ws.Cells[currentRow, 6].Style.Font.Bold = true;
                ws.Cells[currentRow, 7].Formula = $"SUM(G{currentRow - group.Medicines.Count()}:G{currentRow - 1})";
                ws.Cells[currentRow, 7].Style.Font.Bold = true;

                currentRow += 2;
            }

            // Tự động điều chỉnh độ rộng cột
            ws.Cells[ws.Dimension.Address].AutoFitColumns();

            //Thông tin tổng cộng
            ws.Cells[locationRowAtFromDayCell, 2].Value = "Tổng số lượng đã bán:";
            ws.Cells[locationRowAtFromDayCell, 2].Style.Font.Bold = true;
            ws.Cells[locationRowAtFromDayCell, 3].Value = $"{totalAllReport.ToString()}";

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoBanThuoc-{DateTimeOffset.Now.ToUnixTimeSeconds()}.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                MessageBox.Show("Xuất báo cáo thành công!", "Thông báo");
            }
        }

        public List<InventoryReportItem> GetInventoryReport(DateTime fromDate, DateTime toDate)
        {
            // 1. Lấy danh sách các ngày trong khoảng
            var allDates = Enumerable.Range(0, (toDate.Date - fromDate.Date).Days + 1)
                                      .Select(offset => fromDate.Date.AddDays(offset))
                                      .ToList();

            var result = new List<InventoryReportItem>();

            foreach (var date in allDates)
            {
                var start = date;
                var end = date.AddDays(1).AddTicks(-1);

                // 2. Dữ liệu nhập trong ngày
                var nhap = context.NhapXuatHangHoas
                    .Where(x => x.CreatedTime >= start && x.CreatedTime <= end)
                    .GroupBy(x => new { x.MaHang, x.TenHang })
                    .Select(g => new
                    {
                        g.Key.MaHang,
                        g.Key.TenHang,
                        SoLuongNhap = g.Sum(x => x.SoLuongNhap),
                        TonTruoc = g.Max(x => x.SoLuongTonTruoc),
                        CreatedTime = g.Max(x => x.CreatedTime)
                    }).ToList();

                // 3. Dữ liệu xuất trong ngày
                var orderIds = context.Orders
                    .Where(o => o.OrderDate >= start && o.OrderDate <= end)
                    .Select(o => o.OrderId)
                    .ToList();

                var xuat = context.OrderDetails
                    .Where(od => orderIds.Contains(od.OrderId))
                    .GroupBy(od => od.MaHang)
                    .Select(g => new
                    {
                        MaHang = g.Key,
                        SoLuongXuat = g.Sum(x => x.SoLuong),
                        CreatedTime = g.Max(x => x.CreatedTime)
                    }).ToList();

                // 4. Gộp nhập và xuất
                var allMaHang = nhap.Select(x => x.MaHang)
                                    .Union(xuat.Select(x => x.MaHang))
                                    .Distinct();

                int stt = 1;
                foreach (var maHang in allMaHang)
                {
                    var nh = nhap.FirstOrDefault(x => x.MaHang == maHang);
                    var xu = xuat.FirstOrDefault(x => x.MaHang == maHang);

                    var item = new InventoryReportItem
                    {
                        STT = stt++,
                        MaHang = nh?.MaHang ?? xu.MaHang,
                        TenHang = nh?.TenHang ?? "",
                        TonTruoc = nh?.TonTruoc ?? 0,
                        SoLuongNhap = nh?.SoLuongNhap ?? 0,
                        SoLuongXuat = xu?.SoLuongXuat ?? 0,
                        CreatedTime = nh?.CreatedTime ?? xu.CreatedTime
                    };

                    result.Add(item);
                }
            }

            return result.OrderBy(x => x.CreatedTime).ThenBy(x => x.STT).ToList();
        }


        public void ExportInventoryReportByDate(List<InventoryReportItem> items, DateTime fromDate, DateTime toDate)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Jack Five Bulb");

            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("Báo cáo");

            // Tiêu đề
            ws.Cells["D2"].Value = "BÁO CÁO XNT HÀNG HÓA";
            ws.Cells["D2"].Style.Font.Bold = true;
            ws.Cells["D2"].Style.Font.Size = 16;

            ws.Cells["F4"].Value = "Từ ngày:";
            ws.Cells["G4"].Value = fromDate.ToString("dd/MM/yyyy");
            ws.Cells["F5"].Value = "Đến ngày:";
            ws.Cells["G5"].Value = toDate.ToString("dd/MM/yyyy");

            int row = 8;
            var grouped = items.GroupBy(x => x.CreatedTime.Date).OrderBy(g => g.Key);

            foreach (var group in grouped)
            {
                // Ngày bán
                ws.Cells[row, 2].Value = $"Ngày bán: {group.Key:dd/MM/yyyy}";
                ws.Cells[row, 2].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                ws.Cells[row, 2].Style.Font.Bold = true;

                row++;

                // Tiêu đề bảng
                string[] headers = { "#", "Mã Hàng", "Tên Hàng", "Số Lượng Tồn Trước", "Số Lượng Nhập", "Số Lượng Tồn Sau", "Số Lượng Xuất" };
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[row, i + 2].Value = headers[i];
                    ws.Cells[row, i + 2].Style.Font.Bold = true;
                    ws.Cells[row, i + 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[row, i + 2].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    ws.Cells[row, i + 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                row++;

                int stt = 1;
                foreach (var item in group)
                {
                    ws.Cells[row, 2].Value = stt++;
                    ws.Cells[row, 3].Value = item.MaHang;
                    ws.Cells[row, 4].Value = item.TenHang;
                    ws.Cells[row, 5].Value = item.TonTruoc;
                    ws.Cells[row, 6].Value = item.SoLuongNhap;
                    ws.Cells[row, 7].Value = item.TonSau;
                    ws.Cells[row, 8].Value = item.SoLuongXuat ?? 0;

                    for (int i = 2; i <= 8; i++)
                        ws.Cells[row, i].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                    row++;
                }

                row += 2; // khoảng cách giữa các ngày

            }

            // Auto-fit columns
            ws.Cells[ws.Dimension.Address].AutoFitColumns();

            // Lưu file
            using var saveDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoXNTHangHoa-{DateTimeOffset.Now.ToUnixTimeSeconds()}.xlsx"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, package.GetAsByteArray());
                MessageBox.Show("Xuất báo cáo thành công!");
            }
        }


        private void XuatBaoCaoXuatNhapTon()
        {
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
            var reportData = GetInventoryReport(fromDate, toDate);
            ExportInventoryReportByDate(reportData, fromDate, toDate);
        }

        private void XuatBaoCaoBanHang()
        {
            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            var items = (from od in context.OrderDetails
                         join o in context.Orders on od.OrderId equals o.OrderId
                         join p in context.Products on od.MaHang equals p.MaHang
                         where o.OrderDate >= fromDate && o.OrderDate <= toDate
                         orderby o.OrderDate, p.TenHang
                         select new RevenueReportItem
                         {
                             MaHang = od.MaHang,
                             TenHang = p.TenHang,
                             MaHoaDon = o.OrderNo,
                             DonViTinh = p.DonViTinh,
                             SoLuong = od.SoLuong,
                             GiaBan = od.GiaBan,
                             SaleDate = o.OrderDate,
                             PhanTramGiamGia = o.PhanTramGiamGia
                         }).ToList();

            ExcelPackage.License.SetNonCommercialPersonal("Jack Five Bulb");
            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("Báo Cáo");

            int currentRow = 2;

            // Tiêu đề
            ws.Cells[currentRow, 4].Value = "BÁO CÁO BÁN HÀNG";
            ws.Cells[currentRow, 4].Style.Font.Size = 16;
            ws.Cells[currentRow, 4].Style.Font.Bold = true;
            ws.Cells[currentRow, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[currentRow, 4, currentRow, 6].Merge = true;
            currentRow += 2;

            // Ngày từ - đến
            ws.Cells[currentRow, 6].Value = "Từ ngày:";
            ws.Cells[currentRow, 7].Value = fromDate.ToString("dd/MM/yyyy");
            currentRow++;
            ws.Cells[currentRow, 6].Value = "Đến ngày:";
            ws.Cells[currentRow, 7].Value = toDate.ToString("dd/MM/yyyy");
            currentRow += 2;

            // Tổng doanh thu
            decimal tongDoanhThu = items.Sum(x => x.GiaBan);
            ws.Cells[currentRow, 2].Value = "Tổng doanh thu";
            ws.Cells[currentRow, 3].Value = tongDoanhThu;
            ws.Cells[currentRow, 2, currentRow, 3].Style.Font.Bold = true;
            currentRow += 2;

            // Nhóm theo ngày
            var reportData = items.GroupBy(x => x.SaleDate.Date);

            foreach (var group in reportData)
            {
                // Ngày bán
                ws.Cells[currentRow, 2].Value = $"Ngày bán: {group.Key:dd/MM/yyyy}";
                ws.Cells[currentRow, 2].Style.Font.Bold = true;
                ws.Cells[currentRow, 2].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                currentRow++;

                // Tiêu đề cột
                string[] headers = { "#", "Mã Hàng", "Tên Hàng", "Mã Hoá Đơn", "Đơn vị tính", "Số lượng", "Đơn giá", "Thành tiền" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = ws.Cells[currentRow, i + 2];
                    cell.Value = headers[i];
                    cell.Style.Font.Bold = true;
                    cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }
                currentRow++;

                int stt = 1;
                foreach (var item in group)
                {
                    ws.Cells[currentRow, 2].Value = stt++;
                    ws.Cells[currentRow, 3].Value = item.MaHang;
                    ws.Cells[currentRow, 4].Value = item.TenHang;
                    ws.Cells[currentRow, 5].Value = item.MaHoaDon;
                    ws.Cells[currentRow, 6].Value = item.DonViTinh;
                    ws.Cells[currentRow, 7].Value = item.SoLuong;
                    ws.Cells[currentRow, 8].Value = item.GiaBan / item.SoLuong; // đơn giá
                    ws.Cells[currentRow, 9].Value = item.GiaBan;                 // thành tiền

                    for (int col = 2; col <= 9; col++)
                    {
                        ws.Cells[currentRow, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    currentRow++;
                }

                // Tổng cộng theo ngày
                ws.Cells[currentRow, 8].Value = "Tổng cộng:";
                ws.Cells[currentRow, 9].Formula = $"SUM(I{currentRow - group.Count()}:I{currentRow - 1})";
                ws.Cells[currentRow, 8, currentRow, 9].Style.Font.Bold = true;
                ws.Cells[currentRow, 8, currentRow, 9].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                currentRow += 2;
            }

            // Auto fit columns
            ws.Cells[ws.Dimension.Address].AutoFitColumns();

            // Lưu file
            using var saveDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoBanHang-{DateTimeOffset.Now.ToUnixTimeSeconds()}.xlsx"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, package.GetAsByteArray());
                MessageBox.Show("Xuất báo cáo thành công!");
            }
        }

    }
}

