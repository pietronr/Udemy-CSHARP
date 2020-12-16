Console.WriteLine("Tipos de dados: \n");

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; // codigo UniCode (\u) //
            string nome = "Maria Green"; // imutavel //

            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            SByte n0 = 100; // SB maiusculo precisa de "using System, pois é .NET //
            byte n1 = 255; // valor será = 0, passa pro limite oposto //
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;

            n1++;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);