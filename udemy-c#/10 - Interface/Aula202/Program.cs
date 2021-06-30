using System;
using System.IO;
using System.Collections.Generic;
using Aula202.Entities;

namespace Aula202
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pietr\OneDrive\Documentos\udemy-c#\10 - Interfaces\repos\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
