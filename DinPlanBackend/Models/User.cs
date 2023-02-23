using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DinPlan.Models;

[Index("Username", IsUnique = true, Name = "UIDX_Username")]
public class User
{

    public int Id { get; set; }
    [StringLength(30)]
    public string Username { get; set; }
    [StringLength(30)]
    public string Email { get; set; }
    [StringLength(50)]
    public string? Firstname { get; set; }
    [StringLength(50)]
    public string? Lastname { get; set; }
    [StringLength(50)]
    public string Password { get; set; }


}
