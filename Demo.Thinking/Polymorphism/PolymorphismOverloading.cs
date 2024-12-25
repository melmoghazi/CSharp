using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Polymorphism.Polymorphism
{
    public class PolymorphismOverloading
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("start polymorphism overloading practice");
            /*
             * Compile-Time Polymorphism (Static):
                Achieved through method overloading or operator overloading.
                Behavior is determined at compile time.
                Example: Methods with the same name but different parameters.
             */
            Vehicle1 v = new Vehicle1();
            v.Drive(11, 11);

            Console.WriteLine("end polymorphism overloading practice");
            Console.ReadLine();
        }
    }

    public class Vehicle1
    {
        public int Id { get; set; }
        public void Drive()
        {
            Console.WriteLine("drive method in Vehicle1 class");
        }
        public void Drive(int x)
        {
            Console.WriteLine($"drive method(int {x}) in Vehicle1 class");
        }
        public int Drive(int x, int y)
        {
            Console.WriteLine($"drive method(int {x},int {y}) in Vehicle1 class");
            return x + y;
        }
    }
}
