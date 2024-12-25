namespace ListAndIEnumerable
{
    internal class Program
    {
        /*
         *IEnumerable:
            -It is an interface defined in the System.Collections namespace.
            -Represents a sequence of elements that can be iterated over using a foreach loop.
            -It is read-only and doesn't allow modification of the collection (e.g., adding, removing items).
            -Useful for deferred execution (e.g., LINQ queries) and working with any collection that can be enumerated. 
            -Only provides the ability to iterate over a collection using the GetEnumerator method.
            -Commonly implemented by collections such as arrays, lists, dictionaries, and custom data structures.
            -Lightweight and used for read-only access or iteration.
            -Can represent an infinite sequence because of deferred execution.
            -Suitable when you only need to enumerate a collection without modifying it.
        *List
            -It is a concrete class defined in the System.Collections.Generic namespace.
            -Represents a collection of objects that can be accessed by index and allows dynamic resizing.
            -Supports adding, removing, and modifying elements in the collection.
            -Implements IEnumerable and other interfaces like ICollection and IList.
            -Provides methods and properties for managing the collection, such as Add, Remove, Contains, Count, etc.
            -Heavier, as it provides more functionality for managing collections.
            -Suitable for scenarios where you need to frequently add, remove, or access elements by index.
            -Not deferred; all elements must be fully loaded in memory.
         */
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            // Cannot use `numbers.Add(6)` because IEnumerable doesn't support adding.
            
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
            numbersList.Add(6); // You can add items
            foreach (var number in numbersList)
            {
                Console.WriteLine(number);
            }
        }
    }
    
}
