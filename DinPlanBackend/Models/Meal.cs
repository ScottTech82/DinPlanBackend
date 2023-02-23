using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DinPlan.Models
{
    [Index("Name", IsUnique = true, Name = "UIDX_Name")]
    public class Meal
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Type { get; set; } //type of meal ie. italian, asian, mexican, etc.
        [StringLength(30)]
        public string CookType { get; set; } //oven, stove top, bake, broil, etc.
        [StringLength(30)]
        public string? CookTemp { get; set; }  //ie 350 degrees in oven. N/A if on stove top.
        [StringLength(30)]
        public string CookTime { get; set; } //how long to cook in the oven.
        
        public string? CookNotes { get; set; }

        public virtual ICollection<Ingredient>? Ingredients { get; set; }

        public int Memberid { get; set; }
        public virtual Member? Member { get; set; }
    }
}
