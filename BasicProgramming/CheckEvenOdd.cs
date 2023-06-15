using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class CheckEvenOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("enter the num you want");
            int x = Convert.ToInt32(Console.ReadLine());

            if(x%2 == 0 )
            {
                Console.WriteLine("even num");
            }
            else
            {
                Console.WriteLine("odd num");
            }
        }
    }
}
