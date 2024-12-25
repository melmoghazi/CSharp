using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Polymorphism.Polymorphism
{
    public class PolymorphismOverrding
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("start polymorphism overriding Run-Time practice");
            /*
             * Run-Time Polymorphism (Dynamic):
                Achieved through method overriding.
                Behavior is determined at runtime.
                Example: A parent class reference calling a child class's overridden method.
             */

            //Vehicle v=new Vehicle();//cannot create an instance of abstract type or interface

            Vehicle c = new Car();
            c.Drive();

            c = new Bike();
            c.Drive();

            Console.WriteLine("end polymorphism practice");
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public int Id { get; set; }
        public abstract void Drive();
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("drive a car");
        }
    }
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("drive a bike");
        }
    }

}
