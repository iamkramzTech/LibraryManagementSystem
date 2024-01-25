using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface ISearchBooks
    {
        List<Book> SearchByTitle(string title);
        List<Book> SearchByAuthor(string author);
        List<Book> SearchByGenre(string genre);
    }
}
