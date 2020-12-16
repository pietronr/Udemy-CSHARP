Console.WriteLine("Operadores lógicos: \n");

            bool o1 = 2 > 3 && 4 != 5;
            bool o2 = 2 > 3 || 4 != 5;
            bool o3 = !(2 > 3) && 4 != 5; // O "!" nega o resultado, se for V vira F e se for F vira V

            // Precedência: ! > && > ||

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);

            Console.WriteLine(" ");

            bool o4 = 10 < 5;
            bool o5 = o1 || o3 && o4;

            Console.WriteLine(o4);
            Console.WriteLine(o5);

            Console.WriteLine("-------------------------");