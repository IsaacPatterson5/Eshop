using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{   
    [Table("BasketItem")]
    public class Basketitem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        // Navigation Properties
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}