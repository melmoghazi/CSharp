namespace DemoGenerics
{
    internal partial class Program
    {
        /// <summary>
        /// Where T : IComparable, means T implement IComparable Interface.
        /// Where T : Book, means T is the Book class or one of its subclasses
        /// Where T : class, means reference type
        /// Where T : struct, means value type
        /// Where T : new(), means T is an object have a defult constructor.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //Generic List
            GenericList<Book> genericListBooks = new GenericList<Book>();
            genericListBooks.Add(new Book { Id = 1, Title = "CSharp" });

            GenericList<Author> genericListAuthors = new GenericList<Author>();
            genericListAuthors.Add(new Author { Id = 1, Name = "Mohammed" });


            var number = new Nullable<int>(5);
            Console.WriteLine($"HasValue = {number.HasValue}");
            Console.WriteLine($"GetValueOrDefault = {number.GetValueOrDefault()}");

            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
