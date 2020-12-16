 Console.WriteLine("Valores máximos e mínimos: \n");

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

            char genero2 = 'M';
            int idade = 32;
            double saldo = 10.35784;
            string nome2 = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine(genero2);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome2);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4")); // 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // define "." como separador decimal