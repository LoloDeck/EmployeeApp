using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;


namespace EmployeeNamespace
{
    public struct Employee
    {
        public string FirstName;
        public string LastName;
        public string Department;
        public string JobTitle;
        public int RatePerHour;
        public double TotalHoursWorked;
        public Employee(string firstName, string lastName, string department, string jobTitle, int ratePerHour, double totalHoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            RatePerHour = ratePerHour;
            TotalHoursWorked = totalHoursWorked;
        }
    }
    internal class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobTitle;
        private int ratePerHour;
        private double totalHoursWorked;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; } 
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public int RatePerHour 
        {
            get { return ratePerHour; }
            set { ratePerHour = value; }
        }
        public double TotalHoursWorked
        {
            get { return totalHoursWorked; }
            set { totalHoursWorked = value; }
        }
        public void computeSalary(int ratePerHour, double totalHoursWorked)
        {
            double salary = ratePerHour * totalHoursWorked;
            Console.WriteLine($"Salary: {salary:C}");
        }
        
        

        public PartTimeEmployee(string department)
        {
            this.department = department;
        }
        public double getSalary()
        {
            return ratePerHour * totalHoursWorked;
        }
    }
}
