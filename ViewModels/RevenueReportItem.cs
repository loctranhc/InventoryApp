using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.ViewModels
{
    public class RevenueReportItem
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MaHoaDon { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public DateTime SaleDate { get; set; }
        public int PhanTramGiamGia { get; set; }
    }
}
