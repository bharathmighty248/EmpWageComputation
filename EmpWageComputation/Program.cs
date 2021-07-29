using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder companies = new EmpWageBuilder();
            companies.dmartempWageBuilder();
            companies.relianceempWageBuilder();
        }
    }
}
