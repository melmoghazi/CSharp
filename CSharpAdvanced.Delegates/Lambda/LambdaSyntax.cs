using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates.Lambda
{
    internal class LambdaSyntax
    {
        delegate int Operation(int x, int y);

        public static void Main()
        {
            //1.Basic Lambda Syntax
            //(parameters) => expression
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5)); // Output: 25
            //-------------------------------------------------
            //2. Lambda with Multiple Parameters
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(3, 4)); // Output: 7
            //-------------------------------------------------
            //3.Lambda as an Inline Expression
            //You can pass a lambda directly to a method like List<T>.Where() or List<T>.Select().
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(", ", evenNumbers)); // Output: 2, 4
            //-------------------------------------------------
            //4. Lambda in LINQ
            //Lambda expressions are commonly used with LINQ.
            var numbersLinq = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbersLinq.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(", ", squaredNumbers)); // Output: 1, 4, 9, 16, 25
            //-------------------------------------------------
            //5. Lambda with No Parameters
            Func<string> greet = () => "Hello, World!";
            Console.WriteLine(greet()); // Output: Hello, World!
            //-------------------------------------------------
            //7.Lambda with Complex Logic
            //You can use curly braces {} for multiple statements.
            Func<int, int> factorial = n =>
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                    result *= i;
                return result;
            };

            Console.WriteLine(factorial(5)); // Output: 120
            //-------------------------------------------------
            //8. Lambda with Custom Delegates
            Operation multiply = (a, b) => a * b;
            Console.WriteLine(multiply(3, 4)); // Output: 12
            //use delegate keyword
            Operation adding = delegate (int x, int y) { return x + y; };
            Console.WriteLine(adding(2, 2));
            //Delegates are the type that anonymous functions (including lambdas) are assigned to.
            //-------------------------------------------------

            //-------------------------------------------------


        }
    }
}
