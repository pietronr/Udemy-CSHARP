Console.WriteLine("Estrutura repetitiva for:\n");

            Console.Write("Quantos números inteiros você vai digitar? ");
            int T = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= T; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);