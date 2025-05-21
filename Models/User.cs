using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string UserNo { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public List<InventoryTransaction> InventoryTransactions { get; set; }
    public List<Order> Orders { get; set; }
    public List<UserLog> UserLogs { get; set; }
}