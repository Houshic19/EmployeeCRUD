using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD
{
    class Program
    {
        static void Main()
        {
            var service = new EmployeeService();
            while (true)
            {
                Console.WriteLine("\n==== Employee Management System ====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Display Statistics");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": service.AddEmployee(); break;
                    case "2": service.ViewAllEmployees(); break;
                    case "3": service.UpdateEmployee(); break;
                    case "4": service.DeleteEmployee(); break;
                    case "5": service.ShowStatistics(); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid Choice. Please try again."); break;
                }
            }
        }
    }
}
