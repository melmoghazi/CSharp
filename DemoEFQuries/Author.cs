﻿namespace DemoEFQuries
{
    public class Author
    {
        public Author()
        {
            //Books = new List<Book>();
        }
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AddedDate { get; set; }
        //One author many books
        public virtual ICollection<Book> Books { get; set; }
    }
}