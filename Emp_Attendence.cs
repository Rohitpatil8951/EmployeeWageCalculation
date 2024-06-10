using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Emp_Attendence
    {
        static void Main(string[] args)
        {
            int Emp_Attendence;
            Random random = new Random();
            Emp_Attendence = random.Next(2);
            Console.WriteLine(Emp_Attendence);
            if (Emp_Attendence == 0)
            {
                Console.WriteLine("Employe abesent");

            }
            else
            {
                Console.WriteLine("Employe present");
            }
        }

    }
}
