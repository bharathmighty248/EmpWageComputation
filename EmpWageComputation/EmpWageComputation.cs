﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageComputation
    {
        //string companyName;
        //int numOfWorkingDays;
        //int wagePerHr;
        //int maxHoursPerMonth;
        //public EmpWageComputation(string companyName, int numOfWorkingDays, int wagePerHr, int maxHoursPerMonth)
        //{
        //    this.companyName = companyName;
        //    this.numOfWorkingDays = numOfWorkingDays;
        //    this.wagePerHr = wagePerHr;
        //    this.maxHoursPerMonth = maxHoursPerMonth;
        //}
        public void EmpWage(string companyName, int numOfWorkingDays, int wagePerHr, int maxHoursPerMonth)
        {
            //Constants
            const int IS_FULLTIME = 1;
            const int IS_PARTTIME = 2;

            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays <= numOfWorkingDays)
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
            int totalWage = totalEmpHrs * wagePerHr;
            Console.WriteLine("Employee Total Monthly Wage of " + companyName + " Company is " + totalWage);
        }
    }
}
