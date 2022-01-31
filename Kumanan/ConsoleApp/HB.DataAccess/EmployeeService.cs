using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HB.DataAccess
{
    public class EmployeeService
    {
        private List<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee emp)
        {
            // add it to the database.
            employees.Add(emp);
        }

        public List<Employee> GetEmployees(Employee emp)
        {
            // add it to the database.
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            return employees.SingleOrDefault(t => t.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            // add it to the database.
            var employeeToUpdate = employees.SingleOrDefault(t => t.Id == employee.Id);
            if (employee !=null)
            {

            }

        }

        public void DeleteEmployee(int id)
        {
            var employeeToDelete = employees.SingleOrDefault(t => t.Id == id);
            employees.Remove(employeeToDelete);
        }

    }
}
