namespace Solid.InterfaceSegregation
{
    internal class Program
    {
        /*
         * Clients should not be forced to depend upon interfaces
           that they do not use.

        In the business you can update and delete the employee but you cannot 
        update or delete the applicant. so you cannot make a repository of the 
        Applicant class like the employee because you will violate the ISP.
        The solution is to segregate the IRepository interface.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
