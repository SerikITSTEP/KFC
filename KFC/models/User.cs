using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class User
    {
        [Key]
        public long id_user { get; set; }
        public string login { set; get; }
        public string password { set; get; }
        public string role_id { get; set; }
    }
}
