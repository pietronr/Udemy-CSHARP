// EXERCÍCIO DE FIXAÇÃO MATRIZES


using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matriz = Console.ReadLine().Split(' ');
            int nl = int.Parse(matriz[0]);
            int nc = int.Parse(matriz[1]);

            int[,] mat = new int[nl, nc];

            for (int i = 0; i < nl; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < nc; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int valor = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < nl; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    if (mat[i, j] == valor)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < nc - 1)
                        {
                            Console.WriteLine("Right " + mat[i, j + 1]);
                        }
                        if (i < nl - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}