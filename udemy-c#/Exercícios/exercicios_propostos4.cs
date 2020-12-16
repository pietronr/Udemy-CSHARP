Console.WriteLine("Exercícios propostos parte 4:\n");

            Console.WriteLine("Exercício 1:");

            int inteiro = int.Parse(Console.ReadLine());
            int divisao;

            for (int i = 1; i <= inteiro; i++)
            {
                divisao = i % 2;

                if (divisao == 1)
                {
                    Console.WriteLine(i);
                }
            } 

            Console.WriteLine("\nExercício 2:");

            int ct = int.Parse(Console.ReadLine());
            int contIN = 0, contOUT = 0;

            for (int i = 0; i < ct; i++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < 10 || value > 20)
                {
                    contOUT++;
                }
                else
                {
                    contIN++;
                }
            }

            Console.WriteLine("{0} in", contIN);
            Console.WriteLine("{0} out", contOUT);
pokzYesterday at 12:26 PM
Console.WriteLine("\nExercício 3:");

            int nt = int.Parse(Console.ReadLine());

            for (int i = 0; i < nt; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                float primeiroNumero = float.Parse(numeros[0], CultureInfo.InvariantCulture);
                float segundoNumero = float.Parse(numeros[1], CultureInfo.InvariantCulture);
                float terceiroNumero = float.Parse(numeros[2], CultureInfo.InvariantCulture);

                float media = ((2 * primeiroNumero) + (3 * segundoNumero) + (5 * terceiroNumero)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            } 

            Console.WriteLine("\nExercício 4:");

            int casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                double numerador = double.Parse(values[0], CultureInfo.InvariantCulture);
                double denominador = double.Parse(values[1], CultureInfo.InvariantCulture);

                double div = numerador / denominador;

                if (denominador == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    Console.WriteLine(div.ToString("F1"), CultureInfo.InvariantCulture);
                } 
				Console.WriteLine("\nExercício 5:");

            int valorN = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= valorN; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial); 

            Console.WriteLine("\nExercício 6:");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
			
Console.WriteLine("\nExercício 7:");

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int quadrado = (int)Math.Pow(i, 2);
                int cubo = (int)Math.Pow(i, 3);

                Console.WriteLine($"{i} {quadrado} {cubo}");

            }