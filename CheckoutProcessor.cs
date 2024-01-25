using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public class CheckoutProcessor : ICheckout
    {
        List<Book> _books = new List<Book>();
        public void CheckoutBook(string isbn)
        {
            var book = _books.Find(b => b.ISBN == isbn);
            if (book != null && book.Availability)
            {
                book.Availability = false;
                Console.WriteLine($"Book titled: {book.Title}\n ISBN: {book.ISBN} \ncheckout successfully");

            }
            else if (book != null && book.Availability == false)
                Console.WriteLine($"Book ISBN: {isbn} is not available");
            else
            {
                Console.WriteLine($"Book {isbn} not found");
            }
        }
    }
}
