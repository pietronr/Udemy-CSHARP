class ConversorDeMoeda
    {
        public static double Calculo(double c, double d)
        {
            return c * d * 1.06;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Calculo(cotacao, dolares);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }