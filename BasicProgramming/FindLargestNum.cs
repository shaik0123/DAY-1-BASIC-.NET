using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class FindLargestNum
    {
        public static void LargestNum() {

            Console.WriteLine("enter first num");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third num");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a +" "+ b+ " "+ c);

            if (a > b && a > c)
            {
                Console.WriteLine(" a is greater");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(" b is greater");
            }
            else 
            {
                Console.WriteLine(" is c is greater");
            }
        }
    }
}
