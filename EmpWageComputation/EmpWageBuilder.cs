using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageBuilder
    {
        Dictionary<string, int> companiesWages = new Dictionary<string, int>();
        public void dmartempWageBuilder()
        {
            EmpWageComputation dmart = new EmpWageComputation("DMart", 20, 25, 100);
            companiesWages.Add("Dmart", dmart.EmpWage());
            Console.WriteLine("Employee Monthly Total Wage for Dmart is " + companiesWages["Dmart"]);
        }
        public void relianceempWageBuilder()
        {
            EmpWageComputation reliance = new EmpWageComputation("Reliance", 20, 30, 90);
            companiesWages.Add("Reliance", reliance.EmpWage());
            Console.WriteLine("Employee Monthly Total Wage for Reliance is " + companiesWages["Reliance"]);
        }
    }
}
