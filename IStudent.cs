using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public interface IStudent
    {
        string Name { get; set;}
        int ID { get; set;}
        void SignupStudent(int id, string name);
        void LoginStudent(int id);

    }
}
