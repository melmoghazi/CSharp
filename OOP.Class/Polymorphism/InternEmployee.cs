namespace OOP.Class.Polymorphism
{
    internal class InternEmployee : Employee
    {
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return 3000;
        }
    }
}
