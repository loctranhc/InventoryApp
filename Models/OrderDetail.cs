using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class OrderDetail
{
    [Key]
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }

    // Navigation properties
    public Order Order { get; set; }
    public Product Product { get; set; }
}