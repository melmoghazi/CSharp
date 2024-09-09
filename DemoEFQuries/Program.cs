using Microsoft.EntityFrameworkCore;

namespace DemoEFQuries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DemoBookAPIDbContext context = new DemoBookAPIDbContext())
            {
                //LazyLoading(context);
                //EgarLoading(context);                
                //ExplicitLoading(context);
                IEnumerableAndIQuerable(context);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// IEnumerable: represents an object that can be enumerated. eg (string, array, list, dictionary)
        /// 
        /// IQuerable allows queries to be extended without immediately executed.
        /// 
        /// If you used IEnumerable the query will go to the DB then the next filteration quires
        /// will hapen on the data in the memory that returned from the IEnumerable.
        /// </summary>
        /// <param name="context"></param>
        private static void IEnumerableAndIQuerable(DemoBookAPIDbContext context)
        {
            var booksC= context.Books.Where(b => b.Title.ToLower().StartsWith("c"));
            booksC = booksC.Where(b => b.IsDeleted == true);
            var result= booksC.ToList();
            foreach (var book in result)
            {
                Console.WriteLine(book.Title);
            }

        }

        /// <summary>
        /// Explicit loading: separate query with Load method.
        /// </summary>
        /// <param name="context"></param>
        private static void ExplicitLoading(DemoBookAPIDbContext context)
        {
            var auth = context.Authors.Single(a => a.AuthorId == 1);
            context.Books.Where(b => b.AuthorId == auth.AuthorId).Load();
            foreach (var b in auth.Books)
            {
                Console.WriteLine($"{b.Title} {b.Author.FirstName} {b.Author.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------");
        }

        /// <summary>
        /// Egar loading: use include
        /// </summary>
        /// <param name="context"></param>
        private static void EgarLoading(DemoBookAPIDbContext context)
        {
            var books = context.Books.Include(b => b.Author).ToList();
            foreach (var b in books)
            {
                Console.WriteLine($"{b.Title} {b.Author.FirstName} {b.Author.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------");
        }

        /// <summary>
        /// Lazy loading: use virtual with ICollection and the query happen in foreach
        /// </summary>
        /// <param name="context"></param>
        private static void LazyLoading(DemoBookAPIDbContext context)
        {
            var authors = context.Authors.Where(a => a.AuthorId < 4);
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.FirstName} {author.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
