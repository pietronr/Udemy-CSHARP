class Funcionario
    {
        public string NomeFuncionario;
        public int Salario;
    }
class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("\nDados do primeiro funcionário:");
            f1.NomeFuncionario = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do segundo funcionário:");
            f2.NomeFuncionario = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio = " + medio.ToString("F2", CultureInfo.InvariantCulture));

        }

    }