using System;

namespace old_books
{
    class Program
    {
        static void Main(string[] args)
        {
            var favouriteBook = Console.ReadLine();
            var book = Console.ReadLine();
            var count = 0;
            while (book != "No More Books")
            {
                if (book == favouriteBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                book = Console.ReadLine();
                count++;
            }
            if (book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
