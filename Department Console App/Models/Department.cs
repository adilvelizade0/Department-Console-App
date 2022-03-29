using System;
using System.Collections.Generic;
// using System.Linq;
using Department_Console_App.CustomException;

namespace Department_Console_App.Models
{
    public class Department
    {
        private List<Employee> _employees;
        // private Employee[] _employees;

        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public List<Employee> Employess => _employees;
        // public Employee[] Employess => _employees;
        // private Employee this[int index]
        // {
        //     get => _employees [index];
        //     set => _employees [index] = value;
        // }


        private Department()
        {
            _employees = new List<Employee>();
            // _employees = Array.Empty<Employee>();
        }

        public Department(string name, int employeeLimit):this()
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
        
            try
            {
                if (_employees.Count == EmployeeLimit)
                {
                    throw new CapacityLimitException("\n ❌  Crossed the employee limit\n");
                }
            
                _employees.Add(employee);
                Console.WriteLine("\n ✅  A employee was successfully added\n");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        // public void AddEmployee(Employee employee)
        // {
        //     try
        //     {
        //         if (_employees.Length == EmployeeLimit)
        //         {
        //             throw new CapacityLimitException("\n ❌  Crossed the employee limit\n");
        //         }
        //         
        //         Array.Resize(ref _employees,_employees.Length + 1);
        //         _employees[^1] = employee;
        //         Console.WriteLine("\n ✅  A employee was successfully added\n");
        //     }
        //     catch (Exception e)
        //     {
        //         Console.Clear();
        //         Console.WriteLine(e.Message);
        //     }
        // }
        
        public void RemoveEmployee(int? id)
        {
            try
            {
                if (id is null)  throw new NullReferenceException("\n ❌  Id can't be null\n");
           
                var employee = _employees.Find(employee => employee.Id == id);
                if (employee is null)  throw new NullReferenceException("\n ❌  No results found\n");
           
                _employees.Remove(employee);
                Console.WriteLine("\n ✅  The employee was successfully removed\n");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        
        // public void RemoveEmployee(int? id)
        // {
        //     try
        //     {
        //         if (id is null)  throw new NullReferenceException("\n ❌  Id can't be null\n");
        //    
        //         var employee = Array.Find(_employees,employee => employee.Id == id);
        //         if (employee is null)  throw new NullReferenceException("\n ❌  No results found\n");
        //    
        //         
        //         // _employees.Remove(employee);
        //         _employees = _employees.Length == 1 ? Array.Empty<Employee>() : _employees.Where(employee => employee.Id != id).ToArray();
        //         Console.WriteLine("\n ✅  The employee was successfully removed\n");
        //     }
        //     catch (Exception e)
        //     {
        //         Console.Clear();
        //         Console.WriteLine(e.Message);
        //     }
        // }

        public void PrintAllEmployees()
        {
            if (_employees.Count == 0)
            {
                Console.WriteLine("\n ❌  There is nothing yet\n");
            }
            else
            {
                foreach (var employee in _employees)
                {
                    Console.WriteLine( $"\n Id: {employee.Id.ToString()}\n Name: {employee.Name}\n Age: {employee.Age.ToString()}\n Salary: {employee.Salary.ToString()}\n");
                    Console.WriteLine("<-------------------------------------->");
                }
            }
        }
        
        // public void PrintAllEmployees()
        // {
        //     if (_employees.Length == 0)
        //     {
        //         Console.WriteLine("\n ❌  There is nothing yet\n");
        //     }
        //     else
        //     {
        //         foreach (var employee in _employees)
        //         {
        //             Console.WriteLine( $"\n Id: {employee.Id.ToString()}\n Name: {employee.Name}\n Age: {employee.Age.ToString()}\n Salary: {employee.Salary.ToString()}\n");
        //             Console.WriteLine("<-------------------------------------->");
        //         }
        //     }
        // }
    }
}