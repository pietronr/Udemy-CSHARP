using System;

namespace Aula201.Entities
{
    class Scanner : Device, IScanner
    {
        public override void processDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
