using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EmpWage
{
    public class WageComputation
    {
        
        const int Full_Day = 8;
        const int Half_Day = 4;
        const int Emp_Part_Time =2, Emp_Full_Time = 1;

        Random random = new Random();

        int empHrs = 0, totalHrs = 0, totalWorkingDays = 0;

        public int Attendance(string company, int empWagePerHr, int workdays, int workhrspermonth)
        {
            while (totalHrs <= workhrspermonth && totalWorkingDays < workdays)
            {
                totalWorkingDays++;


                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Emp_Full_Time:                       
                        this.empHrs += Full_Day;
                        break;

                    case Emp_Part_Time:                      
                        this.empHrs += Half_Day;
                        break;

                    default:                      
                        this.empHrs += 0;
                        break;
                }
                totalHrs += empHrs;
                System.Console.WriteLine("Company name :" + company);
                System.Console.WriteLine("Employee working days: " + totalWorkingDays);
                System.Console.WriteLine("Working hours :" + totalHrs);
            }

            int totalWage = totalHrs * empWagePerHr;
            System.Console.WriteLine("Employee monthly wage is : " + totalWage);
            return totalWage;
        }
    }
       
}
