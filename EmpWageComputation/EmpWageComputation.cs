using System;

namespace EmpWageComputation
{
    class EmpWageComputation
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_FULLTIME = 1;
            const int IS_PARTTIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int WAGE_PER_HR = 20;
            //Variables
            int empHrs = 0;
            int dailyWage = 0;
            int monthlyWage = 0;

            Random random = new Random();
            //Computation
            for (int day=1; day<=NUM_OF_WORKING_DAYS; day++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    case IS_PARTTIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                dailyWage = empHrs * WAGE_PER_HR;
                monthlyWage = monthlyWage + dailyWage;
            }
            
            Console.WriteLine("Total Monthly Wage: " + monthlyWage);
        }
    }
}
