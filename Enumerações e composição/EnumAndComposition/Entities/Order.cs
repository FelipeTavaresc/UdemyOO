using EnumAndComposition.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EnumAndComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order (DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (var item in OrderItem)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: " + OrderStatus);
            sb.Append("Client: " + Client);
            sb.Append("Order items:");

            foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
