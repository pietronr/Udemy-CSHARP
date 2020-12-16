Console.WriteLine("Resolvendo um problema sem Orientação a Objetos");

            Console.WriteLine("\nEntre com as medidas do triângulo X");
            double x1, x2, x3;
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triãngulo Y");
            double y1, y2, y3;
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x1 + x2 + x3) / 2;
            double elementoX = (pX * (pX - x1) * (pX - x2) * (pX - x3));
            double areaX = Math.Sqrt(elementoX);

            double pY = (y1 + y2 + y3) / 2;
            double elementoY = (pY * (pY - y1) * (pY - y2) * (pY - y3));
            double areaY = Math.Sqrt(elementoY);

            Console.WriteLine("Área de X = " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }