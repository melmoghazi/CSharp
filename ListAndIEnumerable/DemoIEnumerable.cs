using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndIEnumerable
{
    public class DemoIEnumerable
    {
        public static  void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            //IQueryable<int> numss = new List<int> { 1, 2, 3, 4, 5 }; // missing a cast



            DemoDbContext dbContext = new DemoDbContext();
            //log query into console
//            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

            //IEnumerable
            var authorsList = dbContext.Authors.First(); // Data fetched immediately
            //var filteredAuthors = authorsList.Where(a => a.FirstName == "ali"); // Filtering done in-memory

            //IQuerable
            IQueryable<Author> authorsIQuerable = dbContext.Authors; // Query deferred
            var filteredAuthors2 = authorsIQuerable.Where(a => a.FirstName == "ali"); 

            var authorIQuerable = dbContext.Authors.Where(a => a.FirstName == "ali");
            var author =  authorIQuerable.First();// Query executed on the server
            
            //var authors = dbContext.Authors.ToList();

            Console.ReadKey();
        }
    }

}
