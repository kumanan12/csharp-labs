using System;

namespace HB.DataAccess
{
    public class Employee
    {
        public string FirstName { get; set; }
        protected string LastName { get; set; } = "NA";

        public int Id { get; set; }
        private decimal salary = 0;

        public Employee(decimal empSalary)
        {
            salary = empSalary;
        }

        public Employee()
        {

        }

        public decimal GetSalary()
        {
            return salary;
        }


    }

    public class TeachingEmployee : Employee
    {
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
