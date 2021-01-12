// MATRIZES
// PROGRAM

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // números de elementos

            Console.WriteLine(mat.Rank); // quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // tamanho da primeira dimensão (quantidade de linhas)

            Console.WriteLine(mat.GetLength(1)); // tamanho da segunda dimensão (quantidade de colunas)

        }
    }
}