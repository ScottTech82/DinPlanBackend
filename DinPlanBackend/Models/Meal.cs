using System.ComponentModel.DataAnnotations;

namespace DinPlan.Models
{
    public class Meal
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Type { get; set; } //italian, asian, mexican, etc.
        [StringLength(255)]
        public string? Description { get; set; } //short description of the meal
        [StringLength(30)]
        public string CookType { get; set; } //oven, stove top, bake, broil, etc.
        [StringLength(30)]
        public string? CookTemp { get; set; }  //ie 350 degrees in oven. N/A if on stove top.
        [StringLength(30)]
        public string CookTime { get; set; } //how long to cook in the oven.

        public virtual ICollection<Ingredient>? Ingredients { get; set; }

        public int Userid { get; set; }
        public virtual User? User { get; set; }
    }
}
