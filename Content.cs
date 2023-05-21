using System;
namespace Console_Lab_3
{
	public class Content
	{
        // Method for generating array
        public void generateArray(int[] arr, int size)
        {
            Random random = new Random();

            Console.WriteLine("Input diapazon: ");
            Console.Write("From: ");
            int left = int.Parse(Console.ReadLine()); // left
            Console.Write("To: ");
            int right = int.Parse(Console.ReadLine()); // right
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(left, right + 1);
            Console.Write("Array before sorting:");
            outputArray(arr);
        }

        // Sorting method
        public void sort(int[] arr)
        {
            int left = 0; // Лівий край масиву
            int right = arr.Length - 1; // Правий край масиву
            int minElement; // Змінна для найменшого елементу
            Index min = 0; //  Змінна для збереження індексу найменшого елементу
            for (int i = left; i < right; i++) // Від 0 до n-2 включно
            {
                minElement = arr[i]; // Спочатку найменшим елементом вважаємо Аі
                min = i; // Присвоємо змінній значення індекса найменшого елемента
                for (int j = i + 1; j <= right; j++) // Від 1 до n-1 включно
                {
                    if (arr[j] < minElement) // Якщо Aj < Аі 
                    {
                        minElement = arr[j]; // Присвоюємо нове значення найменшого елемента Aj
                        min = j; // Зберігаємо індекс найменшого елемента Aj
                    }
                }
                (arr[i], arr[min]) = (arr[min], arr[i]); // Замінюємо місцями Аі та Aj
            }
            Console.Write("Array after sorting: ");
            outputArray(arr);
        }

        // Method for creating sieve of Eratosphen
        public void eratosphen(int[] arr)
        {
            bool[] table = new bool[arr.Max() + 1];
            bool flag = false; // прапорець для визначення, чи було виведене принаймні одне просте число
            // Відзначаємо всі числа як прості
            for (int i = 0; i < table.Length; i++)
                table[i] = true;
            // Викреслюємо зайве
            for (int i = 2; i * i < table.Length; i++)
                if (table[i])
                    for (int j = 2 * i; j < table.Length; j += i)
                        table[j] = false;
            // Виводимо знайдене
            Console.Write("Simple numbers: ");
            for (int i = 2; i < table.Length; i++)
            {
                if (table[i])
                {
                    Console.Write(i + " ");
                    flag = true;
                }
            }
            if (!flag) Console.WriteLine("No prime numbers found!");
            Console.WriteLine();
        }

        // Method for searching common divisor
        public int div(int a, int b)
        {
            int divisor = Math.Abs(Math.Min(a, b));
            if (divisor <= 0)
                return 0;
            while (!(a % divisor == 0 && b % divisor == 0))
            {
                divisor--;
            }
            return divisor;
        }

        // Method that creating an array that consists of greatest common divisors
        public void GCDArr(int[] arr)
        {
            int[] divisors = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                divisors[i] = div(arr[i], arr[i + 1]);
            }
            Console.Write("Greatest common divisors: ");
            foreach (int i in divisors)
            {
                if (divisors[i] == 0) Console.Write("(!)" + " ");
                else Console.Write(divisors[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("(!) - divisor is undefined!");
        }

        // Method for looking for the centered triangular numbers in array
        public void centeredTriangularNumbers(int[] arr)
        {
            bool flag = false; // are centered triangular numbers found? 
            Console.WriteLine("Centered triangular numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; ((3 * Math.Pow(j, 2) + 3 * j + 2) / 2) <= arr[i]; j++)
                {
                    if (((3 * Math.Pow(j, 2) + 3 * j + 2) / 2) == arr[i])
                    {
                        Console.WriteLine("arr[" + i + "]: " + arr[i]);
                        flag = true;
                    }
                }
            }
            if (!flag)
            {
                Console.Write("not found!");
                Console.WriteLine();
            }
        }

        // Output method
        public void outputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Method for modify the binary search using the golden ratio
        public void binarySearchModified(int[] arr)
        {
            Random random = new Random();

            Console.Write("Input the desired number: ");
            int num = int.Parse(Console.ReadLine()); // вводимо шукане число

            const double Fi = 1.6180339887498948482;
            int left = 0;
            int right = arr.Length - 1;
            while ((left <= right))
            {
                int m = (int)(left + (right - left) / Fi);
                if (arr[m] == num)
                {
                    while (arr[m] == num) // 0 1 4 6 7 7 7 8 9
                    {
                        m--;
                    }
                    for (int i = m + 1; i < arr.Length; i++)
                    {
                        if (arr[i] == num)
                            Console.WriteLine("Index of the desired number: " + i + ";");
                    }
                    break;
                }
                else if (arr[m] < num) left = m + 1;
                else right = m - 1;
            }
        }

        // A method that consists of other methods to execute the "Arrays" lab block
        public void task1()
        {
            Console.Write("Input size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            generateArray(arr, size);
            sort(arr);
            eratosphen(arr);
            GCDArr(arr);
            centeredTriangularNumbers(arr);
            binarySearchModified(arr);
        }
    }
}

