using System.ComponentModel.DataAnnotations;

namespace KFC.models
{
    public class ReceiptDetail
    {
        [Key]
        public long id_receiptDetail { get; set; }
        public long receipt_id { get; set; }
        public long ingredient_id { get; set; }
        public float quantity { get; set; }
        public float ingredient_costPrice { get; set; }
    }
}
