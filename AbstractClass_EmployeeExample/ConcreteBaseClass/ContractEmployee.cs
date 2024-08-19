using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.ConcreteBaseClass
{
    public class ContractEmployee:BaseEmployee
    {
        public int TotalHoursWorked { get; set; }
        public int HourlyPay { get; set; }

        public override int GetMonthlySalary()
        {
            return TotalHoursWorked * HourlyPay;
        }
    }
}
