using System;
using Aula201.Entities;

namespace Aula201
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = "1000" };
            p.processDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = "2000" };
            s.processDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice { SerialNumber = "3000" };
            c.processDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
