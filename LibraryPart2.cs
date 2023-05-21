using System;
namespace Console_Lab_3
{
	public partial class Library
	{
        public void addBook(StreamWriter library)
        {
            library.Write($"\"{InputValue("Book title: ")}\" ");
            library.Write($"{InputValue("Author: ")} - ");
            library.Write($"{InputValue("Release year: ")}");
            library.WriteLine();
        }
    }
}

