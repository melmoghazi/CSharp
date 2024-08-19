using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.AbstractClassConstructor
{
    public abstract class Employee
    {
        public Employee()
        {
            Print();
        }

        public abstract void Print();
    }
    public class FullTimeEmployee : Employee
    {
        public override void Print()
        {
            Console.WriteLine("FullTimeEmployee Print method");
        }
    }
    public class ContractEmployee : Employee
    {
        public override void Print()
        {
            Console.WriteLine("ContractEmployee Print method");
        }
    }
}
