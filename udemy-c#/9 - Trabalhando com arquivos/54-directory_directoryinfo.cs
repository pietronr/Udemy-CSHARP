using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pietr\OneDrive\Documentos\udemy-c#\9 - Trabalhando com arquivos\myFolder";
            
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred!\n" + e.Message);
            }
        }
    }
}
