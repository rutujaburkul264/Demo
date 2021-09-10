using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EmployeePresentAbsent
{
    class UC6_CalcWagesTill100HrsIsReached
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void CalcWagesTill100HrsIsReached()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int TotalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + TotalWorkingDays + "Emp hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }

    }
}
