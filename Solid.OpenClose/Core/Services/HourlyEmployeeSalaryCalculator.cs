using Solid.OpenClose.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClose.Core.Services
{
    internal class HourlyEmployeeSalaryCalculator : SalaryCalculator
    {
        public HourlyEmployeeSalaryCalculator(Employee employee) : base(employee)
        {
        }

        public override decimal Calculate()
        {
            var emp = Employee as HourlyEmployee;
            return emp.HourRate * emp.TotalMonthlyHours;
        }
    }
}
