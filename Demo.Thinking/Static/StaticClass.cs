using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Static
{
    public static class StaticClass
    {
        public static int x = 1;
        public static string name;
        static StaticClass()
        {
            x = 11;
            name = "Ali";
        }
    }
}
