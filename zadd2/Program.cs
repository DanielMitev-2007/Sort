using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadd2
{
    internal class Program
    {
        static void SelectionSort(Book[] books)
        {
            int n = books.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(books[j].Title, books[minIndex].Title, StringComparison.Ordinal) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Book temp = books[i];
                    books[i] = books[minIndex];
                    books[minIndex] = temp;
                }
            }
        }

        static void PrintBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }
        }

        static void Main()
        {
            Book[] books =
            {
            new Book("Война и мир", "Лев Толстой"),
            new Book("Пипи дългото чорапче", "Астрид Линдгрен"),
            new Book("Том Сойер", "Марк Твен"),
            new Book("Под игото", "Иван Вазов"),
            new Book("Ноев ковчех", "Йордан Радичков")
        };

            Console.WriteLine("Before Sorting:");
            PrintBooks(books);

            SelectionSort(books);

            Console.WriteLine("\nAfter Sorting:");
            PrintBooks(books);
        }
    }
}
