namespace DemoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            YouTubeAPI youTubeAPI = new YouTubeAPI();
            youTubeAPI.GetVideos("Ali");
            Console.WriteLine("--------------------------------------");
            ReadFile();
            Console.WriteLine("--------------------------------------");

            try
            {
                int result = Calculate(1, 0);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");

            }


            Console.WriteLine("End");
            Console.ReadLine();
        }

        static int Calculate(int numerator, int denominator)
        {
            return (numerator / denominator);
        }

        static void ReadFile()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, unexpected error happen while reading the file.");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
        static void ReadFile_Using()
        {
            try
            {
                //using will create under the hood the finally block and call Dispose method.
                using (StreamReader streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                    throw new Exception("Oops");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, unexpected error happen while reading the file.");
            }

        }
    }
}
