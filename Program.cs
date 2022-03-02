using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wlecome to Employee Wage Program");
            EmpAttCheck.Check_Emp_Presence();
            //EmpWage.CalculateEmpWage();
            EmpWagesBySwitchCase.CalculateEmpWage();
        }
    }
}
