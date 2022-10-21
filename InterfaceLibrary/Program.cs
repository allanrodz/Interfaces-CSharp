using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            BooksLibrary lib = new BooksLibrary();
            //Book book = new Book();
            lib.Add(new Book("232-45", "Programming", new DateTime(2021,09,01)));
            Console.WriteLine($"Number of books in the library: {lib.Count}");
            Console.WriteLine();
            foreach (var item in lib)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
