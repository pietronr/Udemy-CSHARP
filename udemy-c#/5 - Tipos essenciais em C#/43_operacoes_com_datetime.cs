// OPERAÇÔES COM DATETIME PARTE 1


using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date; " + d.Date);
            Console.WriteLine("2) Day " + d.Day);
            Console.WriteLine("3) DayOfWeek " + d.DayOfWeek);
            Console.WriteLine("4) dayOfYear " + d.DayOfYear);
            Console.WriteLine("5) Hour " + d.Hour);
            Console.WriteLine("6) Kind " + d.Kind);
            Console.WriteLine("7) Millisecond " + d.Millisecond);
            Console.WriteLine("8) Minute " + d.Minute);
            Console.WriteLine("9) Month " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
        }
    }
}
// OPERAÇÕES COM DATETIME PARTE 2
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss:fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
        }
    }
}

// OPERAÇÕES COM DATETIME PARTE 3

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime x1 = new DateTime(2000, 10, 15);

            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(3);
            DateTime d4 = d1.AddDays(7);

            DateTime x2 = new DateTime(2000, 10, 18);

            TimeSpan t = x2.Subtract(x1);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine(t);
        }
    }
}