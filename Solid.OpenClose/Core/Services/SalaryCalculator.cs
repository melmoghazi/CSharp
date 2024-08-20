using Solid.OpenClose.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClose.Core.Services
{
    //This is not apply the Open Close principal so we should change this class to 
    //abstract class and create a class foreach employee type.

    //internal class SalaryCalculator
    //{
    //    public SalaryCalculator(Employee employee)
    //    {
    //        this.Employee = employee;
    //    }
    //    public Employee Employee { get; }

    //    /// <summary>
    //    /// This is not apply the Open Close principal
    //    /// </summary>
    //    /// <returns></returns>
    //    public decimal Calculate()
    //    {
    //        if (Employee is SalariedEmployee salariedEmployee)
    //            return salariedEmployee.BasicSalary + salariedEmployee.Transportation + salariedEmployee.Housing;
    //        else if (Employee is HourlyEmployee hourlyEmployee)
    //            return hourlyEmployee.HourRate * hourlyEmployee.TotalMonthlyHours;
    //        else if (Employee is InternEmployee internEmployee)
    //            return 2000;
    //        else return 0;
    //    }
    //}

    /// <summary>
    /// Open for extension Close for modification.
    /// We extended this class by other classes SalariedEmployeeSalaryCalculator, HourlyEmployeeSalaryCalculator, InternEmployeeSalaryCalculator
    /// </summary>
    internal abstract class SalaryCalculator
    {
        public SalaryCalculator(Employee employee)
        {
            this.Employee = employee;
        }
        public Employee Employee { get; }
        public abstract decimal Calculate();
    }
}
