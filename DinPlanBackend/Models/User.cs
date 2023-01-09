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
    public string? Favorite { get; set; }




}
