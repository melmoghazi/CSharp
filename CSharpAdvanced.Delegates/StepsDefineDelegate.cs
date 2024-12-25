using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpAdvanced.Delegates
{
    internal class StepsDefineDelegate
    {
        delegate int AdditionDelegate(int x, int y);
        int Addition(int x, int y)
        {
            return x + y;
        }
        static void Main4()
        {
            StepsDefineDelegate p = new StepsDefineDelegate();
            AdditionDelegate del1 = new AdditionDelegate(p.Addition);
            Console.WriteLine($"del1 Addition = {del1.Invoke(1, 1)}");
            //-----------------------------------------------------
            AdditionDelegate del2 = new AdditionDelegate(p.Addition);
            Console.WriteLine($"del2 = {del2(1, 1)}");
            //-----------------------------------------------------
            AdditionDelegate del3 = new(p.Addition);
            Console.WriteLine($"del3 = {del3(1, 1)}");
            //-----------------------------------------------------
            AdditionDelegate del4 = p.Addition;
            Console.WriteLine($"del4 = {del4(1, 1)}");
            //-----------------------------------------------------
            AdditionDelegate del5 = (int x, int y) => x + y;
            Console.WriteLine($"del5 = {del5.Invoke(1, 1)}");
            //-----------------------------------------------------
            Console.WriteLine();

            AdditionDelegate delegate_Named_Function = p.Addition;
            AdditionDelegate delegate_Anonymous_Function = delegate (int x, int y) { return x + y; };
            AdditionDelegate delegate_Lambda_Function = (int x, int y) => x + y;
            Console.WriteLine($"delegate_Named_Function = {delegate_Named_Function(2, 2)}");
            Console.WriteLine($"delegate_Anonymous_Function = {delegate_Anonymous_Function(2, 2)}");
            Console.WriteLine($"delegate_Lambda_Function = {delegate_Lambda_Function(2, 2)}");
            //-----------------------------------------------------

            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var number3 = numbers.Where(n => n == 3);

            Console.WriteLine(number3);
            Console.ReadKey();
        }
    }
}
