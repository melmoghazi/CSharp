namespace DemoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            // get books witch are less than 10
            var books = BookRepository.GetBooks();

            List<Book> booksLessThan10 = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price<10)
            //    {
            //        booksLessThan10.Add(book);
            //    }
            //}

            //get by linq query
            booksLessThan10 = books.Where(b => b.Price < 10).ToList();

            //Display books
            foreach (var book in booksLessThan10)
            {
                Console.WriteLine($"Title: {book.Title} , Price: {book.Price}");
            }
            Console.WriteLine();

            //use select that projects each element of a sequence into a new form.
            var bookTitles = books.Select(b => b.Title).ToList();
            foreach (var book in bookTitles)
            {
                Console.WriteLine($"book title is {book}");
            }



            //Linq Query Operator
            var booksCheaper = from b in books
                               where b.Price < 10
                               orderby b.Price
                               select b.Title;
            Console.WriteLine();
            Console.WriteLine("Display booksCheaper using Linq Query Operator");

            //Linq Extension Methods
            var booksCheaper2 = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Price)
                .Select(b => b.Title);

            foreach (var book in booksCheaper2)
            {
                Console.WriteLine($"book = {book}");
            }

            Console.WriteLine();
            Console.WriteLine("Display booksCheaper using Linq Extension Methods");
            foreach (var book in booksCheaper2)
            {
                Console.WriteLine($"book = {book}");
            }

            //Linq extension methods examples
            var bookFirst= books.First();
            Console.WriteLine($"bookFirst: {bookFirst}");
            var firstOrDefault = books.FirstOrDefault(b=>b.Title=="SQL");
            Console.WriteLine($"firstOrDefault: {firstOrDefault.Title}");
            var singleOrDefault = books.SingleOrDefault(b => b.Title == "SQL");
            Console.WriteLine($"SingleOrDefault: {singleOrDefault.Title}");

            var booksSkipTake = books.Skip(2).Take(2).ToList();
            foreach (var book in booksSkipTake)
            {
                Console.WriteLine($"booksSkipTake = {book.Title}");
            }

            //max book price
            var maxBookPrice = books.Max(b => b.Price);
            Console.WriteLine($"maxBookPrice = {maxBookPrice}");

            //min book price
            var minBookPrice = books.Min(b => b.Price);
            Console.WriteLine($"minBookPrice = {minBookPrice}");

            //total prices of the books
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine($"totalPrices = {totalPrices}");

            //count of the books
            var countOFBooks = books.Count;
            Console.WriteLine($"countOFBooks = {countOFBooks}");
            //count of the books
            var averageBooksPrice = books.Average(b=>b.Price);
            Console.WriteLine($"averageBooksPrice = {averageBooksPrice}");

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
