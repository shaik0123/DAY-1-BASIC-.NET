using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class SwitchCase
    {
        public static void Switch()
        {
            int WAGEPERHR = 20;
            int FULLTIME = 2;
            int PARTTIME = 1;
            int EMPHRS = 0;
            int totalwage = 0;

            Random random = new Random();
            int check = random.Next(0, 3);

            Console.WriteLine("random value : " + check);
            switch (check) {
                case 1:
                    EMPHRS = 8; 
                    break;
                case 2:
                    EMPHRS = 12;
                    break;
                default:
                    EMPHRS = 0;
                    break;

            }

            totalwage = EMPHRS * WAGEPERHR;
            Console.WriteLine("Daily Wage : " + totalwage);
        }
    }
}
