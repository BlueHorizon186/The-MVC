using System.Collections.Generic;

namespace Hello_App.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee("John", "Frederickson", 19500);
            Employee emp2 = new Employee("Jack", "Fort", 14500);
            Employee emp3 = new Employee("Sasha", "May", 25000);

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            return employees;
        }
    }
}