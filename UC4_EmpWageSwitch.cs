using System;
using System.Collections.Generic;
using System.Text;

namespace UC1_EmployeePresentAbsent
{
    class UC4_EmpWageSwitch
    {
        //const readonly
        public const int IS_PART_TIME = 1;
        //public readonly int Test = 12;
        public const int IS_FULL_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public static void EmpWageUsingSwitch()
        {
            //constants
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_Time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
