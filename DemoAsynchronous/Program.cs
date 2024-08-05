namespace DemoAsynchronous
{
    internal class Program
    {
        /// <summary>
        /// Synchronous program execution:
        ///     Program is executed line by line, one at a time.
        ///     When a function is called, program exection has to wait until the function returns.
        /// Asynchronous program execution:
        ///     When a function is called, program exection continues to the next line, without waiting for the function to complete.
        ///     Asynchronous programming improves responsiveness.
        ///     Real world examples:
        ///         - Windows Media Player
        ///         - Web Browser
        ///     How to use Asynchronous?
        ///     Traditional approaches:
        ///         - Multi-threading
        ///         - Callbacks.
        ///     New approach since NET 4.5
        ///         - Async / Await
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Start");



            Console.WriteLine("End");
            Console.ReadLine();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*
         * Multithreading
         * https://stackify.com/c-threading-and-multithreading-a-guide-with-examples/#:~:text=In%20simple%20terms%2C%20a%20thread,single%20threaded%20process%20by%20default.
         */
        void Function1()
        {
            // Some work here
        }
        void Function2()
        {
            // Some other work here
        }
        public void UserMulithreading()
        {
            Thread thread1 = new Thread(new ThreadStart(Function1));
            Thread thread2 = new Thread(new ThreadStart(Function2));
            thread1.Start();
            thread2.Start();
        }

        /*
         * Understand and Use Async and Await
           The async and await keywords in C# simplify managing multithreaded applications. When you mark a method with the async keyword, 
           it signifies that the method can contain the await keyword, which effectively tells C# to delegate the rest of the function’s 
           execution to a worker thread, thus freeing up the main thread to perform other tasks.
         */
        //In this example, the complex calculation runs on a worker thread, leaving the main thread free to process other tasks, enhancing the responsiveness of your application.
        public async Task MyFunction()
        {
            await Task.Run(() =>
            {
                // Complex calculation here
            });
        }
    }
}
