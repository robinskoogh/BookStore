namespace BookStore.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int OrderId { get; set; }
        public int BookId { get; set; }
        public Order Order { get; set; }
        public Book Book { get; set; }

    }
}
