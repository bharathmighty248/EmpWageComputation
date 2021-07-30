using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageBuilder: IEmpWageBuilder
    {
        Dictionary<string, int> companiesWages = new Dictionary<string, int>();
        ArrayList companyWageList = new ArrayList();
        public void AddCompanyEmpWage(string companyName, int numOfWorkingDays, int wagePerHr, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, numOfWorkingDays, wagePerHr, maxHoursPerMonth);
            companyWageList.Add(companyEmpWage);
        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage1 in companyWageList)
            {
                this.companiesWages.Add(companyEmpWage1.companyName,companyEmpWage1.EmpWage());
            }
        }
        public int GetTotalWage(string company)
        {
            return this.companiesWages[company];
        }
    }
}
