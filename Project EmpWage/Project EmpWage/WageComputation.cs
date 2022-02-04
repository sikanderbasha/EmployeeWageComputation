using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EmpWage
{
    public class WageComputation
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        public int Count_Work_Day = 20;
        public int Emp_Per_Rate_Hour = 20;
        public int Max_Hrs_Day_Month = 100;
        public int Working_Days = 0;
        public int Full_Day=8;
        public int Half_Day=4;
        public int empHrs = 0;
        public int EmployeeWage = 0;
       
        public void Attendance()
        {
            for (int i = 0; i < Count_Work_Day && this.empHrs <= Max_Hrs_Day_Month; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Emp_Full_Time:
                        empHrs += Full_Day;
                        break;
                    case Emp_Part_Time:
                        empHrs += Half_Day;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                EmployeeWage += empHrs;
            }
            this.EmployeeWage = empHrs * Emp_Per_Rate_Hour;
            Console.WriteLine("Total Employee wage : " + this.EmployeeWage);
        }
    }

}