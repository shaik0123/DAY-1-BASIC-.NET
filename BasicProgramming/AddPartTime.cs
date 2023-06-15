using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class AddPartTime
    {
        public static void PartTime()
        {
            int WAGEPERHR = 20;
            int FULLTIME = 2;
            int PARTTIME = 1;
            int EMPHRS = 0;
            int totalwage = 0;

            Random random = new Random();
            int check = random.Next(0, 3);

            Console.WriteLine("random value : " + check);

            if (check == FULLTIME)
            {
                EMPHRS = 12;
                totalwage = EMPHRS * WAGEPERHR;
                Console.WriteLine("emp is present");
                Console.WriteLine("Daily Wage full time : " + totalwage);
            }
            else if (check == PARTTIME) 
            {
                EMPHRS = 8;
                totalwage = EMPHRS * WAGEPERHR;
                Console.WriteLine("emp is present");
                Console.WriteLine("Daily Wage part time: " + totalwage);
            }
            else
            {
                Console.WriteLine("emp is absent");
                Console.WriteLine("Daily Wage : " + totalwage);
            }
        }
    }
}
