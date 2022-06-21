namespace API.Entities
{
    public class Basketitem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        // Navigation Properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}