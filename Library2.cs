using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
  
    public class Library2 : ILibrarycs
    {
        List<Book> books;
        public Library2() 
        {
            books = new List<Book>();
        }
        public void AddBook(Book book) 
        {
            books.Add(book);
        }
        public void Checkout(string isbn) 
        {
            var book = books.Find(b=>b.ISBN == isbn);
            if (book != null && book.Availability) 
            {
                book.Availability = false;
                Console.WriteLine($"Book titled: {book.Title}\n ISBN: {book.ISBN} \ncheckout successfully");

            }
            else if(book != null && book.Availability==false)
                Console.WriteLine($"Book ISBN: {isbn} is not available");
            else
            {
                Console.WriteLine($"Book {isbn} not found");
            }
        }
        public void DisplayBooks() 
        {
            if (books.Count==0)
            {
                Console.WriteLine("No Books in the library");
                return;
            }
            Console.WriteLine("==Books in the library==");
            foreach (var book in books) 
            {
                var status = book.Availability ? "Available" : "Checked out";
                Console.WriteLine($"Title: {book.Title} Author: {book.Author} Genre: {book.Genre} ISBN: {book.ISBN} Status: {status}");
            }
        }
    }
}
