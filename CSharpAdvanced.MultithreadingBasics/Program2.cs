using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.MultithreadingBasics
{
    /// <summary>
    /// await return the control to the caller thread and execute the task in a new thread and wait till the task complete.
    /// </summary>
    internal class Program2
    {
        private static object _lock = new object();

        static async Task Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            Console.WriteLine("Main thread id= "+ Environment.CurrentManagedThreadId);
            //Task.Run(()=> ProcessBatch1(cts.Token));
            var task1= ProcessBatch1(cts.Token);
            var task2 = ProcessBatch2(cts.Token);

            //Task.WhenAll(task1, task2);
            //Task.WhenAny(task1, task2);

            Console.ReadKey();

        }
        private static  async Task ProcessBatch1(CancellationToken cancellationToken)
        {
            Console.WriteLine("ProcessBatch1 thread id= "+ Environment.CurrentManagedThreadId);
            await Task.Delay(5000);
            Console.WriteLine("ProcessBatch1(S2) thread id= " + Environment.CurrentManagedThreadId);

            //await Task.Delay(1000);
            for (int i = 0; i <= 100; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        private static async Task ProcessBatch2(CancellationToken cancellationToken)
        {
            Console.WriteLine("ProcessBatch2 thread id= "+ Environment.CurrentManagedThreadId);
            await Task.Delay(2000);
            Console.WriteLine("ProcessBatch2(S2) thread id= " + Environment.CurrentManagedThreadId);

            for (int i = 101; i <= 200; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
