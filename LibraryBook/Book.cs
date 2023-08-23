using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public string Status;

        public Book(string title,string author, string Isbn, string status)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = Isbn;
            this.Status = status;
        }
    }
}
