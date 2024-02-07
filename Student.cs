using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Student
    {

        private static int s_idNumber = 241000;
        
        public string Name { get; set; }
        public int Grade { get; set; }
        public string ID { get; private set; }
      //  public string Password { get; set; }
        /// <summary>
        /// Initialize a new instance of Student Class
        /// accepting student details as Parameter
        /// </summary>
        /// <param name="name">Name of Student</param>
        /// <param name="grade">Grade Level</param>
        /// <param name="password">Passord</param>
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
            //this.Password = password;
            this.ID = s_idNumber.ToString();
            s_idNumber++;
        }

        public void CheckoutBook(Book  book) 
        {
            if(!book.Availability)
            {
                Console.WriteLine("Book status is not available");
            }
            else
            {
                book.Availability = false;
            }
        }

        public void ReturnBook(Book book)
        {
            if(book.Availability)
            {
                Console.WriteLine("Book status is not checkout ");
            }
            else
            {
                book.Availability = true;
            }
        }

        //public void SignupStudent(string id, string name, string grade, string password)
        //{
        //    this.ID = id;
        //    this.Name = name;
        //    this.Grade = grade;
        //    this.Password = password;
        //}
        //public void LoginStudent(string id, string password)
        //{
        //    this.ID = id;
        //    this.Password= password;
        //}

        
    }
}
