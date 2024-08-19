using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.ConcreteClassVirtualMethod
{
    public abstract class Employee
    {
        public virtual void VirtualMehtod()
        {
            Console.WriteLine("Concrete class virtual method");
        }
    }

    public class FullTimeEmployee : Employee
    {

    }

    public class ContractEmployee : Employee
    {
        //we can use new or override both are working
        public new void VirtualMehtod()
        {
            Console.WriteLine("ContractEmployee VirtualMehtod, we changed the implementation");
        }
    }
}
