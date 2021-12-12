using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book(1, "Book1", 2001, 100, 12);
            var book2 = new Book(2, "Book2", 2011, 50, 10);
            var book3 = new Book(3, "Book3", 2020, 70, 5);
            var book4 = new Book(4, "Book4", 2005, 200, 2);

            // Array
            var array = new[] {book1, book2, book3, book4};

            // Generic
            var list = new List<Book>();
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            list.Add(book4);

            list.Remove(book1);
            list.Remove(book4);

            // Non-generic
            var nonGenericList = new List<object>();
            nonGenericList.Add(book1);
            nonGenericList.Add(book2);
            nonGenericList.Add(book3);
            nonGenericList.Add(book4);

            nonGenericList.Remove(book1);
            nonGenericList.Remove(book4);

            Console.WriteLine("Foreach in array");
            foreach (var book in array)
                Console.WriteLine(book);

            Console.WriteLine();
            
            Console.WriteLine("Foreach in list");
            foreach (var book in list)
                Console.WriteLine(book);

            Console.WriteLine();

            Console.WriteLine("Foreach in nonGenericList");
            foreach (var book in nonGenericList)
                Console.WriteLine(book as Book);
        }
    }
}