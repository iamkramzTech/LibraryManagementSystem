using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Management_System
{
    public class Library : ILibrarian, IAddRemoveBooks, IDisplayBooks
    {
       private  List<Book> books;
        public string? UserName { get; private set; }
        public string? Password { get; private set; }

        private Dictionary<string, string> _librarianCredentials;
        private const string LibrarianFilePath = "librarians.txt";

        public Library()
        {
            books = new List<Book>();
            // Initialize or load librarian credentials (from a file, database, etc.)
            _librarianCredentials = ReadLibrarianCredentials();
        }
        public bool LoginLibrarian(string username, string password)
        {
            // Check if the provided credentials are valid
            if (_librarianCredentials.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                /// Authentication successful, set the username
                UserName = username;
                Password = password;
                Console.WriteLine("Librarian login successful");
                return true;
               
            }
           
            return false;
        }

        private static Dictionary<string, string> ReadLibrarianCredentials()
        {
            Dictionary<string, string> credentials = new Dictionary<string, string>();

            try
            {
                // Read lines from the text file
                string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(),LibrarianFilePath));

                foreach (string line in lines)
                {
                    // Split each line into username and password using comma as delimiter
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        string username = parts[0].Trim();
                        string password = parts[1].Trim();

                        // Add username and password to the dictionary
                        credentials[username] = password;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found exception (e.g., create the file)
                Console.WriteLine(ex.Message);
                Console.WriteLine("Librarians file not found. Creating a new file.");
                File.WriteAllText(LibrarianFilePath, string.Empty);
            }

            return credentials;
        }
        public void AddBooks(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added Sucessfully!");
        }
        public void RemoveBooks(string isbn)
        {
           var remove = books.RemoveAll(c=>c.ISBN==isbn);
            if(remove>0)
            {
                Console.WriteLine("Book Removed Successfully!");
            }
            else
            {
                Console.WriteLine("Book Not Found!");
            }

        }
        public void DisplayAllBooks()
        {
            if (books.Count == 0)
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
