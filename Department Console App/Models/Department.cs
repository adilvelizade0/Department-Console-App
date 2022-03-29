using System;
using System.Collections.Generic;
using Department_Console_App.CustomException;

namespace Department_Console_App.Models
{
    public class Department
    {
        private static List<Employee> _employees;

        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public List<Employee> Employess => _employees;

        private Department()
        {
            _employees = new List<Employee>();
        }

        public Department(string name, int employeeLimit):this()
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Count == EmployeeLimit)
            {
                throw new CapacityLimitException("Crossed the limit");
            }
            
            _employees.Add(employee);
        }
        
        public void RemoveEmployee(int? id)
        {
            if (id is null)  throw new NullReferenceException();
           
            var employee = _employees.Find(employee => employee.Id == id);
            if (employee is null)  throw new NullReferenceException();
           
            _employees.Remove(employee);
        }
        
    }
}