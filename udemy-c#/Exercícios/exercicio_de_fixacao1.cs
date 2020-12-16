 Console.WriteLine("Exercício de fixação 1: \n");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte ex_idade = 30;
            int codigo = 5290;
            char ex_genero = 'M';

            double preco1 = 2100;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2);
            Console.WriteLine(" ");
            Console.WriteLine($"Registro: {ex_idade} anos de idade, codigo {codigo} e genero: {ex_genero}");
            Console.WriteLine(" ");
            Console.WriteLine($"Medida com oito casas decimais {medida}");
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal de invariant culture " + medida.ToString("F3", CultureInfo.InvariantCulture));
