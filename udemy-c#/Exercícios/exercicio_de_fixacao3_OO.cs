// CLASSES // 

class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
	
	class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome
                   + ", $"
                   + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
	
	class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + 2 * (Altura);
        }

        public double Diagonal()
        {
            return Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0);
        }

        public override string ToString()
        {
            return "AREA = "
            + Area().ToString("F2", CultureInfo.InvariantCulture)
            + "\nPERIMETRO = "
            + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
            + "\nDIAGONAL = "
            + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
	
// MAIN //
	
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de fixação parte 3");

            Console.WriteLine("\nExercicio 1:");

            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("\nEntre a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);

            Console.WriteLine("\nExercicio 2:");

            Funcionario f;
            f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionario: " + f);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine("\nDados atualizados: " + f);

            Console.WriteLine("\nExercicio 3:");

            Aluno a;
            a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
                + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }

        }
    }