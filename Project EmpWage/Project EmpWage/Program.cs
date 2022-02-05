using System;
using Project_EmpWage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Program"); //main
            WageComputation EmployeeWage = new WageComputation();
            EmployeeWage.Attendance("Amazon", 40, 1, 12);
            EmployeeWage.Attendance("Netflix", 45, 2, 15);
            Console.ReadKey();
        }

    }
}
