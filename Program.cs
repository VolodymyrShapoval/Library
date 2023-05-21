using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_Lab_3
{
    class Program
    {
        static void line()
        {
            Console.WriteLine("------------------------------------------------");
        }

        static void end()
        {
            line();
            Console.Write("PRESS ANY BUTTON");
            Console.ReadKey();
            Console.Clear();
        }

        static void menu()
        {
            Console.WriteLine("1.) Sign up;");
            Console.WriteLine("2.) Add book to library;");
            Console.WriteLine("3.) Take a book;");
            Console.WriteLine("4.) Information about the book;");
            Console.WriteLine("5.) Information about the library;");
            Console.WriteLine("6.) Read content;");
            Console.WriteLine("---------Additional functions------------");
            Console.WriteLine("7.) Determine the risk of brain diseases;");
            Console.WriteLine("8.) Determine the height of the IQ level;");
            Console.WriteLine("9.) Identification;");
            Console.WriteLine("0.) Exit;");
        }

        static void Main(string[] arg)
        {
            Identification myIdentification = new Identification("Volodymyr", "Shapoval", 18, "IPZ-13", 1, "volodymyr.sh.05@gmail.com");
            string readerInfoPath = "/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/readerInfo.txt";
            string libraryPath = "/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library.txt";

            Library library = new Library("Scientific library named after M. Maksymovich of Taras Shevchenko Kyiv National University", "Volodymyrska Street, 58", 10000);
            Reader reader = new Reader();
            Content content = new Content();
            Library.Book book = new Library.Book();

        Start: 
            menu();
            Console.Write($"Enter: ");
            int choice = int.Parse(Console.ReadLine());
            line();
            switch (choice)
            {
                case 1:
                    StreamWriter readerInfo = new StreamWriter(readerInfoPath, true);
                    reader.subscriptionCreation(reader, readerInfo);
                    readerInfo.Close();
                    end();
                    goto Start;
                case 2:
                    StreamWriter libList = new StreamWriter(libraryPath, true);
                    library.addBook(libList);
                    libList.Close();
                    end();
                    goto Start;
                case 3:
                    library.bookTaking(reader, libraryPath);
                    end();
                    goto Start;
                case 4:
                    library.searchBookInfo(reader, libraryPath);
                    end();
                    goto Start;
                case 5:
                    library.outputLibInfo(library);
                    end();
                    goto Start;
                case 6:
                    content.task1();
                    end();
                    goto Start;
                case 7:
                    book.riskReduction();
                    end();
                    goto Start;
                case 8:
                    book.iQ();
                    end();
                    goto Start;
                case 9:
                    myIdentification.outputIdentification(myIdentification);
                    end();
                    goto Start;
                case 0:
                    Console.Write("PRESS ANY BUTTON");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("There is no such method!");
                    end();
                    goto Start;
            }
        }
    }
}