using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
