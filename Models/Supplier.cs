using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Supplier
{
    [Key]
    public int SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string ContactInfo { get; set; }
    public string Address { get; set; }

    // Navigation property
    public List<InventoryTransaction> InventoryTransactions { get; set; }
}