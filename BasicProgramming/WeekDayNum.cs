using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class WeekDayNum
    {
        public static void WeekDay() {
            Console.WriteLine("enter weekday number you want");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("weekday is monday");
                    break;
                case 2:
                    Console.WriteLine("weekday is tuesday");
                    break;
                case 3:
                    Console.WriteLine("weekday is wednesday");
                    break;
                case 4:
                    Console.WriteLine("weekday is thrusday");
                    break;
                case 5:
                    Console.WriteLine("weekday is friday");
                    break;
                case 6:
                    Console.WriteLine("weekday is saturday");
                    break;
                case 7:
                    Console.WriteLine("weekday is sunday");
                    break;
                default:
                    Console.WriteLine("enter a correct weekday number");
                    break;
            }
        
        }
    }
}
