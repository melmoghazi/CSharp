namespace OOP.Class.Polymorphism
{
    internal class FreelanceEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int TotalMonthlyHours { get; set; }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return HourRate * TotalMonthlyHours;
        }
    }
}
