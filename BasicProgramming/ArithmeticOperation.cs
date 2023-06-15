using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    internal class ArithmeticOperation
    {
        public static void Operation()
        {
            Console.WriteLine("enter first value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value 1 for add, 2 for sub, 3 for mul,4 for div");
            int x = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(a + "  " + b);

            switch (x)
            {
                case 1:
                    int add = a + b;
                    Console.WriteLine("addition is : " + add);
                    break;
                case 2:
                    int sub = a - b;
                    Console.WriteLine("subtraction is : " + sub);
                    break;
                case 3:
                    int mul = a * b;
                    Console.WriteLine("multiplication is : "+ mul);
                    break;
                case 4:
                    int div = a / b;
                    Console.WriteLine("division is : " + div);
                    break;
                default:
                    Console.WriteLine("enter valid value");
                    break;
            }
        }
    }
}
