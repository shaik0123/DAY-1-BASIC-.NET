using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class DailyWage
    {
        public void EmpDailyWage() { 
        int WAGEPERHR = 20;
            int EMPHRS = 8;
            int FULLTIME = 1;
            int totalwage  = 0;

            Random random = new Random();
            int check = random.Next(0,2);

            Console.WriteLine("random value : " + check);

            if (check == FULLTIME) {
                totalwage = EMPHRS * WAGEPERHR;
                Console.WriteLine("emp is present");
                Console.WriteLine("Daily Wage : " + totalwage);
            }
            else
            {
                Console.WriteLine("emp is absent");
                Console.WriteLine("Daily Wage : " + totalwage);
            }
        }
    }
}
