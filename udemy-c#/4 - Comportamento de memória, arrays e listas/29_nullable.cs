// NULLABLE

using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // Nullable<double>
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // pega o valor padrão
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // existe algum valor nessa variável?
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value); // pega o valor, dá erro se for chamada a partir de um objecto nullable com valor null
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}
// NULLABLE PARTE 2

using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            double a = x ?? 5; // joga o valor de "x" em "a", mas se "x" for null, joga o valor 5 para "a"
            double b = y ?? 5; // joga o valor de "y" em "b", mas se "y" for null, joga o valor 5 para "b"

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}