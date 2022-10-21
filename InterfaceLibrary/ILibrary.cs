using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    interface ILibrary<Book>
    {

        //Method to add a book

        void Add(Book book);

        //Method to remove book given isbn
        bool Remove(string isbn);

        //Method to search a book given isbn
        bool Search(string isbn);

        //Method to check available books
        List<Book> CheckAvailableBooks();

        //Method to check borrowed books
        List<Book> CheckBorrowedBooks();

        //Sort books by publication
        void SortByPublicationDate();

    }
}
