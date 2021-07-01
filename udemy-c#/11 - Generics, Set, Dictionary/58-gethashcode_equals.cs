//CLASSE CLIENTE
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula207.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}

//PROGRAM
using System;
using Aula207.Entities;

namespace Aula207
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Pietro", Email = "pokz@gmail.com" };
            Client b = new Client { Name = "Stone", Email = "stone@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
