using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class MonthlyWage
    {
        public void EmpMonthlyWage() {
            int WORKINGDAYS = 20;
            int PARTTIME = 1;
            int FULLTIME = 2;
            int WAGEPERHR = 20;
            int empwage = 0;
            int emphrs = 0;
            int totalwage = 0;

           

            for(int day = 1;  day <= WORKINGDAYS; day++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                Console.WriteLine("random value : " + check);
                if (check == PARTTIME)
                {
                    emphrs = 8;
                }
                else if(check == FULLTIME)
                {
                    emphrs = 12;
                }
                else { 
                    emphrs = 0;
                }
                empwage = emphrs * WAGEPERHR;
                Console.WriteLine("wage : "+  empwage);
                totalwage += empwage;
            }
            Console.WriteLine("total wage : " + totalwage);
        }
    }
}
