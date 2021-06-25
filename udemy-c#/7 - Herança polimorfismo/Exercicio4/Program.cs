using System;
using Exercicio4.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int empregados = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, rendaAnual, empregados));
                }

                Console.WriteLine("\nTAXES PAID:");
                double sum = 0.0;
                foreach(Pessoa p in list)
                {
                    Console.WriteLine(p.Name + ": $ " + p.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                    sum += p.Imposto();
                }

                Console.Write("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture) + "\n");
            }
        }
    }
}
