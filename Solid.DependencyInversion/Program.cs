namespace Solid.DependencyInversion
{
    internal class Program
    {
        /*
         * High-Level Modules/Classes should not depend on low-level Modules/Classes but both 
         * should depend on abstractions.
         * Abstractions should not depend on details but details should depend on abstraction.
         * 
         */
        /*
         * There a difference between Dependency Inversion and Dependency Injection:
            Dependency Inversion is the principal.
            Dependency Injection in the way to apply the the DIP an it can be implemented by:
                1-Contstructor injection
                2-Method injection
                3-Properity injection.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
