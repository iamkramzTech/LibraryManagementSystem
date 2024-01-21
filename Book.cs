﻿using System;
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
        private bool _IsAvailable;
        private string _genre;
        public Book()
        {

        }
        public string Title
        { 
            get { return _title; } set {  _title = value; } 
        }
        public string Author
        {
            get { return _author; } set { _author = value; }
        }
        public string ISBN { 
            get { return _isbn; } set { _isbn = value; } 
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public bool Availability
        {
            get 
            { 
                return _IsAvailable; 
            }
            set
            {
                _IsAvailable = value;
            }
        }
    }
}
