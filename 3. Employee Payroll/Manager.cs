using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Employee_Payroll
{
    internal class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(string name, double salary, string department)
            : base(name, salary)
        {
            Department = department;
        }
        public string GetDetails()
        {
            return $"{GetDetails()}\nDepartment: {Department}";
        }
    }
    {

    }
}
