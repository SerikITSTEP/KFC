using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Role
    {
        [Key]
        public string id_role { get; set; }
        public string role_name { get; set; }
    }
}
