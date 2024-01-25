using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Student : IStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void SignupStudent(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public void LoginStudent(int id)
        {
            ID = id;
        }
    }
}
