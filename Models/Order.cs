using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int? CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
    public int? EmployeeId { get; set; }
    public decimal Discount { get; set; }

    // Navigation properties
    public Customer Customer { get; set; }
    public User Employee { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}