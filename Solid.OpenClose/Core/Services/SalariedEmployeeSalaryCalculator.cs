using Solid.OpenClose.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClose.Core.Services
{
    internal class SalariedEmployeeSalaryCalculator : SalaryCalculator
    {
        public SalariedEmployeeSalaryCalculator(Employee employee) : base(employee)
        {
        }

        public override decimal Calculate()
        {
            var emp = Employee as SalariedEmployee;
            return emp.BasicSalary + emp.Transportation + emp.Housing;
        }
    }
}
