using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class InventoryTransaction
{
    [Key]
    public int TransactionId { get; set; }
    public int ProductId { get; set; }
    public string TransactionType { get; set; }
    public int Quantity { get; set; }
    public DateTime TransactionDate { get; set; }
    public int? SupplierId { get; set; }
    public int? UserId { get; set; }

    // Navigation properties
    public Product Product { get; set; }
    public Supplier Supplier { get; set; }
    public User User { get; set; }
}