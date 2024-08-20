using OOP.Class.Polymorphism;

namespace OOP.Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer");
            ////Constructor Overloading
            //Customer customer = new Customer(1,"Mohammed");
            //customer.Orders.Add(new Order { Id = 1 });
            //Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");

            ////Indexer
            SampleHttpCookie cookie = new SampleHttpCookie();
            cookie["name"] = "Mohammed";
            Console.WriteLine($"cookie name: {cookie["name"]}");
            Console.WriteLine("-Inheritance--------------------------------------------");
            Console.WriteLine("OOP");
            Console.WriteLine();
            Console.WriteLine("Employee");
            Employee employee = new();
            employee.SetName("Mohammed", "Ali");
            employee.SetBirthDate(new DateOnly(1990, 10, 10));
            PrintPersonDetails(employee);
            Console.WriteLine();
            Console.WriteLine("Applicant");

            Applicant applicant = new();
            applicant.SetName("Shady", "Hady");
            applicant.SetBirthDate(new DateOnly(1995, 05, 05));
            PrintPersonDetails(applicant);
            Console.WriteLine();
            Console.WriteLine("-Polymorphism--------------------------------------------");
            Console.WriteLine("---dynamic Polymorphism----");
            var core = new CoreEmployee();
            core.BasicSalary = 2000;
            core.Transportation = 1000;
            core.Housing = 500;
            Console.WriteLine($"CoreEmployee Salary = {core.GetSalary()}");
            Console.WriteLine();

            var freelancer = new FreelanceEmployee();
            freelancer.HourRate = 100;
            freelancer.TotalMonthlyHours = 60;
            Console.WriteLine($"FreelanceEmployee Salary = {freelancer.GetSalary()}");
            Console.WriteLine();

            var intern=new InternEmployee();
            Console.WriteLine($"InternEmployee Salary = {intern.GetSalary()}");
            Console.WriteLine();

            Console.WriteLine("---static Polymorphism overloading----");
            Console.WriteLine($"CoreEmployee Salary with tax persentage 10% = {core.GetSalary(10)}");
            Console.WriteLine();
            Console.WriteLine($"CoreEmployee Salary with tax persentage 10% + bonus = {core.GetSalary(10,1000)}");
            Console.WriteLine();
            Console.ReadLine();
        }
        static void PrintPersonDetails(Person person)
        {
            Console.WriteLine($"FirstName = {person.FirstName}");
            Console.WriteLine($"LastName = {person.LastName}");
            Console.WriteLine($"BirthDate = {person.BirthDate}");
        }
    }
}
