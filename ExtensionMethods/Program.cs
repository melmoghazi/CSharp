namespace ExtensionMethods
{

    /// <summary>
    /// Extension Methods: Allow us to add methods to existing class without:
    /// - Changing its source code, or 
    /// - Creating a new class that inherit from it.
    /// Create the extension methods if you do not have the source code of the class.
    /// Most of the time you will be using the existing extension methods.
    /// Extension Method creates as a static member in a static class with this param.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");


            string post = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string shortenPost = post.Shorten(11);
            Console.WriteLine("Extension Method Shorten():" + shortenPost);

            //Exmaple of existing extension method
            IEnumerable<int> numbers = new List<int> { 1,2,3,4,5};
            numbers.Max();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
