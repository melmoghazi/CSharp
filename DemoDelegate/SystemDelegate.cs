using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    internal class SystemDelegate
    {
        //Encapsulate a method that has no parameters and does not return a value.
        System.Action action;

        //Encapsulate a method that has no parameters and returns a value of the type specified by the out TResult parameter.
        System.Func<int> func;
    }

}
