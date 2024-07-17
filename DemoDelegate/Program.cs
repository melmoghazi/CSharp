namespace DemoDelegate
{
    /// <summary>
    /// A delegate is an object that knows how to call a method or a group of methods.
    /// A reference or apointer to a function.
    /// Why do we need a delegate?
    /// To design extensible and flexible applications (eg frameworks).
    /// Interfaces or delegates?
    /// Use delegates when:
    ///     an eventing design pattern is used.
    ///     the caller does not need to access other properties or methods on the object implementing the method.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            PhotoProcessor photoProcessor = new PhotoProcessor();

            //photoProcessor.Process("photo.png");
            //photoProcessor.ProcessDelegate("photo.png");

            //create new object of PhotoFilters
            var filters =new PhotoFilters();
            //create new object from the delegate PhotoFilterHandler 
            PhotoProcessor.PhotoFilterHandler handler = filters.ApplyBrightness;
            //add one or more method to the delegate
            handler += filters.ApplyContrast;
            handler += filters.Resize;

            //you can define your own custom filter and add it to delegate to be applied on the photo.
            handler += RemoveRedEyeFilter;
            //call the process method
            photoProcessor.Process("photo.png", handler);


            //user action
            Console.WriteLine("-----use system.delegate System.Action-----");
            System.Action<Photo> action = filters.ApplyBrightness;
            action += filters.ApplyContrast;
            action += filters.Resize;
            action += RemoveRedEyeFilter;
            action.Invoke(new Photo());



            Console.WriteLine("End");
            Console.ReadLine();

        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove Red Eye Filter");
        }
    }
}
