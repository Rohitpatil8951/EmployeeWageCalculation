using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{   
    public class CalculateWagePerDay
    {
        static void Main(string[] args)
        {
            int empHoursPerDay = 8;
            int empWagePerhour = 20;
            double TotalWagePerday = empHoursPerDay * empWagePerhour;
            Console.WriteLine(TotalWagePerday);
        }
    }
}
