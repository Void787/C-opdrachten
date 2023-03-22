using System;
using System.Drawing;

namespace h4_opdracht_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phase 1, collect information on books");
            List<Book> Books = new List<Book>();
            while (true)
            {
                Console.WriteLine("please type in the name of the book.");
                string bookname = Console.ReadLine();
                if (bookname == "") { break; }
                Console.WriteLine("please type in the number of pages.");
                string numberofpagesS = Console.ReadLine();
                if (bookname == "") { break; }
                int numberofpages = Convert.ToInt32(numberofpagesS);
                Console.WriteLine("please type in the publicationYear");
                string publicationYearS = Console.ReadLine();
                if (bookname == "") { break; }
                int publicationYear = Convert.ToInt32(publicationYearS);
                Book book = new Book(bookname, numberofpages, publicationYear);
                Books.Add(book);
            }
            while (true)
            {
                Console.WriteLine("What is to be printed?");
                string choice = Console.ReadLine();
                if (choice == "everything")
                {
                    foreach (Book book in Books)
                    {
                        Console.WriteLine("Name: " + book.Name);
                        Console.WriteLine("Pages: " + book.Pages);
                        Console.WriteLine("publicationYear: " + book.PublicationYear);
                    }
                } if (choice == "title") {
                    Console.WriteLine("name of the book:");
                    string name = Console.ReadLine();
                    foreach (Book book in Books)
                    {
                        if (book.Name == name)
                        {
                            Console.WriteLine("Name: " + book.Name);
                            Console.WriteLine("Pages: " + book.Pages);
                            Console.WriteLine("publicationYear: " + book.PublicationYear);
                        }
                    }
                }
                if (choice == "end program")
                {
                    break;
                }

                
                
            }
        }
    }
}