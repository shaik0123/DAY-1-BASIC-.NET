using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class EmpAttendance
    {
        public void valid() {

            int present = 1;

            Random random= new Random();
            int check = random.Next(0, 2);
            Console.WriteLine("random value : " + check);


            if (check == present)
            {
                Console.WriteLine("emp is present ");
            }
            else
            {
                Console.WriteLine("emp is absent");
            }


        }
    }
}
