
namespace CSharpAdvanced.Delegates
{
    /// <summary>
    /// Delegate that return bool value called predicate
    /// </summary>
    internal class Program3
    {
        delegate bool ShouldCalculate(Employee employee);
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i <= 100; i++)
            {
                employees.Add(new Employee()
                {
                    Name = $"{i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deduction = Random.Shared.Next(0, 501),
                    Bonus = Random.Shared.Next(0, 1001)
                });

            }

            CalculateSalaries(employees, emp => emp.BasicSalary < 2000);

            Console.ReadKey();
        }
        private static void CalculateSalaries(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (Employee employee in employees)
            {
                if (predicate(employee) == true)
                {
                    var salary = employee.BasicSalary + employee.Bonus - employee.Deduction;
                    Console.WriteLine($"Salary for employee {employee.Name} with basic salary({employee.BasicSalary})");
                }
            }
        }
    }

    internal class Employee
    {
        public string Name { get; set; }
        public int BasicSalary { get; set; }
        public int Deduction { get; set; }
        public int Bonus { get; set; }

    }
}