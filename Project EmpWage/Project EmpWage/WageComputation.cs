using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EmpWage
{
    class WageComputation
    {
            readonly int IS_PRESENT = 1;
            readonly int Wage_Per_Hours = 20;
            readonly int Full_Day_Hour = 8;

            public void Attendance()
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == IS_PRESENT)
                {
                    Console.WriteLine("Employee is Present");
                    CalculateDailyWage();
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                    Console.WriteLine("Employee Wage is null");
                }

            }
            public void CalculateDailyWage()
            {
                int EmployeeWage = Wage_Per_Hours * Full_Day_Hour;
                Console.WriteLine("Employee Full Wage is : " + EmployeeWage);
            }
        }
    
    }
