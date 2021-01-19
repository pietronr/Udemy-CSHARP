// CLASSE OrderStatus, dentro da pasta Enums, dentro da pasta Entities
using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

// CLASSE Order, dentro da pasta Entities
using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}

// PROGRAM

using System;
using System.Globalization;
using System.Collections.Generic;
using Primeiro.Entities;
using Primeiro.Entities.Enums;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}