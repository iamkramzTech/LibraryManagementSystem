﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class ReturnProcessor : IReturnable
    {
       public void ReturnBook()
        {
            Console.WriteLine("The Book is returned");        
        }
    }
}
