using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    public class Product
    {
        [Key]
        public long id_product { get; set; }
        public string product_name { get; set; }
        public float product_costPrice { get; set; }
        public float product_price { get; set; }
    }
}
