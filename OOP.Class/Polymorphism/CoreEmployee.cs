using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class.Polymorphism
{
    internal class CoreEmployee : Employee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var salary = BasicSalary + Transportation + Housing;
            return salary;
        }

        public decimal GetSalary(int taxPersentage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //decimal netSalary = GetSalary() - BasicSalary * taxPersentage / 100m;
            //return netSalary;
            return GetSalary() - BasicSalary * taxPersentage / 100;
        }
        public decimal GetSalary(int taxPersentage,int bonus)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return (GetSalary() - BasicSalary * taxPersentage / 100) + bonus;
        }
    }
}
