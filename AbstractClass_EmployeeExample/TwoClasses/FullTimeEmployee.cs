using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.TwoClasses
{
    public class FullTimeEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AnnualSalary { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }

    }
}
