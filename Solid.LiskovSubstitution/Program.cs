using Solid.LiskovSubstitution.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Solid.LiskovSubstitution
{
    internal class Program
    {
        /*
         * Liskov Substitution
         * Objects in a program should be replaceable with instances of their
         * subtypes without altering the correctness of that program.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Employee employee = new SalariedEmployee();
            employee.SetName("Rehab", "Fahmy");
            DismissEmployee(employee);

            employee = new HourlyEmployee();
            employee.SetName("Hussam", "Rady");
            DismissEmployee(employee);

            employee = new InternEmployee();
            employee.SetName("Ahmed", "Rabie");
            DismissEmployee(employee);

            /*
             * In the business the CEO can not be dismissed 
            This violate the Liskov Substitution Principal
            The solution is to create an new class DismissedEmployee
            The HourlyEmployee, InternEmployee and SalariedEmployee classes inherit from DismissedEmployee 
            but the CEO class inherit directly from Employee Class.
            */
            employee = new CEO();
            employee.SetName("Ahmed", "Hindawi");
            DismissEmployee(employee);
            Console.WriteLine();
            Console.WriteLine(@"In the business the CEO can not be dismissed 
            This violate the Liskov Substitution Principal
            The solution is to create an new class DismissedEmployee
            The HourlyEmployee, InternEmployee and SalariedEmployee classes inherit from DismissedEmployee 
            but the CEO class inherit directly from Employee Class.");
            Console.WriteLine("*****Apply LSP*****");

            Solid.LiskovSubstitution.Core.ApplyLSP.DismissedEmployee employeeLSP =
                            new Solid.LiskovSubstitution.Core.ApplyLSP.SalariedEmployee();
            employee.SetName("Rehab", "Fahmy");
            DismissEmployee(employee);

            employeeLSP = new Solid.LiskovSubstitution.Core.ApplyLSP.HourlyEmployee();
            employeeLSP.SetName("Hussam", "Rady");
            DismissEmployee(employee);

            employeeLSP = new Solid.LiskovSubstitution.Core.ApplyLSP.InternEmployee();
            employeeLSP.SetName("Ahmed", "Rabie");
            DismissEmployee(employee);

            //employeeLSP = new Solid.LiskovSubstitution.Core.ApplyLSP.CEO();
            Console.WriteLine("The CEO cannot be dismissed.");

            Console.WriteLine("End");
            Console.ReadKey();
        }

        static void DismissEmployee(Employee employee)
        {
            employee.Dismiss();
            Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} has been dismissed.");
        }
    }
}
