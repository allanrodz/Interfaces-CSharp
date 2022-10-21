using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InterfaceLibrary
{
    class BooksLibrary : ICollection<Book>, ILibrary<Book>
    {
        
        #region ILibrary Methods
        public bool Search(string isbn)
        {
            bool found = false;
            foreach (Book book in list)
            {
                if (book.ISBN == isbn)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        public bool Remove(string isbn)
        {
            bool found = false;

            foreach  (Book book in list)
            {
                if (book.ISBN == isbn)
                {
                    list.Remove(book);
                    found = true;
                    break;
                }
            }
            return found;
        }

        public List<Book> CheckAvailableBooks()
        {

            List<Book> available = new List<Book>();

            foreach (Book book in list)
            {
                if (book.Status == 1)
                {
                    available.Add(book);
                }
            }

            return available;
        }


        public List<Book> CheckBorrowedBooks()
        {

            List<Book> borrowed = new List<Book>();

            foreach (Book book in list)
            {
                if (book.Status == 0)
                {
                    borrowed.Add(book);
                }
            }

            return borrowed;
        }

        public void SortByPublicationDate()
        {

            list.Sort(new CompareByDate());
           
        }

        #endregion//declaration of list object
        private List<Book> list;

        //constructor
        public BooksLibrary()
        {
            list = new List<Book>();
        }

        #region ICollection Methods and Properties
        //Properties

        public int Count { get { return list.Count; } }
        public bool IsReadOnly { get { return false; } }

        //Methods

        public void Add(Book book)
        {
            list.Add(book);
        }

        public bool Remove(Book book)
        {
            return list.Remove(book);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Book book)
        {
            return list.Contains(book);
        }

        public void CopyTo(Book[] array, int index)
        {
            list.CopyTo(array, 0);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion

    }
}
