using System;
using System.Linq;
using System.Windows.Forms;
using InventoryApp.Data;

namespace InventoryApp
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
            //LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            using (var db = new InventoryDbContext())
            {
                var inventoryList = db.Products
                    .Select(p => new
                    {
                        p.SKU,
                        p.Name,
                        p.Quantity,
                        p.Unit,
                    })
                    .ToList();

                dataGridViewInventory.DataSource = inventoryList;
            }
        }
    }
}
