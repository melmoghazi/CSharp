using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class.OverrideAndNew
{
    public class D : B
    {
        public new void Print()
        {
            Console.WriteLine("Print in D class");
        }
    }
}
