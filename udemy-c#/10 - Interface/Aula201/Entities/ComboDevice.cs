using System;

namespace Aula201.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print: " + document);
        }

        public override void processDoc(string document)
        {
            Console.WriteLine("ComboDevice processing: " + document);
        }

        public string Scan()
        {
            return "CombDevice scan result";
        }
    }
}
