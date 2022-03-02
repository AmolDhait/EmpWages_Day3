using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class EmpWagesBySwitchCase
    {
        public static void CalculateEmpWage()
        {
            //int IS_FULL_TIME = 1;
            //int IS_PART_TIME = 2;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int Total_Working_hours = 100;
            int totalEmpWage = 0;
        
            while (totalEmpHrs <=Total_Working_hours || totalWorkingDays < totalWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);


                switch (empCheck)
                {
                    case 1 :
                        Console.Write("\nEmployee is Present ");
                        empHrs = 8;
                        break;

                    case 2:

                        Console.Write("\nEmployee is Part Time ");
                        empHrs = 4;
                        break;

                    default:

                        Console.Write("\nEmployee is Absent ");
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.Write("\ntotal day " + totalWorkingDays + " Emp Hrs" +totalEmpHrs);

            }
            totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.Write("\n" + totalEmpWage);
        }
    }
}
