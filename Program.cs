using System.Diagnostics;

namespace Library_Management_System
{
     class Program
    {
        static void Main(string[] args)
        {
            int op;
            bool hasLogin;

            var library1 = new Library();
            
            var book1 = new Book("Java Programming 1", "kramz", "978-0596-155-7", "Programming");
            var book2 = new Book
            {
                Title = "Data Structures and Algorithims using C",
                ISBN = "979 - 0596 - 155 - 8",
                Author = "N. Maholtra",
                Genre = "Computer Science"
            };


            //Add books so that there will be books to display in the Library 
            //during the running of the program
            library1.AddBooks(book1);
            library1.AddBooks(book2);
            Console.Clear();
            do
            {
                Console.WriteLine("**Welcome to Library Management System!**");


                Console.WriteLine("Please Login First");
                Console.Write("Enter Username: ");
                var username = Console.ReadLine();
                Console.Write("Enter Password: ");
                var password = Console.ReadLine();

                hasLogin = library1.LoginLibrarian(username, password);



                if (!hasLogin)
                {
                    // Invalid credentials
                    Console.WriteLine("Invalid username or password");
                    Thread.Sleep(1000);
                    Console.Clear();


                }
            }
            while (!hasLogin);



            Console.Clear();
            do
            {

                Console.WriteLine("**Welcome to Library Management System!**");

                Console.WriteLine("==All Library Operations==");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Remove Books\n");
                Console.Write("Choose an Operation based on their Number: ");
                // op = Convert.ToInt32(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {

                        case 0:
                            Console.WriteLine("System will Exit Now..");
                            break;
                        case 1:

                            AddBook(library1);
                            break;
                        case 2:
                            Console.WriteLine("**Display list of all Books**");
                            library1.DisplayAllBooks();
                            break;
                        case 3:
                           
                            RemoveBook(library1);
                            break;
                        default:
                            Console.WriteLine("You entered Invalid Command");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            while (op != 0); 
        }
        private static void AddBook(Library library)
        {
           // Book addBook;

            Console.WriteLine("**Add Books**");
            Console.Write("Book Title: ");
            var title = Console.ReadLine();
            Console.Write("Author: ");
            var author = Console.ReadLine();
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();
            Console.Write("Genre: ");
            var genre = Console.ReadLine();
           library.AddBooks(new Book
            {
                Title = title,
                Author = author,
                ISBN = isbn,
                Genre = genre
            });
            
        }
        private static void RemoveBook(Library library)
        {
            //Book removeBook = new Book();
            Console.WriteLine("**Remove Books**");
            Console.Write("Enter ISBN NUmber Format(xxx-x-xxxxx-x): ");
            var removeISBN = Console.ReadLine();
            library.RemoveBooks(removeISBN);
        }
    }
}
