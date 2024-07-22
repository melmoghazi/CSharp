namespace ExtensionMethods
{
    //public class StringExtensions : String
    //{
        // can not inherit from sealed class
    //}

    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfCharacters)
        {
            return str.Substring(0, numberOfCharacters);
        }
    }
}
