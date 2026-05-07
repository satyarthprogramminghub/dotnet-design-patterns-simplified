using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public List<OrderItem> Items { get; set; } = new();
        public string Status { get; set; } = "Pending";

        public decimal GetTotal()
        {
            return Items.Sum(item => item.UnitPrice * item.Quantity);
        }
    }
}
