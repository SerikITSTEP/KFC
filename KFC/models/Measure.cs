using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Measure
    {
        [Key]
        public long id_measure { get; set; }
        public string measure_name { get; set; }
    }
}
