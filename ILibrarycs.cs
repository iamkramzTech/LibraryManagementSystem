﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface ILibrarycs
    {
        void AddBook(Book book);
        void Checkout(string isbn);
        void DisplayBooks();
    }
}
