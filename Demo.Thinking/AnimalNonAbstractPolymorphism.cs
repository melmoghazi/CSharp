
namespace Demo.Thinking
{
    abstract class Animal1
    {
        // Abstract method to be implemented in derived classes
        public void MakeSound()
        {
            Console.WriteLine("Animal is making sound...");
        }

        // A concrete method in the abstract class
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }
    class Dog1 : Animal1
    {
        // Implementing the abstract method
        public void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof Woof!");
        }

        // Hiding the Eat method from the base class
        public new void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Animal1 myDog = new Dog1();
            myDog.MakeSound(); // Calls Dog's implementation of MakeSound
            myDog.Eat();       // Calls Animal's Eat method

            Dog1 specificDog = new Dog1();
            specificDog.MakeSound(); // Calls Dog's implementation of MakeSound
            specificDog.Eat();       // Calls Dog's Eat method (new keyword)

            Console.ReadKey();
        }
    }
}
