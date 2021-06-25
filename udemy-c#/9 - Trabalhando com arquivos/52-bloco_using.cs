using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pietr\OneDrive\Documentos\udemy-c#\9 - Trabalhando com arquivos\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!\n" + e.Message);
            }
        }
    }
}
