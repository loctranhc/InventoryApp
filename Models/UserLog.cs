using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class UserLog
{
    [Key]
    public int LogId { get; set; }
    public int UserId { get; set; }
    public string Action { get; set; }
    public DateTime ActionDate { get; set; }

    public User User { get; set; }
}