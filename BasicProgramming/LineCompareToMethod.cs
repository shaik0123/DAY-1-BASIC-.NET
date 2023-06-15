using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class LineCompareToMethod
    {
        public static void CompareToMethod()
        {
            Console.WriteLine("enter the x1 value");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the x2 value");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the y1 value");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the y2 value");
            Double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the x3 value");
            Double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the x4 value");
            Double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the y3 value");
            Double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the y4 value");
            Double y4 = Convert.ToDouble(Console.ReadLine());



            Double l1 = (Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)));
            Double l2 = (Math.Sqrt((x4 - x3)*(x4 - x3) + (y4 - y3)*(y4 - y3)));
            Console.WriteLine(l1 + "  "+l2);

            

           if (l1.CompareTo(l2) > 0)
            {
                Console.WriteLine("l1 is greater");

            }
            else if(l1.CompareTo(l2) < 0 )
            {
                Console.WriteLine("l1 is lesser");
            }
            else 
            {
                Console.WriteLine("lines are equal ");
            }




        }
    }
}
