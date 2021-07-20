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
            const int WAGE_PER_HR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
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
            empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
