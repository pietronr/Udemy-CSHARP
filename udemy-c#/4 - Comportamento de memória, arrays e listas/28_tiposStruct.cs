using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
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
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
        }

    }
}