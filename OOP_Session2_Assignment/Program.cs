using System.Reflection;

namespace OOP_Session2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Employee {i+1} Data");

                int Id;
                while(true)
                {
                    Console.WriteLine("Enter Id:");
                    if (int.TryParse(Console.ReadLine(),out Id) && Id > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Id");
                    }
                }

                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();

                Privileges SecurityLevel;
                int Input;
                while(true)
                {
                    Console.WriteLine("Enter Security Level");
                    Console.WriteLine("1: Guest");
                    Console.WriteLine("2: Developer");
                    Console.WriteLine("4: Secretary");
                    Console.WriteLine("8: DBA");
                    Console.WriteLine("15: Security Officer");
                    if (int.TryParse(Console.ReadLine(), out Input) && Enum.IsDefined(typeof(Privileges), Input))
                    {
                        SecurityLevel = (Privileges)Input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, Enter a number from 0 to 4!");
                    }
                }

                double Salary;
                while(true)
                {
                    Console.WriteLine("Enter Salary");
                    if (double.TryParse(Console.ReadLine(), out Salary) && Salary > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Salary!");
                    }
                }
                int Day, Month, Year;
                while (true)
                {
                    Console.Write("Enter Hire Date (Day): ");
                    if (int.TryParse(Console.ReadLine(), out Day) && Day > 0 && Day <= 31)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid day (1-31).");
                }
                while (true)
                {
                    Console.Write("Enter Hire Date (Month): ");
                    if (int.TryParse(Console.ReadLine(), out Month) && Month > 0 && Month <= 12)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid month (1-12).");
                }
                while (true)
                {
                    Console.Write("Enter Hire Date (Year): ");
                    if (int.TryParse(Console.ReadLine(), out Year) && Year <= DateTime.Now.Year)
                        break;
                    else
                        Console.WriteLine("Invalid input. Please enter a valid year.");
                }
                HiringDate HireDate = new HiringDate(Day, Month, Year);

                Gender Sex;
                int genderInput;
                while (true)
                {
                    Console.WriteLine("Enter Gender (1: Male, 2: Female): ");
                    if (int.TryParse(Console.ReadLine(), out genderInput) && genderInput >0 && genderInput <= 2)
                    {
                        Sex = (Gender)genderInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for Gender.");
                    }
                }
                employees[i] = new Employee(Id, Name, SecurityLevel, Salary, HireDate, Sex);
            }
            Console.WriteLine();
            Console.WriteLine("Employees Data:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }
        }
    }
}
