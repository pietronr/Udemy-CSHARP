Console.WriteLine("Exercício de fixação 2: \n");

            Console.WriteLine("Entre com seu nome completo: ");
            string my_name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string last_name = vetor[0];
            int my_age = int.Parse(vetor[1]);
            float my_height = float.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Saídas: ");
            Console.WriteLine(my_name);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(last_name);
            Console.WriteLine(my_age);
            Console.WriteLine(my_height.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------");