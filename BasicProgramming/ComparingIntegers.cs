using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class ComparingIntegers
    {
        public static void CompareTwoIntegers() {
            Console.WriteLine("enter first integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second integer");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + " " + b);


            if (a == b)
            {
                Console.WriteLine("integers are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            } 
        }
    }
}
