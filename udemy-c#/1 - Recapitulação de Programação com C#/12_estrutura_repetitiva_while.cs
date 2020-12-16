Console.WriteLine("Estrutura repetitiva:\n");

            Console.Write("Digite um número: ");
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (X >= 0)
            {
                double raiz = Math.Sqrt(X);
                Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");