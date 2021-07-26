using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageComputation
    {
        public void EmpWage()
        {
            //Constants
            const int IS_FULLTIME = 1;
            const int IS_PARTTIME = 2;
            const int NUM_OF_WORKING_DAYS = 20;
            const int WAGE_PER_HR = 20;
            const int MAX_HRS_IN_MONTH = 100;
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            //Computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            int totalWage = totalEmpHrs * WAGE_PER_HR;
            Console.WriteLine("Total Monthly Wage: " + totalWage);
        }
    }
}
