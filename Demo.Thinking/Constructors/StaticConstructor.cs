using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Thinking.Constructors
{
    internal class StaticConstructor
    {
        public static string AppName { get; private set; }
        public string name = "StaticConstructor";
        static StaticConstructor()
        {
            AppName = "DotNetApp";
            //name = "a";//an object reference is required for a no-static field, method, or property
        }
        public StaticConstructor()
        {
            AppName = "appName";
            name = "a";
        }
        public StaticConstructor(string appName)
        {
            AppName = appName;
        }
        public static void StaticMethod()
        {
            //AppName  // can access static memebers
            //name //cannot access non static memebers must use object reference
        }
        public void InstanceMethod()
        {
            //AppName // can access static members
            //name // can access non static memebers
        }
    }

    public class Program
    {
        /*
         *When to Use a Static Constructor in C#
            A static constructor is used to initialize static data or perform actions that need to be executed only once, when the class is first accessed. It is particularly useful when:

            Initializing Static Fields: If a class has static fields or properties that require complex initialization logic.
            Configuring Dependencies: Setting up static dependencies, such as connecting to a database or initializing configuration values.
            Ensuring One-Time Setup: Performing a one-time setup that applies to all instances or usages of the class. 
         */
        static void Main1(string[] args)
        {
            StaticConstructor sc = new StaticConstructor();
            Console.WriteLine(sc.name);

            StaticConstructor sc2 = new StaticConstructor("my app name sc2");
            





            Console.WriteLine(StaticConstructor.AppName);


            // Accessing the Logger class triggers the static constructor
            Logger.Log("Application started.");
            Logger.Log("Another log entry.");
            Console.ReadKey();
        }
    }

    class Logger
    {
        // Static field to hold the log file path
        private static readonly string logFilePath;

        // Static constructor
        static Logger()
        {
            logFilePath = "logfile.txt";
            Console.WriteLine("Static constructor: Log file path initialized.");
        }

        // Static method to log a message
        public static void Log(string message)
        {
            Console.WriteLine($"Logging to {logFilePath}: {message}");
        }
    }

}
