using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageBuilder: IEmpWageBuilder
    {
        Dictionary<string, int> companyToEmpWageMap = new Dictionary<string, int>();
        List<CompanyEmpWage> companyEmpWageList = new List<CompanyEmpWage>();
        List<int> storeDailyWage = new List<int>();
        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Add(companyEmpWage);
        }
        
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWageVariable in companyEmpWageList)
            {
                this.companyToEmpWageMap.Add(companyEmpWageVariable.companyName, companyEmpWageVariable.EmpWage(storeDailyWage));
            }
        }
        
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company];
        }
    }
}
