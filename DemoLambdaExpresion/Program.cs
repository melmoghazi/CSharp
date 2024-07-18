namespace DemoLambdaExpresion
{
    /// <summary>
    /// What is Lambda Expresion?
    /// An anonymous method:
    ///     - no access modifier
    ///     - no name
    ///     - no return statement
    /// Why do we need anonymous methods?
    ///     for convenience, write less code and achieve the same thing.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Console.WriteLine(Square(5));

            //args => expresion
            //args lambda operator expresion
            //args goes to expresion
            // () => ...
            // x => ...
            //(x,y,z) => ...
            // x => x * x; 
            Func<int, int> func = (x) => x * x;
            Console.WriteLine(func(5));

            Console.WriteLine("---Get books that are less than 10");
            var books = BookRepository.GetBooks();

            //FindAll take a predicate
            //var cheapBooksList = books.FindAll(IsCheapBook);
            var cheapBooksList = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooksList)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }

        //write a method that take a number and return the square of this number
        static int Square(int x)
        {
            return x * x;
        }

        static bool IsCheapBook(Book book)
        {
            return book.Price < 10;
        }
    }
}
