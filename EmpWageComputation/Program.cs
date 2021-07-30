using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 25, 100);
            empWageBuilder.AddCompanyEmpWage("Reliance", 20, 30, 120);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Employee Total Wages for Dmart Company is: " + empWageBuilder.GetTotalWage("DMart"));
            Console.WriteLine("Employee Total Wages for Reliance Company is: " + empWageBuilder.GetTotalWage("Reliance"));
        }
    }
}
