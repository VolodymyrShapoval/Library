using System;
namespace Console_Lab_3
{
	public partial class Library
	{
        public void bookTaking(Reader reader, string libPath)
        {
            string search = InputValue("Enter book title: ");
            int m = reader.binarySearch(search, libPath);
            if (m == -1) Console.WriteLine("Nothing was found for your request");
            else
            {
                string[] arr = File.ReadAllLines("/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library2.txt");
                Console.WriteLine(arr[m]);
                if (reader.choose())
                {
                    arr[m] += "(" + reader.Name + " " + reader.Surname + ")";
                    Console.WriteLine(arr[m]);
                    StreamWriter final = new StreamWriter("/Users/volodymyr.shapoval/Documents/Програмування/C#/КНУ/Console_Lab_3/library.txt");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        final.WriteLine(arr[i]);
                    }
                    final.Close();
                }
            }
        }
    }
}

