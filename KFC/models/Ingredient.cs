using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Ingredient
    {
        [Key]
        public float id_ingredient { get; set; }
        public string ingredient_name { get; set; }
        public long measure_id { get; set; }
    }
}
