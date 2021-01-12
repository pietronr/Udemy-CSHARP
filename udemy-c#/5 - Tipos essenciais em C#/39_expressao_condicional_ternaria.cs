// EXPRESSÃO CONDICIONAL TERNÁRIA
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);

            //                 (condicao) ? valor_se_verdadeiro : valor_se_falso
            double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto2);
        }
    }
}