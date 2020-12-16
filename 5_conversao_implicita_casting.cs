Console.WriteLine("Conversão implícita e casting:  \n");

            float x = 4.5f;
            double y = x; // 4 bites cabem dentro de 8 bites (conversão implícita de tipos)
            Console.WriteLine(y);

            double v1;
            float v2;
            int v3;

            v1 = 5.1;
            v2 = (float)v1; // 8 bites não cabem dentro de 4 bites (conversão explícita de tipos)
            Console.WriteLine(v2);

            v3 = (int)v1; // valor quebrado não "cabe" em int, haverá perda de informação, os valores decimais são truncados (conversão explícita)
            Console.WriteLine(v3);

            int var1 = 5;
            int var2 = 2;

            double resultado = (double)var1 / var2; // casting, para converter para decimal

            Console.WriteLine(resultado); // imprimirá um valor inteiro, caso não tenha o casting