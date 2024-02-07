using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private bool _IsAvailable = true;
        private string _genre;

        public Book() 
        {
        
        }

        /// <summary>
        /// Initializes a new instance of the Book class with the given name, author, isbn, and genre.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="isbn">The ISBN-13 Number of the book </param>
        /// <param name="genre">The Genre of the book</param>
        public Book(string title,string author,string isbn,string genre)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
            _genre = genre;
            _IsAvailable = true;

        }
        /// <summary>
        /// Gets or sets the book title
        /// </summary>
        public string Title
        { 
            get { return _title; } set {  _title = value; } 
        }
        /// <summary>
        /// Gets or sets the book author
        /// </summary>
        public string Author
        {
            get { return _author; } set { _author = value; }
        }
        /// <summary>
        /// Gets or sets the book ISBN Number
        /// </summary>
        public string ISBN { 
            get { return _isbn; } set { _isbn = value; } 
        }
        /// <summary>
        /// Gets or sets the book Genre
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        /// <summary>
        /// Gets or sets the status of the book (True:available; False:not)
        /// </summary>
        public bool Availability
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }
      
    }
}
