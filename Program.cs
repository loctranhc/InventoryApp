using System.Configuration;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using MigrateDatabase;

namespace InventoryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            ApplicationConfiguration.Initialize();
            var optionsBuilder = new DbContextOptionsBuilder<InventoryAppDbContext>();
            var connectionString = ConfigurationManager.ConnectionStrings["InventoryAppDb"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
            var context = new InventoryAppDbContext(optionsBuilder.Options);
            Application.Run(new LaunchForm(context));
        }
    }
}