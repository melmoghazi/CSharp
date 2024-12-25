using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Polymorphism
{
    public class DemoPolymorphism
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("start polymorphism practice");
            //Vehicle3 vehicle = new Vehicle3();

            //car
            Vehicle3 car = new Car3();
            car.Drive(11);
            Console.WriteLine($"Id = {car.Id}: Name = {car.name}");
            car.TurnRight();
            car.TurnLeft();


            Console.WriteLine();


            //bike
            var bike = new Bike3();
            bike.Drive();
            Console.WriteLine($"Id = {bike.Id}: Name = {bike.name}");
            bike.TurnRight();

            Console.WriteLine("end polymorphism practice");
            Console.ReadLine();
        }
    }

    public abstract class Vehicle3
    {
        public int Id = 1;
        public string name = "Vehicle3";
        public void Drive()
        {
            Console.WriteLine("drive method in Vehicle3 class");
        }
        public abstract void Drive(int x);

        public virtual void TurnRight()
        {
            Console.WriteLine("TurnRight method in Vehicle3 class");
        }
        public void TurnLeft()
        {
            Console.WriteLine("TurnLift method in Vehicle3 class");
        }
    }

    public class Car3 : Vehicle3
    {
        public int Id = 2;
        public string name = "Car3";
        public void Drive()
        {
            Console.WriteLine("drive method in Car3 class");
        }
        public override void Drive(int x)
        {
            Console.WriteLine($"drive method(int {x}) in Car3 class");
        }

        public new void TurnRight()//hides inherited member, User the new keyword if hiding was intended
        {
            Console.WriteLine("TurnRight method in Car3 class");
        }
        public void TurnLeft()
        {
            Console.WriteLine("TurnLift method in Car3 class");
        }
    }
    public class Bike3 : Vehicle3
    {
        public int Id = 3;
        public string name = "Bike3";
        public override void Drive(int x)
        {
            Console.WriteLine($"drive method(int {x}) in Bike3 class");
        }

    }
}
