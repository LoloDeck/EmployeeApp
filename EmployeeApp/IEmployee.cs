using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeInterface
{
    public interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public int RatePerHour { get; set; }
        public double TotalHoursWorked { get; set; }
        public void computeSalary(int ratePerHour, double totalHoursWorked);
    }
}
