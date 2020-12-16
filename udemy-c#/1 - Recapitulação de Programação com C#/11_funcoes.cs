Console.WriteLine("Funções :\n");

            Console.WriteLine("Digite três números:");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());

            double resultado = Maior(valor1, valor2, valor3);

            Console.WriteLine("Maior = " + resultado);

            static int Maior(int num1, int num2, int num3) // "Static" deve ser igual à primeira função, "int" é o tipo da saída
            {
                int m;
                if (num1 > num2 && num1 > num3)
                {
                    m = num1;
                }
                else if (num2 > num3)
                {
                    m = num2;
                }
                else
                {
                    m = num3;
                }
                return m;
            }