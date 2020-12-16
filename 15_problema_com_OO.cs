class Triangulo {
   public double A;
   public double B;
   public double C;
}
    class Program {
Console.WriteLine("Resolvendo o problema com Orientação a Objetos");

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triãngulo Y");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2;
            double elementoX = (pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
            double areaX = Math.Sqrt(elementoX);

            double pY = (y.A + y.B + y.C) / 2;
            double elementoY = (pY * (pY - y.A) * (pY - y.B) * (pY - y.C));
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