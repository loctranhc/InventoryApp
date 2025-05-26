using Microsoft.EntityFrameworkCore;
using MigrateDatabase;

namespace InventoryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var optionsBuilder = new DbContextOptionsBuilder<InventoryAppDbContext>();
            optionsBuilder.UseSqlServer("Server=172.30.51.193;Database=InventoryApp;User ID=sa;Password=mddEwMgUxwK3FvPJ;Encrypt=False;");
            var context = new InventoryAppDbContext(optionsBuilder.Options);
            Application.Run(new RevenueReportForm(context));
        }
    }
}