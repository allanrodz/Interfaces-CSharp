using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    class Book
    {

        //Properties

        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public int Status { get; set; }

        //Constructor(s)
        public Book()
        {
            Status = 1;
        }

        public Book(string isbn, string title, DateTime date)
        {
            ISBN = isbn;
            Title = title;
            DatePublished = date;
            Status = 1; //available to be borrowed

        }

        public override string ToString()
        {
            return string.Format($"\nISBN: {ISBN}\nTitle: {Title}\nPublication Date: {DatePublished.ToShortDateString()}\nStatus: {Status}");
        }
    }
}
