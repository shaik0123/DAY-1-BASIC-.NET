using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class VoteValidation
    {
        public static void Validation() {
            Console.WriteLine("enter the age of candidate");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("candidate not elgible for casting his/her own vote");
            }
            else if(age >= 18)
            {
                Console.WriteLine("candidate elgible for casting his/her own vote");
            }
        }
    }
}
