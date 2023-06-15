using System;

namespace BasicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             EmpAttendance emp = new EmpAttendance();
             emp.valid();
             Console.WriteLine("**************************************");


             DailyWage dailyWage = new DailyWage();
             dailyWage.EmpDailyWage();


             Console.WriteLine("=======================================");


             AddPartTime.PartTime();

             Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

             SwitchCase.Switch();

             Console.WriteLine("###########################################");

             LineComparison.Comparison();

             Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

             MonthlyWage monthlyWage = new MonthlyWage();
             monthlyWage.EmpMonthlyWage();

             Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
             WageCondition.Condition();

             Console.WriteLine("//////////////////////////////////////");
             LineEqualsMethod.EqualsMethod();

             Console.WriteLine("?????????????????????????????????");
             LineCompareToMethod.CompareToMethod();

            ComparingIntegers.CompareTwoIntegers();

            CheckEvenOdd.EvenOdd();

            VoteValidation.Validation();
            CandidateAdmission.Admission();
            FindLargestNum.LargestNum();
            WeekDayNum.WeekDay();
            ArithmeticOperation.Operation();



        }
    }
}
