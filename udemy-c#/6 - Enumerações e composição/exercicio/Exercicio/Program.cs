using System;
using Exercicio.Entities;
using Exercicio.Entities.Enum;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;
            Client client = new Client(name, email, birthDate);
            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                OrderItem items = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(items);
            }

            Console.WriteLine("");
            Console.WriteLine(order);
        }
    }
}
