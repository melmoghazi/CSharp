using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.AbstractBaseClass
{
    public class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee()
        {
            
        }
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
