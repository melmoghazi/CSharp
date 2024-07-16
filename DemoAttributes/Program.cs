using System.Drawing;
using System.Reflection;

namespace DemoAttributes
{
    /// <summary>
    /// https://www.tutorialspoint.com/csharp/csharp_attributes.htm
    /// https://www.tutorialspoint.com/csharp/csharp_reflection.htm
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.Display();

            //read attribute by reflection
            Type type = typeof(Rectangle);

            //iterating through the attribtues of the Rectangle class
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;

                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            //iterating through the method attribtues
            foreach (MethodInfo m in type.GetMethods())
            {

                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi = (DeBugInfo)a;

                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
