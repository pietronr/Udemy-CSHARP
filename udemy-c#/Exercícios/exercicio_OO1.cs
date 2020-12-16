class Pessoa
    {
        public string Nome;
        public int Idade;
    }

class Program
    {
        static void Main(string[] args)
        {
          Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("\nDados da primeira pessoa:");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("\nPessoa mais velha: " + p2.Nome);
            }
        }
    }
