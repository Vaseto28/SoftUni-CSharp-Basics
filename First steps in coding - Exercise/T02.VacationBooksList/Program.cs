using System;

namespace vaction_book_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var pages = int.Parse(Console.ReadLine());
            var pagesPerHour = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var neededDays = (pages / pagesPerHour) / days;
            Console.WriteLine(neededDays);
        }
    }
}
