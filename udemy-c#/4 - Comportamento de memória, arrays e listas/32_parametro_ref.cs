// PARÂMETRO REF
// CLASSE
using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
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
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}