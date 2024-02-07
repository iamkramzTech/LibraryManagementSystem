using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public class Library : IAddRemoveBooks, IDisplayBooks
    {
        public List<Book> Books { get; set; }
        public string? UserName { get; private set; }
        public string? Password { get; private set; }

        private Dictionary<string, string> _librarianCredentials;
        private const string LibrarianFilePath = "librarians.txt";

        /// <summary>
        /// Initilaze a new instance of a Library Class 
        /// </summary>
        public Library()
        {
            Books = new List<Book>();
            // Initialize or load librarian credentials (from a file, database, etc.)
            //_librarianCredentials = ReadLibrarianCredentials();
        }

        /// <summary>
        /// Allows a Library to try to free resources and perform other cleanup operations
        /// before it is reclaimed by garbage collection.
        /// </summary>
        ~Library() { }
        /// <summary>
        /// Librarian Login function
        /// </summary>
        /// <param name="username">username of the Librarian</param>
        /// <param name="password">password of the librarian</param>
        /// <returns>return true if username and password match. otherwise false</returns>
        //public bool LoginLibrarian(string username, string password)
        //{
        //    // Check if the provided credentials are valid
        //    if (_librarianCredentials.TryGetValue(username, out string? storedPassword) && storedPassword == password)
        //    {
        //        /// Authentication successful, set the username
        //        UserName = username;
        //        Password = password;
        //        Console.WriteLine("Librarian login successful");
        //        return true;
               
        //    }
           
        //    return false;
        //}
        /// <summary>
        /// Read Librarian store in the txt file stored in local directory
        /// </summary>
        /// <returns></returns>
        //private static Dictionary<string, string> ReadLibrarianCredentials()
        //{
        //    Dictionary<string, string> credentials = new Dictionary<string, string>();

        //    try
        //    {
        //        // Read lines from the text file
        //        string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(),LibrarianFilePath));

        //        foreach (string line in lines)
        //        {
        //            // Split each line into username and password using comma as delimiter
        //            string[] parts = line.Split(',');

        //            if (parts.Length == 2)
        //            {
        //                string username = parts[0].Trim();
        //                string password = parts[1].Trim();

        //                // Add username and password to the dictionary
        //                credentials[username] = password;
        //            }
        //        }
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        // Handle file not found exception (e.g., create the file)
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Librarians file not found. Creating a new file.");
        //        File.WriteAllText(LibrarianFilePath, string.Empty);
        //    }

        //    return credentials;
        //}
        /// <summary>
        /// Adding Book in the library
        /// </summary>
        /// <param name="book">Book Type from Book.cs blueprint</param>
        public void AddBooks(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book Added Sucessfully!");
        }

        /// <summary>
        /// Removing the Books in the library based on ISBN Number. 
        /// </summary>
        /// <param name="isbn">ISBN Number of the book to be remove</param>
        public void RemoveBooks(string isbn)
        {
           var remove = Books.RemoveAll(c=>c.ISBN==isbn);
            if(remove>0)
            {
                Console.WriteLine("Book Removed Successfully!");
            }
            else
            {
                Console.WriteLine("Book Not Found!");
            }

        }

        /// <summary>
        /// Library Function to Display All Book Information
        /// Book(Title, author, isbn, genre, status)
        /// </summary>
        public void DisplayAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No Books in the library");
                return;
            }
            Console.WriteLine("==Books in the library==");
            foreach (var book in Books)
            {
                var status = book.Availability ? "Available" : "Checked out";
                Console.WriteLine($"Title: {book.Title} Author: {book.Author} Genre: {book.Genre} ISBN: {book.ISBN} Status: {status}");
            }
        }
        //overriding ToString method inherited from Object class
        public override string ToString() => $"Library Name: {UserName}";

    }
}
