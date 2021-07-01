using System;
using System.Collections.Generic;

namespace Aula208
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
