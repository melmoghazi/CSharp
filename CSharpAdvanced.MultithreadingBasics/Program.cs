namespace CSharpAdvanced.MultithreadingBasics
{
    internal class Program
    {
        private static object _lock = new object();
        static void Main1(string[] args)
        {// one thread
         //ProcessBatch1();
         //ProcessBatch2();

            //2 threads
            //var th1 = new Thread(new ThreadStart(ProcessBatch1));
            //th1.Priority = ThreadPriority.Highest;
            //var th2 = new Thread(ProcessBatch2);
            //th2.Priority = ThreadPriority.Lowest;
            //th1.IsBackground = true;
            //th2.IsBackground = true;

            //th1.Start();
            //th2.Start();

            //ThreadPool.QueueUserWorkItem(ProcessBatch1);
            //ThreadPool.QueueUserWorkItem(ProcessBatch2);
            //ThreadPool make the IsBackground = true by default

            var cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(ProcessBatch1, cts.Token);
            ThreadPool.QueueUserWorkItem(ProcessBatch2, cts.Token);
            Thread.Sleep(1300);
            cts.Cancel();
            Console.ReadKey();
        }

        private static void ProcessBatch1(object? state)
        {
            //cancle
            var cancel = (CancellationToken)state;
            Thread.Sleep(1000);
            for (int i = 0; i <= 1000; i++)
            {
                if (cancel.IsCancellationRequested)
                    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        private static void ProcessBatch2(object? state)
        {
            //cancle
            var cancel = (CancellationToken)state;

            Thread.Sleep(1000);
            for (int i = 1001; i <= 2000; i++)
            {
                if (cancel.IsCancellationRequested)
                    return;
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //without lock
        //private static void ProcessBatch1()
        //{
        //    for (int i = 0; i <= 1000; i++)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine(i);
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}
        //private static void ProcessBatch2()
        //{
        //    for (int i = 1001; i <= 2000; i++)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine(i);
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //}
    }
}
