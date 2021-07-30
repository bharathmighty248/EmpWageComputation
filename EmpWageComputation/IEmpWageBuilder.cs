using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    interface IEmpWageBuilder
    {
        public void AddCompanyEmpWage(string companyName, int numOfWorkingDays, int wagePerHr, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int GetTotalWage(string company);
    }
}
