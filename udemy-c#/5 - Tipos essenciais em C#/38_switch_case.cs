// SWITCH CASE PARTE 1
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string day;

            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }

            Console.WriteLine("Dia: " + day);
// SWITCH CASE PARTE 2
int y = int.Parse(Console.ReadLine());
            string day2;

            switch (y)
            {
                case 1:
                    day2 = "Sunday";
                    break;
                case 2:
                    day2 = "Monday";
                    break;
                case 3:
                    day2 = "Tuesday";
                    break;
                case 4:
                    day2 = "Wednesday";
                    break;
                case 5:
                    day2 = "Thursday";
                    break;
                case 6:
                    day2 = "Friday";
                    break;
                case 7:
                    day2 = "Saturday";
                    break;
                default:
                    day2 = "Invalide value";
                    break;
            }
            Console.WriteLine("Dia: " + day2);
        }
    }
}