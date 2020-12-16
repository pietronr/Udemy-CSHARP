Console.WriteLine("Estrutura condicional: \n");

             Console.WriteLine("Entre com um número inteiro:");
            int valueX = int.Parse(Console.ReadLine());

            if (valueX % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
            

            Console.WriteLine("Qual a hora atual?");
            int horaAtual = int.Parse(Console.ReadLine());

            if (horaAtual < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaAtual >= 12  && horaAtual < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }