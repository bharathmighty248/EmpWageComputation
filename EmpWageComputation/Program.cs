using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageComputation employeeWage = new EmpWageComputation();
            employeeWage.EmpWage("Dmart", 20, 20, 100);
            employeeWage.EmpWage("Reliance", 25, 30, 150);
        }
    }
}
