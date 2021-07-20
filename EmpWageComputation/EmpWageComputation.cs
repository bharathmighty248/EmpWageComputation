using System;

namespace EmpWageComputation
{
    class EmpWageComputation
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_PRESENT = 1;
            const int WAGE_PER_HR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
