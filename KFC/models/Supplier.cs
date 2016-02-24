using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Supplier
    {
        [Key]
        public long id_supplier { get; set; }
        public string supplier_name { get; set; }
        public string supplier_fio { get; set; }
        public string supplier_address { get; set; }
        public string supplier_phone { get; set; }
    }
}
