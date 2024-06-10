namespace EmployeeWage
{
    public class Wage
    {

        static void Main(string[] args)
        {

            Console.WriteLine(computeEmpWage(20, 20, 100, "JIO"));
            Console.WriteLine(computeEmpWage(20, 20, 100, "Simens"));
        }
        public static double computeEmpWage(int wagePerHour, int maxWorkingDays, int maxTotalHours, string companyName)
        {

            Console.WriteLine($"Welcome to {companyName} Employee Wage Computation Program ");
            Random random = new Random();
            int hours, totalHours = 0;
            double totalWage = 0;



            for (int i = 1; i <= maxWorkingDays; i++)
            {

                int empType = random.Next(1, 3);
                Console.WriteLine(empType);
                switch (empType)
                {
                    case 1:
                        hours = 4;
                        break;
                    case 2:
                        hours = 8;
                        break;
                    default:
                        hours = 0;
                        break;

                }
                if (totalHours + hours > maxTotalHours)
                {
                    break;
                }
                else
                {
                    totalHours += hours;

                }
            }

            totalWage = totalHours * wagePerHour;
            return totalWage;

        }


    }
}
