using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    public class BookRepository
    {
        public static List<Book> GetBooks()
        {
            return new List<Book> {
                new Book { Title="CSharp", Price=5 },
                new Book { Title="DB", Price=7 },
                new Book { Title="SQL", Price=19 },
                new Book { Title="Postgresql", Price=20 },
                new Book { Title="JavaScript", Price=25 }

             };
        }
    }
}
