using System;

namespace EmpWageComputation
{
    class EmpWageComputation
    {
        static void Main(string[] args)
        {
            //Constants
            const int IS_PRESENT = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
