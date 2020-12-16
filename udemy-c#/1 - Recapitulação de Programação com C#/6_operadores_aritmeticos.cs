Console.WriteLine("Operadores aritméticos: \n");

            int numero1 = 3 + 4 * 2;
            int numero2 = (3 + 4) * 2;
            int numero3 = 17 % 3;
            double numero4 = 10.0 / 8; // ".0" colocado pra indicar que é uma expressão double

            double A = 1.0, B = -3.0, C = -4.0;
            double delta = Math.Pow(B, 2.0) - 4.0 * A * C;
            double x1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine("-------------------------");