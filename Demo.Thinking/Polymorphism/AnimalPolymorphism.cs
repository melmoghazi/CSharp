using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Polymorphism
{
    abstract class Animal
    {
        // Abstract method to be implemented in derived classes
        public abstract void MakeSound();

        // A concrete method in the abstract class
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }
    class Dog : Animal
    {
        // Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof Woof!");
        }

        // Hiding the Eat method from the base class
        public new void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }
    }
    class Program
    {
        static void Main1()
        {
            Animal myDog = new Dog();
            myDog.MakeSound(); // Calls Dog's implementation of MakeSound
            myDog.Eat();       // Calls Animal's Eat method

            Dog specificDog = new Dog();
            specificDog.MakeSound(); // Calls Dog's implementation of MakeSound
            specificDog.Eat();       // Calls Dog's Eat method (new keyword)

            Console.ReadKey();
        }
    }
}
