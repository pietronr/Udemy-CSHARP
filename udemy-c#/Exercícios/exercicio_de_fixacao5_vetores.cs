/ EXERCÍCIO DE FIXAÇÃO VETORES
// CLASSE

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Primeiro
{
    class Aluno
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Aluno(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
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
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Aluno[] vect = new Aluno[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                vect[room] = new Aluno(name, email, room);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }

        }
    }
}