using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using InventoryApp;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class RevenueReportForm : BaseForm
    {
        private readonly InventoryAppDbContext _context;

        public RevenueReportForm(InventoryAppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

            var orders = _context.Orders
                .Where(o => o.OrderDate >= from && o.OrderDate <= to)
                .ToList();

            var orderIds = orders.Select(o => o.OrderId).ToList();
            var userNos = orders.Select(o => o.UserNo).Distinct().ToList();

            var orderDetails = _context.OrderDetails
                .Where(od => orderIds.Contains(od.OrderId))
                .ToList();

            var users = _context.Users
                .Where(u => userNos.Contains(u.UserNo))
                .ToList();

            var reportData = orders.Select(o =>
            {
                var details = orderDetails.Where(od => od.OrderId == o.OrderId);
                decimal tongTien = details.Sum(od => od.SoLuong * od.GiaBan);
                tongTien *= (1 - o.PhanTramGiamGia / 100m);

                string nhanVien = users.FirstOrDefault(u => u.UserNo == o.UserNo)?.UserName ?? "Không rõ";

                return new
                {
                    MaHoaDon = o.OrderNo,
                    NgayLap = o.OrderDate.ToString("dd/MM/yyyy"),
                    NhanVien = nhanVien,
                    TongTien = tongTien
                };
            }).ToList();

            dgvRevenue.DataSource = reportData;

            decimal totalRevenue = reportData.Sum(x => x.TongTien);
            lblTotalRevenue.Text = $"Tổng doanh thu: {totalRevenue:N0} VNĐ";
        }

    }
}

