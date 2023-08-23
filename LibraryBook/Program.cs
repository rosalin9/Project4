using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBook
{
    public class Program
    {
        static List<Book> books = new List<Book>();

        public static void AddBook()
        {
            string title, author, Isbn, status;
            Console.Write("Enter the number of Books: ");
            int bookQuantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < bookQuantity; i++) 
            {
                Console.Write("Enter the Title of the book: ");
                title = Console.ReadLine();
                Console.Write("Enter the Author of the book: ");
                author = Console.ReadLine();
                Console.Write("Enter the ISBN number of the book: ");
                Isbn = Console.ReadLine();
                status = "Available";
                books.Add(new Book(title,author,Isbn,status));
            }
        }

        public static void BorrowBook()
        {
            Console.Write("Enter the Title of the book: ");
            string title = Console.ReadLine();
            Console.Write("Enter the Author of the book: ");
            string author = Console.ReadLine();

            Book result = books.Find(x => x.Title == title);
            Console.WriteLine("Collect your Book from the counter");
            books.Remove(result);
            
        }

        public static void ReturnBook()
        {
            
            AddBook();
        }
        public static void DisplayBook()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Title              Author                ISBN                Status ");
            if (books.Count > 0) 
            {
                foreach(Book book in books) 
                {
                    if(book.Status == "Available")
                    {
                        Console.Write("{0,-19}", book.Title);
                        Console.Write("{0,-10}", book.Author);
                        Console.Write("{0,-25}", book.ISBN);
                        Console.WriteLine(book.Status);
                        

                    }
                }
                
            }
     
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! To Library System");
            Console.WriteLine("1. Add Book in the Library");
            Console.WriteLine("2. Borrow Book from the Library");
            Console.WriteLine("3. Return Book to the Library");
            Console.WriteLine("4. Display Book available in the Library");
            int ch;
            do
            {
                Console.Write("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        BorrowBook();
                        break;
                    case 3:
                        ReturnBook();
                        break;
                    case 4:
                        DisplayBook();
                        break;
                    default:
                        Console.WriteLine("Incorect choice");
                        break;
                }
            } while (ch > 0);
            Console.Read();
        }
    }
}
