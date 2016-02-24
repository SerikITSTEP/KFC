using System;
using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class Receipt
    {
        [Key]
        public long id_receipt { get; set; }
        public string receipt_number { get; set; }
        public DateTime receipt_date { get; set; }
        public long user_id { get; set; }
        public long supplier_id { get; set; }//нужно добавить
        public float receipt_summ { get; set; }
    }
}
