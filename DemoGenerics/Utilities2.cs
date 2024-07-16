using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    public class Utilities2<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj=new T();
        }
    }
}
