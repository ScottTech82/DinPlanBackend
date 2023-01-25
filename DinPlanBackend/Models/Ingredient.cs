using System.Text.Json.Serialization;

namespace DinPlan.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; } //amount of ingredient like 1 1/2 cups or 1 tbsp, etc.

        public string Notes { get; set; } //any further comments about the ingredient.

        public int MealId { get; set; }
        [JsonIgnore]
        public virtual Meal? Meal { get; set; }
    }
}
