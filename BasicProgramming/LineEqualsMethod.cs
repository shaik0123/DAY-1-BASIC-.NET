using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class LineEqualsMethod
    {
        public static void EqualsMethod()
        {
            int x1 = 4;
            int x2 = 6;
            int y1 = 4;
            int y2 = 6;
            int x3 = 4;
            int x4 = 6;
            int y3 = 3;
            int y4 = 9;

            int LengthofTheLine1 = Convert.ToInt32(Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2));
            int LengthofTheLine2 = Convert.ToInt32(Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2));
            Console.WriteLine(LengthofTheLine1 + " " + LengthofTheLine2);

            if (LengthofTheLine2.Equals(LengthofTheLine1))
            {
                Console.WriteLine("lines are equal");

            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
            


        }
    }
}
