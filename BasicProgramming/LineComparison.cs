using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasicProgramming
{
    internal class LineComparison
    {
        public static void Comparison()
        {
            int x1 = 4;
            int x2 = 6;
            int y1 = 4;
            int y2 = 6;
            
            int LengthofTheLine = Convert.ToInt32(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)));
            Console.WriteLine("length of the line : " + LengthofTheLine);
        }

    }
}
