using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string SKU { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string Unit { get; set; }
    public decimal ImportPrice { get; set; }
    public decimal SalePrice { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public int MinStockLevel { get; set; }

    // Navigation properties
    public Category Category { get; set; }
    public List<InventoryTransaction> InventoryTransactions { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}