using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    class CompareByDate:IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {

            return x.DatePublished.CompareTo(y.DatePublished);
        }
    }
}
