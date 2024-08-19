using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.AbstractClassVirtualMethod
{
    public abstract class Employee
    {
        public virtual void VirtualMehtod()
        {
            Console.WriteLine("Abstract class virtual method");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    public class ContractEmployee : Employee
    {
        public override void VirtualMehtod()
        {
            Console.WriteLine("ContractEmployee VirtualMehtod, we changed the implementation");
        }
    }
}
