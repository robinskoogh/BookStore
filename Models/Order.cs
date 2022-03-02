using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
    }
}
