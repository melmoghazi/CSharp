using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.ValueTypeAndReferenceType
{
    public class ValueAndReference
    {
        public static void Main()
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.ReadKey();

        }
    }
}
