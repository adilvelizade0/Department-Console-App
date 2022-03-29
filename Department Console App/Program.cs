using System;
using Department_Console_App.Models;

namespace Department_Console_App
{
    class Program
    {
        static void Main()
        {
            Department department = new Department("CodeAcademy",2);
            Employee employee1 = new Employee("Adil",20,200);
            Employee employee2 = new Employee("Elcan",-1,300);
            
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            
            department.RemoveEmployee(1);
            
            foreach (var employee in department.Employess)
            {
                Console.WriteLine(employee.ToString());
            }
            
        }
    }
}