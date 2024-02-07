namespace Library_Management_System
{
    public class LibrarySystem : ISearchBooks
    {
        public List<Student> Students { get; set; }
        public Library Library { get; set; }

        public LibrarySystem() 
        {
        
            Students = new List<Student>();
            Library = new Library();
        }  

        public void RegisterStudent(Student student)
        {
            if(string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Grade.ToString()))
            {
                Console.WriteLine("All Fields are Required");
            }
            else
            {
                Students.Add(student);
                Console.WriteLine($"Registered successfully. ID Number: {student.ID}");
            }
            
        }

        public List<Book> SearchByTitle(string? title=null)
        {
            //using LINQ query to fetch book search based on title
            var linqQuery = from books in Library.Books where books.Title == title && books.Availability==true select books;


            return linqQuery.ToList();
        }
        public List<Book> SearchByAuthor(string? author = null)
        {
            //using LAMBDA expression to fetch book search based on author
            var lambdaExp= Library.Books.Where(book => book.Author == author && book.Availability==true).Select(book => book);

            return lambdaExp.ToList();
        }

        public List<Book> SearchByGenre(string? genre = null)
        {
            //using LAMBDA expression to fetch book search based on genre
            var lambdaExp = Library.Books.Where(book => book.Genre == genre && book.Availability == true).Select(book => book);

            return lambdaExp.ToList();
        }
    }
}
