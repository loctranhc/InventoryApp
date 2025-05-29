using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigrateDatabase;

namespace InventoryApp
{
    public partial class ThongKeBaoCaoControl : UserControl
    {
        private readonly InventoryAppDbContext appDbContext;

        public ThongKeBaoCaoControl(InventoryAppDbContext context)
        {
            InitializeComponent();
            appDbContext = context;
        }

        private void btnBaoCaoBanHang_Click(object sender, EventArgs e)
        {
            RevenueReportForm form = new RevenueReportForm(appDbContext, "BaoCaoBanHang", "XUẤT BÁO CÁO BÁN HÀNG");
            form.ShowDialog();
        }

        private void btnBaoCaoBanThuoc_Click(object sender, EventArgs e)
        {
            RevenueReportForm form = new RevenueReportForm(appDbContext, "BaoCaoBanThuoc", "XUẤT BÁO CÁO BÁN THUỐC");
            form.ShowDialog();
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            RevenueReportForm form = new RevenueReportForm(appDbContext, "BaoCaoXuatNhapTon", "XUẤT BÁO CÁO XUẤT NHẬP TỒN HÀNG HOÁ");
            form.ShowDialog();
        }
    }
}
