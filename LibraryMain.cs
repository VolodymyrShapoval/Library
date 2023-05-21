using System;
using System.Text.RegularExpressions;

namespace Console_Lab_3
{
	/// <summary>
	/// Клас для опису бібліотеки
	/// </summary>
	public partial class Library
	{
		private string LibName;
		private string LibAddress;
		private int BookFund;
		public Library() { }
		public Library(string LibName, string LibAddress, int BookFund)
		{
			this.LibName = LibName;
			this.LibAddress = LibAddress;
			this.BookFund = BookFund;
		}

		public string Name
		{
			get
			{
				return LibName;
			}
			set
			{
				LibName = value;
			}
		}
        public string Address
        {
            get
            {
                return LibAddress;
            }
            set
            {
                LibAddress = value;
            }
        }
		public int AmountFund
		{
			get
			{
				return BookFund;
			}
			set
			{
				BookFund = value;
			}
		}

		public void outputLibInfo(Library library)
		{
			Display($"Name: {library.Name}");
			Display($"Address: {library.LibAddress}");
			Display($"Book fund: {library.AmountFund}");
		}

		public string InputValue(string text)
		{
			Console.Write(text);
			return Console.ReadLine();
		}
        public void Display(string value)
		{
			Console.WriteLine(value);
		}
		public void Display(int value)
		{
			Console.WriteLine(value);
		}

		public void searchBookInfo(Reader reader, string libPath)
		{
            string search = InputValue("Enter book title: ");
            int m = reader.binarySearch(search, libPath);
			if (m == -1) Console.WriteLine("Nothing was found for your request");
			else
			{
				string[] arr = File.ReadAllLines("/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library2.txt");
				Console.WriteLine($"Info: {arr[m]}");
			}
        }

		public class Book
		{
			public string authorName;
			public string bookName;
			public string releaseYear;

			public void riskReduction()
			{
				int hours;
				double result;
				do
				{
					Console.WriteLine("How many hours do you read a week? ");
					hours = int.Parse(Console.ReadLine());
				} while (hours <= 0 || hours > 40);
				result = (hours <= 4 ? hours / 0.16 : 25 + (0.16 * (hours - 4))); 
				Console.WriteLine($"The risk of brain disease is reduced by {result}%");
			}
			public void iQ()
			{
                int hours, pages;
                double result;
                do
                {
                    Console.WriteLine("How many hours do you read 300 pages? ");
                    hours = int.Parse(Console.ReadLine());
                } while (hours <= 0 || hours > 300);
                do
                {
                    Console.WriteLine("How many pages do you read a year? ");
                    pages = int.Parse(Console.ReadLine());
                } while (pages < 0);
                result = (pages/300)*((300/hours)/((300/hours)*0.5));
                Console.WriteLine($"Your IQ is +{result}");
            }
		}
	}
}