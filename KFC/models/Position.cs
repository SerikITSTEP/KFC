using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Position
    {
        [Key]
        public long id_position { get; set; }
        public string position { get; set; }
    }
}
