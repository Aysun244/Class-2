using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    class Book : Product 
    {
        public string Genre;
        public Book(double no, string name, double price, double count, string genre) : base(no, name, price, count)

        { 
         
            Genre = genre;
        }
    }
}
