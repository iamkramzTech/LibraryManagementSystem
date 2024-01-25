using System.Diagnostics;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var library = new Library();

            Console.WriteLine("**Welcome to Library Management System!**");

            //var book1 = new Book("Java Programming 1", "kramz", "978-0596-155-7", "Programming");
            //var book2 = new Book
            //{
            //    Title = "Data Structures and Algorithims using C",
            //    ISBN = "979 - 0596 - 155 - 8",
            //    Author = "N. Maholtra",
            //    Genre = "Computer Science"
            //};


            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.DisplayBooks();
            //library.Checkout("979 - 0596 - 155 - 8");

            //library.DisplayBooks();
            //library.Checkout("123");
            //library.Checkout("979 - 0596 - 155 - 8");

            var library1 = new Library();
            var book1 = new Book("Java Programming 1", "kramz", "978-0596-155-7", "Programming");
            var book2 = new Book
            {
                Title = "Data Structures and Algorithims using C",
                ISBN = "979 - 0596 - 155 - 8",
                Author = "N. Maholtra",
                Genre = "Computer Science"
            };
            start:
            Console.WriteLine("Please Login First");
            Console.Write("Enter Username: ");
            var username = Console.ReadLine();
            Console.Write("Enter Password: ");
            var password = Console.ReadLine();
           
            var hasLogin = library1.LoginLibrarian(username, password);

            if(!hasLogin) 
            {
                // Invalid credentials
                Console.WriteLine("Invalid username or password");
                Thread.Sleep(1000);
                Console.Clear();
                goto start;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("**Welcome to Library Management System!**");
                library1.AddBooks(book1);
                library1.AddBooks(book2);
                library1.DisplayAllBooks();
            }
          //  Console.WriteLine("Next Code here");
        }
    }
}
