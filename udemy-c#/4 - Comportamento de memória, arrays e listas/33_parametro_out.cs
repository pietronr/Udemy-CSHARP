// PARÂMETRO OUT
// CLASSE

using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

// PROGRAM
using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}