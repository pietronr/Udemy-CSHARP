Console.WriteLine("Exercícios propostos parte 3:\n");

            Console.WriteLine("Exercício 1:");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            Console.WriteLine("Exercício 2:");

            string[] valores = Console.ReadLine().Split(' ');
            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
            }
 Console.WriteLine("Exercício 3");

            int codCombustivel = int.Parse(Console.ReadLine());
            int contAlcool = 0, contGasolina = 0, contDiesel = 0;

            while (codCombustivel != 4)
            {
                if (codCombustivel == 1)
                {
                    contAlcool++;
                }
                else if (codCombustivel == 2)
                {
                    contGasolina++;
                }
                else if (codCombustivel == 3)
                {
                    contDiesel++;
                }
                codCombustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);