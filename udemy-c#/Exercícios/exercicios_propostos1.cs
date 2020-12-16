 Console.WriteLine("Exercício proposto 1: \n");

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int somaTotal;

            somaTotal = valor1 + valor2;

            Console.WriteLine($"SOMA = {somaTotal}", somaTotal);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Exercício proposto 2: \n");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------");

            Console.WriteLine("Exercício proposto 3: \n");

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());

            int diferenca;

            diferenca = ((X * Y) - (W * Z));

            Console.WriteLine("DIFERENÇA = {0}", diferenca);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Exercício proposto 4: \n");

            int idFuncionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;

            Console.WriteLine("NUMBER = " + idFuncionario);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------");

            Console.WriteLine("Exercício proposto 5: \n");

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            int codPeca1 = int.Parse(vet1[0]);
            int numPeca1 = int.Parse(vet1[1]);
            double valorPeca1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            int codPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = ((numPeca1 * valorPeca1) + (numPeca2 * valorPeca2));

            Console.WriteLine($"Códigos: {codPeca1}, {codPeca2}");
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("-------------------------");

            Console.WriteLine("Exercício proposto 6: \n");

            string[] valores = Console.ReadLine().Split(' ');

            float valorA = float.Parse(valores[0], CultureInfo.InvariantCulture);
            float valorB = float.Parse(valores[1], CultureInfo.InvariantCulture);
            float valorC = float.Parse(valores[2], CultureInfo.InvariantCulture);

            float areaTriangulo = (valorA * valorC) / 2;
            float areaCirculo = (float)(3.14159 * Math.Pow(valorC, 2.0));
            float areaTrapezio = ((valorA + valorB) * valorC) / 2;
            float areaQuadrado = valorB * valorB;
            float areaRetangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine("QUADRADO: {0}", areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));