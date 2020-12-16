 Console.WriteLine("Saída de dados: \n");

            int minha_idade = 18;
            double meu_saldo = 14.69696;
            string meu_nome = "Pietro";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", meu_nome, minha_idade, meu_saldo);

            Console.WriteLine($"{meu_nome} tem {minha_idade} anos e tem saldo igual a {meu_saldo:F2} reais");

            Console.WriteLine(meu_nome + " tem " + minha_idade + " anos e tem saldo igual a " + meu_saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");