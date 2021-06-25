using System;
using System.Collections.Generic;
using Exercicio2.Entities;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'c')
                {
                    list.Add(new Product(name, price));
                }

                else if(ch == 'u')
                {
                    Console.Write("Manufacturer Date (DD/MM/YYYY): ");
                    DateTime manufacturerDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacturerDate));
                }

                else if(ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

                Console.WriteLine("\nPRICE TAGS:");
                foreach(Product p in list)
                {
                    Console.WriteLine(p.PriceTag() + "\n");
                }

            }
        }
    }
}
