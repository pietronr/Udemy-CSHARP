// LISTAS

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex" };
        }
    }
}
// LISTAS PARTE 2

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); // adiciona na ordem que é usado o método
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // inserir onde quiser

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // contar os elementos

            string s1 = list.Find(x => x[0] == 'A'); // encontrar a primeira ocorrência do predicado
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // encontra a última ocorrência do predicado
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // encontra o índice da primeira ocorrência do predicado
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // encontra o íncide da última ocorrência do predicado
            Console.WriteLine("Last position 'A': " + pos2);
            List<string> list2 = list.FindAll(x => x.Length == 5); // encontra todos os "itens" que satisfazem a ocorrência
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); // remove o item que satisfaz o predicado
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // remove todos os itens que satisfazem o predicado
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); // remove o item na posição inserida
            Console.WriteLine("-----------------------------------"); 
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); // remove um "alcance", a partir da primeira posição, deseja-se remove "x" elementos
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}