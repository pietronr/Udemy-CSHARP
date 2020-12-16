string frase = Console.ReadLine();
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
            string p3 = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' '); // identifica os elementos entre espações (' ') e separa em vetores
            string e1 = vet[0];
            string e2 = vet[1];
            string e3 = vet[2];

            Console.WriteLine("\nVocê digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3); 

            int a1 = int.Parse(Console.ReadLine()); // conversão de string para int 
            char ch = char.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            string name = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade_ex = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou: ");
            Console.WriteLine(a1);
            Console.WriteLine(ch);
            Console.WriteLine(a2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(sexo);
            Console.WriteLine(idade_ex);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture); 

            Console.WriteLine("-------------------------");
