// DATE TIME

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 08, 01); // ano, mês, dia, 0 horas
            DateTime d2 = new DateTime(2020, 08, 01, 20, 45, 3); // ano, mês, dia, hora, minuto, segundo
            DateTime d3 = new DateTime(2020, 08, 01, 20, 45, 3, 500); // ano, mês, dia, hora, minuto, segundo, milisegundos (não imprime)

            DateTime d4 = DateTime.Now; // data e hora atual
            DateTime d5 = DateTime.Today; // data de agora, 0 horas
            DateTime d6 = DateTime.UtcNow; // data e hora no UTC

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("200-08-15 14:55:50");

            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd, MM, yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}