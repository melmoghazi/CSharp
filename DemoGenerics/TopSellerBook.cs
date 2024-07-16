namespace DemoGenerics
{
    //Constrain of Where T : Book, means T is the Book class or one of its subclasses
    public class TopSellerBook<T> where T : Book
    {
        public string GetTopSellerBook(T book)
        {
            return book.Title;
        }
    }

}
