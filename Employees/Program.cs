using System;
using System.Globalization;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int employeesQuantity = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= employeesQuantity; i++)
            {
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == searchId);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\n\nUpdated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}