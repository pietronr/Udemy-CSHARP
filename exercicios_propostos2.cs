Console.WriteLine("Exercícios propostos parte 2: \n");

            Console.WriteLine("Exercício 1");

            int valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            Console.WriteLine("\nExercício 2");

            int valor2 = int.Parse(Console.ReadLine());

            if (valor2 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }

            Console.WriteLine("\nExercício 3");

            string[] valores = Console.ReadLine().Split(' ');
            int valor3 = int.Parse(valores[0]);
            int valor4 = int.Parse(valores[1]);

            if (valor4 % valor3 == 0 || valor3 % valor4 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.WriteLine("\nExercicio 4");

            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);
            int duracao;

            if (horaFinal < horaInicial)
            {
                horaFinal += 24;
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else if (horaFinal == horaInicial)
            {
                duracao = 24;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
 Console.WriteLine("\nExercício 5");

string[] produto = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(produto[0]);
            int qtdProduto = int.Parse(produto[1]);
            double total;

            if (codigoProduto == 1)
            {
                total = qtdProduto * 4;
            }
            else if (codigoProduto == 2)
            {
                total = qtdProduto * 4.5;
            }
            else if (codigoProduto == 3)
            {
                total = qtdProduto * 5;
            }
            else if (codigoProduto == 4)
            {
                total = qtdProduto * 2;
            } 
            else
            {
                total = qtdProduto * 1.5;
            }
 Console.WriteLine("\nExercício 6");

            float valorQualquer = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorQualquer < 0 || valorQualquer > 100)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if (valorQualquer == 0 || valorQualquer == 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valorQualquer > 0 && valorQualquer < 25)
            {
                Console.WriteLine("Intervalo (0,25)");
            }
            else if (valorQualquer == 25 && valorQualquer < 50)
            {
                Console.WriteLine("Intervalo [25,50)");
            }
            else if (valorQualquer > 25 && valorQualquer < 50)
            {
                Console.WriteLine("Intervalo (25,50)");
            }
else if (valorQualquer > 25 && valorQualquer == 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valorQualquer == 50 && valorQualquer < 75)
            {
                Console.WriteLine("Intervalo [50,75)");
            }
            else if (valorQualquer > 50 && valorQualquer < 75)
            {
                Console.WriteLine("Intervalo (50,75)");
            }
            else if (valorQualquer > 50 && valorQualquer == 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valorQualquer == 75 && valorQualquer < 100)
            {
                Console.WriteLine("Intervalo [75,100)");
            }
            else if (valorQualquer > 25 && valorQualquer < 100)
            {
                Console.WriteLine("Intervalo (75,100)");
            }
            else if (valorQualquer > 75 && valorQualquer == 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
   Console.WriteLine("\nExercício 7:");

            string[] coords = Console.ReadLine().Split(' ');
            double eixoX = double.Parse(coords[0]);
            double eixoY = double.Parse(coords[1]);

            if (eixoX == 0 && eixoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (eixoX == 0 && eixoY > 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (eixoX == 0 && eixoY < 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (eixoY == 0 && eixoX > 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoY == 0 && eixoX < 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
Console.WriteLine("\nExercício 8:");

            double renda = double.Parse(Console.ReadLine());
            double imposto;

            if (renda >= 0 && renda <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (renda >= 2000 && renda < 3000)
            {
                imposto = (renda - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (renda >= 3000 && renda < 4500)
            {
                imposto = ((1000 * 0.08) + ((renda - 3000) * 0.18));
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (renda >= 4500)
            {
                imposto = ((1000 * 0.08) + (1500 * 0.18) + ((renda - 4500) * 0.28));
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }