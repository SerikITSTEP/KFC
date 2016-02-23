using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
