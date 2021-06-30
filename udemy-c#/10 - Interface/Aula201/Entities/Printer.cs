using System;

namespace Aula201.Entities
{
    class Printer : Device, IPrinter
    {
        public override void processDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
