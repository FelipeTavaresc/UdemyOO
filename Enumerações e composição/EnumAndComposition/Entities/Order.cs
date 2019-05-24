using EnumAndComposition.Entities.Enum;
using System;
using System.Collections.Generic;

namespace EnumAndComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order (DateTime moment, OrderStatus orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            OrderItem = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
    }
}
