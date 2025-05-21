using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }

    // Navigation property
    public List<Product> Products { get; set; }
}