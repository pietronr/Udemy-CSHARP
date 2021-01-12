// OPERAÇÕES COM TIMESPAN PARTE 1

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan x = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(x);

            Console.WriteLine("Days: " + x.Days);
            Console.WriteLine("Hours: " + x.Hours);
            Console.WriteLine("Minutes: " + x.Minutes);
            Console.WriteLine("Milliseconds: " + x.Milliseconds);
            Console.WriteLine("Second: " + x.Seconds);
            Console.WriteLine("Ticks: " + x.Ticks);

            Console.WriteLine("TotalDays: " + x.TotalDays);
            Console.WriteLine("TotalHours: " + x.TotalHours);
            Console.WriteLine("TotalMinutes: " + x.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + x.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + x.TotalMilliseconds);

        }
    }
}

// OPERAÇÕES COM TIMESPAN PARTE 2

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}