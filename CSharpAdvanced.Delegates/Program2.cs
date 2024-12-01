using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates
{
    internal class Program2
    {
        delegate int CalculateDelegate(int num1, int num2);
        static void Main2(string[] args)
        {
            int n1 = 10;
            int n2 = 2;

            //call existing method that match your delegate.
            CalculateWithDelegate(n1, n2, Add);
            //use anonymous delegate
            CalculateWithDelegate(n1, n2, delegate (int num1, int num2) { return num1 + num2; });
            //use arrow function or fat arrow funtion or lambda expresion
            CalculateWithDelegate(n1, n2, (n1, n2) => { Console.Write("Anonymous Add "); return n1 + n2; });

            //multicast delegate
            Console.WriteLine("multicast delegate");
            CalculateDelegate del = Add;
            del += Subtraction;
            del += Multiply;
            del += Divide;
            del -= Multiply;
            del -= Divide;

            var delResult = del(n1, n2);
            Console.WriteLine(delResult);


            Console.ReadKey();
        }
        static void CalculateWithDelegate(int num1, int num2, CalculateDelegate del)
        {
            var result = del(num1, num2);
            Console.WriteLine($"result = {result}");
        }
        static int Add(int num1, int num2)
        {
            Console.Write("Add ");
            return num1 + num2;
        }
        static int Subtraction(int num1, int num2)
        {
            Console.Write("Subtraction ");
            return num1 - num2;
        }
        static int Multiply(int numb1, int numb2)
        {
            Console.WriteLine("Multiply");
            return numb1 * numb2;
        }
        static int Divide(int numb1, int numb2)
        {
            Console.WriteLine("Divide");
            return numb1 / numb2;
        }
    }
}
