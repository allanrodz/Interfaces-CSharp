using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    class UserInterface
    {
        static void Main()
        {
            BooksLibrary lib = new BooksLibrary();
            int option;

            do
            {
                Console.WriteLine("\n*******Library Menu*********\n");
                Console.WriteLine("1 - Add a new book");
                Console.WriteLine("2 - Search for a book");
                Console.WriteLine("3 - Borrow a book");
                Console.WriteLine("4 - Return a book");
                Console.WriteLine("0 - Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nPlease enter ISBN, title and Date of publication, respectively:");
                        string isbn = Console.ReadLine();
                        string title = Console.ReadLine();
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        lib.Add(new Book(isbn, title, date));
                        break;

                    case 2:
                        Console.WriteLine("\nPlease enter ISBN:");
                        isbn = Console.ReadLine();
                        foreach (var item in lib)
                        {
                            if (item.ISBN == isbn)
                            {
                                Console.WriteLine($"\nBook found!\n\nTitle: {item.Title}\nISBN: {item.ISBN}\nDate of publication:{item.DatePublished.ToShortTimeString()}\n");
                            }
                            else
                            {
                                Console.WriteLine("\nNo book found!");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nPlease enter title:");
                        title = Console.ReadLine();
                        foreach (var item in lib)
                        {
                            if (item.Title == title && item.Status != 0)
                            {
                                Console.WriteLine("\nBook borrowed!");
                                item.Status = 0;
                            }
                            else if (item.Title == title && item.Status == 0)
                            {
                                Console.WriteLine("\nBook borrowed to someone else.");
                            }
                            else
                            {
                                Console.WriteLine("\nBook not found!");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nPlease enter title:");
                        title = Console.ReadLine();
                        foreach (var item in lib)
                        {
                            if (item.Title == title)
                            { 

                                item.Status = 1;
                            }
                        }
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("\nPlease enter a valid option!");
                        break;
                }
            } while (option != 0);

            Console.WriteLine("\nThanks for using application.");
        }

    }


}
