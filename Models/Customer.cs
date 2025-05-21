using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Notes { get; set; }
    public int LoyaltyPoints { get; set; }

    // Navigation property
    public List<Order> Orders { get; set; }
}