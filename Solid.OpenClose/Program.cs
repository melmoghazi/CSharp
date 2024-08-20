using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace Solid.OpenClose
{
    internal class Program
    {
        /*
        * Open Close Principal (OCP)
        Open for extension Close for modification.
        The software entities(modules, classes, functions etc.) should be open for extension but closed for modification.
        We extended SalaryCalculator class by the other classes SalariedEmployeeSalaryCalculator, 
        HourlyEmployeeSalaryCalculator, InternEmployeeSalaryCalculator
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
