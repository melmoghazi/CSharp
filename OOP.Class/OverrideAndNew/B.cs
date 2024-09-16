using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class.OverrideAndNew
{
    public abstract class B
    {
        public virtual void Print()
        {
            Console.WriteLine("Print in B class");
        }
        public void DoSomething()
        {
            Console.WriteLine("This is non-abstract method");
        }
    }
}
