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

            Console.ReadLine();
        }
    }
}
