using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace Console_Lab_3
{
	/// <summary>
	/// Клас для опису читача
	/// </summary>
	public class Reader
	{
		private string FirstName;
		private string LastName;
		private string Passport;
		private string ResidenceAddress;
		private string TelephoneNumber;

		public Reader() { }
		public Reader(string FirstName, string LastName, string Passport, string ResidenceAddress, string TelephoneNumber)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Passport = Passport;
			this.ResidenceAddress = ResidenceAddress;
			this.TelephoneNumber = TelephoneNumber;
		}

		public string Name
		{
			get
			{
				return FirstName;
			}
			set
			{
				FirstName = value;
			}
		}
		public string Surname
		{
			get
			{
				return LastName;
			}
			set
			{
				LastName = value;
			}
		}
		public string Pass
		{
			get
			{
				return Passport;
			}
			set
			{
				Passport = value;
			}
		}
		public string Address
		{
			get
			{
				return ResidenceAddress;
			}
			set
			{
				ResidenceAddress = value;
			}
		}
		public string Telephone
		{
			get
			{
				return TelephoneNumber;
			}
			set
			{
				TelephoneNumber = value;
			}
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

		public void subscriptionCreation(Reader reader, StreamWriter readerInfo)
		{
			readerInfo.WriteLine($"-->Reader #{InputValue("Index: ")}");
			reader.FirstName = InputValue("First name: ");
			reader.LastName = InputValue("Last name: ");
            readerInfo.WriteLine("Name: " + reader.FirstName + " " + reader.LastName);
			readerInfo.WriteLine("Passport: " + InputValue("Passport: "));
			readerInfo.WriteLine("Residence address: " + InputValue("Residence address: "));
			readerInfo.WriteLine("Telephone number: " + InputValue("Telephone number: "));
			readerInfo.WriteLine("-----------------------------------------------");
		}
		public void sort(string libPath)
		{
			string newPath = "/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library2.txt";
			string[] arr = File.ReadAllLines(libPath);
			File.WriteAllText(newPath, string.Join(Environment.NewLine, arr.OrderBy(x => x)));
		}

		public int findIndex<T>(T[] array, T item)
		{
			return Array.IndexOf(array, item);
		}
		public int indexOfFirstLetterArr(string word)
		{
			char[] digits =
			{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C',
			'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
			'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

			return findIndex(digits, word[1]);
		}
        public int indexOfFirstLetterS(string word)
        {
            char[] digits =
            {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C',
            'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            return findIndex(digits, word[0]);
        }

		public bool choose()
		{
			int choice;
			Console.WriteLine("Do you wanna take this book? (1 - yes, 0 - no) ");
			do
			{
				Console.Write("Enter: ");
				choice = int.Parse(Console.ReadLine());
			} while (choice != 1 && choice != 0);
			if (choice == 1) return true;
			else return false;
		}

        public int binarySearch(string search, string libPath)
		{
            string newPath = "/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library2.txt";
            sort(libPath);
			Random rand = new Random();
            string[] arr = File.ReadAllLines(newPath);
            int count = File.ReadAllLines(newPath).Length;
            int left = 0;
            int right = count - 1;
			int m = -1; // ЗМІНИВ з 0 на -1
            while (left <= right)
            {	
                m = rand.Next(left, right + 1);
                if (arr[m][1] == search[0])
                {
                    while (m != 0 && arr[m - 1][1] == search[0]) m--;
                    if (!arr[m].Contains(search) && m != right) m++;
                    if (arr[m].Contains(search))
                    {
						return m;
						break;
                    }
                    Console.WriteLine("Not found!");
                    break;
                }
                else if (indexOfFirstLetterArr(arr[m]) > indexOfFirstLetterS(search)) right = m - 1;
                else left = m + 1;
            }
			return -1;
        }
	}
}