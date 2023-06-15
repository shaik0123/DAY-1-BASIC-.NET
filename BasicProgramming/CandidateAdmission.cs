using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class CandidateAdmission
    {
        public static void Admission()
        {
            Console.WriteLine("enter phy marks");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chem marks");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter math marks");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("phy marks : " + p + " chem marks : " + c + " math marks : " + m);

            if(p >= 65)
            {
                if(c >= 55)
                {
                    if(m >= 50)
                    {

                    }
                }
            }
            Console.WriteLine("candidate is elgible for admit course");
        }
    }
}
