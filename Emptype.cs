namespace EmployeeWage
{
    public class Emptype
    {
        static void Main(string[] args)
        {

            int partTimeEmp = 4;
            int fullTimeEmp = 8;
            if (partTimeEmp == 4)
            {
                Console.WriteLine("Part time employe");
            }
            else if (partTimeEmp == 8)
            {
                Console.WriteLine("Full time employe");

            }
            else
            {
                Console.WriteLine("Enter a valid hours");
            }

        }
    }
}