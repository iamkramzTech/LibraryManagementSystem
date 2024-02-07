using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Library_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Commented Code --
            //integer based library operation 
            // int op;
            //variable to Check if user has successfully login
            //  bool hasLogin;

            //variable to check if op=0 system will exit
            //  bool sysExit = false;
            #endregion

            #region -- Create an instance of LibrarySystem --
            // Create a new library system
            var librarySystem = new LibrarySystem();
            #endregion

            #region -- Create Books and Add in Library --
            // Create some books
            var book1 = new Book("Java Programming 1", "N. Maholtra", "978-6-78-90123-4-6", "Computer Science");
            var book2 = new Book
            {
                Title = "Data Structures and Algorithims using C",
                ISBN = "978-7-89-01234-5-7",
                Author = "N. Maholtra",
                Genre = "Computer Science"
            };

            var book3 = new Book
            {
                Title = "Data Structures and Algorithims using C++",
                ISBN = "978-7-89-01234-5-8",
                Author = "N. Maholtra",
                Genre = "Computer Science"
            };

            var book4 = new Book
            {
                Title = "After We Fell",
                ISBN = "978-4-56-78901-2-4",
                Author = "Pearly",
                Genre = "Fiction"
            };

            //Add books so that there will be books to display in the Library 
            //during the running of the program
            librarySystem.Library.AddBooks(book1);
            librarySystem.Library.AddBooks(book2);
            librarySystem.Library.AddBooks(book3);
            librarySystem.Library.AddBooks(book4);

            #endregion

            #region -- Display All Books --
            //Display Book
            librarySystem.Library.DisplayAllBooks();
            #endregion

            #region -- Register a Student in Library System --

            //Register a Student in a Library system
            Student student1 = new Student("Mark John", 12);
            var student2 = new Student("John Doe", 10);

            librarySystem.RegisterStudent(student1);
            librarySystem.RegisterStudent(student2);

            #endregion

            #region -- Checkout Book --
            //checkout book
            student1.CheckoutBook(book2);

            #endregion

            librarySystem.Library.DisplayAllBooks();

            #region -- return Book --
            //return book
            student1.ReturnBook(book1);
            // librarySystem.Library.DisplayAllBooks();

            #endregion

            //it will create newline same as \n escape characters
            Console.WriteLine(Environment.NewLine);
            #region -- Searching Book by Title --
            var searchBookTitle = librarySystem.SearchByTitle(book4.Title);
            Console.WriteLine($"**Search Book by Title.**\n {searchBookTitle.Count} Result Found");
            Console.WriteLine("Title\tAuthor\tGenre");

            searchBookTitle.ForEach(book => Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Genre}"));
            #endregion

            #region -- Searching Book by Author --
            var searchBookAuthor = librarySystem.SearchByAuthor("N. Maholtra");
            Console.WriteLine($"**Search Book by Author.**\n {searchBookAuthor.Count} Result Found");
            Console.WriteLine("Title\tAuthor\tGenre");

            searchBookAuthor.ForEach(book => Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Genre}"));
            #endregion

            #region -- Searching Book by Genre --
            var searchBookGenre = librarySystem.SearchByGenre("Fiction");
            Console.WriteLine($"**Search Book by Genre.**\n {searchBookGenre.Count} Result Found");
            Console.WriteLine("Title\tAuthor\tGenre");

            searchBookGenre.ForEach(book => Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Genre}"));
            #endregion



            #region --- Commented Previous Code -- 
            //Console.Clear();
            //do
            //{
            //    Console.WriteLine("**Welcome to Library Management System!**");


            //    Console.WriteLine("Please Login First");
            //    Console.Write("Enter Username: ");
            //    var username = Console.ReadLine();
            //    Console.Write("Enter Password: ");
            //    var password = Console.ReadLine();

            //    hasLogin = library1.LoginLibrarian(username:username, password: password);


            //    if (!hasLogin)
            //    {
            //        // Invalid credentials
            //        Console.WriteLine("Invalid username or password");
            //        Thread.Sleep(1000);
            //        Console.Clear();


            //    }
            //}
            //while (!hasLogin);


            //Console.Clear();
            //do
            //{

            //    Console.WriteLine($"**Welcome to Library Management System!**\t\t\t{library1.ToString()}");

            //    Console.WriteLine("==All Library Operations==");
            //    Console.WriteLine("0. Exit");
            //    Console.WriteLine("1. Add Books");
            //    Console.WriteLine("2. Display Books");
            //    Console.WriteLine("3. Remove Books\n");
            //    Console.Write("Choose an Operation based on their Number: ");
            //    // op = Convert.ToInt32(Console.ReadLine());
            //    if (int.TryParse(Console.ReadLine(), out op))
            //    {
            //        switch (op)
            //        {

            //            case 0:
            //                sysExit = true; //system will exit
            //                Console.WriteLine("System will Exit Now..");
            //                break;
            //            case 1:

            //                AddBook(library1);
            //                break;
            //            case 2:
            //                Console.WriteLine("**Display list of all Books**");
            //                library1.DisplayAllBooks();
            //                break;
            //            case 3:

            //                RemoveBook(library1);
            //                break;
            //            default:
            //                Console.WriteLine("You entered Invalid Command");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //}
            //while (!sysExit); 
        }
        //private static void AddBook(Library library)
        //{
        //    bool sucess=false;
        //    // Book addBook;
        //    do
        //    {
        //        Console.WriteLine("**Add Books**");
        //        Console.Write("Input Book Title: ");
        //        var title = Console.ReadLine();
        //        Console.Write("Input Book Author: ");
        //        var author = Console.ReadLine();
        //        Console.WriteLine("**Note: Must be ISBN-13 format. Prefix Number 978 or 979 consist of 13 numbers separated by hypens**");
        //        Console.Write("Input valid ISBN Number( ex: 978-3-16-14841-0-0 ): ");
        //        var isbn = Console.ReadLine();
        //        Console.Write("Input Book Genre: ");
        //        var genre = Console.ReadLine();

        //        //Check if all Field is Fill up
        //        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(genre))
        //        {
        //            Console.WriteLine("All Field Must not Empty!.\nTry Again..");
        //        }
        //        else
        //        {
        //            if (!IsValidISBN13(isbn))
        //            {
        //                Console.WriteLine("Error! Please Enter valid ISBN-13 Format");
        //            }
        //            else
        //            {

        //                library.AddBooks(new Book
        //                {
        //                    Title = title,
        //                    Author = author,
        //                    ISBN = isbn,
        //                    Genre = genre
        //                });
        //                sucess = true;
        //            }
        //        }
        //    }
        //    while (sucess != true);

        //}
        //private static void RemoveBook(Library library)
        //{
        //    //Book removeBook = new Book();
        //    Console.WriteLine("**Remove Books**");
        //    Console.Write("Enter ISBN NUmber Format(ex: 978-3-16-14841-0-0): ");
        //    var removeISBN = Console.ReadLine();
        //    if (!IsValidISBN13(removeISBN))
        //    {
        //        Console.WriteLine("Enter Valid ISBN-13 Number");
        //    }
        //    else
        //    {
        //        library.RemoveBooks(removeISBN);
        //    }
        //}
        //private static bool IsValidISBN13(string isbn)
        //{
        //    // Regular expression for ISBN-13
        //    string isbn13Pattern = @"^\d{3}-\d{1,5}-\d{1,7}-\d{1,8}-\d{1,7}-\d$";
        //    // Check if the input matches the pattern
        //    return Regex.IsMatch(isbn, isbn13Pattern);


        //    /*ISBN-13 generated code
        //        //1. 978 - 3 - 16 - 14841 - 0 - 0
        //        //2. 978 - 1 - 23 - 45678 - 9 - 1
        //        //3. 978 - 2 - 34 - 56789 - 0 - 2
        //        //4. 978 - 3 - 45 - 67890 - 1 - 3
        //        //5. 978 - 4 - 56 - 78901 - 2 - 4
        //        //6. 978 - 5 - 67 - 89012 - 3 - 5
        //        //7. 978 - 6 - 78 - 90123 - 4 - 6
        //        //8. 978 - 7 - 89 - 01234 - 5 - 7
        //        //9. 978 - 8 - 90 - 12345 - 6 - 8
        //        //10. 978 - 9 - 01 - 23456 - 7 - 9
        //    */
        //}
        #endregion
    }
}
