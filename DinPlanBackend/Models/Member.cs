using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DinPlan.Models;

[Index("Name", IsUnique = true, Name = "UIDX_Name")]
public class Member
{

    public int Id { get; set; }
    [StringLength(30)]
    public string Name { get; set; }
    [StringLength(30)]
    public string? Favorite { get; set; }




}
