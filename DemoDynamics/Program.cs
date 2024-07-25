using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace DemoDynamics
{
    internal class Program
    {
        /// <summary>
        /// programming languages:
        ///     - Statically-typed languages: C#, Java.
        ///         - type resolution is at compile time.
        ///         - benefit: early feedback (at compile time)
        ///     - Dynamically-typed languages: Javascript, python, ruby.
        ///         - type resolution is at run time.
        ///         - benefit: easer and faster to code. 
        ///  ----------------------------------------------------------------------------------------       
        /// 
        /// Reflection is a way to inspect a metadata about a type and access properities and methods.
        /// -----------------------------------------------------------------------------------------
        /// It is a bad practice to use dynamic.
        /// because dynamic keyword refers to type late binding, which means the system will check type only during execution instead of during compilation.
        ///     It will then mean that user, instead of programmer, is left to discover the potential error.
        /// To solve the previous point you could rely on unit tests, non regression human tests and so on but it can lead to increased maintenance costs.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine();

            var name = "Mohammed";
            Console.WriteLine(name);
            //name = 10;//cannot implicitly convert type int to string.

            dynamic myName = "Mohammed";
            Console.WriteLine(myName);
            myName = 10;
            Console.WriteLine(myName);


            Console.WriteLine();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
