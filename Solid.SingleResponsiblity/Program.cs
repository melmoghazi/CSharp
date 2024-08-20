namespace Solid.SingleResponsiblity
{
    internal class Program
    {
        /*
         * Single Responsibility Principal (SRP)
        The class is responsible of one thing so it has a lot of properties and methods but they all related to one thing.
        The class should be height cohesive. متماسكة اى تسخدم لغرض واحد فقط
        The class should have only one reason to change.
        Example: Job Vacancy Manager class. The class has CRUD operations of job vacancy but not has items 
        related to applicant and not sending emails.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
