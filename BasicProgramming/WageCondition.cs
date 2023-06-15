using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class WageCondition
    {
        public static void Condition()
        {
            int MAXHRS = 100;
            int WORKINGDAYS = 20;
            int PARTTIME = 1;
            int FULLTIME = 2;
            int WAGEPERHR = 20;
            int empwage = 0;
            int emphrs = 0;
            int totalwage = 0;
            int totalhrs = 0;
            int totalworkingdays = 0;

            while (totalhrs <= MAXHRS && totalworkingdays < WORKINGDAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int check = random.Next(0, 3);

                Console.WriteLine("random value : " + check);

                if (check == PARTTIME)
                {
                    emphrs = 8;
                }
                else if (check == FULLTIME)
                {
                    emphrs = 12;
                }
                else
                {
                    emphrs = 0;
                }
                totalhrs += emphrs;
                empwage = emphrs * WAGEPERHR;
                Console.WriteLine("wage : " + empwage);
                totalwage += empwage;
            }
            Console.WriteLine("total wage : " + totalwage);
        }
    }
}
