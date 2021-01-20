using System;
using System.Collections.Generic;
using Exercicio.Entities.Enum;
using System.Text;
using System.Globalization;

namespace Exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem items in Items)
            {
                sum += items.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: " + Moment.ToString("dd / MM / yyyy HH: mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client);       
            sb.AppendLine("Order items");
            foreach(OrderItem i in Items)
            {
                sb.AppendLine(i.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture)); 
            return sb.ToString();
        }
    }
}
